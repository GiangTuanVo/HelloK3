using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibConnection;
using LibConnection.ModBus;
using LibConnection.Core;
using CShapePLC.Model;

namespace CShapePLC
{
    public partial class FrmModbusTcp : Form
    {
        private ModbusTcpNet modbusTcpNet = null;
        private List<string> WarningList = new List<string>();
        int saveError = 0;
        public FrmModbusTcp()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            modbusTcpNet = new ModbusTcpNet(txtAddress.Text, int.Parse(txtPort.Text), byte.Parse(txtStation.Text));
            modbusTcpNet.DataFormat = DataFormat.CDAB;//Sắp sếp dữ liệu;
            OperateResult connect = modbusTcpNet.ConnectServer();
            if (connect.IsSuccess)
            {
                MessageBox.Show("Sucessful");
                btnOpen.Enabled = false;
                timer1.Start();
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            switch (cmbType.Text)
            {
                case "Bool":
                    MessageBox.Show(modbusTcpNet.ReadBool(txtAddr.Text).Content.ToString());
                    break;
                case "Int16":
                    MessageBox.Show(modbusTcpNet.ReadInt16(txtAddr.Text).Content.ToString());
                    break;
                case "Int32":
                    MessageBox.Show(modbusTcpNet.ReadInt32(txtAddr.Text).Content.ToString());
                    break;
                case "Int64":
                    MessageBox.Show(modbusTcpNet.ReadInt64(txtAddr.Text).Content.ToString());
                    break;
                case "Float":
                    MessageBox.Show(modbusTcpNet.ReadFloat(txtAddr.Text).Content.ToString());
                    break;
                case "Double":
                    MessageBox.Show(modbusTcpNet.ReadDouble(txtAddr.Text).Content.ToString());
                    break;
                default:
                    break;
            }
            
           
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            switch (cmbWriteType.Text)
            {
                case "Bool":
                    OperateResult result = modbusTcpNet.Write(txtAddrWrite.Text, bool.Parse(txtValue.Text));
                    break;
                case "Int16":
                    result = modbusTcpNet.Write(txtAddrWrite.Text, Int16.Parse(txtValue.Text));
                    break;
                case "Int32":
                    result = modbusTcpNet.Write(txtAddrWrite.Text, Int32.Parse(txtValue.Text));
                    break;
                case "Int64":
                    result = modbusTcpNet.Write(txtAddrWrite.Text, Int64.Parse(txtValue.Text));
                    break;
                case "Float":
                    result = modbusTcpNet.Write(txtAddrWrite.Text, float.Parse(txtValue.Text));
                    break;
                case "Double":
                    result = modbusTcpNet.Write(txtAddrWrite.Text, double.Parse(txtValue.Text));
                    break;
                default:
                    break;
            }

        }

        private void FrmModbusTcp_Load(object sender, EventArgs e)
        {
            WarningList.Add("");
            WarningList.Add("Over head");
            WarningList.Add("Emergency");
            WarningList.Add("Over Speed");
            WarningList.Add("Sensor error");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ret = modbusTcpNet.ReadInt16(txtAddrWrite.Text).Content;
            if (saveError != ret && ret!=0)
            {
                saveError = ret;
                Warning vs = new Warning();
                vs.No = ret;
                vs.Tiltle = WarningList[ret];
                vs.dateTime = DateTime.Now;
                lstWarning.Items.Add(vs.ToString());
            }
        }

        private void btnReadArray_Click(object sender, EventArgs e)
        {
            OperateResult<Int16[]> result = modbusTcpNet.ReadInt16("0", 10);
            if (result.IsSuccess)
            {
                Int16[] ret = result.Content;
            }

            Int16[] Result = modbusTcpNet.ReadInt16("0", 10).Content;

        }

        private void btnWriteArray_Click(object sender, EventArgs e)
        {
            bool[] writeBool = new bool[] { true, false, true, false, true };
            OperateResult result = modbusTcpNet.Write("8192", writeBool);
        }
    }
}
