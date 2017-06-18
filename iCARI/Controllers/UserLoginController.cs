using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iCARI.Models;

namespace iCARI.Controllers
{
    public class UserLoginController : Controller
    {
        //
        // GET: /UserLogin/

        public ActionResult Index()
        {
            return View("UserLogin");
        }
    }
}