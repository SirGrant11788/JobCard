using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLOUD
{
    public partial class UpdateEmployeeInfo : System.Web.UI.Page
    {
        string source = @"Data Source=LAPTOP-D1N08U8T\SQLEXPRESS;Initial Catalog=CLOUD;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtbNumToUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbNum_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbSurnameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdateNum_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE EMPLOYEE_DETAILS SET EmployeeNo = '"+txtbNum.Text+"' where EmployeeNo = '"+ txtbNumToUpdate.Text+"'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("EMPLOYEE NUMBER HAS BEEN UPDATED");
                lb.Items.Add("EMPLOYEE NUMBER: " + txtbNumToUpdate.Text + "\n");

            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);

            }
        }

        protected void btnNameUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE EMPLOYEE_DETAILS SET EmployeeFirstName = '" + txtbName.Text + "' where EmployeeNo = '" + txtbNumToUpdate.Text + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("EMPLOYEE NAME HAS BEEN UPDATED");
                lb.Items.Add("EMPLOYEE NAME: " + txtbName.Text + "\n");

            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);

            }
        }

        protected void btnSurnameUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE EMPLOYEE_DETAILS SET EmployeeLastName = '" + txtbSurnameUpdate.Text + "' where EmployeeNo = '" + txtbNumToUpdate.Text + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("EMPLOYEE SURNAME HAS BEEN UPDATED");
                lb.Items.Add("EMPLOYEE SURNAME: " + txtbSurnameUpdate.Text + "\n");

            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);

            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnHome_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }

        protected void btnUpdateNum_Click1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE EMPLOYEE_DETAILS SET EmployeeNo = '" + txtbNum.Text + "' where EmployeeNo = '" + txtbNumToUpdate.Text + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("EMPLOYEE NUMBER HAS BEEN UPDATED");
                lb.Items.Add("EMPLOYEE NUMBER: " + txtbNumToUpdate.Text + "\n");

            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);

            }
        }

        protected void btnNameUpdate_Click1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE EMPLOYEE_DETAILS SET EmployeeFirstName = '" + txtbName.Text + "' where EmployeeNo = '" + txtbNumToUpdate.Text + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("EMPLOYEE NAME HAS BEEN UPDATED");
                lb.Items.Add("EMPLOYEE NAME: " + txtbName.Text + "\n");

            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);

            }
        }

        protected void btnSurnameUpdate_Click1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE EMPLOYEE_DETAILS SET EmployeeLastName = '" + txtbSurnameUpdate.Text + "' where EmployeeNo = '" + txtbNumToUpdate.Text + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                lb.Items.Add("EMPLOYEE SURNAME HAS BEEN UPDATED");
                lb.Items.Add("EMPLOYEE SURNAME: " + txtbSurnameUpdate.Text + "\n");

            }
            catch (Exception E)
            {
                lb.Items.Add("ERROR: " + E);

            }
        }
    }
}