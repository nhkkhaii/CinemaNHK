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
    public partial class UcHome : DevExpress.XtraEditors.XtraUserControl
    {
        public UcHome()
        {
            InitializeComponent();
        }
        private static UcHome _instance;
        public static UcHome Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcHome();
                }
                return _instance;
            }
        }
    }
}
