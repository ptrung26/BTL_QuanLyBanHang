namespace GUI
{
    partial class frmChiTietHDN
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnIn = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lblcontentMaHD = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblContentNgayLap = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblContentTenNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblContentTongTien = new System.Windows.Forms.Label();
            this.lblContentSoDT = new System.Windows.Forms.Label();
            this.lblContentDiaChi = new System.Windows.Forms.Label();
            this.lblContentTenNCC = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(532, 105);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(169, 46);
            this.btnIn.TabIndex = 49;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToResizeColumns = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHoaDon.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.Location = new System.Drawing.Point(15, 162);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHoaDon.RowTemplate.DividerHeight = 1;
            this.dgvHoaDon.RowTemplate.Height = 35;
            this.dgvHoaDon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(686, 235);
            this.dgvHoaDon.TabIndex = 48;
            // 
            // lblcontentMaHD
            // 
            this.lblcontentMaHD.AutoSize = true;
            this.lblcontentMaHD.Location = new System.Drawing.Point(129, 9);
            this.lblcontentMaHD.Name = "lblcontentMaHD";
            this.lblcontentMaHD.Size = new System.Drawing.Size(78, 16);
            this.lblcontentMaHD.TabIndex = 47;
            this.lblcontentMaHD.Text = "Mã hóa đơn";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(12, 9);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(81, 16);
            this.lblMaHD.TabIndex = 46;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // lblContentNgayLap
            // 
            this.lblContentNgayLap.AutoSize = true;
            this.lblContentNgayLap.Location = new System.Drawing.Point(488, 43);
            this.lblContentNgayLap.Name = "lblContentNgayLap";
            this.lblContentNgayLap.Size = new System.Drawing.Size(114, 16);
            this.lblContentNgayLap.TabIndex = 45;
            this.lblContentNgayLap.Text = "Ngày lập hóa đơn";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(331, 43);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(117, 16);
            this.lblNgayLap.TabIndex = 44;
            this.lblNgayLap.Text = "Ngày lập hóa đơn:";
            // 
            // lblContentTenNV
            // 
            this.lblContentTenNV.AutoSize = true;
            this.lblContentTenNV.Location = new System.Drawing.Point(488, 9);
            this.lblContentTenNV.Name = "lblContentTenNV";
            this.lblContentTenNV.Size = new System.Drawing.Size(91, 16);
            this.lblContentTenNV.TabIndex = 43;
            this.lblContentTenNV.Text = "Tên nhân viên";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(331, 9);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(127, 16);
            this.lblTenNV.TabIndex = 42;
            this.lblTenNV.Text = "Nhân viên phụ trách:";
            // 
            // lblContentTongTien
            // 
            this.lblContentTongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentTongTien.Location = new System.Drawing.Point(560, 418);
            this.lblContentTongTien.Name = "lblContentTongTien";
            this.lblContentTongTien.Size = new System.Drawing.Size(131, 23);
            this.lblContentTongTien.TabIndex = 41;
            this.lblContentTongTien.Text = "Tiền";
            this.lblContentTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContentSoDT
            // 
            this.lblContentSoDT.AutoSize = true;
            this.lblContentSoDT.Location = new System.Drawing.Point(129, 120);
            this.lblContentSoDT.Name = "lblContentSoDT";
            this.lblContentSoDT.Size = new System.Drawing.Size(85, 16);
            this.lblContentSoDT.TabIndex = 40;
            this.lblContentSoDT.Text = "Số điện thoại";
            // 
            // lblContentDiaChi
            // 
            this.lblContentDiaChi.AutoSize = true;
            this.lblContentDiaChi.Location = new System.Drawing.Point(129, 81);
            this.lblContentDiaChi.Name = "lblContentDiaChi";
            this.lblContentDiaChi.Size = new System.Drawing.Size(47, 16);
            this.lblContentDiaChi.TabIndex = 39;
            this.lblContentDiaChi.Text = "Địa chỉ";
            // 
            // lblContentTenNCC
            // 
            this.lblContentTenNCC.AutoSize = true;
            this.lblContentTenNCC.Location = new System.Drawing.Point(129, 43);
            this.lblContentTenNCC.Name = "lblContentTenNCC";
            this.lblContentTenNCC.Size = new System.Drawing.Size(31, 16);
            this.lblContentTenNCC.TabIndex = 38;
            this.lblContentTenNCC.Text = "Tên";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(455, 418);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(87, 23);
            this.lblTongTien.TabIndex = 37;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(12, 120);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(88, 16);
            this.lblSoDT.TabIndex = 36;
            this.lblSoDT.Text = "Số điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 81);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 35;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(12, 43);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(106, 16);
            this.lblTenNCC.TabIndex = 34;
            this.lblTenNCC.Text = "Tên khách hàng:";
            // 
            // frmChiTietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 469);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.lblcontentMaHD);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.lblContentNgayLap);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.lblContentTenNV);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblContentTongTien);
            this.Controls.Add(this.lblContentSoDT);
            this.Controls.Add(this.lblContentDiaChi);
            this.Controls.Add(this.lblContentTenNCC);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenNCC);
            this.Name = "frmChiTietHDN";
            this.Text = "frmChiTietHDN";
            this.Load += new System.EventHandler(this.frmChiTietHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label lblcontentMaHD;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblContentNgayLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblContentTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblContentTongTien;
        private System.Windows.Forms.Label lblContentSoDT;
        private System.Windows.Forms.Label lblContentDiaChi;
        private System.Windows.Forms.Label lblContentTenNCC;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenNCC;
    }
}