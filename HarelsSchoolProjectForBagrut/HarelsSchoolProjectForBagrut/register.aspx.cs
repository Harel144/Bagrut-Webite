using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HarelsSchoolProjectForBagrut
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public string msg;
        public string sqlCheckUsername;
        public string sqlLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["uName"] != "אורח")
            {
                Response.Redirect("Homepage.aspx");
            }

            if (Request.Form["submit"] != null)
            {
                string fileName = "BagrutDB.mdf";
                string tableName = "usersTbl";

                string uName = Request.Form["name"];
                string password = Request.Form["pw"];
                string gender = Request.Form["gender"];
                string email = Request.Form["email"];
                string hobbies = Request.Form["hobbies"];
                string birthdate = Request.Form["birthdate"];

                sqlCheckUsername = "SELECT * FROM " + tableName + " WHERE uName = '" + uName + "'";
                if (!Helper.IsExist(fileName, sqlCheckUsername))
                {
                    sqlLogin = "INSERT INTO " + tableName + " (uName, Email, pass, gender, hobbies, birthdate, IsAdmin) VALUES ('" + uName + "', '" + email + "', '" + password + "','" + gender + "','" + hobbies + "','" + birthdate + "','no') select scope_identity()";

                    if (Helper.IsExist(fileName, sqlLogin))
                    {
                        Response.Redirect("logIn.aspx");
                    }
                }
                else
                {
                    msg += "<p class='errorBox'>שם המשתמש תפוס</p>";
                }
            }
        }
    }
}