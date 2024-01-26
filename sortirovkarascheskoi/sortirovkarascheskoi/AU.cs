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
    public partial class AU : Form
    {
        private bool _isAuthenticated = false;
        public AU()
        {
            InitializeComponent();
        }

        private void GoReg_Click(object sender, EventArgs e)
        {
            Reg reg_form = new Reg();
            reg_form.ShowDialog();
        }

        private void AU_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false)
                Application.Exit();

        }

        private void MakeAuth_Click(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager("\"C:\\Users\\Валерия\\source\\repos\\sortirovkarascheskoi\\users.db\"");
            if (dbManager.CheckUser(AuthLogin.Text, AuthPwd.Text) == true)
            {
                _isAuthenticated = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Не удалось!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
