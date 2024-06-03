
namespace CShapePLC
{
    partial class FrmMelcSerial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Real = new System.Windows.Forms.Timer(this.components);
            this.picReadX0 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picReadX1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picM0 = new System.Windows.Forms.PictureBox();
            this.picM1 = new System.Windows.Forms.PictureBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtM0 = new System.Windows.Forms.TextBox();
            this.txtM1 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLenth = new System.Windows.Forms.TextBox();
            this.btnReadLength = new System.Windows.Forms.Button();
            this.txtInt16 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInt32 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFloat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValueDataWrite = new System.Windows.Forms.TextBox();
            this.txtAddrDataWrite = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbmDataType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.cmbBaud);
            this.groupBox1.Controls.Add(this.cmbCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComPort";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(148, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 120);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 42);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "9600",
            "19200"});
            this.cmbBaud.Location = new System.Drawing.Point(102, 76);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 28);
            this.cmbBaud.TabIndex = 1;
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(102, 42);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(121, 28);
            this.cmbCom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BaudRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ComName";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 559);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 18);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "label3";
            // 
            // Real
            // 
            this.Real.Tick += new System.EventHandler(this.Real_Tick);
            // 
            // picReadX0
            // 
            this.picReadX0.Location = new System.Drawing.Point(6, 25);
            this.picReadX0.Name = "picReadX0";
            this.picReadX0.Size = new System.Drawing.Size(50, 50);
            this.picReadX0.TabIndex = 2;
            this.picReadX0.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "X0";
            // 
            // picReadX1
            // 
            this.picReadX1.Location = new System.Drawing.Point(62, 25);
            this.picReadX1.Name = "picReadX1";
            this.picReadX1.Size = new System.Drawing.Size(50, 50);
            this.picReadX1.TabIndex = 2;
            this.picReadX1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "X1";
            // 
            // picM0
            // 
            this.picM0.Location = new System.Drawing.Point(6, 103);
            this.picM0.Name = "picM0";
            this.picM0.Size = new System.Drawing.Size(50, 50);
            this.picM0.TabIndex = 2;
            this.picM0.TabStop = false;
            // 
            // picM1
            // 
            this.picM1.Location = new System.Drawing.Point(62, 103);
            this.picM1.Name = "picM1";
            this.picM1.Size = new System.Drawing.Size(50, 50);
            this.picM1.TabIndex = 2;
            this.picM1.TabStop = false;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(127, 103);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 50);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtM0
            // 
            this.txtM0.Location = new System.Drawing.Point(6, 159);
            this.txtM0.Name = "txtM0";
            this.txtM0.Size = new System.Drawing.Size(50, 26);
            this.txtM0.TabIndex = 5;
            this.txtM0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtM1
            // 
            this.txtM1.Location = new System.Drawing.Point(62, 159);
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(50, 26);
            this.txtM1.TabIndex = 5;
            this.txtM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(244, 45);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(65, 26);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(244, 100);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(65, 26);
            this.txtValue.TabIndex = 6;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Length";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(239, 132);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 38);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Controls.Add(this.txtAddr);
            this.groupBox2.Controls.Add(this.picReadX0);
            this.groupBox2.Controls.Add(this.btnWrite);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.picReadX1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLenth);
            this.groupBox2.Controls.Add(this.txtValue);
            this.groupBox2.Controls.Add(this.picM0);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.picM1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtM1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtM0);
            this.groupBox2.Controls.Add(this.btnReadLength);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Location = new System.Drawing.Point(266, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 379);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read/Write Bits";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 261);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(341, 102);
            this.txtResult.TabIndex = 9;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(6, 229);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(100, 26);
            this.txtAddr.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // txtLenth
            // 
            this.txtLenth.Location = new System.Drawing.Point(127, 229);
            this.txtLenth.Name = "txtLenth";
            this.txtLenth.Size = new System.Drawing.Size(75, 26);
            this.txtLenth.TabIndex = 6;
            // 
            // btnReadLength
            // 
            this.btnReadLength.Location = new System.Drawing.Point(229, 220);
            this.btnReadLength.Name = "btnReadLength";
            this.btnReadLength.Size = new System.Drawing.Size(118, 35);
            this.btnReadLength.TabIndex = 4;
            this.btnReadLength.Text = "READ LENGTH";
            this.btnReadLength.UseVisualStyleBackColor = true;
            this.btnReadLength.Click += new System.EventHandler(this.btnReadLength_Click);
            // 
            // txtInt16
            // 
            this.txtInt16.Location = new System.Drawing.Point(677, 43);
            this.txtInt16.Name = "txtInt16";
            this.txtInt16.Size = new System.Drawing.Size(68, 26);
            this.txtInt16.TabIndex = 9;
            this.txtInt16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "D0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(673, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Short";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(756, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Int32";
            // 
            // txtInt32
            // 
            this.txtInt32.Location = new System.Drawing.Point(760, 43);
            this.txtInt32.Name = "txtInt32";
            this.txtInt32.Size = new System.Drawing.Size(68, 26);
            this.txtInt32.TabIndex = 9;
            this.txtInt32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(765, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "D2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(839, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Float";
            // 
            // txtFloat
            // 
            this.txtFloat.Location = new System.Drawing.Point(843, 43);
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.Size = new System.Drawing.Size(68, 26);
            this.txtFloat.TabIndex = 9;
            this.txtFloat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(848, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "D4";
            // 
            // txtValueDataWrite
            // 
            this.txtValueDataWrite.Location = new System.Drawing.Point(674, 250);
            this.txtValueDataWrite.Multiline = true;
            this.txtValueDataWrite.Name = "txtValueDataWrite";
            this.txtValueDataWrite.Size = new System.Drawing.Size(234, 85);
            this.txtValueDataWrite.TabIndex = 11;
            // 
            // txtAddrDataWrite
            // 
            this.txtAddrDataWrite.Location = new System.Drawing.Point(674, 140);
            this.txtAddrDataWrite.Name = "txtAddrDataWrite";
            this.txtAddrDataWrite.Size = new System.Drawing.Size(65, 26);
            this.txtAddrDataWrite.TabIndex = 6;
            this.txtAddrDataWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(673, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(675, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Value";
            // 
            // cbmDataType
            // 
            this.cbmDataType.FormattingEnabled = true;
            this.cbmDataType.Items.AddRange(new object[] {
            "Short",
            "Int32",
            "Int64",
            "Float",
            "Double",
            "Ushort"});
            this.cbmDataType.Location = new System.Drawing.Point(674, 196);
            this.cbmDataType.Name = "cbmDataType";
            this.cbmDataType.Size = new System.Drawing.Size(121, 28);
            this.cbmDataType.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(673, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Data Type";
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(674, 349);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(118, 35);
            this.btnWriteData.TabIndex = 4;
            this.btnWriteData.Text = "WRITE";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 588);
            this.Controls.Add(this.cbmDataType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtValueDataWrite);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFloat);
            this.Controls.Add(this.txtInt32);
            this.Controls.Add(this.txtInt16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAddrDataWrite);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnWriteData);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer Real;
        private System.Windows.Forms.PictureBox picReadX0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picReadX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picM0;
        private System.Windows.Forms.PictureBox picM1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtM0;
        private System.Windows.Forms.TextBox txtM1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLenth;
        private System.Windows.Forms.Button btnReadLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInt16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInt32;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFloat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtValueDataWrite;
        private System.Windows.Forms.TextBox txtAddrDataWrite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbmDataType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnWriteData;
    }
}

