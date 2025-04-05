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
    public partial class GV_CLASS : Form
    {
        public GV_CLASS()
        {
            InitializeComponent();
        }
        SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

        private void GV_CLASS_Load(object sender, EventArgs e)
        {
            cob_classID.DataSource = GetClassID();
            cob_classID.DisplayMember = "CLASS_ID";
            dgv_class.DataSource = PrintClass();
        }

        private DataTable GetClassID()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("GetClassID", _conn);
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
        private DataTable PrintClass()
        {
            DataTable dt = new DataTable();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("PrintClass", _conn);
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


        

        private void btn_exist_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát không!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btn_update_Click_1(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {

                try
                {
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand("UpdateClass", _conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //execute
                    cmd.Parameters.Add("@CLASS_ID", SqlDbType.Char).Value = cob_classID.Text.Trim();
                    cmd.Parameters.Add("@SCHEDELE", SqlDbType.NVarChar).Value = cob_buoi_day.Text.Trim();
                    cmd.Parameters.Add("@TEACHING_SESSION", SqlDbType.Char).Value = cob_schedule.Text.Trim();

                    SqlParameter sql = cmd.Parameters.Add("@result", SqlDbType.Int);
                    sql.Direction = ParameterDirection.ReturnValue;

                    //Query
                    cmd.ExecuteNonQuery();

                    var result = (int)sql.Value;

                    switch (result)
                    {
                        case -1:
                            MessageBox.Show("Mã class không tồn tại!");
                            break;
                        case 0:
                            MessageBox.Show("Update thành công");
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
                    _conn.Close();
                }
            }
            dgv_class.DataSource = PrintClass();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
