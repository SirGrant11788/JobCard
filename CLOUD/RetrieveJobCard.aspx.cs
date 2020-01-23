using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLOUD
{
    public partial class RetrieveJobCard : System.Web.UI.Page
    {
        string source = @"Data Source=LAPTOP-D1N08U8T\SQLEXPRESS;Initial Catalog=CLOUD;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtbNum_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(source))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT JobCardNo,JobTypeNo,CustomerID,NoOfDays FROM JOB_CARD WHERE JobCardNo = "+txtbNum.Text+"", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ListBox1.Items.Add("NUMBER OF DAYS: " + String.Format("{0}", reader["NoOfDays"]));
                        ListBox1.Items.Add("CUSTOMER ID: " + String.Format("{0}", reader["CustomerID"]));
                        ListBox1.Items.Add("JOB TYPE NUMBER: " + String.Format("{0}", reader["JobTypeNo"]));
                        ListBox1.Items.Add("JOB CARD NUMBER: " + String.Format("{0}", reader["JobCardNo"]) + "\n");

                    }
                    else
                    {
                        ListBox1.Items.Add(" ERROR: \t CANNOT FIND JOB CARD NUMBER");
                    }

                }
                con.Close();
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnHome_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}