using HKOWebMVC4.DAL.HKOPodaciService;
using HKOWebMVC4.DAL.Repository.UserServices;
using HKOWebMVC4.DAL.Service.PoslodavacService;
using HKOWebMVC4.Models.HKOWebModels.Korisnik;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKOWebMVC4.Controllers.HKOWebControllers.Poslodavac
{
    public class PoslodavacController : Controller
    {

        #region members
        private static HKOPodaci HKOData = new HKOPodaci();
        private static UserService userService = new UserService();
        private static HKOPodaciService HKODataService = new HKOPodaciService();
        #endregion

        // GET: Poslodavac
        public ActionResult Index()
        {
            KorisnikOdabirZanimanja odabirZanimanja = new KorisnikOdabirZanimanja();
            odabirZanimanja.svaZanimanja = HKODataService.fetchDistinctZanimanjaDictionary();
            odabirZanimanja.odabranaZanimanja = userService.getSelectedProffesionForCurrentUser();
            return View("~/Views/HKOWebViews/Poslodavac/Index.cshtml", odabirZanimanja);
        }

        // GET: Poslodavac/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Poslodavac/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Poslodavac/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Poslodavac/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Poslodavac/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Poslodavac/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Poslodavac/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
