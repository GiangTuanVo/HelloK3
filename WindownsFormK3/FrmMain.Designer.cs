
namespace WindownsFormK3
{
    partial class FrmMain
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
            this.radRedColor = new System.Windows.Forms.RadioButton();
            this.radBlueColor = new System.Windows.Forms.RadioButton();
            this.radOrangeColor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFontUnderline = new System.Windows.Forms.CheckBox();
            this.chkFontItalic = new System.Windows.Forms.CheckBox();
            this.chkFontBold = new System.Windows.Forms.CheckBox();
            this.chkLed = new System.Windows.Forms.CheckBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lstPersonal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.grbCom = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.chklbLeft = new System.Windows.Forms.CheckedListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.chklbRight = new System.Windows.Forms.CheckedListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.drinkIcons1 = new WindownsFormK3.Control.DrinkIcons();
            this.picLed = new System.Windows.Forms.PictureBox();
            this.Image = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // radRedColor
            // 
            this.radRedColor.AutoSize = true;
            this.radRedColor.Location = new System.Drawing.Point(9, 38);
            this.radRedColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radRedColor.Name = "radRedColor";
            this.radRedColor.Size = new System.Drawing.Size(56, 24);
            this.radRedColor.TabIndex = 3;
            this.radRedColor.TabStop = true;
            this.radRedColor.Text = "Red";
            this.radRedColor.UseVisualStyleBackColor = true;
            this.radRedColor.CheckedChanged += new System.EventHandler(this.radRedColor_CheckedChanged);
            // 
            // radBlueColor
            // 
            this.radBlueColor.AutoSize = true;
            this.radBlueColor.Location = new System.Drawing.Point(9, 85);
            this.radBlueColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBlueColor.Name = "radBlueColor";
            this.radBlueColor.Size = new System.Drawing.Size(58, 24);
            this.radBlueColor.TabIndex = 3;
            this.radBlueColor.TabStop = true;
            this.radBlueColor.Text = "Blue";
            this.radBlueColor.UseVisualStyleBackColor = true;
            this.radBlueColor.CheckedChanged += new System.EventHandler(this.radBlueColor_CheckedChanged);
            // 
            // radOrangeColor
            // 
            this.radOrangeColor.AutoSize = true;
            this.radOrangeColor.Location = new System.Drawing.Point(9, 131);
            this.radOrangeColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radOrangeColor.Name = "radOrangeColor";
            this.radOrangeColor.Size = new System.Drawing.Size(84, 24);
            this.radOrangeColor.TabIndex = 3;
            this.radOrangeColor.Text = "Orange";
            this.radOrangeColor.UseVisualStyleBackColor = true;
            this.radOrangeColor.CheckedChanged += new System.EventHandler(this.radOrangeColor_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRedColor);
            this.groupBox1.Controls.Add(this.radBlueColor);
            this.groupBox1.Controls.Add(this.radOrangeColor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(130, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(14, 205);
            this.txtText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(271, 113);
            this.txtText.TabIndex = 7;
            this.txtText.Text = "Hello everyone!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFontUnderline);
            this.groupBox2.Controls.Add(this.chkFontItalic);
            this.groupBox2.Controls.Add(this.chkFontBold);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(152, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(133, 177);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // chkFontUnderline
            // 
            this.chkFontUnderline.AutoSize = true;
            this.chkFontUnderline.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFontUnderline.Location = new System.Drawing.Point(9, 131);
            this.chkFontUnderline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFontUnderline.Name = "chkFontUnderline";
            this.chkFontUnderline.Size = new System.Drawing.Size(89, 24);
            this.chkFontUnderline.TabIndex = 0;
            this.chkFontUnderline.Text = "Uderline";
            this.chkFontUnderline.UseVisualStyleBackColor = true;
            this.chkFontUnderline.CheckedChanged += new System.EventHandler(this.chkFontUnderline_CheckedChanged);
            // 
            // chkFontItalic
            // 
            this.chkFontItalic.AutoSize = true;
            this.chkFontItalic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFontItalic.Location = new System.Drawing.Point(9, 85);
            this.chkFontItalic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFontItalic.Name = "chkFontItalic";
            this.chkFontItalic.Size = new System.Drawing.Size(99, 22);
            this.chkFontItalic.TabIndex = 0;
            this.chkFontItalic.Text = "Font Italic";
            this.chkFontItalic.UseVisualStyleBackColor = true;
            this.chkFontItalic.CheckedChanged += new System.EventHandler(this.chkFontItalic_CheckedChanged);
            // 
            // chkFontBold
            // 
            this.chkFontBold.AutoSize = true;
            this.chkFontBold.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFontBold.Location = new System.Drawing.Point(9, 38);
            this.chkFontBold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFontBold.Name = "chkFontBold";
            this.chkFontBold.Size = new System.Drawing.Size(94, 22);
            this.chkFontBold.TabIndex = 0;
            this.chkFontBold.Text = "Font Bold";
            this.chkFontBold.UseVisualStyleBackColor = true;
            this.chkFontBold.CheckedChanged += new System.EventHandler(this.chkFontBold_CheckedChanged);
            // 
            // chkLed
            // 
            this.chkLed.AutoSize = true;
            this.chkLed.Location = new System.Drawing.Point(235, 454);
            this.chkLed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLed.Name = "chkLed";
            this.chkLed.Size = new System.Drawing.Size(54, 24);
            this.chkLed.TabIndex = 10;
            this.chkLed.Text = "LED";
            this.chkLed.UseVisualStyleBackColor = true;
            this.chkLed.CheckedChanged += new System.EventHandler(this.chkLed_CheckedChanged);
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(14, 345);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(271, 26);
            this.dtpTime.TabIndex = 11;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // lstPersonal
            // 
            this.lstPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPersonal.FormattingEnabled = true;
            this.lstPersonal.ItemHeight = 20;
            this.lstPersonal.Location = new System.Drawing.Point(22, 149);
            this.lstPersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPersonal.Name = "lstPersonal";
            this.lstPersonal.Size = new System.Drawing.Size(375, 204);
            this.lstPersonal.TabIndex = 12;
            this.lstPersonal.SelectedIndexChanged += new System.EventHandler(this.lstPersonal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birth Day";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 26);
            this.txtName.TabIndex = 14;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(94, 55);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(181, 26);
            this.txtAge.TabIndex = 14;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(94, 84);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(181, 26);
            this.txtSex.TabIndex = 14;
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Location = new System.Drawing.Point(94, 113);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(181, 26);
            this.txtBirthDay.TabIndex = 14;
            this.txtBirthDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(322, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(322, 104);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(75, 35);
            this.btnRepair.TabIndex = 15;
            this.btnRepair.Text = "REPAIR";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstPersonal);
            this.groupBox3.Controls.Add(this.btnRepair);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBirthDay);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSex);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtAge);
            this.groupBox3.Location = new System.Drawing.Point(314, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 372);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Personal Information";
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(6, 58);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(163, 28);
            this.cboCom.TabIndex = 17;
            // 
            // grbCom
            // 
            this.grbCom.Controls.Add(this.label6);
            this.grbCom.Controls.Add(this.cboBaud);
            this.grbCom.Controls.Add(this.label5);
            this.grbCom.Controls.Add(this.cboCom);
            this.grbCom.Controls.Add(this.btnClose);
            this.grbCom.Controls.Add(this.btnOpen);
            this.grbCom.Location = new System.Drawing.Point(314, 394);
            this.grbCom.Name = "grbCom";
            this.grbCom.Size = new System.Drawing.Size(182, 210);
            this.grbCom.TabIndex = 18;
            this.grbCom.TabStop = false;
            this.grbCom.Text = "Connection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "BaudRate";
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "9600",
            "19200"});
            this.cboBaud.Location = new System.Drawing.Point(6, 117);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(163, 28);
            this.cboBaud.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "ComPort";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(94, 161);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(4, 161);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "ITEMS";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // chklbLeft
            // 
            this.chklbLeft.FormattingEnabled = true;
            this.chklbLeft.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.chklbLeft.Location = new System.Drawing.Point(770, 136);
            this.chklbLeft.Name = "chklbLeft";
            this.chklbLeft.Size = new System.Drawing.Size(182, 235);
            this.chklbLeft.TabIndex = 19;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(770, 377);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 35);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(851, 377);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(75, 35);
            this.btnItems.TabIndex = 15;
            this.btnItems.Text = "ITEMS";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // chklbRight
            // 
            this.chklbRight.FormattingEnabled = true;
            this.chklbRight.Location = new System.Drawing.Point(1017, 136);
            this.chklbRight.Name = "chklbRight";
            this.chklbRight.Size = new System.Drawing.Size(182, 235);
            this.chklbRight.TabIndex = 19;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(958, 160);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(53, 35);
            this.btnMoveRight.TabIndex = 15;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(958, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // drinkIcons1
            // 
            this.drinkIcons1.BackColor = System.Drawing.Color.White;
            this.drinkIcons1.ItemImage = global::WindownsFormK3.Properties.Resources.milk_coffee;
            this.drinkIcons1.ItemName = "Milk Coffee";
            this.drinkIcons1.ItemPrice = "20000vnd";
            this.drinkIcons1.Location = new System.Drawing.Point(636, 435);
            this.drinkIcons1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkIcons1.Name = "drinkIcons1";
            this.drinkIcons1.Size = new System.Drawing.Size(150, 169);
            this.drinkIcons1.TabIndex = 20;
            // 
            // picLed
            // 
            this.picLed.Location = new System.Drawing.Point(235, 394);
            this.picLed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLed.Name = "picLed";
            this.picLed.Size = new System.Drawing.Size(50, 50);
            this.picLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLed.TabIndex = 8;
            this.picLed.TabStop = false;
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(18, 394);
            this.Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(195, 174);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 8;
            this.Image.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 649);
            this.Controls.Add(this.drinkIcons1);
            this.Controls.Add(this.chklbRight);
            this.Controls.Add(this.chklbLeft);
            this.Controls.Add(this.grbCom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.chkLed);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.picLed);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbCom.ResumeLayout(false);
            this.grbCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radRedColor;
        private System.Windows.Forms.RadioButton radBlueColor;
        private System.Windows.Forms.RadioButton radOrangeColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkFontUnderline;
        private System.Windows.Forms.CheckBox chkFontItalic;
        private System.Windows.Forms.CheckBox chkFontBold;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.CheckBox chkLed;
        private System.Windows.Forms.PictureBox picLed;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ListBox lstPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtBirthDay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.GroupBox grbCom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.CheckedListBox chklbLeft;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.CheckedListBox chklbRight;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button button1;
        private Control.DrinkIcons drinkIcons1;
    }
}