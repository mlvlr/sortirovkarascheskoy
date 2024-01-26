using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortirovkarascheskoi
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager("\"C:\\Users\\Валерия\\source\\repos\\sortirovkarascheskoi\\users.db\"");
            if (dbManager.AddUser(RegLogin.Text, RegPwd.Text) == true)
            {
                if (RegPwd.Text == RegPwd2.Text)
                {
                    MessageBox.Show("Успешно!");
                }
            }
            else
            {
                MessageBox.Show("Не удалось!");
            }
        }

    }
}
