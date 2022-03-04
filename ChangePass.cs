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
    public partial class ChangePass : DevExpress.XtraEditors.XtraForm
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        private void btnChangepass_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                if (txbMKC.Text == "" || txbMKM.Text == "" || txbConfirm.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                }
                else
                {
                    if (txbMKC.Text == Login.MK)
                    {
                        if (txbMKM.Text == txbConfirm.Text )
                        {
                            SqlCommand add = new SqlCommand("UPDATE KHACHHANG SET MATKHAUTKKH = @MKM WHERE SOTKKH = @TK", con);
                            add.Parameters.AddWithValue("@TK", Login.tenTK);
                            add.Parameters.AddWithValue("@MKM", txbMKM.Text);
                            add.ExecuteNonQuery();
                            XtraMessageBox.Show("Thay đổi mật khẩu thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            throw new Exception("Lặp lại mật khẩu mới không đúng!!");
                        }                     
                    }
                    else
                    {
                        throw new Exception("Mật khẩu cũ không đúng!!");
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