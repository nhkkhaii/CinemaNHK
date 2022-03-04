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
    public partial class Splash : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public Splash()
        {
            InitializeComponent();
            
        }
        int starpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
      
            starpoint += 4;
            Loadform.Value = starpoint;
            if(Loadform.Value == 100)
            {
                Loadform.Value = 0;
                timer1.Stop();
                MainView frm = new MainView();
                this.Hide();
                frm.Show();
            }
        }


        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}