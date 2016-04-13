using HKOWeb.DAL.BuduciStudentDAL;
using HKOWeb.Models.HKOWebModels;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HKOWeb.Controllers.HKOWebControllers
{
    public class ZanimanjaOverviewController : Controller
    {
        #region members
        private BuduciStudentService buduciStudentService = new BuduciStudentService();
        #endregion

        #region methods
        public ActionResult ZanimanjaOverview()
        {
            List<ZanimanjaOverview> tListaZanimanja = buduciStudentService.generateListOfZanimanja();
            return View(tListaZanimanja);
        }

        public ActionResult RadnaMjesta(int zanimanjeId)
        {
            return View();
        }

        public ActionResult KljucniPoslovi(int zanimanjeId)
        {
            return View();
        }

        public ActionResult Kompetencije(int zanimanjeId)
        {
            return View();
        }

        public ActionResult Kolegiji(int zanimanjeId)
        {
            return View();
        }

        public ActionResult IshodiUcenja(int zanimanjeId)
        {
            return View();
        }
        #endregion
    }
}
