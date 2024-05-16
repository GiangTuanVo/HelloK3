using CoffeShop.Model;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoffeShop.SubForm
{
    public partial class Login : Form
    {
        private bool isLogin = false;
        private bool isPassHide = false;
        private bool isConfirmHide = false;
        string path = Application.StartupPath + "\\file\\user.csv";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtConfirm.Visible = false;
            //btnConfirmHide.Visible = false;
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
                            if (item.ItemArray[1].ToString() == txtName.Text
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
                    Account account = new Account(ReadData.fileData.Tables["User"].Rows.Count + 1, txtName.Text, txtPassword.Text);
                    ReadData.fileData.Tables["User"].Rows.Add(account.No, account.User, account.Password);
                    File.AppendAllText(path, account.ToString());
                    ShowInfo info = new ShowInfo();
                    info.ItemInfo = "Register account successful !";
                    info.ItemColor = Color.Blue;
                    info.ShowDialog();

                    txtName.Text = "";
                    txtConfirm.Text = "";
                    txtPassword.Text = "";
                    chkAccount.Checked = false;
                }
            }
        }

        private void chkAccount_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkAccount.Checked)
            {
                btnLogin.Text = "SIGUP TO APPLICATION";
                btnLogin.Image = Properties.Resources.sigup;
                txtConfirm.Visible = true;
                //btnConfirmHide.Visible = true;
            }
            else
            {
                btnLogin.Text = "LOGIN TO APPLICATION";
                btnLogin.Image = Properties.Resources.loginicon;
                txtConfirm.Visible = false;
                //btnConfirmHide.Visible = false;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnPassHide_Click(object sender, EventArgs e)
        {
            if (isConfirmHide == false)
            {
                txtPassword.PasswordChar = '\0';
                //btnPassHide.Image = Properties.Resources.Eye;
                isConfirmHide = true;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                //btnPassHide.Image = Properties.Resources.Visualy_Impaired;
                isConfirmHide = false;
            }
        }
    }
}
