using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scenario4_4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string field1 = (string)(Session["Name"]);
            string field2 = (string)(Session["Email"]);
            if (field1 == String.Empty || field2 == String.Empty)
            {
                Response.Write("Fill in all fields");
            }
            else
            {
                Response.Write($"Name: {field1} <br>Email: {field2}");
            }
        }
    }
}