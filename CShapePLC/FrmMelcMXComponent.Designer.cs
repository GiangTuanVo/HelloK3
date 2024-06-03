
namespace CShapePLC
{
    partial class FrmMelcMXComponent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtReadD0 = new System.Windows.Forms.TextBox();
            this.D0 = new System.Windows.Forms.Label();
            this.lstShowData = new System.Windows.Forms.ListBox();
            this.bunifuRadialGauge1 = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.uiLedBulb1 = new Sunny.UI.UILedBulb();
            this.label2 = new System.Windows.Forms.Label();
            this.uiLedBulb2 = new Sunny.UI.UILedBulb();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(195, 9);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(100, 26);
            this.txtStation.TabIndex = 0;
            this.txtStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logical Station Number";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(312, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(405, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 441);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtReadD0
            // 
            this.txtReadD0.Location = new System.Drawing.Point(51, 74);
            this.txtReadD0.Name = "txtReadD0";
            this.txtReadD0.Size = new System.Drawing.Size(74, 26);
            this.txtReadD0.TabIndex = 4;
            this.txtReadD0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D0
            // 
            this.D0.AutoSize = true;
            this.D0.Location = new System.Drawing.Point(17, 77);
            this.D0.Name = "D0";
            this.D0.Size = new System.Drawing.Size(28, 20);
            this.D0.TabIndex = 5;
            this.D0.Text = "D0";
            // 
            // lstShowData
            // 
            this.lstShowData.FormattingEnabled = true;
            this.lstShowData.ItemHeight = 20;
            this.lstShowData.Location = new System.Drawing.Point(16, 106);
            this.lstShowData.Name = "lstShowData";
            this.lstShowData.Size = new System.Drawing.Size(311, 164);
            this.lstShowData.TabIndex = 6;
            // 
            // bunifuRadialGauge1
            // 
            this.bunifuRadialGauge1.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge1.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.bunifuRadialGauge1.LighteningFactor = 70;
            this.bunifuRadialGauge1.Location = new System.Drawing.Point(337, 106);
            this.bunifuRadialGauge1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.bunifuRadialGauge1.Maximum = 100;
            this.bunifuRadialGauge1.Minimum = 0;
            this.bunifuRadialGauge1.Name = "bunifuRadialGauge1";
            this.bunifuRadialGauge1.Prefix = "";
            this.bunifuRadialGauge1.ProgressBackColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge1.ProgressBgColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge1.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressColor2 = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge1.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge1.ProgressColorLow = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressHighValueMark = 70;
            this.bunifuRadialGauge1.RangeEnd = 100;
            this.bunifuRadialGauge1.RangeLabelsColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge1.RangeLabelsFont = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuRadialGauge1.RangeStart = 0;
            this.bunifuRadialGauge1.ShowRangeLabels = true;
            this.bunifuRadialGauge1.ShowValueLabel = true;
            this.bunifuRadialGauge1.Size = new System.Drawing.Size(180, 164);
            this.bunifuRadialGauge1.Suffix = "%";
            this.bunifuRadialGauge1.TabIndex = 7;
            this.bunifuRadialGauge1.Thickness = 30;
            this.bunifuRadialGauge1.Value = 40;
            this.bunifuRadialGauge1.ValueByTransition = 40;
            this.bunifuRadialGauge1.ValueLabelColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge1.WarningMark = 70;
            // 
            // uiLedBulb1
            // 
            this.uiLedBulb1.Color = System.Drawing.Color.Red;
            this.uiLedBulb1.Location = new System.Drawing.Point(52, 280);
            this.uiLedBulb1.Name = "uiLedBulb1";
            this.uiLedBulb1.Size = new System.Drawing.Size(42, 33);
            this.uiLedBulb1.TabIndex = 8;
            this.uiLedBulb1.Text = "uiLedBulb1";
            this.uiLedBulb1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "X0";
            // 
            // uiLedBulb2
            // 
            this.uiLedBulb2.Color = System.Drawing.Color.Red;
            this.uiLedBulb2.Location = new System.Drawing.Point(51, 319);
            this.uiLedBulb2.Name = "uiLedBulb2";
            this.uiLedBulb2.Size = new System.Drawing.Size(42, 33);
            this.uiLedBulb2.TabIndex = 8;
            this.uiLedBulb2.Text = "uiLedBulb1";
            this.uiLedBulb2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "X1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 367);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "M0";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 397);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 24);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "M1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FrmMelcMXComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 470);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiLedBulb2);
            this.Controls.Add(this.uiLedBulb1);
            this.Controls.Add(this.bunifuRadialGauge1);
            this.Controls.Add(this.lstShowData);
            this.Controls.Add(this.D0);
            this.Controls.Add(this.txtReadD0);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStation);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMelcMXComponent";
            this.Text = "FrmMelcMXComponent";
            this.Load += new System.EventHandler(this.FrmMelcMXComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtReadD0;
        private System.Windows.Forms.Label D0;
        private System.Windows.Forms.ListBox lstShowData;
        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge1;
        private Sunny.UI.UILedBulb uiLedBulb1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UILedBulb uiLedBulb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}