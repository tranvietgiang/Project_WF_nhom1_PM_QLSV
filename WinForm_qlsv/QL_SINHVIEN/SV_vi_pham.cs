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

namespace Login
{
    public partial class SV_vi_pham : Form
    {
        public SV_vi_pham()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");


        private void QLSV_vi_pham_Load(object sender, EventArgs e)
        {
            dgv_vipham.DataSource =  PrintViPhamByIDSV();

            foreach (Control control in panel5.Controls)
            {
                if (control is Label label) // Kiểm tra nếu control là Label
                {
                    control.MouseEnter += Control_MouseEnter;
                    control.MouseLeave += Control_MouseLeave;
                }
            }
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
            label.ForeColor = HexToColor("#00649D"); // Đổi màu chữ khi hover
            this.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
        }

        // Hàm chuyển đổi mã màu hex thành Color
        private Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }
        private DataTable PrintViPhamByIDSV()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintViPhamByIDSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            new SVMain_Student().Show();this.Hide();    
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new SV_Dang_ky_hoc_phan().Show(); this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
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
    }
}
