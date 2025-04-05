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
    public partial class SV_thongtinsinhvien : Form
    {
        public SV_thongtinsinhvien()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SV_thongtinsinhvien_Load(object sender, EventArgs e)
        {
            try { conn.Open();
                SqlCommand cmd = new SqlCommand("thongtinsinhvienCA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txtma.Text = reader["STUDENT_ID"].ToString(); 
                txtten.Text = reader["FULLNAME"].ToString(); 
                txtemail.Text = reader["EMAIL"].ToString(); 
                txtsodt.Text = reader["PHONE"].ToString(); 
                txtdiachi.Text = reader["ADDRRES"].ToString(); 
                txtgiotinh.Text = reader["GENDER"].ToString(); 
                txttenlop.Text = reader["CLASS_NAME"].ToString(); 
              
                
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
