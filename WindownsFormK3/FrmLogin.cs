using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindownsFormK3.Model;

namespace WindownsFormK3
{
    public partial class FrmLogin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        List<User> listUsers = new List<User>();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkAccount.Checked)
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    User user = new User(txtName.Text, txtPassword.Text);
                    listUsers.Add(user);
                    chkAccount.Checked = false;
                    txtName.Text = "";
                    txtPassword.Text = "";
                    txtConfirm.Text = "";
                    MessageBox.Show("Crate account sucessful!");
                }
            }
            else
            {
                foreach (User item in listUsers)
                {
                    if (item.Name == txtName.Text && item.Password == txtPassword.Text)
                    {
                        MessageBox.Show($"User Name : {txtName.Text}\r\nPassword : {txtPassword.Text}");
                        txtName.Text = "";
                        txtPassword.Text = "";
                        break;
                    }
                }

            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtConfirm.Visible = false;
        }

        private void lblLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void chkAccount_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkAccount.Checked)
            {
                txtConfirm.Visible = true;
                btnLogin.Text = "SIGN";
            }
            else
            {
                txtConfirm.Visible = false;
                btnLogin.Text = "LOGIN";
            }
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}
