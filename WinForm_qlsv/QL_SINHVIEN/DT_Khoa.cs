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
    public partial class DT_KHOA : Form
    {
        public DT_KHOA()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

        private void DT_KHOA_Load(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = loaddlkhoa();
        }
        public DataTable loaddlkhoa()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("laydlkhoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try { conn.Open();
            SqlCommand cmd = new SqlCommand("themdlkhoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parma = new SqlParameter("@makhoa", txtma.Text);
                cmd.Parameters.Add(parma);
                SqlParameter parten = new SqlParameter("@tenkhoa", txtten.Text);
                cmd.Parameters.Add(parten);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("thêm thành công");
                }
                else
                {
                    MessageBox.Show("thêm không thành công");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            dgvhienthi.DataSource = loaddlkhoa();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("xoadlkhoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parma = new SqlParameter("@makhoa", txtma.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            dgvhienthi.DataSource = loaddlkhoa();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("suadlkhoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parma = new SqlParameter("@makhoa", txtma.Text);
                cmd.Parameters.Add(parma);
                SqlParameter parten = new SqlParameter("@tenkhoa", txtten.Text);
                cmd.Parameters.Add(parten);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("sửa thành công");
                }
                else
                {
                    MessageBox.Show("sửa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            dgvhienthi.DataSource = loaddlkhoa();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("timkhoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parma = new SqlParameter("@makhoa", txtmatim.Text);
                cmd.Parameters.Add(parma);
                SqlDataReader dr = cmd.ExecuteReader(); 
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvhienthi.DataSource= dt;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
         
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = loaddlkhoa();
        }

        private void dgvhienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dgvhienthi.CurrentCell.RowIndex;
            txtma.Text = dgvhienthi.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = dgvhienthi.Rows[dong].Cells[1].Value.ToString();


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
