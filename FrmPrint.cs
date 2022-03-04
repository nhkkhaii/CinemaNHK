using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CinemaNHK
{
    public partial class FrmPrint : DevExpress.XtraEditors.XtraForm
    {
        public FrmPrint()
        {
            InitializeComponent();
        }
        public void PrintHoaDon(int SOVE, string TenPhim, string TenRap, string TenNv, string TenKH, DateTime NgayChieu, string GioChieu, string TenPhong, string GheNgoi, string GiaVe)
        {
            Inve report = new Inve();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(SOVE, TenPhim, TenRap, TenNv, TenKH, NgayChieu, GioChieu, TenPhong, GheNgoi, GiaVe);
            docViewTicket.DocumentSource = report;
            report.CreateDocument();
        }
    }
}