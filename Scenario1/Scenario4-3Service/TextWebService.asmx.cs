using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Scenario4_3
{
    /// <summary>
    /// Summary description for TextWebService
    /// </summary>
    [WebService(Namespace = "http://northwindtraders.com/")]
    [WebServiceBinding(ConformsTo
        = WsiProfiles.BasicProfile1_1)]
    public class TextWebService :
        System.Web.Services.WebService
    {
        [WebMethod]
        public string ToUpper(string inputString)
        {
            return inputString.ToUpper();
        }
        [WebMethod]
        public string ToLower(string inputString)
        {
            return inputString.ToLower();
        }
    }
}
