using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLOUD
{
    public partial class RetrieveEmployeeInfo : System.Web.UI.Page
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
                SqlCommand command = new SqlCommand("SELECT EmployeeNo,EmployeeFirstName,EmployeeLastName from EMPLOYEE_DETAILS where EmployeeNo = '"+txtbNum.Text+"'", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lb.Items.Add("EMPLOYEE NAME: " + String.Format("{0}", reader["EmployeeFirstName"]));
                        lb.Items.Add("EMPLOYEE SURNAME: " + String.Format("{0}", reader["EmployeeLastName"]));
                        lb.Items.Add("EMPLOYEE NUMBER: " + String.Format("{0}", reader["EmployeeNo"]) + "\n");

                    }
                    else
                    {
                        lb.Items.Add(" ERROR: \t CANNOT FIND EMPLOYEE ID");
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
            Response.Redirect("default.aspx");
        }

        protected void btnHome_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}