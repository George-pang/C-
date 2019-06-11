using System.Web.Mvc;

namespace WebApp.Areas.M_Event
{
    public class M_EventAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "M_Event";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "M_Event_default",
                "M_Event/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}