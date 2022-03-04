using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaNHK
{
    public partial class UcVe : DevExpress.XtraEditors.XtraUserControl
    {
        public UcVe()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        private void DisplayData()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select v.SOVE as 'Số vé',p.TENPHIM as 'Phim',tl.TENTHELOAI as 'Thể loại',p.GIAPHIM as 'Giá',p.NGAYCHIEUPHIM 'Ngày chiếu' ,sc.GIOCHIEU as 'Giờ chiếu', kh.HOTENKHACHHANG as 'Tên khách hàng', r.TENRAP as 'Tên Rạp', pc.TENPHONG as 'Phòng chiếu', g.SOGHE as 'Ghế', nv.HOTENNV as 'Nhân Viên Lập' from VE v, SUATCHIEU sc, GHE g, NHANVIEN nv, KHACHHANG kh, PHIM p, THELOAI tl, PHONGCHIEU pc, RAP r where v.KHACHHANGID = kh.KHACHHANGID and v.SUATCHIEUID = sc.SUATCHIEUID and v.SOGHEID = g.SOGHEID and v.NHANVIENID = nv.NHANVIENID and p.PHIMID = sc.PHIMID and p.THELOAIID = tl.THELOAIID and r.RAPID = pc.RAPID and sc.SUATCHIEUID = pc.SUATCHIEUID and g.PHONGCHIEUID = pc.PHONGCHIEUID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            DataVe.DataSource = dt;
        }
        private static UcVe _instance;
        public static UcVe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcVe();
                }
                return _instance;
            }
        }

        private void UcVe_Load(object sender, EventArgs e)
        {
            DisplayData();
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT NHANVIENID,HOTENNV from NHANVIEN", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxNhanVien.DataSource = dt;
            cbxNhanVien.ValueMember = "NHANVIENID";
            cbxNhanVien.DisplayMember = "HOTENNV";
            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                if (txbIDVe.Text == "" || cbxNhanVien.Text == "")
                {
                    throw new Exception("Vui lòng chọn thông tin Vé!");
                }
                else
                {
                    SqlCommand add = new SqlCommand("UPDATE VE SET VE.NHANVIENID = @NVID WHERE SOVE=@SVe", con);
                    add.Parameters.AddWithValue("@NVID", cbxNhanVien.SelectedValue.ToString());
                    add.Parameters.AddWithValue("@SVe", Int32.Parse(txbIDVe.Text));
                    add.ExecuteNonQuery();
                    XtraMessageBox.Show("Cập nhật Vé thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
                con.Close();
                DisplayData();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataVe_Click(object sender, EventArgs e)
        {
            GridView gridView = DataVe.FocusedView as GridView;
            foreach (int i in gridView.GetSelectedRows())
            {
                DataRow row = gridView.GetDataRow(i);
                txbIDVe.Text = row[0].ToString();
                cbxNhanVien.Text = row[10].ToString();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                if (txbIDVe.Text =="")
                {
                    throw new Exception("Vui lòng Vé cần in!");
                }
                else
                {
                    SqlCommand add = new SqlCommand("select v.SOVE as 'Số vé',p.TENPHIM as 'Phim',tl.TENTHELOAI as 'Thể loại',p.GIAPHIM as 'Giá',p.NGAYCHIEUPHIM 'Ngày chiếu' ,sc.GIOCHIEU as 'Giờ chiếu', kh.HOTENKHACHHANG as 'Tên khách hàng', r.TENRAP as 'Tên Rạp', pc.TENPHONG as 'Phòng chiếu', g.SOGHE as 'Ghế', nv.HOTENNV as 'Nhân Viên Lập' from VE v, SUATCHIEU sc, GHE g, NHANVIEN nv, KHACHHANG kh, PHIM p, THELOAI tl, PHONGCHIEU pc, RAP r where v.KHACHHANGID = kh.KHACHHANGID and v.SUATCHIEUID = sc.SUATCHIEUID and v.SOGHEID = g.SOGHEID and v.NHANVIENID = nv.NHANVIENID and p.PHIMID = sc.PHIMID and p.THELOAIID = tl.THELOAIID and r.RAPID = pc.RAPID and sc.SUATCHIEUID = pc.SUATCHIEUID and g.PHONGCHIEUID = pc.PHONGCHIEUID and v.SOVE = @SVID", con);
                    add.Parameters.AddWithValue("@SVID", Int32.Parse(txbIDVe.Text));
                    SqlDataAdapter da = new SqlDataAdapter(add);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach(DataRow row in dt.Rows)
                    {
                        using(FrmPrint frm = new FrmPrint())
                        {
                            frm.PrintHoaDon(Int32.Parse(row.ItemArray[0].ToString()),row.ItemArray[1].ToString(),row.ItemArray[7].ToString(),row.ItemArray[10].ToString(),row.ItemArray[6].ToString(),DateTime.Parse(row.ItemArray[4].ToString()),row.ItemArray[5].ToString(),row.ItemArray[8].ToString(),row.ItemArray[9].ToString(),row.ItemArray[3].ToString());
                            frm.ShowDialog();
                        }
                    }
                }
                
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
