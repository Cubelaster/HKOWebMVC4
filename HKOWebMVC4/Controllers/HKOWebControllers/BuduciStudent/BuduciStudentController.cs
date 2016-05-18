using HKOWebMVC4.Models.HKOWebModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKOWebMVC4.Controllers.HKOWebControllers.BuduciStudent
{
    [Authorize]
    public class BuduciStudentController : Controller
    {
        #region member
        private static HKOPodaci HKOData = new HKOPodaci();
        #endregion

        // GET: BuduciStudent
        public ActionResult Index()
        {
            ISVU_API.Isvu.UpisniListovi("22");
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
            ObjectResult<ZanimanjeKljucniPoslovi_Result> kljucniPosloviResult = HKOData.ZanimanjeKljucniPoslovi(zanimanjeId);
            return View("~/Views/HKOWebViews/BuduciStudent/KljucniPoslovi.cshtml", kljucniPosloviResult);
        }

        // GET: BuduciStudent/Edit/5
        public ActionResult Kompetencije(int zanimanjeId)
        {
            ObjectResult<ZanimanjeKompetencije_Result> zanimanjeKompetencijeResult = HKOData.ZanimanjeKompetencije(zanimanjeId);
            return View("~/Views/HKOWebViews/BuduciStudent/Kompetencije.cshtml", zanimanjeKompetencijeResult);
        }

        public ActionResult Kolegiji(int studijskiProgramId, int zanimanjeId)
        {
            KolegijiPregled kolegijiPregled = new KolegijiPregled();
            kolegijiPregled.obavezniKolegijiResult = HKOData.StudijskiProgramObavezniKolegiji(studijskiProgramId);
            kolegijiPregled.izborniKolegijiResult = HKOData.StudijskiProgramIzborniKolegiji(studijskiProgramId);
            kolegijiPregled.preporuceniKolegijiResult = HKOData.ZanimanjePreporuceniIzborniKolegiji(zanimanjeId);
            return View("~/Views/HKOWebViews/BuduciStudent/Kolegiji.cshtml", kolegijiPregled);
        }

        // GET: BuduciStudent/Delete/5
        public ActionResult IshodiUcenja(int kolegijId)
        {
            ViewBag.back = System.Web.HttpContext.Current.Request.UrlReferrer;
            ObjectResult<KolegijSkupIshodaUcenja_Result> ishodiUcenjaResult = HKOData.KolegijSkupIshodaUcenja(kolegijId);
            return View("~/Views/HKOWebViews/BuduciStudent/IshodiUcenja.cshtml", ishodiUcenjaResult);
        }
    }
}
