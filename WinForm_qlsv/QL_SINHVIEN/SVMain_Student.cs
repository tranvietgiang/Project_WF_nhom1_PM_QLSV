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
    public partial class SVMain_Student : Form
    {
        public SVMain_Student()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn đăng xuất không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                new Login_TDC().Show();
                this.Hide();
            }
        }

        private void QLSV_Student_Load(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Label label) // Kiểm tra nếu control là Label
                {
                    control.MouseEnter += Control_MouseEnter;
                    control.MouseLeave += Control_MouseLeave;
                }
            }

            // này là chỉ cần để trong panl là nó sẽ được kích hoạt hết
            //foreach (Control control in this.Controls) // 'this.Controls' để lấy tất cả các control trong Form
            //{
            //    if (control is Panel panel) // Kiểm tra nếu control là Panel
            //    {
            //        foreach (Control innerControl in panel.Controls) // Duyệt qua các control bên trong Panel
            //        {
            //            if (innerControl is Label label) // Kiểm tra nếu control là Label
            //            {
            //                label.MouseEnter += Control_MouseEnter;
            //                label.MouseLeave += Control_MouseLeave;
            //            }
            //        }
            //    }
            //}

            foreach (Control control in panel3.Controls)
            {
                if (control is Label label) // Kiểm tra nếu control là Label
                {

                    control.MouseEnter += Control_MouseEnter_panl_4;
                    control.MouseLeave += Control_MouseLeave_panl_4;
                }
            }

        }


        private void Control_MouseEnter_panl_4(object sender, EventArgs e)
        {
            Label label = sender as Label;  // Chuyển đổi sender về Label
            label.ForeColor = HexToColor("#ff6600"); // Đổi màu chữ khi hover
            this.Cursor = Cursors.Hand; // Thay đổi con trỏ chuột thành hình bàn tay
        }

        // Khi chuột rời khỏi Label
        private void Control_MouseLeave_panl_4(object sender, EventArgs e)
        {
            Label label = sender as Label;  // Chuyển đổi sender về Label
            label.ForeColor = HexToColor("#00649D"); // Khôi phục lại màu chữ ban đầu (hoặc bạn có thể thay thế bằng màu khác)
            this.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
        }


        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;  // Chuyển đổi sender về Label
            label.ForeColor = HexToColor("#ff6600"); // Đổi màu chữ khi hover
            this.Cursor = Cursors.Hand; // Thay đổi con trỏ chuột thành hình bàn tay
        }

        // Khi chuột rời khỏi Label
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;  // Chuyển đổi sender về Label
            label.ForeColor = Color.White; // Khôi phục lại màu chữ ban đầu (hoặc bạn có thể thay thế bằng màu khác)
            this.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
        }

        // Hàm chuyển đổi mã màu hex thành Color
        private Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            new SV_Dang_ky_hoc_phan().Show(); this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            new SV_XemTKB().Show(); this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            new SV_Diem().Show(); this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            new SV_vi_pham().Show(); this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new SV_thongtinsinhvien().Show(); this.Hide();
        }
    }
}
