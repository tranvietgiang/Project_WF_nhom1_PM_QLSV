using DOAN1_LTUD;
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
    public partial class SV_Dang_ky_hoc_phan : Form
    {
        public SV_Dang_ky_hoc_phan()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

        
        private void Đang_ky_hoc_phan_Load(object sender, EventArgs e)
        {

            
            dgv_dk.DataSource = PrintDangKyHP();

            hover_change_color();
            cob_name_major.SelectedIndex = 0;

        }
        // này là chỉ cần để trong panl là nó sẽ được kích hoạt hết
        private void hover_change_color()
        {
            foreach (Control control in this.Controls) // 'this.Controls' để lấy tất cả các control trong Form
            {
                if (control is Panel panel) // Kiểm tra nếu control là Panel
                {
                    foreach (Control innerControl in panel.Controls) // Duyệt qua các control bên trong Panel
                    {
                        if (innerControl is Label label) // Kiểm tra nếu control là Label
                        {
                            label.MouseEnter += Control_MouseEnter;
                            label.MouseLeave += Control_MouseLeave;
                        }
                    }
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
            label.ForeColor = Color.White; // Khôi phục lại màu chữ ban đầu (hoặc bạn có thể thay thế bằng màu khác)
            this.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
        }
        private Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new SVMain_Student().Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private DataTable PrintDangKyHP()
        {
            dgv_dk.ForeColor = Color.Black; // Đặt màu chữ
            dgv_dk.BackgroundColor = Color.White; // Đặt màu nền (nếu cần)
            dgv_dk.DefaultCellStyle.ForeColor = Color.Black; // Đặt màu chữ cho ô
            dgv_dk.DefaultCellStyle.BackColor = Color.White; // Đặt màu nền cho ô
            DataTable dt = new  DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintDangKyHP", conn);

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
    }
}
