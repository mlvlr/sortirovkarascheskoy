using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace sortirovkarascheskoi
{
    public class Sorted
    {
        public List<int[]> States { get; private set; } = new List<int[]>();

        public string Sort(string input)
        {
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

            States.Clear();
            States.Add((int[])numbers.Clone());
            CombSortAlgorithm(numbers);


            string output = string.Join(" ", numbers);
            return output;
        }

        private void CombSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            int gap = n;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                gap = NextGap(gap);
                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        Swap(ref arr[i], ref arr[i + gap]);
                        swapped = true;

                        States.Add((int[])arr.Clone());

                    }
                }
            }
        }

        private int NextGap(int gap)
        {
            // Уменьшение значения gap на фактор уменьшения
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
