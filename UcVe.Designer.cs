
namespace CinemaNHK
{
    partial class UcVe
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
            this.DataVe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txbIDVe = new System.Windows.Forms.TextBox();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.UcVelayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.comboBox1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.textBox1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.button2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.button1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.DataVeitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcVelayoutControl1ConvertedLayout)).BeginInit();
            this.UcVelayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataVeitem)).BeginInit();
            this.SuspendLayout();
            // 
            // DataVe
            // 
            this.DataVe.Location = new System.Drawing.Point(12, 12);
            this.DataVe.MainView = this.gridView1;
            this.DataVe.Name = "DataVe";
            this.DataVe.Size = new System.Drawing.Size(508, 216);
            this.DataVe.TabIndex = 0;
            this.DataVe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DataVe.Click += new System.EventHandler(this.DataVe_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DataVe;
            this.gridView1.Name = "gridView1";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(270, 232);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(250, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIn.Location = new System.Drawing.Point(270, 280);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(250, 45);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txbIDVe
            // 
            this.txbIDVe.Location = new System.Drawing.Point(12, 251);
            this.txbIDVe.Name = "txbIDVe";
            this.txbIDVe.ReadOnly = true;
            this.txbIDVe.Size = new System.Drawing.Size(254, 25);
            this.txbIDVe.TabIndex = 3;
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(12, 299);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(254, 24);
            this.cbxNhanVien.TabIndex = 7;
            // 
            // UcVelayoutControl1ConvertedLayout
            // 
            this.UcVelayoutControl1ConvertedLayout.Controls.Add(this.cbxNhanVien);
            this.UcVelayoutControl1ConvertedLayout.Controls.Add(this.txbIDVe);
            this.UcVelayoutControl1ConvertedLayout.Controls.Add(this.btnIn);
            this.UcVelayoutControl1ConvertedLayout.Controls.Add(this.btnSua);
            this.UcVelayoutControl1ConvertedLayout.Controls.Add(this.DataVe);
            this.UcVelayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcVelayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.UcVelayoutControl1ConvertedLayout.Name = "UcVelayoutControl1ConvertedLayout";
            this.UcVelayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.UcVelayoutControl1ConvertedLayout.Size = new System.Drawing.Size(532, 337);
            this.UcVelayoutControl1ConvertedLayout.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.comboBox1item,
            this.textBox1item,
            this.button2item,
            this.button1item,
            this.DataVeitem});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(532, 337);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // comboBox1item
            // 
            this.comboBox1item.Control = this.cbxNhanVien;
            this.comboBox1item.Location = new System.Drawing.Point(0, 268);
            this.comboBox1item.Name = "comboBox1item";
            this.comboBox1item.Size = new System.Drawing.Size(258, 49);
            this.comboBox1item.Text = "Nhân Viên :";
            this.comboBox1item.TextLocation = DevExpress.Utils.Locations.Top;
            this.comboBox1item.TextSize = new System.Drawing.Size(67, 16);
            // 
            // textBox1item
            // 
            this.textBox1item.Control = this.txbIDVe;
            this.textBox1item.Location = new System.Drawing.Point(0, 220);
            this.textBox1item.Name = "textBox1item";
            this.textBox1item.Size = new System.Drawing.Size(258, 48);
            this.textBox1item.Text = "ID Vé :";
            this.textBox1item.TextLocation = DevExpress.Utils.Locations.Top;
            this.textBox1item.TextSize = new System.Drawing.Size(67, 16);
            // 
            // button2item
            // 
            this.button2item.Control = this.btnIn;
            this.button2item.Location = new System.Drawing.Point(258, 268);
            this.button2item.Name = "button2item";
            this.button2item.Size = new System.Drawing.Size(254, 49);
            this.button2item.TextSize = new System.Drawing.Size(0, 0);
            this.button2item.TextVisible = false;
            // 
            // button1item
            // 
            this.button1item.Control = this.btnSua;
            this.button1item.Location = new System.Drawing.Point(258, 220);
            this.button1item.Name = "button1item";
            this.button1item.Size = new System.Drawing.Size(254, 48);
            this.button1item.TextSize = new System.Drawing.Size(0, 0);
            this.button1item.TextVisible = false;
            // 
            // DataVeitem
            // 
            this.DataVeitem.Control = this.DataVe;
            this.DataVeitem.Location = new System.Drawing.Point(0, 0);
            this.DataVeitem.Name = "DataVeitem";
            this.DataVeitem.Size = new System.Drawing.Size(512, 220);
            this.DataVeitem.TextSize = new System.Drawing.Size(0, 0);
            this.DataVeitem.TextVisible = false;
            // 
            // UcVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UcVelayoutControl1ConvertedLayout);
            this.Name = "UcVe";
            this.Size = new System.Drawing.Size(532, 337);
            this.Load += new System.EventHandler(this.UcVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcVelayoutControl1ConvertedLayout)).EndInit();
            this.UcVelayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataVeitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DataVe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txbIDVe;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private DevExpress.XtraLayout.LayoutControl UcVelayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem comboBox1item;
        private DevExpress.XtraLayout.LayoutControlItem textBox1item;
        private DevExpress.XtraLayout.LayoutControlItem button2item;
        private DevExpress.XtraLayout.LayoutControlItem button1item;
        private DevExpress.XtraLayout.LayoutControlItem DataVeitem;
    }
}
