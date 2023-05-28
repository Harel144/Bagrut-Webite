using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HarelsSchoolProjectForBagrut
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string loginMsg;
        public string bar;
        protected void Page_Load(object sender, EventArgs e)
        {
            loginMsg = "<center><h3>שלום ";
            loginMsg += Session["uName"];
            loginMsg += "</h3></center>";

            if (Session["uName"] == "אורח")
            {
                bar = " <div class='bar'><ul>";
                bar += "<li><a href='Homepage.aspx'>דף הבית</a></li>";
                bar += "<li><a href='weekly-recommendation.aspx'>ההמלצה השבועית</a></li>";
                bar += "<li><a href='SuggestSeries.aspx'>הצע סדרה</a></li>";
                bar += "<li><a href ='shopRedirect.aspx' target='_blank' class='shopButton'>חנות</a></li>";
                bar += "<li class='important'> <form action='https://www.paypal.com/donate' method='post' target='_top'> <input type='hidden' name='hosted_button_id' value='E5P3UA657WWVC' /> <input type='submit' value='תרום' border='0' name='submit' title='PayPal - The safer, easier way to pay online!' alt='Donate with PayPal button' /> </form> </li>";
                bar += "<li><a href= 'logIn.aspx'>התחבר</a></li>";
                bar += "<li><a href= 'register.aspx'>הירשם</a></li>";
                bar += "<li><a href= 'about.aspx'>אודות</a></li>";
                bar += "</ul> </div>";
            }
            else if (Session["admin"] == "yes")
            {
                bar = " <div class='bar'><ul>";
                bar += "<li><a href='Homepage.aspx'>דף הבית</a></li>";
                bar += "<li><a href='weekly-recommendation.aspx'>ההמלצה השבועית</a></li>";
                bar += "<li><a href='SuggestSeries.aspx'>הצע סדרה</a></li>";
                bar += "<li><a href ='shopRedirect.aspx' target='_blank' class='shopButton'>חנות</a></li>";
                bar += "<li class='important'> <form action='https://www.paypal.com/donate' method='post' target='_top'> <input type='hidden' name='hosted_button_id' value='E5P3UA657WWVC' /> <input type='submit' value='תרום' border='0' name='submit' title='PayPal - The safer, easier way to pay online!' alt='Donate with PayPal button' /> </form> </li>";
                bar += "<li><a href= 'logout.aspx'>התנתק</a></li>";
                bar += "<li><a href= 'about.aspx'>אודות</a></li>";
                bar += "<li class='important'><a href='ManagerPage.aspx'>דף מנהלים</a></li>";
                bar += "</ul> </div>";
            }
            else
            {
                bar = " <div class='bar'><ul>";
                bar += "<li><a href='Homepage.aspx'>דף הבית</a></li>";
                bar += "<li><a href='weekly-recommendation.aspx'>ההמלצה השבועית</a></li>";
                bar += "<li><a href='SuggestSeries.aspx'>הצע סדרה</a></li>";
                bar += "<li><a href ='shopRedirect.aspx' target='_blank' class='shopButton'>חנות</a></li>";
                bar += "<li class='important'> <form action='https://www.paypal.com/donate' method='post' target='_top'> <input type='hidden' name='hosted_button_id' value='E5P3UA657WWVC' /> <input type='submit' value='תרום' border='0' name='submit' title='PayPal - The safer, easier way to pay online!' alt='Donate with PayPal button' /> </form> </li>";
                bar += "<li><a href= 'logout.aspx'>התנתק</a></li>";
                bar += "<li><a href= 'about.aspx'>אודות</a></li>";
                bar += "</ul> </div>";
            }
        }
    }
}