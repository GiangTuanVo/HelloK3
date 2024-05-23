using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindownsFormK3.Control
{
    public partial class DrinkIcons : UserControl
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
        public DrinkIcons()
        {
            InitializeComponent();
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
