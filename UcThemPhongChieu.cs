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
    public partial class UcThemPhongChieu : DevExpress.XtraEditors.XtraUserControl
    {
        public UcThemPhongChieu()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        private static UcThemPhongChieu _instance;
        public static UcThemPhongChieu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcThemPhongChieu();
                }
                return _instance;
            }
        }

        private void UcThemPhongChieu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);          
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT RAPID,TENRAP from RAP", con);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbxRap.DataSource = dt1;
            cbxRap.ValueMember = "RAPID";
            cbxRap.DisplayMember = "TENRAP";
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT PHIMID,TENPHIM from PHIM", con);
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbxTenPhim.DataSource = dt2;
            cbxTenPhim.ValueMember = "PHIMID";
            cbxTenPhim.DisplayMember = "TENPHIM";
            con.Close();

        }

        private void btnAddPC_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (txbIDPhong.Text == "" || cbxSuatChieu.Text == "" || cbxRap.Text == "" || cbxTenPhong.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                }
                else
                {
                    SqlCommand add = new SqlCommand("INSERT INTO PHONGCHIEU VALUES(@IDPhong,@RAP,@SC,@TenP)", con);
                    add.Parameters.AddWithValue("@IDPhong", txbIDPhong.Text);
                    add.Parameters.AddWithValue("@TenP", cbxTenPhong.Text);
                    add.Parameters.AddWithValue("@RAP", cbxRap.SelectedValue.ToString());
                    add.Parameters.AddWithValue("@SC", cbxSuatChieu.SelectedValue.ToString());
                    add.ExecuteNonQuery();
                    SqlCommand add1 = new SqlCommand("INSERT INTO GHE VALUES('A01',@IDPhong),('A02',@IDPhong),('A03',@IDPhong),('A04',@IDPhong),('A05',@IDPhong),('A06',@IDPhong),('A07',@IDPhong),('A08',@IDPhong),('B01',@IDPhong),('B02',@IDPhong),('B03',@IDPhong),('B04',@IDPhong),('B05',@IDPhong),('B06',@IDPhong),('B07',@IDPhong),('B08',@IDPhong),('C01',@IDPhong),('C02',@IDPhong),('C03',@IDPhong),('C04',@IDPhong),('C05',@IDPhong),('C06',@IDPhong),('C07',@IDPhong),('C08',@IDPhong),('D01',@IDPhong),('D02',@IDPhong),('D03',@IDPhong),('D04',@IDPhong),('D05',@IDPhong),('D06',@IDPhong),('D07',@IDPhong),('D08',@IDPhong),('E01',@IDPhong),('E02',@IDPhong),('E03',@IDPhong),('E04',@IDPhong),('E05',@IDPhong),('E06',@IDPhong),('E07',@IDPhong),('E08',@IDPhong),('F01',@IDPhong),('F02',@IDPhong),('F03',@IDPhong),('F04',@IDPhong),('F05',@IDPhong),('F06',@IDPhong),('F07',@IDPhong),('F08',@IDPhong),('G01',@IDPhong),('G02',@IDPhong),('G03',@IDPhong),('G04',@IDPhong),('G05',@IDPhong),('G06',@IDPhong),('G07',@IDPhong),('G08',@IDPhong),('H01',@IDPhong),('H02',@IDPhong),('H03',@IDPhong),('H04',@IDPhong),('H05',@IDPhong),('H06',@IDPhong),('H07',@IDPhong),('H08',@IDPhong),('I01',@IDPhong),('I02',@IDPhong),('I03',@IDPhong),('I04',@IDPhong),('I05',@IDPhong),('I06',@IDPhong),('I07',@IDPhong),('I08',@IDPhong),('J01',@IDPhong),('J02',@IDPhong),('J03',@IDPhong),('J04',@IDPhong),('J05',@IDPhong),('J06',@IDPhong),('J07',@IDPhong),('J08',@IDPhong)", con);
                    add1.Parameters.AddWithValue("@IDPhong", txbIDPhong.Text);
                    add1.ExecuteNonQuery();
                    XtraMessageBox.Show("Thêm phòng chiếu thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSuatChieu1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT POSTER FROM PHIM WHERE PHIMID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", cbxTenPhim.SelectedValue.ToString());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["POSTER"]);
                MemoryStream mem = new MemoryStream(data);
                PicPhim.Image = Image.FromStream(mem);
                PicPhim.SizeMode = PictureBoxSizeMode.StretchImage;
                PicPhim.Refresh();
            }
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT sc.SUATCHIEUID,sc.GIOCHIEU from SUATCHIEU sc , PHIM p where sc.PHIMID = p.PHIMID and p.PHIMID = @ID", con);
            cmd2.Parameters.AddWithValue("@ID", cbxTenPhim.SelectedValue.ToString());

            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbxSuatChieu.DataSource = dt2;
            cbxSuatChieu.ValueMember = "SUATCHIEUID";
            cbxSuatChieu.DisplayMember = "GIOCHIEU";
            con.Close();
        }
    }
}
