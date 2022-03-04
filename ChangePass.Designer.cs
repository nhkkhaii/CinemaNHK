
namespace CinemaNHK
{
    partial class ChangePass
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
            this.btnChangepass = new System.Windows.Forms.Button();
            this.txbMKC = new System.Windows.Forms.TextBox();
            this.txbMKM = new System.Windows.Forms.TextBox();
            this.txbConfirm = new System.Windows.Forms.TextBox();
            this.ChangePasslayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txbConfirmitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbMKMitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbMKCitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnChangepassitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePasslayoutControl1ConvertedLayout)).BeginInit();
            this.ChangePasslayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbConfirmitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMKMitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMKCitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangepassitem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangepass
            // 
            this.btnChangepass.Location = new System.Drawing.Point(12, 159);
            this.btnChangepass.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangepass.Name = "btnChangepass";
            this.btnChangepass.Size = new System.Drawing.Size(320, 36);
            this.btnChangepass.TabIndex = 9;
            this.btnChangepass.Text = "Đổi mật khẩu";
            this.btnChangepass.UseVisualStyleBackColor = true;
            this.btnChangepass.Click += new System.EventHandler(this.btnChangepass_Click);
            // 
            // txbMKC
            // 
            this.txbMKC.Location = new System.Drawing.Point(12, 32);
            this.txbMKC.Margin = new System.Windows.Forms.Padding(5);
            this.txbMKC.Name = "txbMKC";
            this.txbMKC.PasswordChar = '*';
            this.txbMKC.Size = new System.Drawing.Size(320, 25);
            this.txbMKC.TabIndex = 7;
            // 
            // txbMKM
            // 
            this.txbMKM.Location = new System.Drawing.Point(12, 81);
            this.txbMKM.Margin = new System.Windows.Forms.Padding(5);
            this.txbMKM.Name = "txbMKM";
            this.txbMKM.PasswordChar = '*';
            this.txbMKM.Size = new System.Drawing.Size(320, 25);
            this.txbMKM.TabIndex = 10;
            // 
            // txbConfirm
            // 
            this.txbConfirm.Location = new System.Drawing.Point(12, 130);
            this.txbConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.txbConfirm.Name = "txbConfirm";
            this.txbConfirm.PasswordChar = '*';
            this.txbConfirm.Size = new System.Drawing.Size(320, 25);
            this.txbConfirm.TabIndex = 12;
            // 
            // ChangePasslayoutControl1ConvertedLayout
            // 
            this.ChangePasslayoutControl1ConvertedLayout.Controls.Add(this.txbConfirm);
            this.ChangePasslayoutControl1ConvertedLayout.Controls.Add(this.txbMKM);
            this.ChangePasslayoutControl1ConvertedLayout.Controls.Add(this.txbMKC);
            this.ChangePasslayoutControl1ConvertedLayout.Controls.Add(this.btnChangepass);
            this.ChangePasslayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangePasslayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ChangePasslayoutControl1ConvertedLayout.Name = "ChangePasslayoutControl1ConvertedLayout";
            this.ChangePasslayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.ChangePasslayoutControl1ConvertedLayout.Size = new System.Drawing.Size(344, 207);
            this.ChangePasslayoutControl1ConvertedLayout.TabIndex = 14;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txbConfirmitem,
            this.txbMKMitem,
            this.txbMKCitem,
            this.btnChangepassitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(344, 207);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txbConfirmitem
            // 
            this.txbConfirmitem.Control = this.txbConfirm;
            this.txbConfirmitem.Location = new System.Drawing.Point(0, 98);
            this.txbConfirmitem.Name = "txbConfirmitem";
            this.txbConfirmitem.Size = new System.Drawing.Size(324, 49);
            this.txbConfirmitem.Text = "Lặp lại mật khẩu";
            this.txbConfirmitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbConfirmitem.TextSize = new System.Drawing.Size(99, 17);
            // 
            // txbMKMitem
            // 
            this.txbMKMitem.Control = this.txbMKM;
            this.txbMKMitem.Location = new System.Drawing.Point(0, 49);
            this.txbMKMitem.Name = "txbMKMitem";
            this.txbMKMitem.Size = new System.Drawing.Size(324, 49);
            this.txbMKMitem.Text = "Mật khẩu mới";
            this.txbMKMitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbMKMitem.TextSize = new System.Drawing.Size(99, 17);
            // 
            // txbMKCitem
            // 
            this.txbMKCitem.Control = this.txbMKC;
            this.txbMKCitem.Location = new System.Drawing.Point(0, 0);
            this.txbMKCitem.Name = "txbMKCitem";
            this.txbMKCitem.Size = new System.Drawing.Size(324, 49);
            this.txbMKCitem.Text = "Mật khẩu cũ";
            this.txbMKCitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbMKCitem.TextSize = new System.Drawing.Size(99, 17);
            // 
            // btnChangepassitem
            // 
            this.btnChangepassitem.Control = this.btnChangepass;
            this.btnChangepassitem.Location = new System.Drawing.Point(0, 147);
            this.btnChangepassitem.Name = "btnChangepassitem";
            this.btnChangepassitem.Size = new System.Drawing.Size(324, 40);
            this.btnChangepassitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnChangepassitem.TextVisible = false;
            // 
            // ChangePass
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 207);
            this.Controls.Add(this.ChangePasslayoutControl1ConvertedLayout);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.IconOptions.Image = global::CinemaNHK.Properties.Resources.LOGONHK;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePass";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.ChangePasslayoutControl1ConvertedLayout)).EndInit();
            this.ChangePasslayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbConfirmitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMKMitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMKCitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangepassitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangepass;
        private System.Windows.Forms.TextBox txbMKC;
        private System.Windows.Forms.TextBox txbMKM;
        private System.Windows.Forms.TextBox txbConfirm;
        private DevExpress.XtraLayout.LayoutControl ChangePasslayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem txbConfirmitem;
        private DevExpress.XtraLayout.LayoutControlItem txbMKMitem;
        private DevExpress.XtraLayout.LayoutControlItem txbMKCitem;
        private DevExpress.XtraLayout.LayoutControlItem btnChangepassitem;
    }
}