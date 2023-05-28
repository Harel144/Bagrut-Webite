using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Linq;

namespace HarelsSchoolProjectForBagrut
{
    public partial class logIn : System.Web.UI.Page
    {
        public string msg = " ";
        public string sqlLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["uName"] != "אורח")
            {
                Response.Redirect("Homepage.aspx");
            }

            if (Request.Form["submit"] != null)
            {
                string uName = Request.Form["uName"];
                string pass = Request.Form["pw"];

                string fileName = "BagrutDB.mdf";
                string tableName = "usersTbl";

                sqlLogin = "SELECT * FROM " + tableName + " WHERE uName = '" + uName + "' AND pass = '" + pass + "'";

                if (Helper.IsExist(fileName, sqlLogin))
                {
                    DataTable table = Helper.ExecuteDataTable(fileName, sqlLogin);

                    int length = table.Rows.Count;
                    if (length == 0)
                    {
                        msg = "No users";
                    }
                    else
                    {
                        string res = string.Join(Environment.NewLine, table.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
                        res = res.Substring(res.Length - "yes".Length);

                        if (res == "yes")
                        {
                            Session["uName"] = "Admin";
                            Session["admin"] = "yes";
                        }
                        else
                        {
                            Session["uName"] = table.Rows[0]["uName"];
                        }
                        Response.Redirect("Homepage.aspx");
                    }
                }
            }
        }
    }
}
