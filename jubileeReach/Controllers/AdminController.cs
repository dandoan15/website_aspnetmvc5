using jubileeReach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jubileeReach.Controllers
{
    public class AdminController : Controller
    {
        private Model1 db = new Model1();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}