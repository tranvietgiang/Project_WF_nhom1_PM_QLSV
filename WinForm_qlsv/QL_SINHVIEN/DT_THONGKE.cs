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

namespace Login
{
    public partial class DT_THONGKE : Form
    {
        public DT_THONGKE()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

        private void DT_THONGKE_Load(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = loadsv();
        }
        public DataTable loadsv()
        {
            DataTable dt = new DataTable();
            try {
            conn.Open();
                SqlCommand cmd = new SqlCommand("PrintSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);    
                da.Fill(dt);

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
        public DataTable tongsinhvien()
        {
            DataTable dt = new DataTable();
            try { 
              conn.Open();
                SqlCommand cmd = new SqlCommand("totalsinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                
            }
            catch(Exception ex){ MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            return dt;
        }
        public DataTable tongsv()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("tongsv", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            return dt;
        }







        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = tongsinhvien();
        }
      


        private void button3_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = loadsv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = tongsv();
        }
    }
}
