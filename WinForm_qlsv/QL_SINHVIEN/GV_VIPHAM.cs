using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DOAN1_LTUD;

namespace Login
{
    public partial class GV_VIPHAM : Form
    {
        public GV_VIPHAM()
        {
            InitializeComponent();
        }
        SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

       
        private void GV_VIPHAM_Load(object sender, EventArgs e)
        {
            dgv_violation.DataSource = PrintViolatesv();

            //
            cob_mssv.DataSource = PrintSV();
            cob_mssv.DisplayMember = "FULLNAME";
            cob_mssv.ValueMember = "STUDENT_ID";

            //
            cob_mamh.DataSource = PrintMH();
            cob_mamh.DisplayMember = "NAME_ST";
            cob_mamh.ValueMember = "SUBJECT_ID";

        }

        private DataTable PrintViolatesv()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("PrintViPham", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        private DataTable PrintSV()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("PrintSVByCD23TT9", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }


        private DataTable PrintMH()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();
                    
                SqlCommand cmd = new SqlCommand("GetAllMonHocByCD23TT9", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txt_mavp.Text.Trim() == "" || cob_vipham.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập mã lỗi or tên lỗi");
                return;
            }
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("AddViolation", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@mavp", SqlDbType.Char).Value = txt_mavp.Text.Trim().ToUpper();
                cmd.Parameters.Add("@violation_name", SqlDbType.NVarChar).Value = cob_vipham.SelectedIndex;
                cmd.Parameters.Add("@masv", SqlDbType.Char).Value = cob_mssv.SelectedValue;
                cmd.Parameters.Add("@mamh", SqlDbType.Char).Value = cob_mamh.SelectedValue;

                SqlParameter sql = cmd.Parameters.Add("@result", SqlDbType.Int);
                sql.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();

                var result = (int)sql.Value;

                if (result == -1)
                {
                    MessageBox.Show("Mã Vi Phạm đã tồn tại!");
                }
                else if (result == 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }
            dgv_violation.DataSource = PrintViolatesv();
        }

        private void txt_mavp_TextChanged(object sender, EventArgs e)
        {
            txt_mavp.Text.ToUpper();
        }

        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có quay lại không!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CThi_Click(object sender, EventArgs e)
        {
            dgv_violation.DataSource = DSSVCamThi();
        }

        private DataTable DSSVCamThi()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("DSSVCamThi", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_violation.DataSource = PrintViolatesv();
        }

        private void btnChuViPham_Click(object sender, EventArgs e)
        {
            dgv_violation.DataSource = DSSVChuaViPham();

        }


        private DataTable DSSVChuaViPham()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("DSSVChuaViPham", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        private void btnSVCLASSCD23TT9_Click(object sender, EventArgs e)
        {
            dgv_violation.DataSource = PrintSVByCD23TT9();

        }

        private DataTable PrintSVByCD23TT9()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("PrintSVByCD23TT9", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            dgv_violation.DataSource = DetailViPham();

        }


        private DataTable DetailViPham()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("DetailViPham", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = cob_mssv.SelectedValue;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }
    }
}
