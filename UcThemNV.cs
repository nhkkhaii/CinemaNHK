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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaNHK
{
    public partial class UcThemNV : DevExpress.XtraEditors.XtraUserControl
    {
        public UcThemNV()
        {
            InitializeComponent();
        }
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;
        private void DisplayData()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand slt = new SqlCommand("SELECT * FROM NHANVIEN ", con);
            SqlDataAdapter sda = new SqlDataAdapter(slt);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataNV.DataSource = dt;
            con.Close();
        }
        private static UcThemNV _instance;
        public static UcThemNV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcThemNV();
                }
                return _instance;
            }
        }

        private void UcThemNV_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                if (txbIDNV.Text == "" || txbHoTen.Text == "" || txbDiaChi.Text == ""
                    || txbEmail.Text == "" || txbTKNV.Text == "" || txbMKNV.Text == ""
                    || txbSDT.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhân viên!");
                }
                else
                {
                    SqlCommand checkID = new SqlCommand("SELECT COUNT(*) FROM [NHANVIEN] WHERE ([NHANVIENID] = @IDNV)", con);
                    checkID.Parameters.AddWithValue("@IDNV", txbIDNV.Text);
                    int IDNHANVIEN = (int)checkID.ExecuteScalar();
                    if (IDNHANVIEN > 0)
                    {
                        if (isEmail(txbEmail.Text) == true)
                        {
                            SqlCommand add = new SqlCommand("UPDATE NHANVIEN SET SOTKNV = @TKNV,MATKHAUTKNV = @MKTKNV,HOTENNV = @HOTEN,SDTNV = @SDT,DIACHINV = @DIACHI,EMAILNV = @EMAIL,NGAYSINHNV= @NGAYSINHNV,CHUCVU = @CHUCVU WHERE NHANVIENID=@ID", con);
                            add.Parameters.AddWithValue("@ID", txbIDNV.Text);
                            add.Parameters.AddWithValue("@TKNV", txbTKNV.Text);
                            add.Parameters.AddWithValue("@MKTKNV", txbMKNV.Text);
                            add.Parameters.AddWithValue("@HOTEN", txbHoTen.Text);
                            add.Parameters.AddWithValue("@SDT", txbSDT.Text);
                            add.Parameters.AddWithValue("@EMAIL", txbEmail.Text);
                            add.Parameters.AddWithValue("@DIACHI", txbDiaChi.Text);
                            add.Parameters.AddWithValue("@CHUCVU", cbxCV.Text);
                            DateTime d = DTPNgaySinh.Value;
                            add.Parameters.AddWithValue("@NGAYSINHNV", d);
                            add.ExecuteNonQuery();
                            XtraMessageBox.Show("Cập nhật nhân viên thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("Không đúng định dạng Email!!");
                        }
                    }
                    else
                    {
                        throw new Exception("Nhân viên không tồn tại!!");


                    }
                }
                DisplayData();
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                if (txbIDNV.Text == "" || txbHoTen.Text == "" || txbDiaChi.Text == ""
                    || txbEmail.Text == "" || txbTKNV.Text == "" || txbMKNV.Text == ""
                    || txbSDT.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhân viên!");
                }
                else
                {
                    SqlCommand checkID = new SqlCommand("SELECT COUNT(*) FROM [NHANVIEN] WHERE ([NHANVIENID] = @IDNV)", con);
                    checkID.Parameters.AddWithValue("@IDNV", txbIDNV.Text);
                    int IDNHANVIEN = (int)checkID.ExecuteScalar();
                    if (IDNHANVIEN == 0)
                    {
                        if (isEmail(txbEmail.Text) == true)
                    {
                            SqlCommand add = new SqlCommand("INSERT INTO NHANVIEN VALUES(@ID,@TKNV,@MKTKNV,@HOTEN,@SDT,@DIACHI,@EMAIL,@NGAYSINHNV,@CHUCVU)", con);
                            add.Parameters.AddWithValue("@ID", txbIDNV.Text);
                            add.Parameters.AddWithValue("@TKNV", txbTKNV.Text);
                            add.Parameters.AddWithValue("@MKTKNV", txbMKNV.Text);
                            add.Parameters.AddWithValue("@HOTEN", txbHoTen.Text);
                            add.Parameters.AddWithValue("@SDT", txbSDT.Text);
                            add.Parameters.AddWithValue("@EMAIL", txbEmail.Text);
                            add.Parameters.AddWithValue("@DIACHI", txbDiaChi.Text);
                            add.Parameters.AddWithValue("@CHUCVU", cbxCV.Text);
                            DateTime d = DTPNgaySinh.Value;
                            add.Parameters.AddWithValue("@NGAYSINHNV", d);
                            add.ExecuteNonQuery();
                            XtraMessageBox.Show("Thêm nhân viên thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        else
                        {
                            throw new Exception("Không đúng định dạng Email!!");
                        }
                    }
                    else
                    {
                        throw new Exception("Nhân viên đã tồn tại!!");


                    }

                }
                DisplayData();
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();

                if (txbIDNV.Text == "" || txbHoTen.Text == "" || txbDiaChi.Text == ""
                    || txbEmail.Text == "" || txbTKNV.Text == "" || txbMKNV.Text == ""
                    || txbSDT.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin nhân viên!");
                }
                else
                {
                    SqlCommand checkID = new SqlCommand("SELECT COUNT(*) FROM [NHANVIEN] WHERE ([NHANVIENID] = @IDNV)", con);
                    checkID.Parameters.AddWithValue("@IDNV", txbIDNV.Text);
                    int IDNHANVIEN = (int)checkID.ExecuteScalar();
                    if (IDNHANVIEN > 0)
                    {
                        SqlCommand add = new SqlCommand("DELETE FROM NHANVIEN WHERE NHANVIENID = @ID", con);
                        add.Parameters.AddWithValue("@ID", txbIDNV.Text);
                        add.ExecuteNonQuery();
                        XtraMessageBox.Show("Xóa nhân viên thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Không tồn tại ID nhân viên!!");
                    }
                }
                DisplayData();
                con.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DataNV_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void DataNV_Click(object sender, EventArgs e)
        {
            GridView gridView = DataNV.FocusedView as GridView;
            foreach (int i in gridView.GetSelectedRows())
            {
                DataRow row = gridView.GetDataRow(i);
                txbIDNV.Text = row[0].ToString();
                txbTKNV.Text = row[1].ToString().Replace(" ", "");
                txbMKNV.Text = row[2].ToString().Replace(" ", "");
                txbHoTen.Text = row[3].ToString();
                txbSDT.Text = row[4].ToString().Replace(" ", "");
                txbDiaChi.Text = row[5].ToString();
                txbEmail.Text = row[6].ToString().Replace(" ", "");
                DateTime d = DateTime.Parse(row[7].ToString());
                DTPNgaySinh.Value = d;
                cbxCV.Text = row[8].ToString();
            }
        }
    }
}
