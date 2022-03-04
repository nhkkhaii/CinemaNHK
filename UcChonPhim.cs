using DevExpress.XtraBars.Docking;
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
    public partial class UcChonPhim : System.Windows.Forms.UserControl
    {
        public UcChonPhim()
        {
            InitializeComponent();
        }
        private static UcChonPhim _instance;
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        public string Tenphim
        {
            get { return cbxTenPhim.SelectedValue.ToString(); }
           
        }
        public string GiaPhim
        {
            get { return txbGia.Text; }

        }
        public string Tenrap
        {
            get { return cbxRap.SelectedValue.ToString(); }
            
        }
        public string Tenphong
        {
            get { return cbxPhongChieu.SelectedValue.ToString(); }           
        }
        public string Giochieu
        {
            get { return cbxGioChieu.SelectedValue.ToString(); }            
        }


        public static UcChonPhim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcChonPhim();
                }
                return _instance;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {  
            try
            {
                if (cbxGioChieu.Text == "" || cbxRap.Text == "" || cbxTenPhim.Text == "" || cbxPhongChieu.Text == "")
                {
                    throw new Exception("Vui lòng chọn đầy đủ thông tin!");
                }
                else
                {
                    this.Hide();
                    ((MainView)this.ParentForm).ShowHomePage();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayData()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PHIMID,TENPHIM from PHIM", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxTenPhim.DataSource = dt;
            cbxTenPhim.ValueMember = "PHIMID";
            cbxTenPhim.DisplayMember = "TENPHIM";
            con.Close();
        }
        private void UcChonPhim_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        public Image ChuyenDoi(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void cbxTenPhim_SelectedIndexChanged(object sender, EventArgs e)
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
            SqlCommand cmd3 = new SqlCommand("SELECT GIAPHIM FROM PHIM WHERE PHIMID = @ID", con);
            cmd3.Parameters.AddWithValue("@ID", cbxTenPhim.SelectedValue.ToString());
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            foreach(DataRow row in dt3.Rows)
            {
                txbGia.Text = row.ItemArray[0].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT pc.PHONGCHIEUID,pc.TENPHONG from RAP r, PHONGCHIEU pc, SUATCHIEU sc, PHIM p where r.RAPID = pc.RAPID and pc.SUATCHIEUID = sc.SUATCHIEUID and p.PHIMID = sc.PHIMID and p.PHIMID = @PID", con);
            cmd2.Parameters.AddWithValue("@PID", cbxTenPhim.SelectedValue.ToString());
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbxPhongChieu.DataSource = dt2;
            cbxPhongChieu.ValueMember = "PHONGCHIEUID";
            cbxPhongChieu.DisplayMember = "TENPHONG";
            con.Close();
        }
        private void cbxPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT r.RAPID,r.TENRAP from RAP r, PHONGCHIEU pc, SUATCHIEU  sc where r.RAPID = pc.RAPID and pc.SUATCHIEUID = sc.SUATCHIEUID and pc.PHONGCHIEUID = @ID", con);
                cmd1.Parameters.AddWithValue("@ID", cbxPhongChieu.SelectedValue.ToString());
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                cbxRap.DataSource = dt1;
                cbxRap.ValueMember = "RAPID";
                cbxRap.DisplayMember = "TENRAP";
                con.Close();
                con.Open();
                SqlCommand cmd3 = new SqlCommand("SELECT sc.GIOCHIEU, sc.SUATCHIEUID from PHONGCHIEU p, SUATCHIEU sc where p.SUATCHIEUID = sc.SUATCHIEUID and p.PHONGCHIEUID = @PC", con);
                cmd3.Parameters.AddWithValue("@PC", cbxPhongChieu.SelectedValue.ToString());
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                cbxGioChieu.DataSource = dt3;
                cbxGioChieu.ValueMember = "SUATCHIEUID";
                cbxGioChieu.DisplayMember = "GIOCHIEU";
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void cbxTenPhim_TextChanged(object sender, EventArgs e)
        {
            var parent = this.ParentForm as MainView;
            parent.tenphim = Tenphim;
        }

        private void cbxPhongChieu_TextChanged(object sender, EventArgs e)
        {
            var parent = this.ParentForm as MainView;
            parent.tenphong = Tenphong;
        }

        private void cbxRap_TextChanged(object sender, EventArgs e)
        {
            var parent = this.ParentForm as MainView;
            parent.tenrap = Tenrap;
        }

        private void cbxGioChieu_TextChanged(object sender, EventArgs e)
        {
            var parent = this.ParentForm as MainView;
            parent.giochieu = Giochieu;
          
        }

        private void txbGia_TextChanged(object sender, EventArgs e)
        {
            var parent = this.ParentForm as MainView;
            parent.GP = GiaPhim;
        }
    }
}

