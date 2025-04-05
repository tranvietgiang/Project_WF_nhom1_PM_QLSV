using Login;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DOAN1_LTUD
{


    public partial class GV_DIEM : Form
    {

       
        public GV_DIEM()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

      


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
        
      


        private DataTable GetSortSV()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetSortSV", conn);
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
        
        private DataTable GetDTBSV()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetDTBSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = cob_masv.SelectedValue;

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
        
        private DataTable GetDetailSV()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetDetailSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = cob_masv.SelectedValue;

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


        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
               this.Close();
            }
        }
    
        private void DIEM_GV_Load(object sender, EventArgs e)
        {
            dgv_score.DataSource = GetAllSVGVDIEM();


            cob_masv.DataSource = GetAllSVGVDIEM();
            cob_masv.DisplayMember = "FULLNAME";
            cob_masv.ValueMember = "STUDENT_ID";

            cob_massv.DataSource = GetAllSVGVDIEM();
            cob_massv.DisplayMember = "STUDENT_ID";

            lab_mssv.Text = cob_masv.SelectedValue.ToString();

            cob_masv.SelectedIndexChanged += Cob_masv_SelectedIndexChanged;

        }



        private void Cob_masv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab_mssv.Text = cob_masv.SelectedValue.ToString();
        }






        private void btn_find_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            dgv_score.DataSource =  GetSortSV();
        }

        private void btn_average_Click(object sender, EventArgs e)
        {
            dgv_score.DataSource =  GetDTBSV();
        }

        private void btn_detail_sroce_Click(object sender, EventArgs e)
        {
            dgv_score.DataSource =  GetDetailSV();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
             DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("FindSVCuoi", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = cob_masv.SelectedValue;

                cmd.ExecuteNonQuery();
                SqlDataAdapter dgv = new SqlDataAdapter(cmd);

                dgv.Fill(dt);


                if (dt.Rows.Count > 0)
                {

                    dgv_score.DataSource = dt;
                }
                else
                {
                    dgv_score.DataSource = null;
                }

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_xemsv_Click(object sender, EventArgs e)
        {
            dgv_score.DataSource = GetAllSVGVDIEM();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lab_mssv_Click(object sender, EventArgs e)
        {
            dgv_score.DataSource = GetAllSVGVDIEM();
        }
    }
}
