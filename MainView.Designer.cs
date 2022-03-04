
namespace CinemaNHK
{
    partial class MainView
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
            this.fdfContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLogin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceRegister = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceChangepass = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceInfo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDichVu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDashBoard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceNV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acePhim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceSuatChieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceVe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acePhongChieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.bsiName = new DevExpress.XtraBars.BarStaticItem();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // fdfContainer
            // 
            this.fdfContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fdfContainer.Location = new System.Drawing.Point(242, 39);
            this.fdfContainer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.fdfContainer.Name = "fdfContainer";
            this.fdfContainer.Size = new System.Drawing.Size(808, 491);
            this.fdfContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceHome,
            this.aceAccount,
            this.aceDichVu,
            this.aceDashBoard});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(242, 491);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceHome
            // 
            this.aceHome.ImageOptions.Image = global::CinemaNHK.Properties.Resources.icons8_home_40;
            this.aceHome.Name = "aceHome";
            this.aceHome.Text = "Trang chủ";
            this.aceHome.Click += new System.EventHandler(this.aceHome_Click);
            // 
            // aceAccount
            // 
            this.aceAccount.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceLogin,
            this.aceRegister,
            this.aceChangepass,
            this.aceInfo});
            this.aceAccount.ImageOptions.Image = global::CinemaNHK.Properties.Resources.icons8_user_account_40;
            this.aceAccount.Name = "aceAccount";
            this.aceAccount.Text = "Tài khoản";
            // 
            // aceLogin
            // 
            this.aceLogin.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.aceLogin.Appearance.Normal.Options.UseFont = true;
            this.aceLogin.Name = "aceLogin";
            this.aceLogin.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLogin.Text = "Đăng nhập";
            this.aceLogin.Click += new System.EventHandler(this.aceLogin_Click);
            // 
            // aceRegister
            // 
            this.aceRegister.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.aceRegister.Appearance.Normal.Options.UseFont = true;
            this.aceRegister.Name = "aceRegister";
            this.aceRegister.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceRegister.Text = "Đăng ký";
            this.aceRegister.Click += new System.EventHandler(this.aceRegister_Click);
            // 
            // aceChangepass
            // 
            this.aceChangepass.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.aceChangepass.Appearance.Normal.Options.UseFont = true;
            this.aceChangepass.Name = "aceChangepass";
            this.aceChangepass.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceChangepass.Text = "Đổi mật khẩu";
            this.aceChangepass.Click += new System.EventHandler(this.aceChangepass_Click);
            // 
            // aceInfo
            // 
            this.aceInfo.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.aceInfo.Appearance.Normal.Options.UseFont = true;
            this.aceInfo.Name = "aceInfo";
            this.aceInfo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceInfo.Text = "Thông tin";
            this.aceInfo.Click += new System.EventHandler(this.aceInfo_Click);
            // 
            // aceDichVu
            // 
            this.aceDichVu.ImageOptions.Image = global::CinemaNHK.Properties.Resources.icons8_ticket_40;
            this.aceDichVu.Name = "aceDichVu";
            this.aceDichVu.Text = "Dịch vụ";
            this.aceDichVu.Click += new System.EventHandler(this.aceDichVu_Click);
            // 
            // aceDashBoard
            // 
            this.aceDashBoard.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceNV,
            this.acePhim,
            this.aceSuatChieu,
            this.aceVe,
            this.acePhongChieu});
            this.aceDashBoard.ImageOptions.Image = global::CinemaNHK.Properties.Resources.icons8_services_40;
            this.aceDashBoard.Name = "aceDashBoard";
            this.aceDashBoard.Text = "Dữ liệu";
            // 
            // aceNV
            // 
            this.aceNV.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.aceNV.Appearance.Normal.Options.UseFont = true;
            this.aceNV.Name = "aceNV";
            this.aceNV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceNV.Text = "Thêm nhân viên";
            this.aceNV.Click += new System.EventHandler(this.aceNV_Click);
            // 
            // acePhim
            // 
            this.acePhim.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.acePhim.Appearance.Normal.Options.UseFont = true;
            this.acePhim.Name = "acePhim";
            this.acePhim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePhim.Text = "Thêm phim";
            this.acePhim.Click += new System.EventHandler(this.acePhim_Click);
            // 
            // aceSuatChieu
            // 
            this.aceSuatChieu.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.aceSuatChieu.Appearance.Normal.Options.UseFont = true;
            this.aceSuatChieu.Name = "aceSuatChieu";
            this.aceSuatChieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceSuatChieu.Text = "Thêm suất chiếu";
            this.aceSuatChieu.Click += new System.EventHandler(this.aceSuatChieu_Click);
            // 
            // aceVe
            // 
            this.aceVe.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.aceVe.Appearance.Normal.Options.UseFont = true;
            this.aceVe.Name = "aceVe";
            this.aceVe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceVe.Text = "Vé đã mua";
            this.aceVe.Click += new System.EventHandler(this.aceVe_Click);
            // 
            // acePhongChieu
            // 
            this.acePhongChieu.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.acePhongChieu.Appearance.Normal.Options.UseFont = true;
            this.acePhongChieu.Name = "acePhongChieu";
            this.acePhongChieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePhongChieu.Text = "Thêm Phòng Chiếu";
            this.acePhongChieu.Click += new System.EventHandler(this.acePhongChieu_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiName});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1050, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.bsiName);
            // 
            // bsiName
            // 
            this.bsiName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiName.Id = 0;
            this.bsiName.Name = "bsiName";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(CinemaNHK.MainViewModel);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 530);
            this.ControlContainer = this.fdfContainer;
            this.Controls.Add(this.fdfContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::CinemaNHK.Properties.Resources.LOGONHK;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainView";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fdfContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHome;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceAccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLogin;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDichVu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceChangepass;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceInfo;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarStaticItem bsiName;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceRegister;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDashBoard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceNV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePhim;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceVe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSuatChieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePhongChieu;
    }
}

