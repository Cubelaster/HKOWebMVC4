using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKOWebMVC4.Controllers.HKOWebControllers.BuduciStudent
{
    public class BuduciStudentController : Controller
    {
        #region member
        private static HKOPodaci HKOData = new HKOPodaci();
        #endregion

        // GET: BuduciStudent
        public ActionResult Index()
        {
            ObjectResult<ZanimanjeStudiji_Result> zanimanjeStudijResult = HKOData.ZanimanjeStudiji();
            return View("~/Views/HKOWebViews/BuduciStudent/Index.cshtml", zanimanjeStudijResult);
        }

        // GET: BuduciStudent/Details/5
        public ActionResult RadnaMjesta(int? zanimanjeId)
        {
            ObjectResult<ZanimanjeRadnaMjesta_Result> radnaMjestaResult = HKOData.ZanimanjeRadnaMjesta(zanimanjeId);
            return View("~/Views/HKOWebViews/BuduciStudent/RadnaMjesta.cshtml", radnaMjestaResult);
        }

        // GET: BuduciStudent/Create
        public ActionResult KljucniPoslovi(int zanimanjeId)
        {
            return View();
        }

        // GET: BuduciStudent/Edit/5
        public ActionResult Kompetencije(int zanimanjeId)
        {
            ObjectResult<ZanimanjeKompetencije_Result> zanimanjeKompetencijeResult = HKOData.ZanimanjeKompetencije(zanimanjeId);
            return View("~/Views/HKOWebViews/BuduciStudent/Kompetencije.cshtml", zanimanjeKompetencijeResult);
        }

        // POST: BuduciStudent/Edit/5
        [HttpPost]
        public ActionResult Kolegiji(int studijskiProgramId)
        {
                return View();
        }

        // GET: BuduciStudent/Delete/5
        public ActionResult IshodiUcenja(int kolegijId)
        {
            return View();
        }
    }
}
