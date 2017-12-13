using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scenario4_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Name"] == null || Request.QueryString["Email"] == null)
            {
                Response.Write("Fill in all fields");
            }
            else
            {
                Response.Write($"Name: {Request.QueryString["Name"]}<br> Email: {Request.QueryString["Email"]}");
            }
        }
    }
}