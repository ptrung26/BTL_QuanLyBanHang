namespace GUI
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnDangNhap = new Guna.UI2.WinForms.Guna2Panel();
            this.lblQuenMK = new System.Windows.Forms.Label();
            this.txtMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnQuenMK = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMaBaoMat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhapLaiMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMK_Moi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTK_Quen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pnDangNhap.SuspendLayout();
            this.pnQuenMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đăng nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(36, 209);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(325, 55);
            this.btnDangNhap.TabIndex = 12;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pnDangNhap
            // 
            this.pnDangNhap.Controls.Add(this.lblQuenMK);
            this.pnDangNhap.Controls.Add(this.label1);
            this.pnDangNhap.Controls.Add(this.btnDangNhap);
            this.pnDangNhap.Controls.Add(this.txtMK);
            this.pnDangNhap.Controls.Add(this.txtUser);
            this.pnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnDangNhap.Location = new System.Drawing.Point(538, 73);
            this.pnDangNhap.Name = "pnDangNhap";
            this.pnDangNhap.Size = new System.Drawing.Size(402, 439);
            this.pnDangNhap.TabIndex = 16;
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.AutoSize = true;
            this.lblQuenMK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMK.Location = new System.Drawing.Point(82, 278);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(230, 20);
            this.lblQuenMK.TabIndex = 16;
            this.lblQuenMK.Text = "Quên tài khoản hoặc mật khẩu ?";
            this.lblQuenMK.Click += new System.EventHandler(this.lblQuenMK_Click);
            // 
            // txtMK
            // 
            this.txtMK.BorderRadius = 8;
            this.txtMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMK.DefaultText = "";
            this.txtMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK.IconLeft = global::GUI.Properties.Resources.key_s;
            this.txtMK.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtMK.IconRight = global::GUI.Properties.Resources.eye_c;
            this.txtMK.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtMK.Location = new System.Drawing.Point(36, 138);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '●';
            this.txtMK.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMK.PlaceholderText = "Mật khẩu";
            this.txtMK.SelectedText = "";
            this.txtMK.Size = new System.Drawing.Size(333, 43);
            this.txtMK.TabIndex = 10;
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.IconRightClick += new System.EventHandler(this.txtMK_IconRightClick);
            this.txtMK.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtUser
            // 
            this.txtUser.BorderRadius = 8;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.IconLeft = global::GUI.Properties.Resources.user_s;
            this.txtUser.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtUser.Location = new System.Drawing.Point(36, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUser.PlaceholderText = "Tài khoản";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(333, 43);
            this.txtUser.TabIndex = 9;
            this.txtUser.Click += new System.EventHandler(this.txt_Click);
            // 
            // pnQuenMK
            // 
            this.pnQuenMK.Controls.Add(this.txtMaBaoMat);
            this.pnQuenMK.Controls.Add(this.txtNhapLaiMK);
            this.pnQuenMK.Controls.Add(this.lblLogin);
            this.pnQuenMK.Controls.Add(this.label4);
            this.pnQuenMK.Controls.Add(this.btnXacNhan);
            this.pnQuenMK.Controls.Add(this.txtMK_Moi);
            this.pnQuenMK.Controls.Add(this.txtTK_Quen);
            this.pnQuenMK.Location = new System.Drawing.Point(537, 73);
            this.pnQuenMK.Name = "pnQuenMK";
            this.pnQuenMK.Size = new System.Drawing.Size(402, 439);
            this.pnQuenMK.TabIndex = 17;
            // 
            // txtMaBaoMat
            // 
            this.txtMaBaoMat.BorderRadius = 8;
            this.txtMaBaoMat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaBaoMat.DefaultText = "";
            this.txtMaBaoMat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaBaoMat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaBaoMat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaBaoMat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaBaoMat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaBaoMat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaBaoMat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaBaoMat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaBaoMat.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtMaBaoMat.Location = new System.Drawing.Point(35, 255);
            this.txtMaBaoMat.Name = "txtMaBaoMat";
            this.txtMaBaoMat.PasswordChar = '●';
            this.txtMaBaoMat.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaBaoMat.PlaceholderText = "Mã bảo mật";
            this.txtMaBaoMat.SelectedText = "";
            this.txtMaBaoMat.Size = new System.Drawing.Size(333, 43);
            this.txtMaBaoMat.TabIndex = 19;
            this.txtMaBaoMat.UseSystemPasswordChar = true;
            this.txtMaBaoMat.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.BorderRadius = 8;
            this.txtNhapLaiMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiMK.DefaultText = "";
            this.txtNhapLaiMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapLaiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapLaiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiMK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNhapLaiMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhapLaiMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiMK.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtNhapLaiMK.Location = new System.Drawing.Point(35, 198);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.PasswordChar = '●';
            this.txtNhapLaiMK.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNhapLaiMK.PlaceholderText = "Nhập lại mật khẩu";
            this.txtNhapLaiMK.SelectedText = "";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(333, 43);
            this.txtNhapLaiMK.TabIndex = 18;
            this.txtNhapLaiMK.UseSystemPasswordChar = true;
            this.txtNhapLaiMK.Click += new System.EventHandler(this.txt_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(134, 395);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(138, 23);
            this.lblLogin.TabIndex = 17;
            this.lblLogin.Text = "Đăng nhập ngay";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 46);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quên mật khẩu";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 20;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(35, 328);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(325, 55);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMK_Moi
            // 
            this.txtMK_Moi.BorderRadius = 8;
            this.txtMK_Moi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMK_Moi.DefaultText = "";
            this.txtMK_Moi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMK_Moi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMK_Moi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK_Moi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMK_Moi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMK_Moi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK_Moi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMK_Moi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMK_Moi.IconLeft = global::GUI.Properties.Resources.key_s;
            this.txtMK_Moi.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtMK_Moi.Location = new System.Drawing.Point(36, 138);
            this.txtMK_Moi.Name = "txtMK_Moi";
            this.txtMK_Moi.PasswordChar = '●';
            this.txtMK_Moi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMK_Moi.PlaceholderText = "Mật khẩu mới";
            this.txtMK_Moi.SelectedText = "";
            this.txtMK_Moi.Size = new System.Drawing.Size(333, 43);
            this.txtMK_Moi.TabIndex = 10;
            this.txtMK_Moi.UseSystemPasswordChar = true;
            this.txtMK_Moi.IconRightClick += new System.EventHandler(this.txtMK_Moi_IconRightClick);
            this.txtMK_Moi.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtTK_Quen
            // 
            this.txtTK_Quen.BorderRadius = 8;
            this.txtTK_Quen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTK_Quen.DefaultText = "";
            this.txtTK_Quen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTK_Quen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTK_Quen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK_Quen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK_Quen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTK_Quen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK_Quen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTK_Quen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK_Quen.IconLeft = global::GUI.Properties.Resources.user_s;
            this.txtTK_Quen.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtTK_Quen.IconRightSize = new System.Drawing.Size(15, 15);
            this.txtTK_Quen.Location = new System.Drawing.Point(36, 77);
            this.txtTK_Quen.Name = "txtTK_Quen";
            this.txtTK_Quen.PasswordChar = '\0';
            this.txtTK_Quen.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTK_Quen.PlaceholderText = "Tài khoản";
            this.txtTK_Quen.SelectedText = "";
            this.txtTK_Quen.Size = new System.Drawing.Size(333, 43);
            this.txtTK_Quen.TabIndex = 9;
            this.txtTK_Quen.Click += new System.EventHandler(this.txt_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(927, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 29);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 25;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(888, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(33, 29);
            this.guna2ControlBox2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GUI.Properties.Resources.banner_login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // messDialog
            // 
            this.messDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messDialog.Caption = "Thông báo";
            this.messDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.messDialog.Parent = this;
            this.messDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messDialog.Text = "Đăng nhập thành công";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 520);
            this.Controls.Add(this.pnQuenMK);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pnDangNhap);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(990, 567);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnDangNhap.ResumeLayout(false);
            this.pnDangNhap.PerformLayout();
            this.pnQuenMK.ResumeLayout(false);
            this.pnQuenMK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtMK;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Panel pnDangNhap;
        private System.Windows.Forms.Label lblQuenMK;
        private Guna.UI2.WinForms.Guna2Panel pnQuenMK;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton btnXacNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtMK_Moi;
        private Guna.UI2.WinForms.Guna2TextBox txtTK_Quen;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Label lblLogin;
        private Guna.UI2.WinForms.Guna2MessageDialog messDialog;
        private Guna.UI2.WinForms.Guna2TextBox txtMaBaoMat;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiMK;
    }
}