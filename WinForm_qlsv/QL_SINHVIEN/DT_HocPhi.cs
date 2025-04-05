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
    public partial class DT_HocPhi : Form
    {
        public DT_HocPhi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

        private void DT_HocPhi_Load(object sender, EventArgs e)
        {
          
            dgv_hp.DataSource = PrintHP();
        }


        private DataTable PrintHP()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintHP", conn);
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {        
            if (txt_masv.Text.Trim() == "" || cob_status.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ các Field!");
                return;
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateHP", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = txt_masv.Text.Trim();

                // 0 CHƯA ĐÓNG              
                if (cob_status.SelectedIndex == 0) 
                {
                    lbl_totalHP.Text = "";
                    cmd.Parameters.Add("@dateSubmit", SqlDbType.Date).Value = DBNull.Value;
                    cmd.Parameters.Add("@totalHP", SqlDbType.Float).Value = DBNull.Value;
                }
                else 
                { 
                    // 1 LÀ ĐÃ ĐÓNG
                    if(!float.TryParse(lbl_totalHP.Text, out float totalHP))
                    {
                        MessageBox.Show("Vui lòng tính học phí");
                        return;
                    }
                    cmd.Parameters.Add("@dateSubmit", SqlDbType.Date).Value = dtp_date_dong.Value; 
                    cmd.Parameters.Add("@totalHP", SqlDbType.Float).Value = totalHP; // Chuyển đổi thành công
                }


                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = cob_status.Text.Trim();




                SqlParameter sql = cmd.Parameters.Add("@result", SqlDbType.Int);
                sql.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                var result = (int)sql.Value;

                if (result == -1)
                {

                    MessageBox.Show("Cập nhật không thành công!");
                }
                else if(result == 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }


            dgv_hp.DataSource = PrintHP();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {

            if (txt_findSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần tìm!");
                return;
            }

            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("FindSVMaID", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = txt_findSV.Text.Trim();
                cmd.Parameters.Add("@class_name", SqlDbType.NVarChar).Value = lab_class.Text.Trim();


                SqlParameter sql = cmd.Parameters.Add("@result", SqlDbType.Int);
                sql.Direction = ParameterDirection.ReturnValue;


                cmd.ExecuteNonQuery();


                var result = (int)sql.Value;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);



                if (result == -1)
                {
                    MessageBox.Show("Mã Sinh Viên Không tồn tại!");
                    dgv_hp.DataSource = null;
                }
                else
                {
                    dgv_hp.DataSource = dt;
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

        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            dgv_hp.DataSource = PrintHP();
        }


        private void btn_theoten_Click(object sender, EventArgs e)
        {
            if (txt_findSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần tìm!");
                return;
            }
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("FindSVByName", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@namSV", SqlDbType.NVarChar).Value = txt_findSV.Text.Trim();


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgv_hp.DataSource = dt;
                }
                else
                {
                    dgv_hp.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void dgv_hp_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_hp.CurrentCell.RowIndex;
                var row = dgv_hp.Rows[dong].Cells;

                txt_masv.Text = row[1].Value.ToString().Trim();
            }
            catch
            {

            }
        }

        private void txt_masv_TextChanged(object sender, EventArgs e)
        {
            txt_masv.Text = txt_masv.Text.Trim().ToUpper();
            txt_masv.SelectionStart = txt_masv.Text.Length;
        }

        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Giang Viên có muốn thoát không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private DataTable GetAllSVChuaDongHP()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllSVChuaDongHP", conn);
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

        private DataTable GetAllSVDaDongHP()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllSVDaDongHP", conn);
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

        private void btn_chuaNopHP_Click(object sender, EventArgs e)
        {
            dgv_hp.DataSource = GetAllSVChuaDongHP();
        }

        private void btn_daNopHP_Click(object sender, EventArgs e)
        {
            dgv_hp.DataSource = GetAllSVDaDongHP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_hp.DataSource = PrintHP();
        }

        private DataTable TotalHP()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("TotalHP", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV",SqlDbType.Char).Value = txt_masv.Text.Trim();
                
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

        private void btn_tinhHP_Click(object sender, EventArgs e)
        {
            DataTable dt = TotalHP();
            if (dt.Rows.Count > 0)
            {
                lbl_totalHP.Text = dt.Rows[0]["TOTALHP"].ToString(); // Lấy giá trị TotalHP từ cột
            }
            else
            {
                lbl_totalHP.Text = "0"; // Hiển thị 0 nếu không có dữ liệu
            }
        }

        private void lbl_totalHP_Click(object sender, EventArgs e)
        {
            
        }
    }
}
