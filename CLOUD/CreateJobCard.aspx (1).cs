using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLOUD
{
    public partial class CreateJobCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string source = @"Data Source=GRANT\SQLEXPRESS;Initial Catalog=CLOUD;Integrated Security=True";


        protected void txtbJobCardNo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbJobTypeNo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbDays_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO JOB_CARD VALUES ("+txtbJobCardNo.Text+",'"+txtbJobTypeNo.Text+"','"+txtCustomerID.Text+"',"+txtbDays.Text+")", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("JOB CARD HAS BEEN CREATED");
                lb.Items.Add("JOB CARD NUMBER: " + txtbJobCardNo.Text);
                lb.Items.Add("JOB TYPE NUMBER: " + txtbJobTypeNo.Text);
                lb.Items.Add("CUSTOMER ID: " + txtCustomerID.Text);
                lb.Items.Add("NUMBER OF DAYS: " + txtbDays.Text);
            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}