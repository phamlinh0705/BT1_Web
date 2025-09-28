using System;
using System.Web;
using System.Web.UI;
using FunnyLib;   // dùng DLL PersonalFunny

namespace WebApplication1   // 👈 phải đúng với tên project
{
    public partial class api : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json";

            if (Request.HttpMethod == "POST")
            {
                string name = Request.Form["name"] ?? "";
                int number = 0;
                int.TryParse(Request.Form["number"], out number);

                PersonalFunny pf = new PersonalFunny(name, number);
                string message = pf.GenerateMessage();

                string json = "{\"message\":\"" + EscapeJson(message) + "\"}";
                Response.Write(json);
            }
            else
            {
                Response.StatusCode = 405;
                Response.Write("{\"message\":\"Method Not Allowed\"}");
            }

            Response.Flush();
            Context.ApplicationInstance.CompleteRequest();
        }

        private string EscapeJson(string s)
        {
            if (s == null) return "";
            return s.Replace("\\", "\\\\")
                    .Replace("\"", "\\\"")
                    .Replace("\r", "\\r")
                    .Replace("\n", "\\n");
        }
    }
}A