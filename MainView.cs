using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CinemaNHK
{
    public partial class MainView : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        private UserControl currentControl;
        public static string TenPhim;
        public static string TenRap;
        public static string TenPhong;
        public static string GioChieu;
        public static string Gia;
        public static string GiaPhim;
        public string giaphim
        {
            set { Gia = value; }
        }
        public string GP
        {
            set { GiaPhim = value; }
        }
        public string tenphim
        {
            set { TenPhim = value; }
        }
        public string tenphong
        {
            set { TenPhong = value; }
        }
        public string tenrap
        {
            set { TenRap = value; }
        }
        public string giochieu
        {
            set { GioChieu = value; }
        }
        Login frmLogin = new Login();
        ChangePass frmchangePass = new ChangePass();
        DangKy frmdangky = new DangKy();
     
        public void ChangeControl(UserControl newControl)
        {
            if (newControl == null)
            {
                throw new ArgumentNullException("newControl");
            }
            if (currentControl != null)
            {
                fdfContainer.Controls.Remove(currentControl);
            }
            fdfContainer.Controls.Add(newControl);
            currentControl = newControl;
        }
        public void ShowHomePage()
        {
            // You could use a previously created control
            this.ChangeControl(new UcChonGhe());
            // Or create a new one.
            // this.ChangeControl(new HomePageControl());
        }
        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            timer1.Start();
            AddPage(UcHome.Instance);
        }
        /// <summary>
        /// Dùng để gọi một UserControl và add vào Fluent Desigh
        /// </summary>
        /// <param name="userControl"></param>
        public void AddPage(UserControl userControl)
        {
            //Kiểm tra xem trong Fluent Desigh còn controls nào không
            while (fdfContainer.Controls.Count > 0)
            {
                //Nếu còn thì remove hết
                fdfContainer.Controls.RemoveAt(0);
            }
            //Thêm usercontrol vào Fluent Desigh
            fdfContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
        /// <summary>
        /// Dùng để thêm một Control dạng "Form" vào Fluent Desigh
        /// </summary>
        /// <param name="Child"></param>
 
        private void aceLogin_Click(object sender, EventArgs e)
        {
            //Nếu cờ đăng nhập là "false" thì khi click vào sẽ hiển thị form đăng nhập
            if (frmLogin.flag == false)
            {
                this.Hide();
                frmLogin.ShowDialog();
                this.Show();
            }
            //Nếu cờ đăng nhập là "true" thì khi click vào sẽ hiển thị bảng thông tin người dùng
            else
            {
                AddPage(UcInFoAccount.Instance);
            }
        }

        private void aceHome_Click(object sender, EventArgs e)
        {
            AddPage(UcHome.Instance);
        }

        private void aceChangepass_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmchangePass.ShowDialog();
            this.Show();
        }

        private void aceRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdangky.ShowDialog();
            this.Show();
        }

        private void aceInfo_Click(object sender, EventArgs e)
        {
            AddPage(UcInFoAccount.Instance);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Kiểm tra xem "cờ" đăng nhập đã được mở hay chưa
            //Nếu đã được mở thì Enable toàn bộ chức năng có thể dùng theo phân quyền
            if (frmLogin.flag == true && frmLogin.ID == 1)
            {
                aceDichVu.Enabled = true;
                aceInfo.Enabled = true;
                aceChangepass.Enabled = true;
                bsiName.Caption = Login.TENKH;
                aceDashBoard.Enabled = false;
                aceNV.Enabled = false;
                acePhim.Enabled = false;
                aceVe.Enabled = false;
                aceSuatChieu.Enabled = false;
                acePhongChieu.Enabled = false;
            }
            else if (frmLogin.flag == true && frmLogin.ID == 2 && Login.TENKH == "Admin")
            {
                aceDichVu.Enabled = true;
                aceInfo.Enabled = true;
                aceChangepass.Enabled = true;
                bsiName.Caption = Login.TENKH;
                aceDashBoard.Enabled = true;
                aceNV.Enabled = true;
                acePhim.Enabled = true;
                aceVe.Enabled = true;
                aceSuatChieu.Enabled = true;
                acePhongChieu.Enabled = true;
            }
            else if (frmLogin.flag == true && frmLogin.ID == 2 )
            {
                aceDichVu.Enabled = true;
                aceInfo.Enabled = true;
                aceChangepass.Enabled = false;
                bsiName.Caption = Login.TENKH;
                aceDashBoard.Enabled = true;
                aceNV.Enabled = false;
                acePhim.Enabled = false;
                aceVe.Enabled = true;
                aceSuatChieu.Enabled = false;
                acePhongChieu.Enabled = false;
            }
            //Nếu không thì sẽ disable tất cả chức năng trừ "Home" và "Log In"
            else
            {
                aceRegister.Enabled = true;
                aceDichVu.Enabled = false;
                aceInfo.Enabled = false;
                aceChangepass.Enabled = false;
                bsiName.Caption = "";
                aceDashBoard.Enabled = false;
                aceNV.Enabled = false;
                acePhim.Enabled = false;
                aceVe.Enabled = false;
                aceSuatChieu.Enabled = false;
                acePhongChieu.Enabled = false;
            }
        }

        private void aceDichVu_Click(object sender, EventArgs e)
        {
            AddPage(UcChonPhim.Instance);
        }

        private void aceNV_Click(object sender, EventArgs e)
        {
            AddPage(UcThemNV.Instance);
        }

        private void acePhim_Click(object sender, EventArgs e)
        {
            AddPage(UcAddPhim.Instance);
        }

        private void aceVe_Click(object sender, EventArgs e)
        {
            AddPage(UcVe.Instance);
        }

        private void aceSuatChieu_Click(object sender, EventArgs e)
        {
            AddPage(UcSuatChieu.Instance);
        }

        private void acePhongChieu_Click(object sender, EventArgs e)
        {
            AddPage(UcThemPhongChieu.Instance);

        }
    }
}
