using DOAN1_LTUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MENU_GV_SystemMenu : Form
    {
        public MENU_GV_SystemMenu()
        {
            InitializeComponent();
        }

        private void viPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV_VIPHAM vp = new GV_VIPHAM();
            vp.MdiParent = this;
            vp.Show();
        }

        private void chiTiếtSVViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT_BC_GV_VIPHAM sv = new RPT_BC_GV_VIPHAM();
            sv.MdiParent = this;
            sv.Show();
        }

        private void aLLSVViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPT_BaoCao_SVVP sv = new RPT_BaoCao_SVVP();
            sv.MdiParent = this;
            sv.Show();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV_DIEM sv = new GV_DIEM();
            sv.MdiParent = this;
            sv.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV_SinhVien sv = new GV_SinhVien();
            sv.MdiParent = this;
            sv.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV_CLASS sv = new GV_CLASS();
            sv.MdiParent = this;
            sv.Show();
        }
    }
}
