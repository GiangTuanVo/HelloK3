using System;
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
    public partial class Table : UserControl
    {
        public List<OrderControl> ListOrderControl { get; set; }
        public bool IsOrder { get; set; } = false;
        public string ItemTable
        {
            get { return lblTableName.Text; }
            set { lblTableName.Text = value; }
        }
        private List<OrderControl> orders;
        public List<OrderControl> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public Table()
        {
            ListOrderControl = new List<OrderControl>();
            InitializeComponent();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
