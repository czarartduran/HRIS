using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Diagnostics;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {        
        [WebMethod]
        public DateTime WebApplicationDateTime()
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, ConfigurationManager.AppSettings["TimeZone"]);
        }

        [WebMethod]
        public bool RegistereTimeLog(string EmployeeID)
        {
            bool ans = false;
            try
            {
                string timezone = ConfigurationManager.AppSettings["TimeZone"];
                Debug.WriteLine("TimeZone: " + timezone);
                DateTime sysdate = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, timezone);
                DateTime registereddate = Convert.ToDateTime(sysdate.ToString("yyyy/MM/dd"));
                using (hrisDataContext ta = new hrisDataContext())
                {
                    ta.sp_RegisterTimeLog(Convert.ToInt64(EmployeeID), registereddate, sysdate);
                    ans = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("RegistereTimeLog: " + ex.Message);
            }
            return ans;
        }
    }
}
