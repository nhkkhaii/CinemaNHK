
namespace CinemaNHK
{
    partial class DangKy
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
            this.txbConfirm = new System.Windows.Forms.TextBox();
            this.txbMK = new System.Windows.Forms.TextBox();
            this.txbTK = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.DangKylayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txbConfirmitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbMKitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbTKitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnConfirmitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.DangKylayoutControl1ConvertedLayout)).BeginInit();
            this.DangKylayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbConfirmitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMKitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTKitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirmitem)).BeginInit();
            this.SuspendLayout();
            // 
            // txbConfirm
            // 
            this.txbConfirm.Location = new System.Drawing.Point(12, 130);
            this.txbConfirm.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txbConfirm.Name = "txbConfirm";
            this.txbConfirm.PasswordChar = '*';
            this.txbConfirm.Size = new System.Drawing.Size(277, 25);
            this.txbConfirm.TabIndex = 18;
            // 
            // txbMK
            // 
            this.txbMK.Location = new System.Drawing.Point(12, 81);
            this.txbMK.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txbMK.Name = "txbMK";
            this.txbMK.PasswordChar = '*';
            this.txbMK.Size = new System.Drawing.Size(277, 25);
            this.txbMK.TabIndex = 16;
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(12, 32);
            this.txbTK.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txbTK.Name = "txbTK";
            this.txbTK.Size = new System.Drawing.Size(277, 25);
            this.txbTK.TabIndex = 14;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 159);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(277, 40);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Đăng ký";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // DangKylayoutControl1ConvertedLayout
            // 
            this.DangKylayoutControl1ConvertedLayout.Controls.Add(this.txbConfirm);
            this.DangKylayoutControl1ConvertedLayout.Controls.Add(this.txbMK);
            this.DangKylayoutControl1ConvertedLayout.Controls.Add(this.txbTK);
            this.DangKylayoutControl1ConvertedLayout.Controls.Add(this.btnConfirm);
            this.DangKylayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DangKylayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.DangKylayoutControl1ConvertedLayout.Name = "DangKylayoutControl1ConvertedLayout";
            this.DangKylayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.DangKylayoutControl1ConvertedLayout.Size = new System.Drawing.Size(301, 211);
            this.DangKylayoutControl1ConvertedLayout.TabIndex = 21;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txbConfirmitem,
            this.txbMKitem,
            this.txbTKitem,
            this.btnConfirmitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(301, 211);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txbConfirmitem
            // 
            this.txbConfirmitem.Control = this.txbConfirm;
            this.txbConfirmitem.Location = new System.Drawing.Point(0, 98);
            this.txbConfirmitem.Name = "txbConfirmitem";
            this.txbConfirmitem.Size = new System.Drawing.Size(281, 49);
            this.txbConfirmitem.Text = "Lặp lại mật khẩu";
            this.txbConfirmitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbConfirmitem.TextSize = new System.Drawing.Size(99, 17);
            // 
            // txbMKitem
            // 
            this.txbMKitem.Control = this.txbMK;
            this.txbMKitem.Location = new System.Drawing.Point(0, 49);
            this.txbMKitem.Name = "txbMKitem";
            this.txbMKitem.Size = new System.Drawing.Size(281, 49);
            this.txbMKitem.Text = "Mật khẩu";
            this.txbMKitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbMKitem.TextSize = new System.Drawing.Size(99, 17);
            // 
            // txbTKitem
            // 
            this.txbTKitem.Control = this.txbTK;
            this.txbTKitem.Location = new System.Drawing.Point(0, 0);
            this.txbTKitem.Name = "txbTKitem";
            this.txbTKitem.Size = new System.Drawing.Size(281, 49);
            this.txbTKitem.Text = "Tên tài khoản";
            this.txbTKitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbTKitem.TextSize = new System.Drawing.Size(99, 17);
            // 
            // btnConfirmitem
            // 
            this.btnConfirmitem.Control = this.btnConfirm;
            this.btnConfirmitem.Location = new System.Drawing.Point(0, 147);
            this.btnConfirmitem.Name = "btnConfirmitem";
            this.btnConfirmitem.Size = new System.Drawing.Size(281, 44);
            this.btnConfirmitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnConfirmitem.TextVisible = false;
            // 
            // DangKy
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 211);
            this.Controls.Add(this.DangKylayoutControl1ConvertedLayout);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IconOptions.Image = global::CinemaNHK.Properties.Resources.LOGONHK;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangKy";
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.DangKylayoutControl1ConvertedLayout)).EndInit();
            this.DangKylayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbConfirmitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMKitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTKitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirmitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbConfirm;
        private System.Windows.Forms.TextBox txbMK;
        private System.Windows.Forms.TextBox txbTK;
        private System.Windows.Forms.Button btnConfirm;
        private DevExpress.XtraLayout.LayoutControl DangKylayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem txbConfirmitem;
        private DevExpress.XtraLayout.LayoutControlItem txbMKitem;
        private DevExpress.XtraLayout.LayoutControlItem txbTKitem;
        private DevExpress.XtraLayout.LayoutControlItem btnConfirmitem;
    }
}