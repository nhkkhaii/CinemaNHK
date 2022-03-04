
namespace CinemaNHK
{
    partial class Login
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
            this.txbTK = new System.Windows.Forms.TextBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.txbMK = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LoginlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txbMKitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbTKitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnLoginitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblTKitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LoginlayoutControl1ConvertedLayout)).BeginInit();
            this.LoginlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMKitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTKitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTKitem)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(12, 60);
            this.txbTK.Margin = new System.Windows.Forms.Padding(4);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(273, 25);
            this.txbTK.TabIndex = 0;
            this.txbTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTK_KeyPress);
            // 
            // lblTK
            // 
            this.lblTK.Location = new System.Drawing.Point(12, 12);
            this.lblTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(273, 25);
            this.lblTK.TabIndex = 1;
            this.lblTK.Text = "Tên tài khoản";
            // 
            // txbMK
            // 
            this.txbMK.Location = new System.Drawing.Point(12, 109);
            this.txbMK.Margin = new System.Windows.Forms.Padding(4);
            this.txbMK.Name = "txbMK";
            this.txbMK.PasswordChar = '*';
            this.txbMK.Size = new System.Drawing.Size(273, 25);
            this.txbMK.TabIndex = 2;
            this.txbMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMK_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 138);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(273, 48);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginlayoutControl1ConvertedLayout
            // 
            this.LoginlayoutControl1ConvertedLayout.Controls.Add(this.txbMK);
            this.LoginlayoutControl1ConvertedLayout.Controls.Add(this.txbTK);
            this.LoginlayoutControl1ConvertedLayout.Controls.Add(this.btnLogin);
            this.LoginlayoutControl1ConvertedLayout.Controls.Add(this.lblTK);
            this.LoginlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.LoginlayoutControl1ConvertedLayout.Name = "LoginlayoutControl1ConvertedLayout";
            this.LoginlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.LoginlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(297, 198);
            this.LoginlayoutControl1ConvertedLayout.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txbMKitem,
            this.txbTKitem,
            this.btnLoginitem,
            this.lblTKitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(297, 198);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txbMKitem
            // 
            this.txbMKitem.Control = this.txbMK;
            this.txbMKitem.Location = new System.Drawing.Point(0, 77);
            this.txbMKitem.Name = "txbMKitem";
            this.txbMKitem.Size = new System.Drawing.Size(277, 49);
            this.txbMKitem.Text = "Mật khẩu";
            this.txbMKitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbMKitem.TextSize = new System.Drawing.Size(109, 17);
            // 
            // txbTKitem
            // 
            this.txbTKitem.Control = this.txbTK;
            this.txbTKitem.Location = new System.Drawing.Point(0, 29);
            this.txbTKitem.Name = "txbTKitem";
            this.txbTKitem.Size = new System.Drawing.Size(277, 48);
            this.txbTKitem.Text = "Login Your Account";
            this.txbTKitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbTKitem.TextSize = new System.Drawing.Size(109, 16);
            // 
            // btnLoginitem
            // 
            this.btnLoginitem.Control = this.btnLogin;
            this.btnLoginitem.Location = new System.Drawing.Point(0, 126);
            this.btnLoginitem.Name = "btnLoginitem";
            this.btnLoginitem.Size = new System.Drawing.Size(277, 52);
            this.btnLoginitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnLoginitem.TextVisible = false;
            // 
            // lblTKitem
            // 
            this.lblTKitem.Control = this.lblTK;
            this.lblTKitem.Location = new System.Drawing.Point(0, 0);
            this.lblTKitem.Name = "lblTKitem";
            this.lblTKitem.Size = new System.Drawing.Size(277, 29);
            this.lblTKitem.TextSize = new System.Drawing.Size(0, 0);
            this.lblTKitem.TextVisible = false;
            // 
            // Login
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 198);
            this.Controls.Add(this.LoginlayoutControl1ConvertedLayout);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = global::CinemaNHK.Properties.Resources.LOGONHK;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.LoginlayoutControl1ConvertedLayout)).EndInit();
            this.LoginlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMKitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTKitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTKitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbTK;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.TextBox txbMK;
        private System.Windows.Forms.Button btnLogin;
        private DevExpress.XtraLayout.LayoutControl LoginlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem txbMKitem;
        private DevExpress.XtraLayout.LayoutControlItem txbTKitem;
        private DevExpress.XtraLayout.LayoutControlItem btnLoginitem;
        private DevExpress.XtraLayout.LayoutControlItem lblTKitem;
    }
}