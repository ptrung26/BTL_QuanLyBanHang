namespace Project_BTL
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnNCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.panelChucNang = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDonNhapHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonDatHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnHDN = new Guna.UI2.WinForms.Guna2Button();
            this.btnChucNang = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.panelTTNV = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.btnBaoCaoDT = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.panelTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.sidebar.Controls.Add(this.btnBaoCaoDT);
            this.sidebar.Controls.Add(this.btnThongKe);
            this.sidebar.Controls.Add(this.btnNCC);
            this.sidebar.Controls.Add(this.btnNhanVien);
            this.sidebar.Controls.Add(this.panelChucNang);
            this.sidebar.Controls.Add(this.btnChucNang);
            this.sidebar.Controls.Add(this.btnQLKH);
            this.sidebar.Controls.Add(this.btnSanPham);
            this.sidebar.Controls.Add(this.btnLogOut);
            this.sidebar.Controls.Add(this.panelTTNV);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(50, 794);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.sidebar.Size = new System.Drawing.Size(244, 1055);
            this.sidebar.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderRadius = 6;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::GUI.Properties.Resources.thongke;
            this.btnThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThongKe.Location = new System.Drawing.Point(0, 771);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(244, 50);
            this.btnThongKe.TabIndex = 68;
            this.btnThongKe.Text = "Thống kê biểu đồ";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.BorderRadius = 6;
            this.btnNCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.btnNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.Color.White;
            this.btnNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNCC.Image")));
            this.btnNCC.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNCC.ImageSize = new System.Drawing.Size(36, 36);
            this.btnNCC.Location = new System.Drawing.Point(0, 721);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(244, 50);
            this.btnNCC.TabIndex = 67;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BorderRadius = 6;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::GUI.Properties.Resources.employee;
            this.btnNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.ImageSize = new System.Drawing.Size(36, 36);
            this.btnNhanVien.Location = new System.Drawing.Point(0, 671);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(244, 50);
            this.btnNhanVien.TabIndex = 66;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.btnDonNhapHang);
            this.panelChucNang.Controls.Add(this.btnDonDatHang);
            this.panelChucNang.Controls.Add(this.btnHoaDon);
            this.panelChucNang.Controls.Add(this.btnHDN);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChucNang.Location = new System.Drawing.Point(0, 467);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(244, 204);
            this.panelChucNang.TabIndex = 13;
            // 
            // btnDonNhapHang
            // 
            this.btnDonNhapHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonNhapHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonNhapHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonNhapHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonNhapHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))), ((int)(((byte)(204)))));
            this.btnDonNhapHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnDonNhapHang.Location = new System.Drawing.Point(0, 150);
            this.btnDonNhapHang.Name = "btnDonNhapHang";
            this.btnDonNhapHang.Size = new System.Drawing.Size(244, 50);
            this.btnDonNhapHang.TabIndex = 10;
            this.btnDonNhapHang.Text = "Đơn nhập hàng";
            this.btnDonNhapHang.Click += new System.EventHandler(this.btnDonNhapHang_Click);
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonDatHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonDatHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonDatHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonDatHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))), ((int)(((byte)(204)))));
            this.btnDonDatHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDonDatHang.Location = new System.Drawing.Point(0, 100);
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.Size = new System.Drawing.Size(244, 50);
            this.btnDonDatHang.TabIndex = 9;
            this.btnDonDatHang.Text = "Đơn đặt hàng";
            this.btnDonDatHang.Click += new System.EventHandler(this.btnDonDatHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))), ((int)(((byte)(204)))));
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoaDon.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHoaDon.Location = new System.Drawing.Point(0, 50);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(244, 50);
            this.btnHoaDon.TabIndex = 8;
            this.btnHoaDon.Text = "Hóa đơn bán";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnHDN
            // 
            this.btnHDN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHDN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHDN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))), ((int)(((byte)(204)))));
            this.btnHDN.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDN.ForeColor = System.Drawing.Color.White;
            this.btnHDN.Location = new System.Drawing.Point(0, 0);
            this.btnHDN.Name = "btnHDN";
            this.btnHDN.Size = new System.Drawing.Size(244, 50);
            this.btnHDN.TabIndex = 8;
            this.btnHDN.Text = "Hóa đơn nhập";
            this.btnHDN.Click += new System.EventHandler(this.btnHDN_Click);
            // 
            // btnChucNang
            // 
            this.btnChucNang.BorderRadius = 6;
            this.btnChucNang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChucNang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChucNang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChucNang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChucNang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.btnChucNang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucNang.ForeColor = System.Drawing.Color.White;
            this.btnChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnChucNang.Image")));
            this.btnChucNang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChucNang.ImageSize = new System.Drawing.Size(25, 25);
            this.btnChucNang.Location = new System.Drawing.Point(0, 417);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Size = new System.Drawing.Size(244, 50);
            this.btnChucNang.TabIndex = 65;
            this.btnChucNang.Text = "Chức năng";
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.BorderRadius = 6;
            this.btnQLKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.btnQLKH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.White;
            this.btnQLKH.Image = ((System.Drawing.Image)(resources.GetObject("btnQLKH.Image")));
            this.btnQLKH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLKH.ImageSize = new System.Drawing.Size(28, 28);
            this.btnQLKH.Location = new System.Drawing.Point(0, 366);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(244, 51);
            this.btnQLKH.TabIndex = 64;
            this.btnQLKH.Text = "Khách hàng";
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BorderRadius = 6;
            this.btnSanPham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSanPham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = global::GUI.Properties.Resources.product_2;
            this.btnSanPham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSanPham.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSanPham.Location = new System.Drawing.Point(0, 311);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(244, 55);
            this.btnSanPham.TabIndex = 63;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 6;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::GUI.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(70, 0);
            this.btnLogOut.ImageSize = new System.Drawing.Size(22, 22);
            this.btnLogOut.Location = new System.Drawing.Point(0, 985);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(244, 50);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelTTNV
            // 
            this.panelTTNV.Controls.Add(this.guna2CirclePictureBox1);
            this.panelTTNV.Controls.Add(this.lblChucVu);
            this.panelTTNV.Controls.Add(this.lblUserName);
            this.panelTTNV.Controls.Add(this.guna2Separator1);
            this.panelTTNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTTNV.Location = new System.Drawing.Point(0, 0);
            this.panelTTNV.Name = "panelTTNV";
            this.panelTTNV.Size = new System.Drawing.Size(244, 311);
            this.panelTTNV.TabIndex = 62;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::GUI.Properties.Resources.user_1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(36, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(170, 170);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 9;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(31, 244);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(86, 28);
            this.lblChucVu.TabIndex = 53;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(31, 197);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(64, 28);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(11, 275);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(217, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // pnlParent
            // 
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent.Location = new System.Drawing.Point(244, 0);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1313, 1055);
            this.pnlParent.TabIndex = 5;
            // 
            // btnBaoCaoDT
            // 
            this.btnBaoCaoDT.BorderRadius = 6;
            this.btnBaoCaoDT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoDT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoCaoDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoCaoDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.btnBaoCaoDT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoDT.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoDT.Image = global::GUI.Properties.Resources.thongke;
            this.btnBaoCaoDT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBaoCaoDT.ImageSize = new System.Drawing.Size(32, 32);
            this.btnBaoCaoDT.Location = new System.Drawing.Point(0, 821);
            this.btnBaoCaoDT.Name = "btnBaoCaoDT";
            this.btnBaoCaoDT.Size = new System.Drawing.Size(244, 50);
            this.btnBaoCaoDT.TabIndex = 69;
            this.btnBaoCaoDT.Text = "Báo cáo doanh thu";
            this.btnBaoCaoDT.Click += new System.EventHandler(this.btnBaoCaoDT_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1557, 1055);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.sidebar);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.sidebar.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.panelTTNV.ResumeLayout(false);
            this.panelTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panelTTNV;
        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblChucVu;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Panel panelChucNang;
        private Guna.UI2.WinForms.Guna2Button btnDonDatHang;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnHDN;
        private Guna.UI2.WinForms.Guna2Button btnChucNang;
        private Guna.UI2.WinForms.Guna2Button btnQLKH;
        private Guna.UI2.WinForms.Guna2Button btnSanPham;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnNCC;
        private Guna.UI2.WinForms.Guna2Button btnDonNhapHang;
        private System.Windows.Forms.Panel pnlParent;
        private Guna.UI2.WinForms.Guna2Button btnBaoCaoDT;
    }
}

