
namespace CinemaNHK
{
    partial class UcSuatChieu
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
            this.components = new System.ComponentModel.Container();
            this.txbSuatChieuId = new System.Windows.Forms.TextBox();
            this.cbxPhim = new System.Windows.Forms.ComboBox();
            this.pHIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new CinemaNHK.CinemaDataSet();
            this.cbxGioChieu = new System.Windows.Forms.ComboBox();
            this.pHIMTableAdapter = new CinemaNHK.CinemaDataSetTableAdapters.PHIMTableAdapter();
            this.btnThemSuat = new System.Windows.Forms.Button();
            this.UcSuatChieulayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.picPhim = new System.Windows.Forms.PictureBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cbxGioChieuitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbxPhimitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbSuatChieuIditem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnThemSuatitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.picPhimitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pHIMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcSuatChieulayoutControl1ConvertedLayout)).BeginInit();
            this.UcSuatChieulayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGioChieuitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPhimitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSuatChieuIditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSuatitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhimitem)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSuatChieuId
            // 
            this.txbSuatChieuId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSuatChieuId.Location = new System.Drawing.Point(498, 32);
            this.txbSuatChieuId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSuatChieuId.Name = "txbSuatChieuId";
            this.txbSuatChieuId.Size = new System.Drawing.Size(281, 25);
            this.txbSuatChieuId.TabIndex = 1;
            // 
            // cbxPhim
            // 
            this.cbxPhim.DataSource = this.pHIMBindingSource;
            this.cbxPhim.DisplayMember = "TENPHIM";
            this.cbxPhim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhim.FormattingEnabled = true;
            this.cbxPhim.Location = new System.Drawing.Point(498, 80);
            this.cbxPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPhim.Name = "cbxPhim";
            this.cbxPhim.Size = new System.Drawing.Size(281, 27);
            this.cbxPhim.TabIndex = 7;
            this.cbxPhim.ValueMember = "PHIMID";
            this.cbxPhim.SelectedIndexChanged += new System.EventHandler(this.cbxPhim_SelectedIndexChanged);
            // 
            // pHIMBindingSource
            // 
            this.pHIMBindingSource.DataMember = "PHIM";
            this.pHIMBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxGioChieu
            // 
            this.cbxGioChieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGioChieu.FormattingEnabled = true;
            this.cbxGioChieu.Items.AddRange(new object[] {
            "09:30",
            "12:30",
            "15:30",
            "18:30",
            "20:30",
            "22:00"});
            this.cbxGioChieu.Location = new System.Drawing.Point(498, 130);
            this.cbxGioChieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxGioChieu.Name = "cbxGioChieu";
            this.cbxGioChieu.Size = new System.Drawing.Size(281, 27);
            this.cbxGioChieu.TabIndex = 8;
            // 
            // pHIMTableAdapter
            // 
            this.pHIMTableAdapter.ClearBeforeFill = true;
            // 
            // btnThemSuat
            // 
            this.btnThemSuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSuat.Location = new System.Drawing.Point(12, 383);
            this.btnThemSuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemSuat.Name = "btnThemSuat";
            this.btnThemSuat.Size = new System.Drawing.Size(482, 43);
            this.btnThemSuat.TabIndex = 9;
            this.btnThemSuat.Text = "Thêm suất chiếu";
            this.btnThemSuat.UseVisualStyleBackColor = true;
            this.btnThemSuat.Click += new System.EventHandler(this.btnThemSuat_Click);
            // 
            // UcSuatChieulayoutControl1ConvertedLayout
            // 
            this.UcSuatChieulayoutControl1ConvertedLayout.Controls.Add(this.cbxGioChieu);
            this.UcSuatChieulayoutControl1ConvertedLayout.Controls.Add(this.cbxPhim);
            this.UcSuatChieulayoutControl1ConvertedLayout.Controls.Add(this.txbSuatChieuId);
            this.UcSuatChieulayoutControl1ConvertedLayout.Controls.Add(this.btnThemSuat);
            this.UcSuatChieulayoutControl1ConvertedLayout.Controls.Add(this.picPhim);
            this.UcSuatChieulayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcSuatChieulayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.UcSuatChieulayoutControl1ConvertedLayout.Name = "UcSuatChieulayoutControl1ConvertedLayout";
            this.UcSuatChieulayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.UcSuatChieulayoutControl1ConvertedLayout.Size = new System.Drawing.Size(791, 438);
            this.UcSuatChieulayoutControl1ConvertedLayout.TabIndex = 10;
            // 
            // picPhim
            // 
            this.picPhim.Location = new System.Drawing.Point(12, 12);
            this.picPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPhim.Name = "picPhim";
            this.picPhim.Size = new System.Drawing.Size(482, 367);
            this.picPhim.TabIndex = 0;
            this.picPhim.TabStop = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cbxGioChieuitem,
            this.cbxPhimitem,
            this.txbSuatChieuIditem,
            this.picPhimitem,
            this.btnThemSuatitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(791, 438);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // cbxGioChieuitem
            // 
            this.cbxGioChieuitem.Control = this.cbxGioChieu;
            this.cbxGioChieuitem.Location = new System.Drawing.Point(486, 98);
            this.cbxGioChieuitem.Name = "cbxGioChieuitem";
            this.cbxGioChieuitem.Size = new System.Drawing.Size(285, 320);
            this.cbxGioChieuitem.Text = "Giờ Chiếu";
            this.cbxGioChieuitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.cbxGioChieuitem.TextSize = new System.Drawing.Size(82, 17);
            // 
            // cbxPhimitem
            // 
            this.cbxPhimitem.Control = this.cbxPhim;
            this.cbxPhimitem.Location = new System.Drawing.Point(486, 49);
            this.cbxPhimitem.Name = "cbxPhimitem";
            this.cbxPhimitem.Size = new System.Drawing.Size(285, 49);
            this.cbxPhimitem.Text = "Phim";
            this.cbxPhimitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.cbxPhimitem.TextSize = new System.Drawing.Size(82, 16);
            // 
            // txbSuatChieuIditem
            // 
            this.txbSuatChieuIditem.Control = this.txbSuatChieuId;
            this.txbSuatChieuIditem.Location = new System.Drawing.Point(486, 0);
            this.txbSuatChieuIditem.Name = "txbSuatChieuIditem";
            this.txbSuatChieuIditem.Size = new System.Drawing.Size(285, 49);
            this.txbSuatChieuIditem.Text = "Suất chiếu ID";
            this.txbSuatChieuIditem.TextLocation = DevExpress.Utils.Locations.Top;
            this.txbSuatChieuIditem.TextSize = new System.Drawing.Size(82, 17);
            // 
            // btnThemSuatitem
            // 
            this.btnThemSuatitem.Control = this.btnThemSuat;
            this.btnThemSuatitem.Location = new System.Drawing.Point(0, 371);
            this.btnThemSuatitem.Name = "btnThemSuatitem";
            this.btnThemSuatitem.Size = new System.Drawing.Size(486, 47);
            this.btnThemSuatitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnThemSuatitem.TextVisible = false;
            // 
            // picPhimitem
            // 
            this.picPhimitem.Control = this.picPhim;
            this.picPhimitem.Location = new System.Drawing.Point(0, 0);
            this.picPhimitem.Name = "picPhimitem";
            this.picPhimitem.Size = new System.Drawing.Size(486, 371);
            this.picPhimitem.TextSize = new System.Drawing.Size(0, 0);
            this.picPhimitem.TextVisible = false;
            // 
            // UcSuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UcSuatChieulayoutControl1ConvertedLayout);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcSuatChieu";
            this.Size = new System.Drawing.Size(791, 438);
            this.Load += new System.EventHandler(this.UcSuatChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHIMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcSuatChieulayoutControl1ConvertedLayout)).EndInit();
            this.UcSuatChieulayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGioChieuitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPhimitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSuatChieuIditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemSuatitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhimitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhim;
        private System.Windows.Forms.TextBox txbSuatChieuId;
        private System.Windows.Forms.ComboBox cbxPhim;
        private System.Windows.Forms.BindingSource pHIMBindingSource;
        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.ComboBox cbxGioChieu;
        private CinemaDataSetTableAdapters.PHIMTableAdapter pHIMTableAdapter;
        private System.Windows.Forms.Button btnThemSuat;
        private DevExpress.XtraLayout.LayoutControl UcSuatChieulayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem cbxGioChieuitem;
        private DevExpress.XtraLayout.LayoutControlItem cbxPhimitem;
        private DevExpress.XtraLayout.LayoutControlItem txbSuatChieuIditem;
        private DevExpress.XtraLayout.LayoutControlItem btnThemSuatitem;
        private DevExpress.XtraLayout.LayoutControlItem picPhimitem;
    }
}
