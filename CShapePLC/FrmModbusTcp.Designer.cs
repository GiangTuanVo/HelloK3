
namespace CShapePLC
{
    partial class FrmModbusTcp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbWriteType = new System.Windows.Forms.ComboBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddrWrite = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lstWarning = new System.Windows.Forms.ListBox();
            this.btnReadArray = new System.Windows.Forms.Button();
            this.btnWriteArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(128, 21);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 26);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "192.168.1.15";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(128, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(168, 26);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "502";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(315, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 35);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(315, 69);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Station";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(128, 78);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(168, 26);
            this.txtStation.TabIndex = 2;
            this.txtStation.Text = "0";
            this.txtStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(114, 155);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(75, 26);
            this.txtAddr.TabIndex = 4;
            this.txtAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(378, 144);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 39);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Bool",
            "Int16",
            "Int32",
            "Int64",
            "Float",
            "Double"});
            this.cmbType.Location = new System.Drawing.Point(195, 155);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(96, 28);
            this.cmbType.TabIndex = 7;
            // 
            // cmbWriteType
            // 
            this.cmbWriteType.FormattingEnabled = true;
            this.cmbWriteType.Items.AddRange(new object[] {
            "Bool",
            "Int16",
            "Int32",
            "Int64",
            "Float",
            "Double"});
            this.cmbWriteType.Location = new System.Drawing.Point(195, 200);
            this.cmbWriteType.Name = "cmbWriteType";
            this.cmbWriteType.Size = new System.Drawing.Size(96, 28);
            this.cmbWriteType.TabIndex = 11;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(378, 189);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 39);
            this.btnWrite.TabIndex = 10;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // txtAddrWrite
            // 
            this.txtAddrWrite.Location = new System.Drawing.Point(114, 200);
            this.txtAddrWrite.Name = "txtAddrWrite";
            this.txtAddrWrite.Size = new System.Drawing.Size(75, 26);
            this.txtAddrWrite.TabIndex = 8;
            this.txtAddrWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(297, 202);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(75, 26);
            this.txtValue.TabIndex = 8;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstWarning
            // 
            this.lstWarning.FormattingEnabled = true;
            this.lstWarning.ItemHeight = 20;
            this.lstWarning.Location = new System.Drawing.Point(21, 253);
            this.lstWarning.Name = "lstWarning";
            this.lstWarning.Size = new System.Drawing.Size(432, 104);
            this.lstWarning.TabIndex = 12;
            // 
            // btnReadArray
            // 
            this.btnReadArray.Location = new System.Drawing.Point(46, 387);
            this.btnReadArray.Name = "btnReadArray";
            this.btnReadArray.Size = new System.Drawing.Size(96, 39);
            this.btnReadArray.TabIndex = 6;
            this.btnReadArray.Text = "ReadArray";
            this.btnReadArray.UseVisualStyleBackColor = true;
            this.btnReadArray.Click += new System.EventHandler(this.btnReadArray_Click);
            // 
            // btnWriteArray
            // 
            this.btnWriteArray.Location = new System.Drawing.Point(46, 432);
            this.btnWriteArray.Name = "btnWriteArray";
            this.btnWriteArray.Size = new System.Drawing.Size(96, 39);
            this.btnWriteArray.TabIndex = 10;
            this.btnWriteArray.Text = "WriteArray";
            this.btnWriteArray.UseVisualStyleBackColor = true;
            this.btnWriteArray.Click += new System.EventHandler(this.btnWriteArray_Click);
            // 
            // FrmModbusTcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 483);
            this.Controls.Add(this.lstWarning);
            this.Controls.Add(this.cmbWriteType);
            this.Controls.Add(this.btnWriteArray);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtAddrWrite);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnReadArray);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModbusTcp";
            this.Text = "FrmModbusTcp";
            this.Load += new System.EventHandler(this.FrmModbusTcp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbWriteType;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddrWrite;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lstWarning;
        private System.Windows.Forms.Button btnReadArray;
        private System.Windows.Forms.Button btnWriteArray;
    }
}