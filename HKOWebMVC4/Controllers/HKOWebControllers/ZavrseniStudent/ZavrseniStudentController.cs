using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKOWebMVC4.Controllers.HKOWebControllers.ZavrseniStudent
{
    [Authorize]
    public class ZavrseniStudentController : Controller
    {
        #region member
        private static HKOPodaci HKOData = new HKOPodaci();
        #endregion

        public ActionResult Index()
        {
            ObjectResult<StudijskiProgrami_Result> zanimanjeStudijResult = HKOData.StudijskiProgrami();
            return View("~/Views/HKOWebViews/ZavrseniStudent/Index.cshtml", zanimanjeStudijResult);
        }

        public ActionResult RadnaMjesta(int? studijskiProgramId)
        {
            ObjectResult<StudijskiProgramRadnaMjesta_Result> radnaMjestaResult = HKOData.StudijskiProgramRadnaMjesta(studijskiProgramId);
            return View("~/Views/HKOWebViews/ZavrseniStudent/RadnaMjesta.cshtml", radnaMjestaResult);
        }

        public ActionResult KljucniPoslovi(int? studijskiProgramId)
        {
            ObjectResult<StudijskiProgramKljucniPoslovi_Result> kljucniPosloviResult = HKOData.StudijskiProgramKljucniPoslovi(studijskiProgramId);
            return View("~/Views/HKOWebViews/ZavrseniStudent/KljucniPoslovi.cshtml", kljucniPosloviResult);
        }

        public ActionResult Kompetencije(int? studijskiProgramId)
        {
            ObjectResult<StudijskiProgramKompetencije_Result> kompetencijeResult = HKOData.StudijskiProgramKompetencije(studijskiProgramId);
            return View("~/Views/HKOWebViews/ZavrseniStudent/Kompetencije.cshtml", kompetencijeResult);
        }
    }
}