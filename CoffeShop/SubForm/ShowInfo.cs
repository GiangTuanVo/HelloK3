﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeShop.SubForm
{
    public partial class ShowInfo : Form
    {
        public string ItemInfo
        {
            get { return lblInfo.Text; }
            set { lblInfo.Text = value; }
        }
        public Color ItemColor
        {
            get { return lblInfo.ForeColor; }
            set { lblInfo.ForeColor = value; }
        }
        public ShowInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
