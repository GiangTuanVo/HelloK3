﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class DrinkControl : UserControl
    {
        public Image ItemImage
        {
            get { return btnImage.Image; }
            set { btnImage.Image = value; }
        }
        public string ItemName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string ItemPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public DrinkControl()
        {
            InitializeComponent();
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
