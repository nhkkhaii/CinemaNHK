
namespace CinemaNHK
{
    partial class UcAddPhim
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txbPhimID = new System.Windows.Forms.TextBox();
            this.txbTenPhim = new System.Windows.Forms.TextBox();
            this.cbxTheLoai = new System.Windows.Forms.ComboBox();
            this.tHELOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new CinemaNHK.CinemaDataSet();
            this.picPhim = new System.Windows.Forms.PictureBox();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnThemPhim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbGiaPhim = new System.Windows.Forms.TextBox();
            this.UcAddPhimlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txbGiaPhimitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtpNgayChieuitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbxTheLoaiitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbTenPhimitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbPhimIDitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnThemPhimitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnAddImageitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.picPhimitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.label5item = new DevExpress.XtraLayout.LayoutControlItem();
            this.tHELOAITableAdapter = new CinemaNHK.CinemaDataSetTableAdapters.THELOAITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcAddPhimlayoutControl1ConvertedLayout)).BeginInit();
            this.UcAddPhimlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbGiaPhimitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayChieuitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTheLoaiitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenPhimitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPhimIDitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemPhimitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddImageitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhimitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5item)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txbPhimID
            // 
            this.txbPhimID.Location = new System.Drawing.Point(85, 418);
            this.txbPhimID.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhimID.Name = "txbPhimID";
            this.txbPhimID.Size = new System.Drawing.Size(283, 25);
            this.txbPhimID.TabIndex = 1;
            // 
            // txbTenPhim
            // 
            this.txbTenPhim.Location = new System.Drawing.Point(85, 447);
            this.txbTenPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenPhim.Name = "txbTenPhim";
            this.txbTenPhim.Size = new System.Drawing.Size(283, 25);
            this.txbTenPhim.TabIndex = 5;
            // 
            // cbxTheLoai
            // 
            this.cbxTheLoai.DataSource = this.tHELOAIBindingSource;
            this.cbxTheLoai.DisplayMember = "TENTHELOAI";
            this.cbxTheLoai.FormattingEnabled = true;
            this.cbxTheLoai.Location = new System.Drawing.Point(619, 418);
            this.cbxTheLoai.Name = "cbxTheLoai";
            this.cbxTheLoai.Size = new System.Drawing.Size(176, 29);
            this.cbxTheLoai.TabIndex = 12;
            this.cbxTheLoai.ValueMember = "THELOAIID";
            // 
            // tHELOAIBindingSource
            // 
            this.tHELOAIBindingSource.DataMember = "THELOAI";
            this.tHELOAIBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picPhim
            // 
            this.picPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPhim.Location = new System.Drawing.Point(12, 12);
            this.picPhim.Margin = new System.Windows.Forms.Padding(4);
            this.picPhim.Name = "picPhim";
            this.picPhim.Size = new System.Drawing.Size(783, 402);
            this.picPhim.TabIndex = 0;
            this.picPhim.TabStop = false;
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(619, 448);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(176, 28);
            this.dtpNgayChieu.TabIndex = 13;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddImage.Location = new System.Drawing.Point(372, 418);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(170, 40);
            this.btnAddImage.TabIndex = 14;
            this.btnAddImage.Text = "Chọn Ảnh";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Location = new System.Drawing.Point(372, 462);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(170, 39);
            this.btnThemPhim.TabIndex = 15;
            this.btnThemPhim.Text = "Thêm";
            this.btnThemPhim.UseVisualStyleBackColor = true;
            this.btnThemPhim.Click += new System.EventHandler(this.btnThemPhim_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 476);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giá Phim";
            // 
            // txbGiaPhim
            // 
            this.txbGiaPhim.Location = new System.Drawing.Point(106, 476);
            this.txbGiaPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txbGiaPhim.Name = "txbGiaPhim";
            this.txbGiaPhim.Size = new System.Drawing.Size(189, 25);
            this.txbGiaPhim.TabIndex = 16;
            // 
            // UcAddPhimlayoutControl1ConvertedLayout
            // 
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.txbGiaPhim);
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.dtpNgayChieu);
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.cbxTheLoai);
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.txbTenPhim);
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.txbPhimID);
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.label5);
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.btnThemPhim);
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.btnAddImage);
            this.UcAddPhimlayoutControl1ConvertedLayout.Controls.Add(this.picPhim);
            this.UcAddPhimlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcAddPhimlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.UcAddPhimlayoutControl1ConvertedLayout.Name = "UcAddPhimlayoutControl1ConvertedLayout";
            this.UcAddPhimlayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 107, 812, 500);
            this.UcAddPhimlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.UcAddPhimlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(807, 513);
            this.UcAddPhimlayoutControl1ConvertedLayout.TabIndex = 19;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txbGiaPhimitem,
            this.dtpNgayChieuitem,
            this.cbxTheLoaiitem,
            this.txbTenPhimitem,
            this.txbPhimIDitem,
            this.btnThemPhimitem,
            this.picPhimitem,
            this.label5item,
            this.btnAddImageitem});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(807, 513);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txbGiaPhimitem
            // 
            this.txbGiaPhimitem.Control = this.txbGiaPhim;
            this.txbGiaPhimitem.Location = new System.Drawing.Point(94, 464);
            this.txbGiaPhimitem.Name = "txbGiaPhimitem";
            this.txbGiaPhimitem.Size = new System.Drawing.Size(266, 29);
            this.txbGiaPhimitem.Text = ".000đ";
            this.txbGiaPhimitem.TextLocation = DevExpress.Utils.Locations.Right;
            this.txbGiaPhimitem.TextSize = new System.Drawing.Size(70, 16);
            // 
            // dtpNgayChieuitem
            // 
            this.dtpNgayChieuitem.Control = this.dtpNgayChieu;
            this.dtpNgayChieuitem.Location = new System.Drawing.Point(534, 436);
            this.dtpNgayChieuitem.Name = "dtpNgayChieuitem";
            this.dtpNgayChieuitem.Size = new System.Drawing.Size(253, 57);
            this.dtpNgayChieuitem.Text = "Ngày Chiếu";
            this.dtpNgayChieuitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.dtpNgayChieuitem.TextSize = new System.Drawing.Size(70, 17);
            // 
            // cbxTheLoaiitem
            // 
            this.cbxTheLoaiitem.Control = this.cbxTheLoai;
            this.cbxTheLoaiitem.Location = new System.Drawing.Point(534, 406);
            this.cbxTheLoaiitem.Name = "cbxTheLoaiitem";
            this.cbxTheLoaiitem.Size = new System.Drawing.Size(253, 30);
            this.cbxTheLoaiitem.Text = "Thể Loại";
            this.cbxTheLoaiitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.cbxTheLoaiitem.TextSize = new System.Drawing.Size(70, 17);
            // 
            // txbTenPhimitem
            // 
            this.txbTenPhimitem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txbTenPhimitem.AppearanceItemCaption.Options.UseFont = true;
            this.txbTenPhimitem.Control = this.txbTenPhim;
            this.txbTenPhimitem.Location = new System.Drawing.Point(0, 435);
            this.txbTenPhimitem.Name = "txbTenPhimitem";
            this.txbTenPhimitem.Size = new System.Drawing.Size(360, 29);
            this.txbTenPhimitem.Text = "Tên Phim";
            this.txbTenPhimitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.txbTenPhimitem.TextSize = new System.Drawing.Size(70, 21);
            // 
            // txbPhimIDitem
            // 
            this.txbPhimIDitem.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txbPhimIDitem.AppearanceItemCaption.Options.UseFont = true;
            this.txbPhimIDitem.Control = this.txbPhimID;
            this.txbPhimIDitem.Location = new System.Drawing.Point(0, 406);
            this.txbPhimIDitem.MinSize = new System.Drawing.Size(102, 29);
            this.txbPhimIDitem.Name = "txbPhimIDitem";
            this.txbPhimIDitem.Size = new System.Drawing.Size(360, 29);
            this.txbPhimIDitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.txbPhimIDitem.Text = "Phim ID";
            this.txbPhimIDitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.txbPhimIDitem.TextSize = new System.Drawing.Size(70, 21);
            // 
            // btnThemPhimitem
            // 
            this.btnThemPhimitem.Control = this.btnThemPhim;
            this.btnThemPhimitem.Location = new System.Drawing.Point(360, 450);
            this.btnThemPhimitem.Name = "btnThemPhimitem";
            this.btnThemPhimitem.Size = new System.Drawing.Size(174, 43);
            this.btnThemPhimitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnThemPhimitem.TextVisible = false;
            // 
            // btnAddImageitem
            // 
            this.btnAddImageitem.Control = this.btnAddImage;
            this.btnAddImageitem.Location = new System.Drawing.Point(360, 406);
            this.btnAddImageitem.Name = "btnAddImageitem";
            this.btnAddImageitem.Size = new System.Drawing.Size(174, 44);
            this.btnAddImageitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnAddImageitem.TextVisible = false;
            // 
            // picPhimitem
            // 
            this.picPhimitem.Control = this.picPhim;
            this.picPhimitem.Location = new System.Drawing.Point(0, 0);
            this.picPhimitem.Name = "picPhimitem";
            this.picPhimitem.Size = new System.Drawing.Size(787, 406);
            this.picPhimitem.TextSize = new System.Drawing.Size(0, 0);
            this.picPhimitem.TextVisible = false;
            // 
            // label5item
            // 
            this.label5item.Control = this.label5;
            this.label5item.Location = new System.Drawing.Point(0, 464);
            this.label5item.Name = "label5item";
            this.label5item.Size = new System.Drawing.Size(94, 29);
            this.label5item.TextSize = new System.Drawing.Size(0, 0);
            this.label5item.TextVisible = false;
            // 
            // tHELOAITableAdapter
            // 
            this.tHELOAITableAdapter.ClearBeforeFill = true;
            // 
            // UcAddPhim
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UcAddPhimlayoutControl1ConvertedLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcAddPhim";
            this.Size = new System.Drawing.Size(807, 513);
            this.Load += new System.EventHandler(this.UcAddPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcAddPhimlayoutControl1ConvertedLayout)).EndInit();
            this.UcAddPhimlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbGiaPhimitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayChieuitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTheLoaiitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenPhimitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPhimIDitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemPhimitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddImageitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhimitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txbPhimID;
        private System.Windows.Forms.TextBox txbTenPhim;
        private System.Windows.Forms.ComboBox cbxTheLoai;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnThemPhim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbGiaPhim;
        private DevExpress.XtraLayout.LayoutControl UcAddPhimlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem txbGiaPhimitem;
        private DevExpress.XtraLayout.LayoutControlItem dtpNgayChieuitem;
        private DevExpress.XtraLayout.LayoutControlItem cbxTheLoaiitem;
        private DevExpress.XtraLayout.LayoutControlItem txbTenPhimitem;
        private DevExpress.XtraLayout.LayoutControlItem txbPhimIDitem;
        private DevExpress.XtraLayout.LayoutControlItem btnThemPhimitem;
        private DevExpress.XtraLayout.LayoutControlItem btnAddImageitem;
        private DevExpress.XtraLayout.LayoutControlItem picPhimitem;
        private DevExpress.XtraLayout.LayoutControlItem label5item;
        private System.Windows.Forms.BindingSource tHELOAIBindingSource;
        private CinemaDataSet cinemaDataSet;
        private CinemaDataSetTableAdapters.THELOAITableAdapter tHELOAITableAdapter;
    }
}
