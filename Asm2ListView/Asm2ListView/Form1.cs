using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm2ListView
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        string UserName = "Sonbh01929";
        string Password = "21072005";

        bool Check(string UserName, string Password)
        {
            if (UserName == this.UserName && Password == this.Password)
            {
                return true;
            }
            return false;
        }
        private void BttLogin_Click(object sender, EventArgs e)
        {

            if (Check(TxbUserName.Text, TxbPassword.Text))
            {
                FCalculateWater WaterBill = new FCalculateWater();
                WaterBill.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password", "Error", MessageBoxButtons.OK);
            }
        }

        private void CbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPassword.Checked == true)
            {
                TxbPassword.PasswordChar = '\0';
                CbPassword.Text = "Hide Password";
            }
            else
            {
                TxbPassword.PasswordChar = '*';
                CbPassword.Text = "Show Password";
            }
        }
    }
}
