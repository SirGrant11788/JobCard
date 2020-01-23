using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CLOUD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //not neededed here but to be pasted in other forms
        string source = @"Data Source=LAPTOP-D1N08U8T\SQLEXPRESS;Initial Catalog=CLOUD;Integrated Security=True";

        protected void btnCreateJobCard_Click(object sender, EventArgs e)
        {
           // Server.Transfer("CreateJobCard.aspx", true);
            Response.Redirect("~/CreateJobCard.aspx");
        }

        protected void btnRetrieveJobCard_Click(object sender, EventArgs e)
        {
           // Server.Transfer("RetrieveJobCard.aspx", true);
            Response.Redirect("~/RetrieveJobCard.aspx");
        }

        protected void btnUpdateEmployeeInfo_Click(object sender, EventArgs e)
        {
            //Server.Transfer("UpdateEmployeeInfo.aspx", true);
            Response.Redirect("UpdateEmployeeInfo.aspx");
        }

        protected void btnRetrieveEmployeeInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RetrieveEmployeeInfo.aspx");
           // Server.Transfer("RetrieveEmployeeInfo.aspx", true);
        }

        protected void btnCreateEmployeeInfo_Click(object sender, EventArgs e)
        {
           // Server.Transfer("CreateEmployeeInfo.aspx", true);
            Response.Redirect("CreateEmployeeInfo.aspx");
        }

        protected void btnUpdateDailyRate_Click(object sender, EventArgs e)
        {
            //Server.Transfer("UpdateDailyRate.aspx", true);
            Response.Redirect("~/UpdateDailyRate.aspx");
        }

        protected void btnCreateCuatomerQuote_Click(object sender, EventArgs e)
        {
            //
            Response.Redirect("~/CreateCustomerQuote.aspx");
        }
    }
}