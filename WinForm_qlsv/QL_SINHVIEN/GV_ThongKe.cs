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
    public partial class GV_ThongKe : Form
    {
        public GV_ThongKe()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");


        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
           
                this.Hide();
            }
        }

      

        private void GV_ThongKe_Load(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = sinhvientronglop();
        }

        private void dgv_thongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataTable dlsinhviendau()
        {
            DataTable dt = new DataTable();
            try {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sinhviendauCA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
        public DataTable sinhvientronglop()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sinhvientronglopCA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
        public DataTable dlsinhvienkodau()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sinhvienkodauCA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = dlsinhvienkodau();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = dlsinhviendau();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = sinhviennam();
        }
        public DataTable sinhviennam()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sinhviennamCA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            return dt;
        }
        public DataTable sinhviennu()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sinhviennuCA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            return dt;
        }

        private void btnnu_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = sinhviennu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("timsvtronglopCA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parma = new SqlParameter("@tensv", txtmatim.Text);
                cmd.Parameters.Add(parma);
                SqlDataReader read = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                dgvhienthi.DataSource = dt;
            }
            catch { }
            finally { conn.Close(); }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = sinhvientronglop();
        }
    }
}
