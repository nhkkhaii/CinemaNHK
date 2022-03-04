using DevExpress.LookAndFeel;
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
    public partial class UcChonGhe : System.Windows.Forms.UserControl
    {
        public string TP = "";
        public string TPhong = "";
        public string TRap = "";
        public string GChieu = "";
        public string GiaPhim = "";
        public int GP = 0;
        public UcChonGhe()
        {
            InitializeComponent();
        }
        private static UcChonPhim _instance;
        public string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = Cinema; Integrated Security = True;";
        public SqlConnection con;     
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
        public string Gia
        {
            get { return txtTotalMoney.Text; }
        }
        public static List<SimpleButton> DanhSachChon = new List<SimpleButton>();
        public static List<string> Ghe
        {
            get
            {
                List<string> G = new List<string>();
               foreach(SimpleButton i in DanhSachChon)
                {
                    G.Add(i.Text);
                }
                return G;
            }

        }
        private void btnSeat1_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text == "")
            {
                SimpleButton btn = sender as SimpleButton;
                if (btn.Appearance.BackColor == DXSkinColors.FillColors.Success)
                {
                    btn.Appearance.BackColor = DXSkinColors.FillColors.Question;
                    
                    DanhSachChon.Add(btn);
                    txtTotalMoney.Text = ((Int32.Parse(GiaPhim) * DanhSachChon.Count).ToString()) + ".000đ";
                }
                else if (btn.Appearance.BackColor == DXSkinColors.FillColors.Question)
                {
                    btn.Appearance.BackColor = DXSkinColors.FillColors.Success;
                    DanhSachChon.Remove(btn);
                    txtTotalMoney.Text = ((Int32.Parse(GiaPhim) * DanhSachChon.Count).ToString()) + ".000đ";
                }
                else if (btn.Appearance.BackColor == DXSkinColors.FillColors.Warning)
                {
                    MessageBox.Show("Ghế đã được chọn!");
                }
            }
            else
            {
                SimpleButton btn = sender as SimpleButton;
                if (btn.Appearance.BackColor == DXSkinColors.FillColors.Success)
                {
                    btn.Appearance.BackColor = DXSkinColors.FillColors.Question;
                    DanhSachChon.Add(btn);
                    txtTotalMoney.Text = ((Int32.Parse(GiaPhim) * DanhSachChon.Count).ToString()) + ".000đ";
                }
                else if (btn.Appearance.BackColor == DXSkinColors.FillColors.Question)
                {
                    btn.Appearance.BackColor = DXSkinColors.FillColors.Success;
                    DanhSachChon.Remove(btn);
                    txtTotalMoney.Text = ((Int32.Parse(GiaPhim) * DanhSachChon.Count).ToString()) + ".000đ";
                }
                else if (btn.Appearance.BackColor == DXSkinColors.FillColors.Warning)
                {
                    MessageBox.Show("Ghế đã được chọn!");
                }
            }
        }
        List<SimpleButton> simpleButtons = new List<SimpleButton>();
        public void AddButtons()
        {
            simpleButtons.Add(btnSeat1);
            simpleButtons.Add(btnSeat2);
            simpleButtons.Add(btnSeat3);
            simpleButtons.Add(btnSeat4);
            simpleButtons.Add(btnSeat5);
            simpleButtons.Add(btnSeat6);
            simpleButtons.Add(btnSeat7);
            simpleButtons.Add(btnSeat8);
            simpleButtons.Add(btnSeat9);
            simpleButtons.Add(btnSeat10);
            simpleButtons.Add(btnSeat11);
            simpleButtons.Add(btnSeat12);
            simpleButtons.Add(btnSeat13);
            simpleButtons.Add(btnSeat14);
            simpleButtons.Add(btnSeat15);
            simpleButtons.Add(btnSeat16);
            simpleButtons.Add(btnSeat17);
            simpleButtons.Add(btnSeat18);
            simpleButtons.Add(btnSeat19);
            simpleButtons.Add(btnSeat20);
            simpleButtons.Add(btnSeat21);
            simpleButtons.Add(btnSeat22);
            simpleButtons.Add(btnSeat23);
            simpleButtons.Add(btnSeat24);
            simpleButtons.Add(btnSeat25);
            simpleButtons.Add(btnSeat26);
            simpleButtons.Add(btnSeat27);
            simpleButtons.Add(btnSeat28);
            simpleButtons.Add(btnSeat29);
            simpleButtons.Add(btnSeat30);
            simpleButtons.Add(btnSeat31);
            simpleButtons.Add(btnSeat32);
            simpleButtons.Add(btnSeat33);
            simpleButtons.Add(btnSeat34);
            simpleButtons.Add(btnSeat35);
            simpleButtons.Add(btnSeat36);
            simpleButtons.Add(btnSeat37);
            simpleButtons.Add(btnSeat38);
            simpleButtons.Add(btnSeat39);
            simpleButtons.Add(btnSeat40);
            simpleButtons.Add(btnSeat41);
            simpleButtons.Add(btnSeat42);
            simpleButtons.Add(btnSeat43);
            simpleButtons.Add(btnSeat44);
            simpleButtons.Add(btnSeat45);
            simpleButtons.Add(btnSeat46);
            simpleButtons.Add(btnSeat47);
            simpleButtons.Add(btnSeat48);
            simpleButtons.Add(btnSeat49);
            simpleButtons.Add(btnSeat50);
            simpleButtons.Add(btnSeat51);
            simpleButtons.Add(btnSeat52);
            simpleButtons.Add(btnSeat53);
            simpleButtons.Add(btnSeat54);
            simpleButtons.Add(btnSeat55);
            simpleButtons.Add(btnSeat56);
            simpleButtons.Add(btnSeat57);
            simpleButtons.Add(btnSeat58);
            simpleButtons.Add(btnSeat59);
            simpleButtons.Add(btnSeat60);
            simpleButtons.Add(btnSeat61);
            simpleButtons.Add(btnSeat62);
            simpleButtons.Add(btnSeat63);
            simpleButtons.Add(btnSeat64);
            simpleButtons.Add(btnSeat65);
            simpleButtons.Add(btnSeat66);
            simpleButtons.Add(btnSeat67);
            simpleButtons.Add(btnSeat68);
            simpleButtons.Add(btnSeat69);
            simpleButtons.Add(btnSeat70);
            simpleButtons.Add(btnSeat71);
            simpleButtons.Add(btnSeat72);
            simpleButtons.Add(btnSeat73);
            simpleButtons.Add(btnSeat74);
            simpleButtons.Add(btnSeat75);
            simpleButtons.Add(btnSeat76);
            simpleButtons.Add(btnSeat77);
            simpleButtons.Add(btnSeat78);
            simpleButtons.Add(btnSeat79);
            simpleButtons.Add(btnSeat80);
    
        }
        
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if(DanhSachChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế!");

            }
            else
            {
                ThanhToan thanhToan = new ThanhToan();
                this.Hide();
                thanhToan.ShowDialog();
            }
            
        }
        public void MakeUp(SimpleButton btn)
        {
            btn.Appearance.BackColor = DXSkinColors.FillColors.Warning;
        }
        private void UcChonGhe_Load(object sender, EventArgs e)
        {
            TP = MainView.TenPhim;
            TPhong = MainView.TenPhong;
            TRap = MainView.TenRap;
            GChieu = MainView.GioChieu;
            GiaPhim = MainView.GiaPhim.Substring(0,2);
            txtCusID.Text = Login.TENKH;
            AddButtons();
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select v.SOVE as 'Số vé',p.TENPHIM as 'Phim',tl.TENTHELOAI as 'Thể loại',p.GIAPHIM as 'Giá',p.NGAYCHIEUPHIM 'Ngày chiếu' ,sc.GIOCHIEU as 'Giờ chiếu', kh.HOTENKHACHHANG as 'Tên khách hàng', r.TENRAP as 'Tên Rạp', pc.TENPHONG as 'Phòng chiếu', g.SOGHE as 'Ghế', nv.HOTENNV as 'Nhân Viên Lập' from VE v, SUATCHIEU sc, GHE g, NHANVIEN nv, KHACHHANG kh, PHIM p, THELOAI tl, PHONGCHIEU pc, RAP r where v.KHACHHANGID = kh.KHACHHANGID and v.SUATCHIEUID = sc.SUATCHIEUID and v.SOGHEID = g.SOGHEID and v.NHANVIENID = nv.NHANVIENID and p.PHIMID = sc.PHIMID and p.THELOAIID = tl.THELOAIID and r.RAPID = pc.RAPID and sc.SUATCHIEUID = pc.SUATCHIEUID and g.PHONGCHIEUID = pc.PHONGCHIEUID and  p.PHIMID = @PID and sc.SUATCHIEUID = @SC and r.RAPID = @Rap and pc.PHONGCHIEUID = @PC", con);
            cmd.Parameters.AddWithValue("@PID", TP);
            cmd.Parameters.AddWithValue("@Rap", TRap);
            cmd.Parameters.AddWithValue("@PC", TPhong);
            cmd.Parameters.AddWithValue("@SC", GChieu);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                foreach (SimpleButton j in simpleButtons)
                {
                    if (i.ItemArray[9].ToString() == j.Text )
                    {
                        MakeUp(j);
                    }
                }
            }
            
            con.Close();

        }

        private void txtTotalMoney_TextChanged(object sender, EventArgs e)
        {
            var parent = this.ParentForm as MainView;
            parent.giaphim = Gia;
        }
    }
}
