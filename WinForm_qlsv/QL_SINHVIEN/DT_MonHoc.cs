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
    public partial class DT_MonHoc : Form
    {
        public DT_MonHoc()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");


        // get data tb_major
        private DataTable GetDataMajor()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
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

        //Get mã instructors
        private DataTable GetDataInstructors()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintINSTRUCTOR", conn);
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
        private bool CheckInput()
        {
            var check = new Control[] { txt_subjectID, txt_subject_name };
            if (check.Any(it => it.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập đầu đủ thông tin");
                return true;
            }

            return false;
        }

        private void DisplayGetData()
        {
            //giảng vien
            cob_instructors.DataSource = GetDataInstructors();
            cob_instructors.DisplayMember = "FULLNAME";
            cob_instructors.ValueMember = "INSTRUCTOR_ID";

            // khoa
            cob_Nganh.DataSource = GetDataMajor();
            cob_Nganh.DisplayMember = "MAJOR_NAME";
            cob_Nganh.ValueMember = "MAJOR_ID";

            
        }
        private void GV_MonHoc_Load(object sender, EventArgs e)
        {
            DisplayGetData();

            dgv_subject.DataSource = AllTheKhoa();

        }

        private DataTable PrintSubjctCNTT()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintSubjctCNTT", conn);
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
        private DataTable PrintSubjctQLTC()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintSubjctQLTC", conn);
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
        private DataTable PrintSubjctHTTT()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintSubjctHTTT", conn);
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

        // all các khoa
        private DataTable PrintSubjctTKDH()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintSubjctTKDH", conn);
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
        
        
        private DataTable PrintSubjctQTKD()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintSubjctQTKD", conn);
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



        private DataTable AllTheKhoa()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AllTheKhoa", conn);
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



        private void dgv_subject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void print_message(int result)
        {
            switch (result)
            {
                case 0:
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case -1:
                    MessageBox.Show("Môn học đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                return;
            }
            
            if(!int.TryParse(txt_sotc.Text, out _) || !int.TryParse(txt_sobuoi.Text, out _))
            {
                txt_sobuoi.Clear();
                txt_sotc.Clear();
                MessageBox.Show("Vui lòng nhập số nguyên cho 'số tín chủ' or 'số buổi' ");
                return;
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddMh", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maMh", SqlDbType.Char).Value = txt_subjectID.Text.Trim();
                cmd.Parameters.Add("@tenMH", SqlDbType.NVarChar).Value = txt_subject_name.Text.Trim();
                cmd.Parameters.Add("@soTC", SqlDbType.Int).Value = txt_sotc.Text.Trim();
                cmd.Parameters.Add("@soBuoi", SqlDbType.Int).Value = txt_sobuoi.Text.Trim();
                cmd.Parameters.Add("@dgtc", SqlDbType.Float).Value = float.Parse(lab_dgtc.Text.Trim());
                cmd.Parameters.Add("@maGV", SqlDbType.Char).Value = cob_instructors.SelectedValue;
                cmd.Parameters.Add("@maNganh", SqlDbType.Char).Value = cob_Nganh.SelectedValue;

                // Thêm tham số để nhận giá trị trả về
                SqlParameter returnParameter = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int result = (int)returnParameter.Value;

                print_message(result);

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            Clear();
            dgv_subject.DataSource = AllTheKhoa();
        }



        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {

            if(txt_subjectID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã");
                return;
            }


            DialogResult re = MessageBox.Show("Bạn có muốn xóa không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DeleteMh", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@maMh", SqlDbType.Char).Value = txt_subjectID.Text.Trim();

                    // Thêm tham số để nhận giá trị trả về
                    SqlParameter returnParameter = cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();

                    int result = (int)returnParameter.Value;

                    if (result == -1)
                    {
                        MessageBox.Show("Môn học không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if(result == 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Clear();
            dgv_subject.DataSource = AllTheKhoa();
        }

        private void khoaHọcMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_subject.DataSource = PrintSubjctCNTT();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Clear();
            dgv_subject.DataSource = AllTheKhoa();
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_subject.DataSource = PrintSubjctHTTT();
        }

        private void quảnTrịKinhDoanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_subject.DataSource = PrintSubjctQTKD();
        }

        private void quảnLíTàiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_subject.DataSource =  PrintSubjctQLTC();
        }

        private void thiếtKếĐồHọaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_subject.DataSource = PrintSubjctTKDH();
        }

        private void Clear()
        {

            txt_subjectID.Clear();
            txt_subject_name.Clear();
            txt_sobuoi.Clear();
            txt_sotc.Clear();
        }

        private void dgv_subject_Click(object sender, EventArgs e)
        {
            try
            {

                int dong = dgv_subject.CurrentCell.RowIndex;
                txt_subjectID.Text = dgv_subject.Rows[dong].Cells[0].Value.ToString().Trim();
                txt_subject_name.Text = dgv_subject.Rows[dong].Cells[1].Value.ToString().Trim();
                txt_sotc.Text = dgv_subject.Rows[dong].Cells[2].Value.ToString().Trim();
                txt_sobuoi.Text = dgv_subject.Rows[dong].Cells[3].Value.ToString().Trim();
                lab_dgtc.Text = dgv_subject.Rows[dong].Cells[4].Value.ToString().Trim();
                cob_instructors.SelectedValue = dgv_subject.Rows[dong].Cells[5].Value.ToString().Trim();
                cob_Nganh.SelectedValue = dgv_subject.Rows[dong].Cells[6].Value.ToString().Trim();
            }
            catch
            {

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txt_sotc.Text, out _) || !int.TryParse(txt_sobuoi.Text, out _))
            {
                txt_sobuoi.Clear();
                txt_sotc.Clear();
                MessageBox.Show("Vui lòng nhập số nguyên cho 'số tín chủ' or 'số buổi' ");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateMh", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maMh", SqlDbType.Char).Value = txt_subjectID.Text.Trim();
                cmd.Parameters.Add("@tenMH", SqlDbType.NVarChar).Value = txt_subject_name.Text.Trim();
                cmd.Parameters.Add("@soTC", SqlDbType.Int).Value = int.Parse(txt_sotc.Text.Trim());
                cmd.Parameters.Add("@soBuoi", SqlDbType.Int).Value = int.Parse(txt_sobuoi.Text.Trim());
                cmd.Parameters.Add("@maGV", SqlDbType.Char).Value = cob_instructors.SelectedValue;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");      
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            dgv_subject.DataSource = AllTheKhoa();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("FindMHCuoi", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maMH",SqlDbType.Char).Value = txt_subjectID.Text.Trim();

                cmd.ExecuteNonQuery();
                SqlDataAdapter dgv = new SqlDataAdapter(cmd);

                dgv.Fill(dt);
                

                if (dt.Rows.Count > 0)
                {
                   
                    dgv_subject.DataSource = dt;
                }
                else
                {
                    dgv_subject.DataSource= null;
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
