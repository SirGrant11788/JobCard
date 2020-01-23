using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLOUD
{
    public partial class UpdateDailyRate : System.Web.UI.Page
    {
        string source = @"Data Source=GRANT\SQLEXPRESS;Initial Catalog=CLOUD;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtbJobType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbRate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE JOB_TYPE SET DailyRate = "+txtbRate.Text+" WHERE JobType = '"+txtbJobType.Text+"'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("DAILY RATE HAS BEEN SET");
                lb.Items.Add("JOB: " + txtbJobType.Text);
                lb.Items.Add("DAILY RATE: R" + txtbRate.Text +"\n");
                
            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);
                
            }
        }

        protected void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}