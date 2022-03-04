using DevExpress.XtraEditors;
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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace CinemaNHK
{
    public partial class ThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public ThanhToan()
        {
            InitializeComponent();

        }
        public List<string> Ghe = UcChonGhe.Ghe;
        public string G = "";
        public string TP = "";
        public string TPhong = "";
        public string TRap = "";
        public string GChieu = "";
        public string EmailKH = Login.EmailKH;
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        public string GC= "";
        public int SOGHEID = 0;

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            TP = MainView.TenPhim;
            TPhong = MainView.TenPhong;
            TRap = MainView.TenRap;
            GChieu = MainView.GioChieu; 
            txbTKH.Text = Login.TENKH;
            txbMoney.Text = MainView.Gia;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select P.TENPHIM,P.NGAYCHIEUPHIM,R.TENRAP,PC.TENPHONG,SC.GIOCHIEU  from PHIM P, SUATCHIEU SC, PHONGCHIEU PC, RAP R WHERE P.PHIMID = SC.PHIMID AND SC.SUATCHIEUID = PC.SUATCHIEUID AND R.RAPID = PC.RAPID and  p.PHIMID = @PID and sc.SUATCHIEUID = @SC and r.RAPID = @Rap and pc.PHONGCHIEUID = @PC", con);
            cmd.Parameters.AddWithValue("@PID", TP);
            cmd.Parameters.AddWithValue("@Rap", TRap);
            cmd.Parameters.AddWithValue("@PC", TPhong);
            cmd.Parameters.AddWithValue("@SC", GChieu);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                txbPhim.Text = row.ItemArray[0].ToString();
                DateTime d = DateTime.Parse(row.ItemArray[1].ToString());              
                txbNgayChieu.Text = d.ToString("dd/MM/yyyy");
                txbGioChieu.Text = row.ItemArray[4].ToString();
                txbPhongChieu.Text = row.ItemArray[3].ToString();
                txbRap.Text = row.ItemArray[2].ToString();

            }
            
            con.Close();
            for (int i = 0; i < Ghe.Count; i++)
            {
                if(i == Ghe.Count - 1)
                {
                    G = G + Ghe[i];
                }
                else
                {
                    G = G  + Ghe[i] + ",";
                }
            }
            txbGhe.Text = G;
        
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (radioButton1.Checked == true)
                {
                    txbSoTKKH.ReadOnly = false;
                    if(txbSoTKKH.Text == "")
                    {
                        throw new Exception("Vui lòng nhập số tài khoản ngân hàng!");

                    }
                    else
                    {
                        for (int i = 0; i< Ghe.Count; i++)
                        {
                            SqlCommand add = new SqlCommand("INSERT INTO VE VALUES(@SCID,@SOGHEID,@NVID,@KHID)", con);
                            add.Parameters.AddWithValue("@SCID", MainView.GioChieu);
                            add.Parameters.AddWithValue("@NVID", "Admin");
                            add.Parameters.AddWithValue("@KHID", Login.IDKH);
                            SqlCommand add1 = new SqlCommand("select g.SOGHEID , g.SOGHE g From GHE g , PHONGCHIEU pc  where g.PHONGCHIEUID = pc.PHONGCHIEUID and g.SOGHE = @GHE and pc.PHONGCHIEUID = @PC", con);
                            add1.Parameters.AddWithValue("@GHE", Ghe[i]);
                            add1.Parameters.AddWithValue("@PC", MainView.TenPhong);
                            DataTable dt1 = new DataTable();
                            SqlDataAdapter da1 = new SqlDataAdapter(add1);
                            da1.Fill(dt1);
                            foreach(DataRow row in dt1.Rows)
                            {
                                SOGHEID = Int32.Parse(row.ItemArray[0].ToString());
                                add.Parameters.AddWithValue("@SOGHEID", Int32.Parse(row.ItemArray[0].ToString()));
                            }
                            add.ExecuteNonQuery();
                            SqlCommand add2 = new SqlCommand("SELECT SOVE FROM VE WHERE SUATCHIEUID = @SCID and SOGHEID = @SOGHEID and NHANVIENID = @NVID and KHACHHANGID = @KHID ", con);
                            add2.Parameters.AddWithValue("@SCID", MainView.GioChieu);
                            add2.Parameters.AddWithValue("@NVID", "Admin");
                            add2.Parameters.AddWithValue("@SOGHEID", SOGHEID);
                            add2.Parameters.AddWithValue("@KHID", Login.IDKH);
                            DataTable dt2 = new DataTable();
                            SqlDataAdapter da2 = new SqlDataAdapter(add2);
                            da2.Fill(dt2);
                            foreach (DataRow row in dt2.Rows)
                            {
                                GC = GC + row.ItemArray[0].ToString() + " ";
                            }
                        }
                                             
                        XtraMessageBox.Show("Thanh toán thành công!, Số Vé của bạn là : " + GC, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    throw new Exception("Vui lòng chọn phương thức thanh toán!");
                    
                }
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbSoTKKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}