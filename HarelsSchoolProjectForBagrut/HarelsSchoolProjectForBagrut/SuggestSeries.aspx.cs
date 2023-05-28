using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HarelsSchoolProjectForBagrut
{
    public partial class SuggestSeries : System.Web.UI.Page
    {
        public string sqlInsert;
        public string msg;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["uName"] == "אורח")
            {
                Response.Redirect("Homepage.aspx");
            }

            if (Request.Form["submit"] != null)
            {
                string SeriesName = Request.Form["SeriesName"];

                string fileName = "BagrutDB.mdf";
                string tableName = "suggestionTbl";
                string uName = (string)Session["uName"];

                sqlInsert = "INSERT INTO " + tableName + " (uName, SeriesName) VALUES ('" + uName + "', '" + SeriesName + "')";

                if (Helper.IsExist(fileName, sqlInsert))
                {
                    msg += "!הבקשה נשלחה בהצלחה";
                    DataTable table = Helper.ExecuteDataTable(fileName, sqlInsert);
                }

            }
        }
    }
}