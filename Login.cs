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

namespace CinemaNHK
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            
        }
       
        public static string tenTK = "";
        public static string MK = "";
        public static string TENKH = "";
        public static int IDKH;
        public static string EmailKH = "";

        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        public bool flag = false;
        public int ID = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            tenTK = txbTK.Text;
            MK = txbMK.Text;
            string GMK = "";
            con = new SqlConnection(connectionString);
            try
            {   con.Open();
                
                if (txbTK.Text == "" || txbMK.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                }
                else
                {
                    SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [KHACHHANG] WHERE ([SOTKKH] = @user)", con);
                    check_User_Name.Parameters.AddWithValue("@user", txbTK.Text);
                    SqlCommand check_TKNV = new SqlCommand("SELECT COUNT(*) FROM [NHANVIEN] WHERE ([SOTKNV] = @TKNV)", con);
                    check_TKNV.Parameters.AddWithValue("@TKNV", txbTK.Text);
                    int UserExist = (int)check_User_Name.ExecuteScalar();
                    int TKNV = (int)check_TKNV.ExecuteScalar(); 
                    if (UserExist > 0)
                    {
                        SqlCommand GetTK = new SqlCommand("Select * FROM KHACHHANG where ([SOTKKH] = @TKKH)", con);
                        GetTK.Parameters.AddWithValue("@TKKH", txbTK.Text);
                        SqlDataAdapter sda = new SqlDataAdapter(GetTK);
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            GMK = row.ItemArray[2].ToString().Replace(" ", "");
                            TENKH = row.ItemArray[3].ToString();
                            EmailKH = row.ItemArray[6].ToString().Replace(" ", "");
                            IDKH = Int32.Parse(row.ItemArray[0].ToString());
                        }
                        if (MK == GMK)
                        {
                            flag = true;
                            ID = 1;
                            txbMK.Text = "";
                            XtraMessageBox.Show("Đăng nhập thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                            this.Hide();
                        }
                        else
                        {
                            throw new Exception("Sai mật khẩu");
                        }
                    }
                    else if (TKNV > 0)
                    {
                        SqlCommand GetTK = new SqlCommand("Select * FROM NHANVIEN where ([SOTKNV] = @SOTKNV)", con);
                        GetTK.Parameters.AddWithValue("@SOTKNV", txbTK.Text);
                        SqlDataAdapter sda = new SqlDataAdapter(GetTK);
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            GMK = row.ItemArray[2].ToString().Replace(" ","");
                            TENKH = row.ItemArray[3].ToString();                           
                        }     
                        if (MK == GMK)
                        {
                            flag = true;
                            ID = 2;
                            txbMK.Text = "";
                            XtraMessageBox.Show("Đăng nhập thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            throw new Exception("Sai mật khẩu");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Tài khoản không tồn tại!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    }
                con.Close();          
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txbTK_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txbMK_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}