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
    public partial class SV_Diem : Form
    {
        public SV_Diem()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");


        private void SV_Diem_Load(object sender, EventArgs e)
        {

            //loda table
            dgv_score.DataSource = Load_Socre();
            // load display
            cob_name_major.SelectedIndex = 0;
            cob_hk.SelectedIndex = 2;
            cob_namhoc.SelectedIndex = 0;

            // này là chỉ cần để trong panl là nó sẽ được kích hoạt hết
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

        private DataTable Load_Socre()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintSocre", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

                sqlData.Fill(dt);
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
            label.ForeColor = HexToColor("0, 100, 157"); // Khôi phục lại màu chữ ban đầu (hoặc bạn có thể thay thế bằng màu khác)
            this.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
        }
        // Hàm chuyển đổi mã màu hex thành Color
        private Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có quay lại không!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                new SVMain_Student().Show(); this.Hide();
            }
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
