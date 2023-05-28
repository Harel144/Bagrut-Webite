using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HarelsSchoolProjectForBagrut
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public string siteHTML;
        protected string maor;
        public string sqlLogin;
        public string sqlDelete;
        public string sqlUpdate;


        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["admin"] == "yes")
            {
                string fileName = "BagrutDB.mdf";
                string tableName = "usersTbl";

                sqlLogin = "SELECT * FROM " + tableName;

                if (Helper.IsExist(fileName, sqlLogin))
                {
                    DataTable table = Helper.ExecuteDataTable(fileName, sqlLogin);
                    maor = "<table><tr> <td>id</td> <td>שם משתמש</td> <td>אימייל</td> <td>סיסמה</td> <td>מין</td> <td>תחביבים</td> <td>תאריך לידה</td> <td>האם הוא אדמין?</td> </tr>";

                    foreach (DataRow dataRow in table.Rows)
                    {
                        maor += "<tr>";
                        foreach (var item in dataRow.ItemArray)
                        {
                            maor += "<td>" + item + "</td>";
                        }
                        maor += "</tr>";
                    }
                    maor += "</table>";
                }

                if (Request.Form["submit"] != null)
                {
                    string idStr = Request.Form["id"];

                    int id = Convert.ToInt32(idStr);

                    sqlDelete = "DELETE FROM " + tableName + " WHERE Id = " + id;

                    if (Helper.IsExist(fileName, sqlDelete))
                    {
                        DataTable table = Helper.ExecuteDataTable(fileName, sqlDelete);
                    }
                    Response.Redirect("ManagerPage.aspx");
                }

                if (Request.Form["submitAdmin"] != null)
                {
                    string idStr = Request.Form["adminId"];

                    int id = Convert.ToInt32(idStr);

                    sqlUpdate = "UPDATE " + tableName + " SET IsAdmin = 'yes'  WHERE Id = " + id;

                    if (Helper.IsExist(fileName, sqlUpdate))
                    {
                        DataTable table = Helper.ExecuteDataTable(fileName, sqlUpdate);
                    }
                    Response.Redirect("ManagerPage.aspx");
                }
            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }
        }
    }
}