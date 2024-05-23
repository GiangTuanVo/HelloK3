using CoffeShop.Model;
using CoffeShop.SubForm;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CoffeeShop : Form
    {
        private string path = Application.StartupPath + "\\file";
        public CoffeeShop()
        {
            InitializeComponent();   
        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {
            //Read data from file CSV
            ReadData read = new ReadData(path);

            //Add table
            for (int i = 1; i <= 5; i++)
            {
                Table table = new Table();//user control
                table.ItemTable = $"Table{i}";
                table.Click += Table_Click;
                flpTable.Controls.Add(table);
            }
            if (ReadData.fileData.Tables.Count > 0)
            {
                if (ReadData.fileData.Tables["Product"].Rows.Count > 0)
                {
                    foreach (DataRow item in ReadData.fileData.Tables["Product"].Rows)
                    {
                        DrinkControl control = new DrinkControl();
                        control.Margin = new Padding(0, 0, 10, 10);
                        control.ItemImage = Bitmap.FromFile(item.ItemArray[1].ToString());
                        control.ItemName = item.ItemArray[2].ToString();
                        control.ItemPrice = $"{item.ItemArray[3]}vnd";
                        control.Click += Control_Click;
                        flpProduct.Controls.Add(control);
                    }
                }
            }

            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
            Table table = (Table)sender;
            if (table != null)
            {
                lblTable.Text = table.ItemTable;
                if (table.ListOrderControl != null)
                {
                    foreach (var item in table.ListOrderControl)
                    {
                        flpOrder.Controls.Add(item);
                    }
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if (lblTable.Text != "" && CheckTale(lblTable.Text))
            {
                OrderControl order = new OrderControl();
                if (sender is DrinkControl)
                {
                    DrinkControl control = (DrinkControl)sender;
                    order.Width = flpOrder.Width - 10;
                    order.ItemImage = control.ItemImage;
                    order.ItemName = control.ItemName;
                    order.ItemPrice = control.ItemPrice;
                    order.ItemAmount = "1";
                }
                order.MouseDown += Order_MouseDown;
                order.MouseClick += Order_MouseClick;
                flpOrder.Controls.Add(order);
                CalculatorTotoalPrice();
            }
            else
            {

            }
        }

        private void Order_MouseClick(object sender, MouseEventArgs e)
        {
            CalculatorTotoalPrice();
        }

        private void Order_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is OrderControl)
            {
                flpOrder.Controls.Remove((OrderControl)sender);
                CalculatorTotoalPrice();
            }
        }

        private void imgPerson_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void CalculatorTotoalPrice()
        {
            int totalPrice = 0;
            if (flpOrder.Controls.Count > 0)
            {
                foreach (OrderControl item in flpOrder.Controls)
                {
                    totalPrice += item.TotalPrice();
                }
                lblTotal.Text = $"{totalPrice}vnd";
            }
            else
            {
                lblTotal.Text = "0vnd";
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (flpOrder.Controls.Count > 0)
            {
                if (flpTable.Controls.Count > 0)
                {
                    foreach (Table item in flpTable.Controls)
                    {
                        if (item.ItemTable == lblTable.Text)
                        {
                            if (item.IsOrder)
                            {
                                FrmInfo info = new FrmInfo();
                                info.ItemInfo = "Table ordered, please save table";
                                info.ShowDialog();
                                return;
                            }
                            else
                            {
                                foreach (OrderControl control in flpOrder.Controls)
                                {
                                    item.ListOrderControl.Add(control);
                                }
                                item.IsOrder = true;
                                flpOrder.Controls.Clear();
                                lblTable.Text = "";
                                break;
                            }
                        }
                    }
                }
            }
        }
        private bool CheckTale(string table)
        {
            bool isCheck = false;
            if (flpTable.Controls.Count > 0)
            {
                foreach (Table item in flpTable.Controls)
                {
                    if (item.ItemTable == table)
                    {
                        isCheck = true;
                        break;
                    }
                }
            }
            return isCheck;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Print(PrintPanel);
            flpOrder.Controls.Clear();
            if (flpTable.Controls.Count > 0)
            {
                foreach (Table item in flpTable.Controls)
                {
                    if (item.IsOrder && item.ItemTable == lblTable.Text)
                    {
                        item.ListOrderControl.Clear();
                        item.IsOrder = false;
                        break;
                    }
                }
            }

        }
        private void Print(Panel panel)
        {
            PrinterSettings printer = new PrinterSettings();
            GetPrintArea(panel);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog.ShowDialog();
        }
        private Bitmap memoryimg;

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, pagearea.Width / 2 - this.PrintPanel.Width / 2, this.PrintPanel.Location.Y);
        }

        private void GetPrintArea(Panel panel)
        {
            memoryimg = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryimg, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (flpOrder.Controls.Count > 0)
            {
                if (flpTable.Controls.Count > 0)
                {
                    foreach (Table item in flpTable.Controls)
                    {
                        if (item.ItemTable == lblTable.Text)
                        {
                            if (item.IsOrder)
                            {
                                item.ListOrderControl.Clear();
                                foreach (OrderControl control in flpOrder.Controls)
                                {
                                    item.ListOrderControl.Add(control);
                                }
                                item.IsOrder = true;
                                flpOrder.Controls.Clear();
                                lblTable.Text = "";
                                break;
                            }
                            else
                            {
                                FrmInfo info = new FrmInfo();
                                info.ItemInfo = "Table not ordered, please create table";
                                info.ShowDialog();
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            flpOrder.Controls.Clear();
        }
    }
}
