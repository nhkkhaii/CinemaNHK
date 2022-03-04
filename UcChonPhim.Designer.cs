
namespace CinemaNHK
{
    partial class UcChonPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcChonPhim));
            this.cbxTenPhim = new System.Windows.Forms.ComboBox();
            this.pHIMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new CinemaNHK.CinemaDataSet();
            this.cbxGioChieu = new System.Windows.Forms.ComboBox();
            this.sUATCHIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPhongChieu = new System.Windows.Forms.ComboBox();
            this.pHONGCHIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.PicPhim = new System.Windows.Forms.PictureBox();
            this.cbxRap = new System.Windows.Forms.ComboBox();
            this.rAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UcChonPhimlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cbxPhongChieuitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbxGioChieuitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbxTenPhimitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.PicPhimitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbxRapitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnXacNhanitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.pHIMTableAdapter = new CinemaNHK.CinemaDataSetTableAdapters.PHIMTableAdapter();
            this.rAPTableAdapter = new CinemaNHK.CinemaDataSetTableAdapters.RAPTableAdapter();
            this.pHONGCHIEUTableAdapter = new CinemaNHK.CinemaDataSetTableAdapters.PHONGCHIEUTableAdapter();
            this.sUATCHIEUTableAdapter = new CinemaNHK.CinemaDataSetTableAdapters.SUATCHIEUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pHIMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUATCHIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGCHIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcChonPhimlayoutControl1ConvertedLayout)).BeginInit();
            this.UcChonPhimlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPhongChieuitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGioChieuitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTenPhimitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhimitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRapitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhanitem)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTenPhim
            // 
            this.cbxTenPhim.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxTenPhim.DataSource = this.pHIMBindingSource;
            this.cbxTenPhim.DisplayMember = "TENPHIM";
            this.cbxTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenPhim.ForeColor = System.Drawing.Color.Black;
            this.cbxTenPhim.FormattingEnabled = true;
            this.cbxTenPhim.Location = new System.Drawing.Point(12, 36);
            this.cbxTenPhim.Name = "cbxTenPhim";
            this.cbxTenPhim.Size = new System.Drawing.Size(338, 28);
            this.cbxTenPhim.TabIndex = 1;
            this.cbxTenPhim.ValueMember = "PHIMID";
            this.cbxTenPhim.SelectedIndexChanged += new System.EventHandler(this.cbxTenPhim_SelectedIndexChanged);
            this.cbxTenPhim.TextChanged += new System.EventHandler(this.cbxTenPhim_TextChanged);
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
            this.cbxGioChieu.DataSource = this.sUATCHIEUBindingSource;
            this.cbxGioChieu.DisplayMember = "GIOCHIEU";
            this.cbxGioChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGioChieu.FormattingEnabled = true;
            this.cbxGioChieu.Location = new System.Drawing.Point(12, 251);
            this.cbxGioChieu.Name = "cbxGioChieu";
            this.cbxGioChieu.Size = new System.Drawing.Size(338, 28);
            this.cbxGioChieu.TabIndex = 3;
            this.cbxGioChieu.ValueMember = "SUATCHIEUID";
            this.cbxGioChieu.TextChanged += new System.EventHandler(this.cbxGioChieu_TextChanged);
            // 
            // sUATCHIEUBindingSource
            // 
            this.sUATCHIEUBindingSource.DataMember = "SUATCHIEU";
            this.sUATCHIEUBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cbxPhongChieu
            // 
            this.cbxPhongChieu.DataSource = this.pHONGCHIEUBindingSource;
            this.cbxPhongChieu.DisplayMember = "PHONGCHIEUID";
            this.cbxPhongChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhongChieu.FormattingEnabled = true;
            this.cbxPhongChieu.Location = new System.Drawing.Point(12, 90);
            this.cbxPhongChieu.Name = "cbxPhongChieu";
            this.cbxPhongChieu.Size = new System.Drawing.Size(338, 28);
            this.cbxPhongChieu.TabIndex = 4;
            this.cbxPhongChieu.ValueMember = "PHONGCHIEUID";
            this.cbxPhongChieu.SelectedIndexChanged += new System.EventHandler(this.cbxPhongChieu_SelectedIndexChanged);
            this.cbxPhongChieu.TextChanged += new System.EventHandler(this.cbxPhongChieu_TextChanged);
            // 
            // pHONGCHIEUBindingSource
            // 
            this.pHONGCHIEUBindingSource.DataMember = "PHONGCHIEU";
            this.pHONGCHIEUBindingSource.DataSource = this.cinemaDataSet;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Linen;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(354, 373);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(339, 42);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // PicPhim
            // 
            this.PicPhim.BackColor = System.Drawing.Color.Transparent;
            this.PicPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicPhim.Location = new System.Drawing.Point(354, 12);
            this.PicPhim.Name = "PicPhim";
            this.PicPhim.Size = new System.Drawing.Size(339, 357);
            this.PicPhim.TabIndex = 6;
            this.PicPhim.TabStop = false;
            // 
            // cbxRap
            // 
            this.cbxRap.DataSource = this.rAPBindingSource;
            this.cbxRap.DisplayMember = "TENRAP";
            this.cbxRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRap.FormattingEnabled = true;
            this.cbxRap.Location = new System.Drawing.Point(12, 144);
            this.cbxRap.Name = "cbxRap";
            this.cbxRap.Size = new System.Drawing.Size(338, 28);
            this.cbxRap.TabIndex = 10;
            this.cbxRap.ValueMember = "RAPID";
            this.cbxRap.TextChanged += new System.EventHandler(this.cbxRap_TextChanged);
            // 
            // rAPBindingSource
            // 
            this.rAPBindingSource.DataMember = "RAP";
            this.rAPBindingSource.DataSource = this.cinemaDataSet;
            // 
            // UcChonPhimlayoutControl1ConvertedLayout
            // 
            this.UcChonPhimlayoutControl1ConvertedLayout.Controls.Add(this.txbGia);
            this.UcChonPhimlayoutControl1ConvertedLayout.Controls.Add(this.cbxRap);
            this.UcChonPhimlayoutControl1ConvertedLayout.Controls.Add(this.cbxPhongChieu);
            this.UcChonPhimlayoutControl1ConvertedLayout.Controls.Add(this.cbxGioChieu);
            this.UcChonPhimlayoutControl1ConvertedLayout.Controls.Add(this.cbxTenPhim);
            this.UcChonPhimlayoutControl1ConvertedLayout.Controls.Add(this.PicPhim);
            this.UcChonPhimlayoutControl1ConvertedLayout.Controls.Add(this.btnXacNhan);
            this.UcChonPhimlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcChonPhimlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.UcChonPhimlayoutControl1ConvertedLayout.Name = "UcChonPhimlayoutControl1ConvertedLayout";
            this.UcChonPhimlayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 147, 812, 500);
            this.UcChonPhimlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.UcChonPhimlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(705, 427);
            this.UcChonPhimlayoutControl1ConvertedLayout.TabIndex = 12;
            // 
            // txbGia
            // 
            this.txbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGia.Location = new System.Drawing.Point(12, 198);
            this.txbGia.Name = "txbGia";
            this.txbGia.ReadOnly = true;
            this.txbGia.Size = new System.Drawing.Size(338, 25);
            this.txbGia.TabIndex = 11;
            this.txbGia.TextChanged += new System.EventHandler(this.txbGia_TextChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.BackgroundImageOptions.Image = global::CinemaNHK.Properties.Resources.Chonphim;
            this.layoutControlGroup1.BackgroundImageOptions.Visible = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cbxPhongChieuitem,
            this.cbxGioChieuitem,
            this.cbxTenPhimitem,
            this.PicPhimitem,
            this.cbxRapitem,
            this.layoutControlItem1,
            this.btnXacNhanitem});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(705, 427);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // cbxPhongChieuitem
            // 
            this.cbxPhongChieuitem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cbxPhongChieuitem.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.cbxPhongChieuitem.AppearanceItemCaption.Options.UseFont = true;
            this.cbxPhongChieuitem.AppearanceItemCaption.Options.UseForeColor = true;
            this.cbxPhongChieuitem.Control = this.cbxPhongChieu;
            this.cbxPhongChieuitem.Location = new System.Drawing.Point(0, 54);
            this.cbxPhongChieuitem.Name = "cbxPhongChieuitem";
            this.cbxPhongChieuitem.Size = new System.Drawing.Size(342, 54);
            this.cbxPhongChieuitem.Text = "Phòng Chiếu";
            this.cbxPhongChieuitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.cbxPhongChieuitem.TextSize = new System.Drawing.Size(108, 21);
            // 
            // cbxGioChieuitem
            // 
            this.cbxGioChieuitem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cbxGioChieuitem.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.cbxGioChieuitem.AppearanceItemCaption.Options.UseFont = true;
            this.cbxGioChieuitem.AppearanceItemCaption.Options.UseForeColor = true;
            this.cbxGioChieuitem.Control = this.cbxGioChieu;
            this.cbxGioChieuitem.Location = new System.Drawing.Point(0, 215);
            this.cbxGioChieuitem.Name = "cbxGioChieuitem";
            this.cbxGioChieuitem.Size = new System.Drawing.Size(342, 192);
            this.cbxGioChieuitem.Text = "Giờ Chiếu";
            this.cbxGioChieuitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.cbxGioChieuitem.TextSize = new System.Drawing.Size(108, 21);
            // 
            // cbxTenPhimitem
            // 
            this.cbxTenPhimitem.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.cbxTenPhimitem.AppearanceItemCaption.BackColor2 = System.Drawing.Color.Transparent;
            this.cbxTenPhimitem.AppearanceItemCaption.BorderColor = System.Drawing.Color.Transparent;
            this.cbxTenPhimitem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cbxTenPhimitem.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.cbxTenPhimitem.AppearanceItemCaption.Options.UseBackColor = true;
            this.cbxTenPhimitem.AppearanceItemCaption.Options.UseBorderColor = true;
            this.cbxTenPhimitem.AppearanceItemCaption.Options.UseFont = true;
            this.cbxTenPhimitem.AppearanceItemCaption.Options.UseForeColor = true;
            this.cbxTenPhimitem.Control = this.cbxTenPhim;
            this.cbxTenPhimitem.Location = new System.Drawing.Point(0, 0);
            this.cbxTenPhimitem.Name = "cbxTenPhimitem";
            this.cbxTenPhimitem.Size = new System.Drawing.Size(342, 54);
            this.cbxTenPhimitem.Text = "Tên Phim";
            this.cbxTenPhimitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.cbxTenPhimitem.TextSize = new System.Drawing.Size(108, 21);
            // 
            // PicPhimitem
            // 
            this.PicPhimitem.Control = this.PicPhim;
            this.PicPhimitem.Location = new System.Drawing.Point(342, 0);
            this.PicPhimitem.Name = "PicPhimitem";
            this.PicPhimitem.Size = new System.Drawing.Size(343, 361);
            this.PicPhimitem.TextSize = new System.Drawing.Size(0, 0);
            this.PicPhimitem.TextVisible = false;
            // 
            // cbxRapitem
            // 
            this.cbxRapitem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cbxRapitem.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.cbxRapitem.AppearanceItemCaption.Options.UseFont = true;
            this.cbxRapitem.AppearanceItemCaption.Options.UseForeColor = true;
            this.cbxRapitem.Control = this.cbxRap;
            this.cbxRapitem.Location = new System.Drawing.Point(0, 108);
            this.cbxRapitem.Name = "cbxRapitem";
            this.cbxRapitem.Size = new System.Drawing.Size(342, 54);
            this.cbxRapitem.Text = "Rạp";
            this.cbxRapitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.cbxRapitem.TextSize = new System.Drawing.Size(108, 21);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.White;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txbGia;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(342, 53);
            this.layoutControlItem1.Text = "Giá:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 21);
            // 
            // btnXacNhanitem
            // 
            this.btnXacNhanitem.Control = this.btnXacNhan;
            this.btnXacNhanitem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhanitem.ImageOptions.Image")));
            this.btnXacNhanitem.Location = new System.Drawing.Point(342, 361);
            this.btnXacNhanitem.MinSize = new System.Drawing.Size(29, 29);
            this.btnXacNhanitem.Name = "btnXacNhanitem";
            this.btnXacNhanitem.Size = new System.Drawing.Size(343, 46);
            this.btnXacNhanitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.btnXacNhanitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnXacNhanitem.TextVisible = false;
            // 
            // pHIMTableAdapter
            // 
            this.pHIMTableAdapter.ClearBeforeFill = true;
            // 
            // rAPTableAdapter
            // 
            this.rAPTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGCHIEUTableAdapter
            // 
            this.pHONGCHIEUTableAdapter.ClearBeforeFill = true;
            // 
            // sUATCHIEUTableAdapter
            // 
            this.sUATCHIEUTableAdapter.ClearBeforeFill = true;
            // 
            // UcChonPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaNHK.Properties.Resources.Chonphim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.UcChonPhimlayoutControl1ConvertedLayout);
            this.Name = "UcChonPhim";
            this.Size = new System.Drawing.Size(705, 427);
            this.Load += new System.EventHandler(this.UcChonPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHIMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUATCHIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGCHIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcChonPhimlayoutControl1ConvertedLayout)).EndInit();
            this.UcChonPhimlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPhongChieuitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGioChieuitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTenPhimitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhimitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRapitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhanitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTenPhim;
        private System.Windows.Forms.ComboBox cbxGioChieu;
        private System.Windows.Forms.ComboBox cbxPhongChieu;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.PictureBox PicPhim;
        private System.Windows.Forms.ComboBox cbxRap;
        private DevExpress.XtraLayout.LayoutControl UcChonPhimlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem cbxRapitem;
        private DevExpress.XtraLayout.LayoutControlItem cbxPhongChieuitem;
        private DevExpress.XtraLayout.LayoutControlItem cbxGioChieuitem;
        private DevExpress.XtraLayout.LayoutControlItem cbxTenPhimitem;
        private DevExpress.XtraLayout.LayoutControlItem PicPhimitem;
        private DevExpress.XtraLayout.LayoutControlItem btnXacNhanitem;
        private System.Windows.Forms.BindingSource pHIMBindingSource;
        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource sUATCHIEUBindingSource;
        private System.Windows.Forms.BindingSource pHONGCHIEUBindingSource;
        private System.Windows.Forms.BindingSource rAPBindingSource;
        private CinemaDataSetTableAdapters.PHIMTableAdapter pHIMTableAdapter;
        private CinemaDataSetTableAdapters.RAPTableAdapter rAPTableAdapter;
        private CinemaDataSetTableAdapters.PHONGCHIEUTableAdapter pHONGCHIEUTableAdapter;
        private CinemaDataSetTableAdapters.SUATCHIEUTableAdapter sUATCHIEUTableAdapter;
        private System.Windows.Forms.TextBox txbGia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
