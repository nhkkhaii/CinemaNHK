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
    public partial class DangKy : DevExpress.XtraEditors.XtraForm
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                if (txbTK.Text == "" || txbMK.Text == "" || txbConfirm.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                }
                else
                {
                    SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [KHACHHANG] WHERE ([SOTKKH] = @user)", con);
                    check_User_Name.Parameters.AddWithValue("@user", txbTK.Text);
                    int UserExist = (int)check_User_Name.ExecuteScalar();
                    if (UserExist == 0)
                    {
                        if (txbMK.Text == txbConfirm.Text )
                        {
                            SqlCommand add = new SqlCommand("INSERT INTO KHACHHANG(SOTKKH,MATKHAUTKKH) VALUES(@TKKH,@MKKH)", con);
                            add.Parameters.AddWithValue("@TKKH", txbTK.Text);
                            add.Parameters.AddWithValue("@MKKH", txbMK.Text);
                            add.ExecuteNonQuery();
                            XtraMessageBox.Show("Đăng ký thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            throw new Exception("Lặp lại mật khẩu không trùng nhau");
                        }
                    }
                    else
                    {
                        throw new Exception("Tài khoản đã tồn tại !!");
                    }
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