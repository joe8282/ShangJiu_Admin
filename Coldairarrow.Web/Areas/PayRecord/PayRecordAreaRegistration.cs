using System.Web.Mvc;

namespace Coldairarrow.Web.Areas.PayRecord
{
    public class PayRecordAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PayRecord";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PayRecord_default",
                "PayRecord/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}