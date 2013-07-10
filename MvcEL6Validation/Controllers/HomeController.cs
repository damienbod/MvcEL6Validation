using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEL6Validation.Models;

namespace MvcEL6Validation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(HomeDataModel model)
        {
            if (ModelState.IsValid)
            {
                
                return this.RedirectToAction("Index");
            }

            return View("Index", model);
        }

        public ActionResult IndexEnterpriseLibrary()
        {
            return View("IndexEnterpriseLibrary");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexEnterpriseLibrary(HomeDataModelEnterpriseLibrary model)
        {
            if (ModelState.IsValid)
            {

                return this.RedirectToAction("IndexEnterpriseLibrary");
            }

            return View("IndexEnterpriseLibrary", model);
        }


        
    }
}
