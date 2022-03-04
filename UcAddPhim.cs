using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaNHK
{
    public partial class UcAddPhim : DevExpress.XtraEditors.XtraUserControl
    {
        public UcAddPhim()
        {
            InitializeComponent();
        }
        private static UcAddPhim _instance;
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        public static UcAddPhim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcAddPhim();
                }
                return _instance;
            }
        }
        private void UcAddPhim_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT THELOAIID,TENTHELOAI from THELOAI",con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxTheLoai.DataSource = dt;
            cbxTheLoai.ValueMember = "THELOAIID";
            cbxTheLoai.DisplayMember = "TENTHELOAI";
            
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picPhim.Image = new Bitmap(open.FileName);
                picPhim.SizeMode = PictureBoxSizeMode.StretchImage;
                picPhim.Refresh();
            }
        }
      
        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (txbPhimID.Text == "" || txbTenPhim.Text == "" || txbGiaPhim.Text == "" ||cbxTheLoai.Text =="" ||dtpNgayChieu.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                }
                else
                {
                    SqlCommand add = new SqlCommand("INSERT INTO PHIM VALUES(@PHIMID,@THELOAIID,@TENPHIM,@NGAYCHIEU,@POSTER,@GIAPHIM)", con);
                    add.Parameters.AddWithValue("@PHIMID", txbPhimID.Text);
                    add.Parameters.AddWithValue("@THELOAIID", cbxTheLoai.SelectedValue.ToString());
                    add.Parameters.AddWithValue("@TENPHIM", txbTenPhim.Text);
                    DateTime d = DateTime.Parse(dtpNgayChieu.Text);
                    add.Parameters.AddWithValue("@NGAYCHIEU", d);
                    Image img = picPhim.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    add.Parameters.AddWithValue("@POSTER", arr);
                    add.Parameters.AddWithValue("@GIAPHIM", Int32.Parse(txbGiaPhim.Text));
                    add.ExecuteNonQuery();
                    XtraMessageBox.Show("Thêm phim thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
