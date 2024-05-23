using CoffeShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop.SubForm
{
    public partial class FrmLogin : Form
    {
        private bool isLogin = false;
        string path = Application.StartupPath + "\\file\\user.csv";
        public FrmLogin()
        {
            InitializeComponent();
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
                            if (item.ItemArray[1].ToString() == txtUser.Text
                                && item.ItemArray[2].ToString() == txtPassword.Text)
                            {
                                isLogin = true;
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    Account account = new Account(ReadData.fileData.Tables["User"].Rows.Count + 1, txtUser.Text, txtPassword.Text);
                    ReadData.fileData.Tables["User"].Rows.Add(account.No, account.User, account.Password);
                    File.AppendAllText(path, account.ToString());
                    FrmInfo info = new FrmInfo();
                    info.ItemInfo = "Register account successful !";
                    info.ItemColor = Color.Blue;
                    info.ShowDialog();

                    txtUser.Text = "";
                    txtConfirm.Text = "";
                    txtPassword.Text = "";
                    chkAccount.Checked = false;
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtConfirm.Visible = false;
        }

        private void chkAccount_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkAccount.Checked)
            {
                btnLogin.Text = "SIGUP";
                txtConfirm.Visible = true;
            }
            else
            {
                btnLogin.Text = "LOGIN";
                txtConfirm.Visible = false;
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogin)
                Environment.Exit(0);
        }
        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtPassword.PasswordChar = '*';
            }
            else txtPassword.PasswordChar = '\0';
        }

        private void txtConfirm_TextChange(object sender, EventArgs e)
        {
            if (txtConfirm.Text != "") txtConfirm.PasswordChar = '*';
            else txtConfirm.PasswordChar = '\0';
        }
    }
}
