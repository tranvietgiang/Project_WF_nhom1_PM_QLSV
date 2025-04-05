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
    public partial class DT_MENU : Form
    {
        public DT_MENU()
        {
            InitializeComponent();
        }

        private void đIEToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DT_HocPhi sv = new DT_HocPhi();
            sv.MdiParent = this;
            sv.Show();

        }

        private void quảnLíKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT_KHOA sv = new DT_KHOA();
            sv.MdiParent = this;
            sv.Show();
        }

      

        

        private void quảnLíNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT_NGANH sv = new DT_NGANH();
            sv.MdiParent = this;
            sv.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT_SinhVien sv = new DT_SinhVien();
            sv.MdiParent = this;
            sv.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT_THONGKE sv = new DT_THONGKE();
            sv.MdiParent = this;
            sv.Show();
        }

        private void DT_MENU_Load(object sender, EventArgs e)
        {
           
        }

        private void danhSáchSinhViênCủaTrườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DT_baocaodanhsanhsinhvien sv = new DT_baocaodanhsanhsinhvien();
            //sv.MdiParent = this;
            //sv.Show();
        }

        private void thôngTin1SinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DT_thongtin1sv sv = new DT_thongtin1sv();
            //sv.MdiParent = this;
            //sv.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
