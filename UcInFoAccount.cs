using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaNHK
{
    public partial class UcInFoAccount : DevExpress.XtraEditors.XtraUserControl
    {
        public UcInFoAccount()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        private static UcInFoAccount _instance;
        public static string EmailKH = "";
        public static UcInFoAccount Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcInFoAccount();
                }
                return _instance;
            }
        }
        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        public static string Email
        {
            get
            {
                return EmailKH;
            }

        }
        private void LoadInfo()
        {
            DataTable dt = new DataTable();
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand info = new SqlCommand("SELECT * FROM KHACHHANG WHERE SOTKKH = @TKKH", con);
            info.Parameters.AddWithValue("@TKKH", Login.tenTK);
            SqlDataAdapter sda = new SqlDataAdapter(info);
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                txbID.Text = row.ItemArray[0].ToString();
                txbTK.Text = row.ItemArray[1].ToString().Replace(" ", "");
                txbHoTen.Text = row.ItemArray[3].ToString();
                txbSDT.Text = row.ItemArray[4].ToString().Replace(" ", "");
                txbDiaChi.Text = row.ItemArray[5].ToString();
                txbEmail.Text = row.ItemArray[6].ToString().Replace(" ", ""); ;
                if(row.ItemArray[7].ToString() != "")
                {
                     DateTime d = DateTime.Parse(row.ItemArray[7].ToString()); 
                     DTPNgaySinh.Value = d;
                }
                
            }
            con.Close();
        }
        private void UcInFoAccount_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (txbHoTen.Text == "" || txbSDT.Text == "" ||txbDiaChi.Text == "" | txbEmail.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản!");
                }
                else
                {
                    if (isEmail(txbEmail.Text) == true)
                    {
                        SqlCommand add = new SqlCommand("UPDATE KHACHHANG SET HOTENKHACHHANG = @HOTEN,SDTKHACHHANG = @SDT,DIACHIKHACHHANG = @DIACHI,EMAILKHACHHANG = @EM,NGAYSINHKHACHHANG = @NS WHERE KHACHHANGID = @ID", con);
                        add.Parameters.AddWithValue("@ID", Int32.Parse(txbID.Text));
                        add.Parameters.AddWithValue("@HOTEN", txbHoTen.Text);
                        add.Parameters.AddWithValue("@SDT", txbSDT.Text);
                        add.Parameters.AddWithValue("@DIACHI", txbDiaChi.Text);
                        add.Parameters.AddWithValue("@EM", txbEmail.Text);
                        DateTime d = DTPNgaySinh.Value;
                        add.Parameters.AddWithValue("@NS", d);
                        add.ExecuteNonQuery();
                        XtraMessageBox.Show("Cập nhật thông tin thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Không đúng định dạng Email!!");
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
