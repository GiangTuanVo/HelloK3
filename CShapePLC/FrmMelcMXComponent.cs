using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CShapePLC.Model;
using LibConnection;
using LibConnection.Profinet.Melsec;

namespace CShapePLC
{
    public partial class FrmMelcMXComponent : Form
    {
        private MelsecComponent melsecComponent;
        public FrmMelcMXComponent()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OperateResult result = melsecComponent.Connection(int.Parse(txtStation.Text));
            if (result.IsSuccess)
            {
                lblStatus.Text = result.Message;
                lblStatus.ForeColor = Color.Blue;
                timer1.Start();
            }
            else
            {
                lblStatus.Text = result.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void FrmMelcMXComponent_Load(object sender, EventArgs e)
        {
            melsecComponent = new MelsecComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            melsecComponent.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtReadD0.Text = melsecComponent.ReadInt16("D0").Content.ToString();
            ReadPLC read = new ReadPLC();
            read.dateTime = DateTime.Now;
            read.Value = melsecComponent.ReadInt16("D0").Content;
            lstShowData.Items.Add(read.ToString());

            bunifuRadialGauge1.Value = melsecComponent.ReadInt16("D1").Content;

            if (melsecComponent.ReadBool("X0").Content)
            {
                uiLedBulb1.On = true;
            }
            else
            {
                uiLedBulb1.On = false;
            }
            if (melsecComponent.ReadBool("X1").Content)
            {
                uiLedBulb2.On = true;
            }
            else
            {
                uiLedBulb2.On = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) melsecComponent.WriteBool("M0", true);
            else melsecComponent.WriteBool("M0", false);
        }
    }
}
