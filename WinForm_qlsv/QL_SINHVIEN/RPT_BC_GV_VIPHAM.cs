using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;


namespace Login
{
    public partial class RPT_BC_GV_VIPHAM : Form
    {
        public RPT_BC_GV_VIPHAM()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHFTJ6H;Initial Catalog=PROJECT_QLSV;Integrated Security=True;");

        private void RPT_BC_GV_VIPHAM_Load(object sender, EventArgs e)
        {
            cob_vp.DataSource = DisplaySVVP();
            cob_vp.DisplayMember = "FULLNAME";
            cob_vp.ValueMember = "STUDENT_ID";
        }

        private DataTable DisplaySVVP()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintSVByCD23TT9", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                sqlData.Fill(dt);
       
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

        private void button1_Click(object sender, EventArgs e)
        {
            ChitietError sv = new ChitietError();

            ParameterValues rpt = new ParameterValues();

            ParameterDiscreteValue discreteValue = new ParameterDiscreteValue();
            discreteValue.Value = cob_vp.SelectedValue;
            rpt.Add(discreteValue);

            sv.DataDefinition.ParameterFields["@maSV"].ApplyCurrentValues(rpt);

            rpt_ds.ReportSource = sv;

        }
    }
}
