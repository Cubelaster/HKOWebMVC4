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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BuduciStudent/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: BuduciStudent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BuduciStudent/Edit/5
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

        // GET: BuduciStudent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuduciStudent/Delete/5
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
