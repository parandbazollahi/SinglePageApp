using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinglePageApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            //System.Threading.Thread.Sleep(5000);
            return PartialView();
        }

        public ActionResult Add()
        {
            return PartialView();
        }

        public ActionResult Edit(Int32 id)
        {
            return PartialView(id);
        }
    }
}