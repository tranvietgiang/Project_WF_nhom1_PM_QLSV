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
    public partial class DT_SinhVien : Form
    {
        public DT_SinhVien()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");
        private void GV_SinhVien_Load(object sender, EventArgs e)
        {
            // in ra dữ liệu 
            DisPlayCacThamChieuSV();
            // in ra sv
            dgv_student.DataSource = Load_SV();

        }
        // Check Input user 
        private bool CheckInput()
        {
            var check = new Control[] { txt_studentID, txt_student_name, txt_email, mask_phone, txt_address };
            if (check.Any(it => it.Text == ""))
            {
                return true;
            }

            return false;
        }
        private void DisPlayCacThamChieuSV()
        {
            //Khoa
            cobKhoa.DataSource = PrintKhoa();
            cobKhoa.DisplayMember = "NAME_FY";
            cobKhoa.ValueMember = "FACULTY_ID";

            //Nganh
            cobNganh.DataSource = PrintNganh();
            cobNganh.DisplayMember = "MAJOR_NAME";
            cobNganh.ValueMember = "MAJOR_ID";

            //Lớp
            cob_class.DataSource = PrintLop();
            cob_class.DisplayMember = "CLASS_NAME";
            cob_class.ValueMember = "CLASS_NAME";

        }

        // get data khoa
        private DataTable PrintKhoa()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintKhoa", conn);
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

        //Get data nganh
        private DataTable PrintNganh()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintMajor", conn);
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

        //Get data nganh
        private DataTable PrintLop()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintLop", conn);
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

        // sinh vien
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
        
        private DataTable PrintSVCD23TT4()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintSVCD23TT4", conn);
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
        private DataTable PrintSVCD23TT10()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintSVCD23TT10", conn);
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
        
        private DataTable PrintSVCD23TT7()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintSVCD23TT7", conn);
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
        
        private DataTable PrintSVCD23TT9()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("PrintSVCD23TT9", conn);
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



        private void dgv_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int dong = dgv_student.CurrentCell.RowIndex;

                var row = dgv_student.Rows[dong].Cells;

                txt_studentID.Text = row[0].Value.ToString().Trim();
                txt_student_name.Text = row[1].Value.ToString().Trim();

                //handle gender
                //process
                //radNam.Checked = dgv_student.Rows[dong].Cells[2].Value.ToString() == "Nam";
                radNam.Checked = row[2].Value.ToString().Trim() == "NAM";
                radNu.Checked = !radNam.Checked;

                txt_email.Text = row[3].Value.ToString().Trim();
                mask_phone.Text = row[4].Value.ToString().Trim();
                txt_address.Text = row[5].Value.ToString().Trim();
                dtpNS.Text = row[6].Value.ToString().Trim();
                cobKhoa.SelectedValue = row[7].Value.ToString().Trim();
                cobNganh.SelectedValue = row[8].Value.ToString().Trim();
                cob_class.SelectedValue = row[9].Value.ToString().Trim();


            }
            catch
            {

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!");
                return;
            }

            try
            {
                conn.Open();
                string gender = "";
                SqlCommand cmd = new SqlCommand("AddSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = txt_studentID.Text.Trim();
                cmd.Parameters.Add("@nameSV", SqlDbType.NVarChar).Value = txt_student_name.Text.Trim();

                // xử lý thêm gới tính
                if (radNam.Checked == true)
                {
                    gender = "NAM";
                }
                else
                {
                    gender = "NỮ";
                }
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender.Trim();
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txt_email.Text.Trim();
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = mask_phone.Text.Trim();
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = txt_address.Text.Trim();
                cmd.Parameters.Add("@ngayS", SqlDbType.Date).Value = dtpNS.Value;
                cmd.Parameters.Add("@maKH", SqlDbType.Char).Value = cobKhoa.SelectedValue;
                cmd.Parameters.Add("@maNganh", SqlDbType.Char).Value = cobNganh.SelectedValue;
                cmd.Parameters.Add("@class_name", SqlDbType.NVarChar).Value = cob_class.SelectedValue;

                SqlParameter result = cmd.Parameters.Add("@ReturnSo", SqlDbType.Int);
                result.Direction = ParameterDirection.ReturnValue;

                // excute query
                cmd.ExecuteNonQuery();

                int check = (int)result.Value;

                switch (check)
                {
                    case -1:
                        MessageBox.Show("Sinh Viên này đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case -2:
                        MessageBox.Show("EmailTdc phai la duy nhat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 0:
                        MessageBox.Show("Thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            dgv_student.DataSource = Load_SV();
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            txt_studentID.ResetText();
            txt_student_name.ResetText();
            txt_email.ResetText();
            mask_phone.ResetText();
            txt_address.ResetText();


            dgv_student.DataSource = Load_SV();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (txt_studentID.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập sinh viên!");
                return;
            }

            DialogResult re = MessageBox.Show("Bạn có muốn xoát không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("XoaSVCuoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // truyền tham số truy vấn
                    cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = txt_studentID.Text.Trim();

                  
                    if(cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                finally
                {
                    conn.Close();
                }



            }
            dgv_student.DataSource = Load_SV();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để cập nhật");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = txt_studentID.Text.Trim();
                cmd.Parameters.Add("@nameSV", SqlDbType.NVarChar).Value = txt_student_name.Text.Trim();
                string gender = "";
                // xử lý thêm gới tính
                if (radNam.Checked == true)
                {
                    gender = "NAM";
                }
                else
                {
                    gender = "NỮ";
                }
                cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender.Trim();
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txt_email.Text.Trim();
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = mask_phone.Text.Trim();
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = txt_address.Text.Trim();
                cmd.Parameters.Add("@ngayS", SqlDbType.Date).Value = dtpNS.Value;
                cmd.Parameters.Add("@class", SqlDbType.NVarChar).Value = cob_class.SelectedValue;

                SqlParameter result = cmd.Parameters.Add("@return", SqlDbType.Int);
                result.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int check = (int)result.Value;
                switch (check)
                {
                    case -1:
                        MessageBox.Show("Không thể thay đổi mã sinh viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case -2:
                        MessageBox.Show("Sinh Viên này chưa thay đổi gì", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 0:
                        MessageBox.Show("Cập nhật Sinh Viên thành công");
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }


            dgv_student.DataSource = Load_SV();
        }

        private void cD23TT9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_student.DataSource = PrintSVCD23TT9();
        }

        private void cD23TT10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_student.DataSource = PrintSVCD23TT10();
        }

        private void cD23TT4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_student.DataSource = PrintSVCD23TT4();
        }

        private void cD23TT7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_student.DataSource = PrintSVCD23TT7();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("FindSVCuoi", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maSV", SqlDbType.Char).Value = txt_studentID.Text.Trim();

                cmd.ExecuteNonQuery();
                SqlDataAdapter dgv = new SqlDataAdapter(cmd);

                dgv.Fill(dt);


                if (dt.Rows.Count > 0)
                {

                    dgv_student.DataSource = dt;
                }
                else
                {
                    dgv_student = null;
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
    }
}
