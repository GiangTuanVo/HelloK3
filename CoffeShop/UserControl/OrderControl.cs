using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class OrderControl : UserControl
    {
        public Image ItemImage
        {
            get { return picItems.Image; }
            set { picItems.Image = value; }
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
        public string ItemAmount
        {
            get { return txtAmount.Text; }
            set { txtAmount.Text = value; }
        }
        public OrderControl()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            txtAmount.Text = (int.Parse(txtAmount.Text) + 1).ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            txtAmount.Text = (int.Parse(txtAmount.Text) - 1).ToString();
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        private void btnUp_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btnDown_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }
        public int TotalPrice()
        {
            return int.Parse(txtAmount.Text) * int.Parse(ItemPrice.Substring(0, ItemPrice.Length - 3));
        }
    }
}
