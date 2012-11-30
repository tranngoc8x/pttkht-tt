namespace QLD
{
    partial class mainform
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
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.control = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsuser = new System.Windows.Forms.ToolStripMenuItem();
            this.themuser = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnhocsinh = new System.Windows.Forms.ToolStripMenuItem();
            this.themhs = new System.Windows.Forms.ToolStripMenuItem();
            this.danhsachhs = new System.Windows.Forms.ToolStripMenuItem();
            this.mndaotao = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNămHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themnh = new System.Windows.Forms.ToolStripMenuItem();
            this.danhsachnh = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhsachlop = new System.Windows.Forms.ToolStripMenuItem();
            this.themlop = new System.Windows.Forms.ToolStripMenuItem();
            this.mndsmonhoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mndiem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapdiem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemdiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnbaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.fbaocaohocsinh = new System.Windows.Forms.ToolStripMenuItem();
            this.fbaocaodiem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.panellogin = new DevComponents.DotNetBar.ItemPanel();
            this.exitapp = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.mainmenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panellogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.control,
            this.mnhocsinh,
            this.mndaotao,
            this.mndiem,
            this.mnbaocao});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(720, 24);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "menuStrip1";
            // 
            // control
            // 
            this.control.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.logout,
            this.help,
            this.quit});
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(63, 20);
            this.control.Text = "Hệ thống";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsuser,
            this.themuser});
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // dsuser
            // 
            this.dsuser.Name = "dsuser";
            this.dsuser.Size = new System.Drawing.Size(181, 22);
            this.dsuser.Text = "Danh sách người dùng";
            // 
            // themuser
            // 
            this.themuser.Name = "themuser";
            this.themuser.Size = new System.Drawing.Size(181, 22);
            this.themuser.Text = "Thêm mới người dùng";
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(166, 22);
            this.logout.Text = "Đăng xuất";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(166, 22);
            this.help.Text = "Trợ giúp";
            // 
            // quit
            // 
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(166, 22);
            this.quit.Text = "Thoát chương trình";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // mnhocsinh
            // 
            this.mnhocsinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themhs,
            this.danhsachhs});
            this.mnhocsinh.Name = "mnhocsinh";
            this.mnhocsinh.Size = new System.Drawing.Size(98, 20);
            this.mnhocsinh.Text = "Quản lý học sinh";
            // 
            // themhs
            // 
            this.themhs.Name = "themhs";
            this.themhs.Size = new System.Drawing.Size(166, 22);
            this.themhs.Text = "Thêm học sinh";
            this.themhs.Click += new System.EventHandler(this.themhs_Click);
            // 
            // danhsachhs
            // 
            this.danhsachhs.Name = "danhsachhs";
            this.danhsachhs.Size = new System.Drawing.Size(166, 22);
            this.danhsachhs.Text = "Danh sách học sinh";
            this.danhsachhs.Click += new System.EventHandler(this.danhsachhs_Click);
            // 
            // mndaotao
            // 
            this.mndaotao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNămHọcToolStripMenuItem,
            this.quảnLýLớpToolStripMenuItem,
            this.mndsmonhoc});
            this.mndaotao.Name = "mndaotao";
            this.mndaotao.Size = new System.Drawing.Size(96, 20);
            this.mndaotao.Text = "Quản lý đào tạo";
            // 
            // quảnLýNămHọcToolStripMenuItem
            // 
            this.quảnLýNămHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themnh,
            this.danhsachnh});
            this.quảnLýNămHọcToolStripMenuItem.Name = "quảnLýNămHọcToolStripMenuItem";
            this.quảnLýNămHọcToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quảnLýNămHọcToolStripMenuItem.Text = "Quản lý năm học";
            // 
            // themnh
            // 
            this.themnh.Name = "themnh";
            this.themnh.Size = new System.Drawing.Size(167, 22);
            this.themnh.Text = "Thêm mới năm học";
            // 
            // danhsachnh
            // 
            this.danhsachnh.Name = "danhsachnh";
            this.danhsachnh.Size = new System.Drawing.Size(167, 22);
            this.danhsachnh.Text = "Danh sách năm học";
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            this.quảnLýLớpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhsachlop,
            this.themlop});
            this.quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            this.quảnLýLớpToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quảnLýLớpToolStripMenuItem.Text = "Quản lý lớp";
            // 
            // danhsachlop
            // 
            this.danhsachlop.Name = "danhsachlop";
            this.danhsachlop.Size = new System.Drawing.Size(141, 22);
            this.danhsachlop.Text = "Danh sách lớp";
            // 
            // themlop
            // 
            this.themlop.Name = "themlop";
            this.themlop.Size = new System.Drawing.Size(141, 22);
            this.themlop.Text = "Thêm mới lớp";
            // 
            // mndsmonhoc
            // 
            this.mndsmonhoc.Name = "mndsmonhoc";
            this.mndsmonhoc.Size = new System.Drawing.Size(167, 22);
            this.mndsmonhoc.Text = "Danh sách môn học";
            // 
            // mndiem
            // 
            this.mndiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapdiem,
            this.xemdiem});
            this.mndiem.Name = "mndiem";
            this.mndiem.Size = new System.Drawing.Size(81, 20);
            this.mndiem.Text = "Quản lý điểm";
            // 
            // nhapdiem
            // 
            this.nhapdiem.Name = "nhapdiem";
            this.nhapdiem.Size = new System.Drawing.Size(124, 22);
            this.nhapdiem.Text = "Nhập điểm";
            this.nhapdiem.Click += new System.EventHandler(this.nhapdiem_Click);
            // 
            // xemdiem
            // 
            this.xemdiem.Name = "xemdiem";
            this.xemdiem.Size = new System.Drawing.Size(124, 22);
            this.xemdiem.Text = "Xem điểm";
            // 
            // mnbaocao
            // 
            this.mnbaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fbaocaohocsinh,
            this.fbaocaodiem});
            this.mnbaocao.Name = "mnbaocao";
            this.mnbaocao.Size = new System.Drawing.Size(102, 20);
            this.mnbaocao.Text = "Báo cáo thống kê";
            // 
            // fbaocaohocsinh
            // 
            this.fbaocaohocsinh.Name = "fbaocaohocsinh";
            this.fbaocaohocsinh.Size = new System.Drawing.Size(208, 22);
            this.fbaocaohocsinh.Text = "Danh sách học sinh theo lớp";
            this.fbaocaohocsinh.Click += new System.EventHandler(this.fdshs_Click);
            // 
            // fbaocaodiem
            // 
            this.fbaocaodiem.Name = "fbaocaodiem";
            this.fbaocaodiem.Size = new System.Drawing.Size(208, 22);
            this.fbaocaodiem.Text = "Bảng điểm tổng kết học sinh";
            this.fbaocaodiem.Click += new System.EventHandler(this.fbangdiemhs_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.White;
            this.panellogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            // 
            // 
            // 
            this.panellogin.BackgroundStyle.Class = "ItemPanel";
            this.panellogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panellogin.ContainerControlProcessDialogKey = true;
            this.panellogin.Controls.Add(this.exitapp);
            this.panellogin.Controls.Add(this.labelX4);
            this.panellogin.Controls.Add(this.pass);
            this.panellogin.Controls.Add(this.user);
            this.panellogin.Controls.Add(this.buttonX1);
            this.panellogin.Controls.Add(this.labelX3);
            this.panellogin.Controls.Add(this.labelX2);
            this.panellogin.Controls.Add(this.labelX1);
            this.panellogin.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.panellogin.Location = new System.Drawing.Point(148, 130);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(436, 265);
            this.panellogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.panellogin.TabIndex = 3;
            this.panellogin.Text = "itemPanel1";
            // 
            // exitapp
            // 
            this.exitapp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.exitapp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.exitapp.Location = new System.Drawing.Point(324, 182);
            this.exitapp.Name = "exitapp";
            this.exitapp.Size = new System.Drawing.Size(75, 34);
            this.exitapp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.exitapp.Symbol = "";
            this.exitapp.TabIndex = 4;
            this.exitapp.Text = "Thoát";
            this.exitapp.Click += new System.EventHandler(this.exitapp_Click);
            // 
            // labelX4
            // 
            this.labelX4.BackgroundImage = global::QLD.Properties.Resources.Power_Button;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(3, 78);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(128, 128);
            this.labelX4.TabIndex = 8;
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(232, 142);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(170, 29);
            this.pass.TabIndex = 2;
            this.pass.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.user.BackColor = System.Drawing.Color.White;
            this.user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(232, 97);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(169, 29);
            this.user.TabIndex = 1;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(232, 182);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(86, 34);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Đăng nhập";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.labelX3.Location = new System.Drawing.Point(133, 144);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(74, 20);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Mật khẩu";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.labelX2.Location = new System.Drawing.Point(130, 102);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 20);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Tên đăng nhập";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.labelX1.Location = new System.Drawing.Point(36, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(365, 60);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLD.Properties.Resources.THEME_109_HD_Background21;
            this.ClientSize = new System.Drawing.Size(720, 502);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainmenu);
            this.MainMenuStrip = this.mainmenu;
            this.Name = "mainform";
            this.Text = "HỆ THỐNG QUẢN LÝ ĐIỂM";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem mnhocsinh;
        private System.Windows.Forms.ToolStripMenuItem themhs;
        private System.Windows.Forms.ToolStripMenuItem danhsachhs;
        private System.Windows.Forms.ToolStripMenuItem mndaotao;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNămHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themnh;
        private System.Windows.Forms.ToolStripMenuItem danhsachnh;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhsachlop;
        private System.Windows.Forms.ToolStripMenuItem themlop;
        private System.Windows.Forms.ToolStripMenuItem mndiem;
        private System.Windows.Forms.ToolStripMenuItem nhapdiem;
        private System.Windows.Forms.ToolStripMenuItem xemdiem;
        private System.Windows.Forms.ToolStripMenuItem mnbaocao;
        private System.Windows.Forms.ToolStripMenuItem fbaocaohocsinh;
        private System.Windows.Forms.ToolStripMenuItem fbaocaodiem;
        private System.Windows.Forms.ToolStripMenuItem control;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsuser;
        private System.Windows.Forms.ToolStripMenuItem themuser;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem quit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private DevComponents.DotNetBar.ItemPanel panellogin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private DevComponents.DotNetBar.ButtonX exitapp;
        private System.Windows.Forms.ToolStripMenuItem mndsmonhoc;
    }
}

