
namespace CoffeShop
{
    partial class Table
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.btnTable = new Bunifu.UI.WinForms.BunifuImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTableName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTable, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(46, 126);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(3);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(57, 21);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "label1";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTable
            // 
            this.btnTable.ActiveImage = null;
            this.btnTable.AllowAnimations = true;
            this.btnTable.AllowBuffering = false;
            this.btnTable.AllowToggling = false;
            this.btnTable.AllowZooming = true;
            this.btnTable.AllowZoomingOnFocus = false;
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTable.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnTable.ErrorImage")));
            this.btnTable.FadeWhenInactive = false;
            this.btnTable.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnTable.Image = global::CoffeShop.Properties.Resources.table;
            this.btnTable.ImageActive = null;
            this.btnTable.ImageLocation = null;
            this.btnTable.ImageMargin = 30;
            this.btnTable.ImageSize = new System.Drawing.Size(114, 87);
            this.btnTable.ImageZoomSize = new System.Drawing.Size(144, 117);
            this.btnTable.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnTable.InitialImage")));
            this.btnTable.Location = new System.Drawing.Point(3, 3);
            this.btnTable.Name = "btnTable";
            this.btnTable.Rotation = 0;
            this.btnTable.ShowActiveImage = true;
            this.btnTable.ShowCursorChanges = true;
            this.btnTable.ShowImageBorders = true;
            this.btnTable.ShowSizeMarkers = false;
            this.btnTable.Size = new System.Drawing.Size(144, 117);
            this.btnTable.TabIndex = 1;
            this.btnTable.ToolTipText = "";
            this.btnTable.WaitOnLoad = false;
            this.btnTable.Zoom = 30;
            this.btnTable.ZoomSpeed = 10;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Table";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTableName;
        private Bunifu.UI.WinForms.BunifuImageButton btnTable;
    }
}
