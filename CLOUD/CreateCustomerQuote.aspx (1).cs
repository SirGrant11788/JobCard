using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLOUD
{
    public partial class CreateCustomerQuote : System.Web.UI.Page
    {

        string source = @"Data Source=GRANT\SQLEXPRESS;Initial Catalog=CLOUD;Integrated Security=True";


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtbCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(source))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT D.CustomerFirstName, D.CustomerLastName, D.CustomerAreaNo, D.CustomerStreetName, D.CustomerStreetNo, D.CustomerStreet, D.CustomerCity, D.CustomerPostcode,D.CustomerID, C.JobCardNo, ((C.NoOfDays*T.DailyRate)*1.14) as 'Total' FROM CUSTOMER_DETAILS D,JOB_CARD C,JOB_TYPE T where D.CustomerID = C.CustomerID and C.JobTypeNo = T.JobTypeNo and C.CustomerID = '"+ txtbCustomerID.Text + "'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lb.Items.Add("Customer Name: " + String.Format("{0}", reader["CustomerFirstName"]));
                        lb.Items.Add("Customer Name: " + String.Format("{0}", reader["CustomerLastName"]));
                        lb.Items.Add("Customer Area Number: " + String.Format("{0}", reader["CustomerAreaNo"]));
                        lb.Items.Add("Customer Street Name: " + String.Format("{0}", reader["CustomerStreetName"]));
                        lb.Items.Add("Customer Street Number: " + String.Format("{0}", reader["CustomerStreetNo"]));
                        lb.Items.Add("Customer Street: " + String.Format("{0}", reader["CustomerStreet"]));
                        lb.Items.Add("Customer City: " + String.Format("{0}", reader["CustomerCity"]));
                        lb.Items.Add("Customer Postcode: " + String.Format("{0}", reader["CustomerPostcode"]));
                        lb.Items.Add("Customer ID: " + String.Format("{0}", reader["CustomerID"]));
                        lb.Items.Add("Job Card Number: " + String.Format("{0}", reader["JobCardNo"]));
                        lb.Items.Add("Total: R" + String.Format("{0}", reader["Total"])+"\n");

                    }
                    else
                    {
                        lb.Items.Add(" ERROR: \t CANNOT FIND CUSTOMER ID");
                    }

                }
                con.Close();
            }
        }

        protected void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Server.Transfer("default.aspx", true);
        }
    }
}