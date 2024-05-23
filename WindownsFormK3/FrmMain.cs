using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindownsFormK3.Model;
using System.IO.Ports;

namespace WindownsFormK3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void radRedColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radRedColor.Checked) txtText.ForeColor = Color.Red;
        }

        private void radBlueColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlueColor.Checked) txtText.ForeColor = Color.Blue;
        }

        private void radOrangeColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radOrangeColor.Checked) txtText.ForeColor = Color.Orange;
        }

        private void chkFontBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFontBold.Checked)
                txtText.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            else
                txtText.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void chkFontItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFontItalic.Checked)
                txtText.Font = new Font("Century Gothic", 11.25F, txtText.Font.Style ^ FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
        }

        private void chkFontUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFontUnderline.Checked)
                txtText.Font = new Font("Century Gothic", 11.25F, txtText.Font.Style ^ FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Image.Image = Bitmap.FromFile("image\\images.jpg");
            dtpTime.CustomFormat = "yyyy/MM/dd HH:mm:ss tt";

            //Add list box
            Personal nhanvien1 = new Personal("Truong Van Trong", 20, "Nam", "10/4/1999");
            Personal nhanvien2 = new Personal("Nguyen Thi No", 35, "Nu", "3/4/1989");
            lstPersonal.Items.Add(nhanvien1);
            lstPersonal.Items.Add(nhanvien2);

            //Load list
            //string[] Com = new string[] { "COM1", "COM2", "COM3", "COM4" };
            //cboCom.DataSource = Com;

            string[] COM = SerialPort.GetPortNames();
            cboCom.DataSource = COM;
            btnClose.Enabled = false;
        }

        private void chkLed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLed.Checked)
            {
                picLed.Image = Properties.Resources.Light_On;
            }
            else
            {
                picLed.Image = Properties.Resources.Light_Off;
            }
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            txtText.Text = dtpTime.Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAge.Text != "" && txtSex.Text != "" && txtBirthDay.Text != "")
            {
                try
                {
                    //Khoi tao
                    Personal personal = new Personal(txtName.Text, int.Parse(txtAge.Text), txtSex.Text, txtBirthDay.Text);
                    lstPersonal.Items.Add(personal.ToString());
                    txtName.Text = "";
                    txtAge.Text = "";
                    txtSex.Text = "";
                    txtBirthDay.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void lstPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonal.SelectedIndex != -1)
            {
                Personal personal = lstPersonal.SelectedItem as Personal;
                txtName.Text = personal.Name;
                txtAge.Text = personal.Age.ToString();
                txtSex.Text = personal.Sex;
                txtBirthDay.Text = personal.BirthDay;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstPersonal.SelectedIndex != -1)
            {
                lstPersonal.Items.RemoveAt(lstPersonal.SelectedIndex);
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (lstPersonal.SelectedIndex != -1)
            {
                Personal personal = lstPersonal.SelectedItem as Personal;
                personal.Name = txtName.Text;
                personal.Age = int.Parse(txtAge.Text);
                personal.Sex = txtSex.Text;
                personal.BirthDay = txtBirthDay.Text;
                lstPersonal.Items[lstPersonal.SelectedIndex] = personal;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = cboCom.Text;
                serialPort.BaudRate = int.Parse(cboBaud.Text);
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    txtText.Text = $"{serialPort.PortName} Connected!";
                    txtText.ForeColor = Color.Blue;
                    btnClose.Enabled = true;
                    btnOpen.Enabled = false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                txtText.Text = $"{serialPort.PortName} Closed!";
                txtText.ForeColor = Color.Red;
                btnClose.Enabled = false;
                btnOpen.Enabled = true;
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string strChecked = "";
            //CheckedListBox.CheckedIndexCollection indexCollection = chklbListNumber.CheckedIndices;
            //foreach (var item in indexCollection)
            //{
            //    strChecked += item + "\r\n";
            //}
            //MessageBox.Show(strChecked);
            for (int i = 0; i < chklbLeft.Items.Count; i++)
            {
                if (chklbLeft.GetItemChecked(i))
                {
                    strChecked += i + "\r\n";
                }
            }
            MessageBox.Show(strChecked);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            string strItems = "";
            CheckedListBox.CheckedItemCollection itemCollection = chklbLeft.CheckedItems;
            foreach (var item in itemCollection)
            {
                strItems += item + "\r\n";
            }
            MessageBox.Show(strItems);
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            foreach (int item in chklbLeft.SelectedIndices)
            {
                chklbRight.Items.Add(chklbLeft.Items[item]);
                chklbLeft.Items.RemoveAt(item);
            }
        }
    }
}
