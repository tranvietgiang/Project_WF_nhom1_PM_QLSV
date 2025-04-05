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
    //DESKTOP-NHFTJ6H
    public partial class Login_TDC : Form
    {
        public Login_TDC()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");
        
        private void txtquenmatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Login_main_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string tk = txt_username.Text;
                string mk = txt_password.Text;
                if (rdisinhvien.Checked)
                {
                    string sql = "SELECT * FROM USERS WHERE ID='" + tk + "' AND PASSWORDS = HASHBYTES('SHA2_256', N'"+ mk+ "') AND ROTE='sinh vien'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        new SVMain_Student().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mssv hoặc mật khẩu không đúng ");
                    }
                }
                else if (rdigiangvien.Checked)
                {
                    string sql = "select * from USERS WHERE ID='" + tk + "' AND PASSWORDS = HASHBYTES('SHA2_256', N'" + mk + "') AND ROTE='giang vien'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        new MENU_GV_SystemMenu().Show();
                    }
                    else
                    {
                        MessageBox.Show("Msgv hoặc mật khẩu không đúng ");
                    }
                }else if (ridbanlanhdao.Checked)
                {
                    string sql = "select * from USERS WHERE ID='" + tk + "' AND PASSWORDS = HASHBYTES('SHA2_256', N'" + mk + "') AND ROTE='Ban lanh dao'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        new DT_MENU().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("bld hoặc mật khẩu không đúng ");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Login_TDC_Load(object sender, EventArgs e)
        {
            rdigiangvien.Checked = true;
            txt_password.PasswordChar = '●';

            foreach (Control control in panel2.Controls)
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
            label.ForeColor = Color.White; // Khôi phục lại màu chữ ban đầu (hoặc bạn có thể thay thế bằng màu khác)
            this.Cursor = Cursors.Default; // Trả lại con trỏ chuột mặc định
        }
        // Hàm chuyển đổi mã màu hex thành Color
        private Color HexToColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }
        bool isPasswordVisible = false;
        private void pik_checkbox_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txt_password.PasswordChar = '●';
                pik_checkbox.Image = Image.FromFile(@"D:\\G I A N G\\Project_LTUD_QLSV\\image\\show_not.png");
            }

            else
            {
                txt_password.PasswordChar = '\0';


                pik_checkbox.Image = Image.FromFile(@"D:\\G I A N G\Project_LTUD_QLSV\image\\eye_show.png");
            }

            isPasswordVisible = !isPasswordVisible;
        }
    }
}
