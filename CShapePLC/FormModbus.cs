using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibConnection;
using LibConnection.ModBus;

namespace CShapePLC
{
    public partial class FormModbus : Form
    {
        private ModbusRtu modbusRtu = null;
        public FormModbus()
        {
            InitializeComponent();
        }

        private void FormModbus_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            modbusRtu = new ModbusRtu(1);//Station number
            modbusRtu.DataFormat = LibConnection.Core.DataFormat.CDAB; //Gây ra sai kiểu dữ liệu
            modbusRtu.SerialPortInni(sp =>
            {
                sp.PortName = "COM2";
                sp.BaudRate = 9600;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.Parity = Parity.Odd;
            });
            OperateResult result= modbusRtu.Open();
            MessageBox.Show(result.Message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Bool":
                    MessageBox.Show(modbusRtu.ReadBool(addrReadRtu.Text).Content.ToString());
                    break;
                case "Int16":
                    MessageBox.Show(modbusRtu.ReadInt16(addrReadRtu.Text).Content.ToString());
                    break;
                case "Float":
                    MessageBox.Show(modbusRtu.ReadFloat(addrReadRtu.Text).Content.ToString());
                    break;
                default:
                    break;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Bool":
                   OperateResult boolWrite= modbusRtu.Write(addrWriteRtu.Text,bool.Parse(txtValue.Text));
                    MessageBox.Show(boolWrite.Message);
                    break;
                case "Int16":
                    OperateResult int16Write = modbusRtu.Write(addrWriteRtu.Text, Int16.Parse(txtValue.Text));
                    MessageBox.Show(int16Write.Message);
                    break;
                case "Float":
                    OperateResult floatWrite = modbusRtu.Write(addrWriteRtu.Text, float.Parse(txtValue.Text));
                    MessageBox.Show(floatWrite.Message);
                    break;
                default:
                    break;
            }
        }
    }
}
