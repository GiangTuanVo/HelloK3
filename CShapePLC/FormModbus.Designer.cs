
namespace CShapePLC
{
    partial class FormModbus
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addrReadRtu = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.addrWriteRtu = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(18, 18);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(93, 42);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "READ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bool",
            "Int16",
            "Int32",
            "Int64",
            "Float"});
            this.comboBox1.Location = new System.Drawing.Point(211, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // addrReadRtu
            // 
            this.addrReadRtu.Location = new System.Drawing.Point(118, 76);
            this.addrReadRtu.Name = "addrReadRtu";
            this.addrReadRtu.Size = new System.Drawing.Size(86, 26);
            this.addrReadRtu.TabIndex = 4;
            this.addrReadRtu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(18, 119);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(93, 39);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bool",
            "Int16",
            "Int32",
            "Int64",
            "Float"});
            this.comboBox2.Location = new System.Drawing.Point(211, 125);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // addrWriteRtu
            // 
            this.addrWriteRtu.Location = new System.Drawing.Point(118, 125);
            this.addrWriteRtu.Name = "addrWriteRtu";
            this.addrWriteRtu.Size = new System.Drawing.Size(86, 26);
            this.addrWriteRtu.TabIndex = 4;
            this.addrWriteRtu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(311, 125);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(86, 26);
            this.txtValue.TabIndex = 4;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormModbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 204);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.addrWriteRtu);
            this.Controls.Add(this.addrReadRtu);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormModbus";
            this.Text = "FormModbus";
            this.Load += new System.EventHandler(this.FormModbus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox addrReadRtu;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox addrWriteRtu;
        private System.Windows.Forms.TextBox txtValue;
    }
}