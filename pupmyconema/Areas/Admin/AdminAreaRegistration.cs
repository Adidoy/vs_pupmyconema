using System.Web.Mvc;

namespace pupmyconema.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.Routes.LowercaseUrls = true;
            context.MapRoute(
                name: "admin_default",
                url: "admin/{controller}/{action}/{id}",
                //new { action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "AdminHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}