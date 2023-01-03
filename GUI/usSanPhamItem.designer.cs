namespace GUI
{
    partial class usSanPhamItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usSanPhamItem));
            this.lbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.picSp = new System.Windows.Forms.PictureBox();
            this.picCart = new System.Windows.Forms.PictureBox();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            ((System.ComponentModel.ISupportInitialize)(this.picSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(32, 194);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(279, 53);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "XPS 1500";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(165, 247);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(146, 28);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "1500000 VND";
            // 
            // picSp
            // 
            this.picSp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picSp.Image = ((System.Drawing.Image)(resources.GetObject("picSp.Image")));
            this.picSp.Location = new System.Drawing.Point(36, 15);
            this.picSp.Name = "picSp";
            this.picSp.Size = new System.Drawing.Size(274, 176);
            this.picSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSp.TabIndex = 2;
            this.picSp.TabStop = false;
            // 
            // picCart
            // 
            this.picCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCart.Image = ((System.Drawing.Image)(resources.GetObject("picCart.Image")));
            this.picCart.Location = new System.Drawing.Point(36, 247);
            this.picCart.Name = "picCart";
            this.picCart.Size = new System.Drawing.Size(35, 33);
            this.picCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCart.TabIndex = 0;
            this.picCart.TabStop = false;
            this.picCart.Click += new System.EventHandler(this.picCart_Click);
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(36, 298);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(220, 26);
            this.guna2RatingStar1.TabIndex = 4;
            // 
            // usSanPhamItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.picSp);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.picCart);
            this.Name = "usSanPhamItem";
            this.Size = new System.Drawing.Size(349, 355);
            ((System.ComponentModel.ISupportInitialize)(this.picSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCart;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox picSp;
        private System.Windows.Forms.Label priceLbl;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
    }
}
