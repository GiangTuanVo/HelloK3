using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using LibConnection;
using LibConnection.Profinet.Melsec;

namespace CShapePLC
{
    public partial class FrmMain : Form
    {
        MelsecFxSerial FxSerial;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string[] arr = SerialPort.GetPortNames();
            cmbCom.DataSource = arr;
            cmbBaud.SelectedIndex = 0;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FxSerial = new MelsecFxSerial();
            FxSerial.SerialPortInni(sp =>
            {
                sp.PortName = cmbCom.Text;
                sp.BaudRate = int.Parse(cmbBaud.Text);
                sp.DataBits = 7;
                sp.StopBits = StopBits.One;
                sp.Parity = Parity.Even;
            });
            OperateResult ret = FxSerial.Open();
            if (ret.IsSuccess)
            {
                lblStatus.Text = "Connected !";
                lblStatus.ForeColor = Color.Blue;
                Real.Start();
            }
            else
            {
                lblStatus.Text = ret.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (FxSerial.IsOpen())
            {
               FxSerial.Close();
            }
        }

        private void Real_Tick(object sender, EventArgs e)
        {
            OperateResult<bool> Read_X0 = FxSerial.ReadBool("X0");
            if (Read_X0.IsSuccess)
            {
                if(Read_X0.Content)
                    picReadX0.Image = Properties.Resources.Light_On;
                else
                    picReadX0.Image = Properties.Resources.Light_Off;
            }
            OperateResult<bool> Read_X1 = FxSerial.ReadBool("X1");
            
            if (Read_X1.IsSuccess)
            {
                if (Read_X1.Content)
                    picReadX1.Image = Properties.Resources.Light_On;
                else
                    picReadX1.Image = Properties.Resources.Light_Off;
            }
            OperateResult<short> Read_Int16 = FxSerial.ReadInt16("D0");
            if (Read_Int16.IsSuccess)
            {
                txtInt16.Text = Read_Int16.Content.ToString();
            }
            else
            {
                lblStatus.Text = Read_Int16.Message;
            }

            OperateResult<Int32> Read_Int32 = FxSerial.ReadInt32("D2");
            if (Read_Int32.IsSuccess)
            {
                txtInt32.Text = Read_Int32.Content.ToString();
            }
            else
            {
                lblStatus.Text = Read_Int32.Message;
            }

            OperateResult<float> Read_Float = FxSerial.ReadFloat("D4");
            if (Read_Float.IsSuccess)
            {
                txtFloat.Text = Read_Float.Content.ToString();
            }
            else
            {
                lblStatus.Text = Read_Float.Message;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if(txtM0.Text!=""&& txtM1.Text != "")
            {
                OperateResult<bool> Read_M0 = FxSerial.ReadBool(txtM0.Text);
                if (Read_M0.IsSuccess)
                {
                    if (Read_M0.Content)
                        picM0.Image = Properties.Resources.Light_On;
                    else
                        picM0.Image = Properties.Resources.Light_Off;
                }
                OperateResult<bool> Read_M1 = FxSerial.ReadBool(txtM1.Text);

                if (Read_M1.IsSuccess)
                {
                    if (Read_M1.Content)
                        picM1.Image = Properties.Resources.Light_On;
                    else
                        picM1.Image = Properties.Resources.Light_Off;
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FxSerial.Write(txtAddress.Text, bool.Parse(txtValue.Text));
        }

        private void btnReadLength_Click(object sender, EventArgs e)
        {
            OperateResult<bool[]> result = FxSerial.ReadBool(txtAddr.Text, ushort.Parse(txtLenth.Text));
            if (result.IsSuccess)
            {
                foreach (var item in result.Content)
                {
                    txtResult.Text += item.ToString() + "\r\n";
                }
            }
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            switch (cbmDataType.Text)
            {
                case "Short":
                    string[] shortText = txtValueDataWrite.Text.Split(',');
                    short[] shortData = new short[shortText.Length];
                    for (int i = 0; i < shortText.Length; i++)
                    {
                        shortData[i] = short.Parse(shortText[i]);
                    }
                    OperateResult result = FxSerial.Write(txtAddrDataWrite.Text, shortData);
                    break;
                case "Int32":
                    string[] int32Text = txtValueDataWrite.Text.Split(',');
                    Int32[] int32Data = new Int32[int32Text.Length];
                    for (int i = 0; i < int32Text.Length; i++)
                    {
                        int32Data[i] = Int32.Parse(int32Text[i]);
                    }
                    result = FxSerial.Write(txtAddrDataWrite.Text, int32Data);
                    break;
                case "Int64":
                    break;
                case "Float":
                    break;
                default:
                    break;
            }
        }
    }
}
