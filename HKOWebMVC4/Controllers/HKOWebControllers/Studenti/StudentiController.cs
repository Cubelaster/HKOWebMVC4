using ISVU_API.DetaljniUpisniList;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKOWebMVC4.Controllers.HKOWebControllers.Studenti
{
    public class StudentiController : Controller
    {

        private static HKOPodaci hkoPodaci = new HKOPodaci();

        // GET: Studenti
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kompetencije(string JMBAG)
        {

            List<ISVU_API.DetaljniUpisniList.upisaniPredmet> listaPredmeta = ISVU_API.Isvu.UpisniListovi(JMBAG);
            HashSet<KolegijKompetencije_Result> setKompetencija = new HashSet<KolegijKompetencije_Result>();
            foreach(upisaniPredmet predmeti in listaPredmeta)
            {
                ObjectResult<KolegijKompetencije_Result> listaKompetencija = hkoPodaci.KolegijKompetencije("128193");

                foreach (KolegijKompetencije_Result kompetencija in listaKompetencija)
                {
                    setKompetencija.Add(kompetencija);
                }
            }
            return View("~/Views/HKOWebViews/Studenti/StudentiKompetencije.cshtml", setKompetencija);
        }
    }
}