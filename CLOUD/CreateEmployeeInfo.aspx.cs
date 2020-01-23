using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLOUD
{
    public partial class CreateEmployeeInfo : System.Web.UI.Page
    {
        string source = @"Data Source=LAPTOP-D1N08U8T\SQLEXPRESS;Initial Catalog=CLOUD;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtbEmpNo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbSurname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO EMPLOYEE_DETAILS VALUES ('" + txtbEmpNo.Text + "','" + txtbName.Text + "','" + txtbSurname.Text + "')", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("EMPLOYEE HAS BEEN ADDED");
                lb.Items.Add("EMPLOYEE NAME: " + txtbName.Text);
                lb.Items.Add("EMPLOYEE SURNAME: " + txtbSurname.Text);
                lb.Items.Add("EMPLOYEE NUMBER: " + txtbEmpNo.Text);
            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);
            }
        }

        protected void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {

            //Response.Redirect("default.aspx");
            //form1
            Response.Redirect("~/Default.aspx");
        }

        protected void lb_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void BtnHome_Click1(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnCreate_Click1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO EMPLOYEE_DETAILS VALUES ('" + txtbEmpNo.Text + "','" + txtbName.Text + "','" + txtbSurname.Text + "')", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("EMPLOYEE HAS BEEN ADDED");
                lb.Items.Add("EMPLOYEE NAME: " + txtbName.Text);
                lb.Items.Add("EMPLOYEE SURNAME: " + txtbSurname.Text);
                lb.Items.Add("EMPLOYEE NUMBER: " + txtbEmpNo.Text);
            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);
            }
        }
    
    }
}