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
    public partial class DT_NGANH : Form
    {
        public DT_NGANH()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DT_KHOA_Load(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = PrintNganh();
            cbbmagv.DataSource = GetAllKhoa();
            cbbmagv.DisplayMember = "NAME_FY";
            cbbmagv.ValueMember = "FACULTY_ID";

       
        }
        public DataTable GetAllKhoa()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintKhoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch { }
            finally { conn.Close(); }


            return null;
        }

        public DataTable PrintNganh()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open(); 
            SqlCommand cmd = new SqlCommand("PrintNganh", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
            }
            catch { }
            finally { conn.Close(); }


            return null;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtma.Text) || string.IsNullOrWhiteSpace(txtten.Text) || cbbmagv.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return; // Dừng thực hiện nếu có trường không hợp lệ
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("themnganh", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parma = new SqlParameter("@manganh", txtma.Text);
                cmd.Parameters.Add(parma);
                SqlParameter parten = new SqlParameter("@tennganh", txtten.Text);
                cmd.Parameters.Add(parten);
                SqlParameter parmagv = new SqlParameter("@magv", cbbmagv.SelectedValue);
                cmd.Parameters.Add(parmagv);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Cập nhật DataGridView
            dgvhienthi.DataSource = PrintNganh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn có muốn xóa không", "thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {


                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("xoanganh", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parma = new SqlParameter("@manganh", txtma.Text);
                    cmd.Parameters.Add(parma);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("xóa thành công");

                    }
                    else
                    {
                        MessageBox.Show("xóa không thành công");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
                dgvhienthi.DataSource = PrintNganh();
            }
        }

        private void dgvhienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong  = dgvhienthi.CurrentCell.RowIndex;
            txtma.Text = dgvhienthi.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = dgvhienthi.Rows[dong].Cells[1].Value.ToString();
            cbbmagv.SelectedValue = dgvhienthi.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtma.Text) || string.IsNullOrWhiteSpace(txtten.Text) || cbbmagv.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return; // Dừng thực hiện nếu có trường không hợp lệ
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("suanganh", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parma = new SqlParameter("@manganh", txtma.Text);
                cmd.Parameters.Add(parma);
                SqlParameter parten = new SqlParameter("@tennganh", txtten.Text);
                cmd.Parameters.Add(parten);
                SqlParameter parmagv = new SqlParameter("@magv", cbbmagv.SelectedValue);
                cmd.Parameters.Add(parmagv);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Cập nhật DataGridView
            dgvhienthi.DataSource = PrintNganh();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlCommand cmd = new SqlCommand("timnganhtheoma", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parma = new SqlParameter("@manganh", txtmatim.Text);
                cmd.Parameters.Add(parma);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgvhienthi.DataSource = dt;
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            
        }

    
      

        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}
