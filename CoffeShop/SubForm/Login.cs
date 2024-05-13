using CoffeShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop.SubForm
{
    public partial class Login : Form
    {
        private string path = Application.StartupPath + "\\file";
        public Login()
        {
            InitializeComponent();
            ReadData read = new ReadData(path);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtConfirm.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!chkAccount.Checked)
            {
                if (ReadData.fileData.Tables.Count > 0)
                {
                    if (ReadData.fileData.Tables["User"].Rows.Count > 0)
                    {
                        foreach (DataRow item in ReadData.fileData.Tables["User"].Rows)
                        {
                            if(item.ItemArray[1].ToString()==txtName.Text
                                && item.ItemArray[2].ToString() == txtPassword.Text)
                            {
                                this.Hide();
                                CoffeeShop coffeeShop = new CoffeeShop();
                                coffeeShop.ShowDialog();
                            }
                        }
                    }
                }
            }
            else
            {

            }
        }

        private void chkAccount_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkAccount.Checked)
            {
                btnLogin.Text = "SIGUP TO APPLICATION";
                btnLogin.Image = Properties.Resources.sigup;
                txtConfirm.Visible = true;
            }
            else
            {
                btnLogin.Text = "LOGIN TO APPLICATION";
                btnLogin.Image = Properties.Resources.loginicon;
                txtConfirm.Visible = false;
            }
        }
    }
}
