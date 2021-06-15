using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using UrbanMediMarts.Models;

namespace UrbanMediMarts.Controllers
{
    public class HomeController : Controller
    {
        private UrbanMediMartEntities db = new UrbanMediMartEntities();
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {

            return View();
        }
        [Authorize]
        public ActionResult Products()
        {

            var items = db.Categories.ToList();
                return View(items);
        }
       
    }
}