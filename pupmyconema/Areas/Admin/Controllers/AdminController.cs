using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;


namespace pupmyconema.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}