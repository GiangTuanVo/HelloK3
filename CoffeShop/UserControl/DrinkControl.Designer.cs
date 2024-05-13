
namespace CoffeShop
{
    partial class DrinkControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkControl));
            this.PanelCover = new System.Windows.Forms.Panel();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnImage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PanelCover.SuspendLayout();
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCover
            // 
            this.PanelCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCover.Controls.Add(this.Layout);
            this.PanelCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCover.Location = new System.Drawing.Point(0, 0);
            this.PanelCover.Margin = new System.Windows.Forms.Padding(0);
            this.PanelCover.Name = "PanelCover";
            this.PanelCover.Padding = new System.Windows.Forms.Padding(1);
            this.PanelCover.Size = new System.Drawing.Size(164, 169);
            this.PanelCover.TabIndex = 0;
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 1;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Controls.Add(this.lblName, 0, 1);
            this.Layout.Controls.Add(this.lblPrice, 0, 2);
            this.Layout.Controls.Add(this.btnImage, 0, 0);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(1, 1);
            this.Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 3;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.Size = new System.Drawing.Size(160, 165);
            this.Layout.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1, 125);
            this.lblName.Margin = new System.Windows.Forms.Padding(1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(158, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Avocado";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Teal;
            this.lblPrice.Location = new System.Drawing.Point(1, 145);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(158, 19);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "$10";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnImage.ImageSize = new System.Drawing.Size(134, 98);
            this.btnImage.ImageZoomSize = new System.Drawing.Size(154, 118);
            this.btnImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnImage.InitialImage")));
            this.btnImage.Location = new System.Drawing.Point(3, 3);
            this.btnImage.Name = "btnImage";
            this.btnImage.Rotation = 0;
            this.btnImage.ShowActiveImage = true;
            this.btnImage.ShowCursorChanges = true;
            this.btnImage.ShowImageBorders = true;
            this.btnImage.ShowSizeMarkers = false;
            this.btnImage.Size = new System.Drawing.Size(154, 118);
            this.btnImage.TabIndex = 3;
            this.btnImage.ToolTipText = "";
            this.btnImage.WaitOnLoad = false;
            this.btnImage.Zoom = 20;
            this.btnImage.ZoomSpeed = 10;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // DrinkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelCover);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DrinkControl";
            this.Size = new System.Drawing.Size(164, 169);
            this.PanelCover.ResumeLayout(false);
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCover;
        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private Bunifu.UI.WinForms.BunifuImageButton btnImage;
    }
}
