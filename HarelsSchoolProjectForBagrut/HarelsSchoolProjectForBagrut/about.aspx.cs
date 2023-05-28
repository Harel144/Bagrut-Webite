using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HarelsSchoolProjectForBagrut
{
    public partial class abot : System.Web.UI.Page
    {
        public string strHTML;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uName"] == "אורח")
            {
                strHTML = "<p class='center'><a href='register.aspx'><u>הירשם</u></a> או <a href='logIn.aspx'><u>התחבר</u></a> כדי לראות את התוכן</p>";
            }
            else
            {
                strHTML = "<p>אתר זה נוצר בשביל פרוייקט בגרות</p>";
            }
        }
    }
}