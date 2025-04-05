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
    public partial class GV_SinhVien : Form
    {
        public GV_SinhVien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

        private void GV_SinhVien_Load(object sender, EventArgs e)
        {
            dgv_students.DataSource = Load_SV();
            cob_masv.DataSource = GetAllSVGVDIEM();
            cob_masv.DisplayMember = "FULLNAME";
            cob_masv.ValueMember = "STUDENT_ID";
        }

        private DataTable GetAllSVGVDIEM()
        {

           
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllSVGVDIEM", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        private DataTable Load_SV()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                return dt;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return null;
        }



        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có quay lại không!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("FindSVGV", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@masv", SqlDbType.Char).Value = cob_masv.SelectedValue;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                SqlParameter sql = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                sql.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                var result = (int)sql.Value;

                if (result == 0)
                {
                    dgv_students.DataSource = dt;
                  
                }
                else
                {
                    dgv_students.DataSource = null;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_students.DataSource = Load_SV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
