using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CinemaNHK
{
    public partial class Inve : DevExpress.XtraReports.UI.XtraReport
    {
        public Inve()
        {
            InitializeComponent();
        }
        public void InitData(int SOVE, string TenPhim, string TenRap, string TenNv, string TenKH, DateTime NgayChieu, string GioChieu, string TenPhong, string GheNgoi, string GiaVe)
        {
            pSove.Value = SOVE;
            pTenPhim.Value = TenPhim;
            pTenRap.Value = TenRap;
            pGheNgoi.Value = GheNgoi;
            pTenPhong.Value = TenPhong;
            pTKH.Value = TenKH;
            pTNV.Value = TenNv;
            pGiochieu.Value = GioChieu;
            pGiaVe.Value = GiaVe;
            pNgaychieu.Value = NgayChieu;
        }
    }
}
