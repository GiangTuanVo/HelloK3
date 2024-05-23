
namespace WindownsFormK3.Control
{
    partial class DrinkIcons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkIcons));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnImage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrice.Location = new System.Drawing.Point(34, 147);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 19);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "15000vnd";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 122);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Back Coffee";
            // 
            // btnImage
            // 
            this.btnImage.ActiveImage = null;
            this.btnImage.AllowAnimations = true;
            this.btnImage.AllowBuffering = false;
            this.btnImage.AllowToggling = false;
            this.btnImage.AllowZooming = true;
            this.btnImage.AllowZoomingOnFocus = false;
            this.btnImage.BackColor = System.Drawing.Color.Transparent;
            this.btnImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnImage.ErrorImage")));
            this.btnImage.FadeWhenInactive = false;
            this.btnImage.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.ImageActive = null;
            this.btnImage.ImageLocation = null;
            this.btnImage.ImageMargin = 20;
            this.btnImage.ImageSize = new System.Drawing.Size(124, 93);
            this.btnImage.ImageZoomSize = new System.Drawing.Size(144, 113);
            this.btnImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnImage.InitialImage")));
            this.btnImage.Location = new System.Drawing.Point(3, 3);
            this.btnImage.Name = "btnImage";
            this.btnImage.Rotation = 0;
            this.btnImage.ShowActiveImage = true;
            this.btnImage.ShowCursorChanges = true;
            this.btnImage.ShowImageBorders = true;
            this.btnImage.ShowSizeMarkers = false;
            this.btnImage.Size = new System.Drawing.Size(144, 113);
            this.btnImage.TabIndex = 2;
            this.btnImage.ToolTipText = "";
            this.btnImage.WaitOnLoad = false;
            this.btnImage.Zoom = 20;
            this.btnImage.ZoomSpeed = 10;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // DrinkIcons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DrinkIcons";
            this.Size = new System.Drawing.Size(150, 169);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private Bunifu.UI.WinForms.BunifuImageButton btnImage;
    }
}
