namespace GUI
{
    partial class usCTGH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usCTGH));
            this.lbl = new System.Windows.Forms.Label();
            this.picSp = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(232, 27);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(689, 30);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "PC GAMING HACOM SHARK S22 (I5 12400F/B660/8GB RAM/500GB SSD/RTX 2060/600W)";
            // 
            // picSp
            // 
            this.picSp.Image = ((System.Drawing.Image)(resources.GetObject("picSp.Image")));
            this.picSp.Location = new System.Drawing.Point(11, 25);
            this.picSp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSp.Name = "picSp";
            this.picSp.Size = new System.Drawing.Size(215, 144);
            this.picSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSp.TabIndex = 0;
            this.picSp.TabStop = false;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(237, 94);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(44, 24);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(363, 94);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(44, 24);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(285, 94);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(72, 23);
            this.txtSoLuong.TabIndex = 4;
            this.txtSoLuong.Text = "2";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(232, 57);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(136, 25);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "1200000 VNĐ";
            // 
            // usCTGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.picSp);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "usCTGH";
            this.Size = new System.Drawing.Size(978, 183);
            ((System.ComponentModel.ISupportInitialize)(this.picSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSp;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label priceLbl;
    }
}
