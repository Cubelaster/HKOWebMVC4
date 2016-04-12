using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKOWebMVC4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var j = 0;
            HKOPodaci HKOData = new HKOPodaci();
            ObjectResult<KolegijSkupIshodaUcenja_Result> podatak = HKOData.KolegijSkupIshodaUcenja(1);
            if(podatak == null){
                var i = 1;
                i++;
                j += i;
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}