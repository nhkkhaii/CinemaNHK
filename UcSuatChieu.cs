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
    public partial class UcSuatChieu : System.Windows.Forms.UserControl
    {
        public UcSuatChieu()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        private static UcSuatChieu _instance;
        public static UcSuatChieu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcSuatChieu();
                }
                return _instance;
            }
        }

        private void btnThemSuat_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (txbSuatChieuId.Text == "" || cbxGioChieu.Text == "" || cbxPhim.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin suất chiếu!");
                }
                else
                {
                    SqlCommand add = new SqlCommand("INSERT INTO SUATCHIEU VALUES(@SCID,@PID,@GC)", con);
                    add.Parameters.AddWithValue("@SCID", txbSuatChieuId.Text);
                    add.Parameters.AddWithValue("@PID", cbxPhim.SelectedValue.ToString());
                    add.Parameters.AddWithValue("@GC", cbxGioChieu.Text);
                    add.ExecuteNonQuery();
                    XtraMessageBox.Show("Thêm suất chiếu thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Image ChuyenDoi(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void UcSuatChieu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PHIMID,TENPHIM from PHIM", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxPhim.DataSource = dt; 
            cbxPhim.ValueMember = "PHIMID";
            cbxPhim.DisplayMember = "TENPHIM";
            con.Close();
        }


        private void cbxPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT POSTER FROM PHIM WHERE PHIMID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", cbxPhim.SelectedValue.ToString());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["POSTER"]);
                MemoryStream mem = new MemoryStream(data);
                picPhim.Image = Image.FromStream(mem);
                picPhim.SizeMode = PictureBoxSizeMode.StretchImage;
                picPhim.Refresh();
            }
        }
    }
}
