using Anketa.App_Start;
using HKOWebMVC4;
using HKOWebMVC4.Models.HKOWebModels.AjaxModels;
using HKOWebMVC4.Models.HKOWebModels.AjaxModels.PoslodavacModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKOWebMVC4.Controllers.HKOWebControllers.Kompetencije
{
    public class KompetencijeController : Controller
    {
        private static HKOPodaci HKOData = new HKOPodaci();
        private _AjaxResponseModel ajaxResponse = new _AjaxResponseModel();

        [HttpPost]
        public JsonResult _GetOccupationsForCompetencyArray(_AjaxOdabranaZanimanja[] OccupationList)
        {
            IDictionary<_AjaxOdabranaZanimanja, List<ZanimanjeKompetencije_Result>> zanimanjeKompetencijeDict = new Dictionary<_AjaxOdabranaZanimanja, List<ZanimanjeKompetencije_Result>>();
            foreach (_AjaxOdabranaZanimanja occupation in OccupationList)
            {
                var kompetencije = HKOData.ZanimanjeKompetencije(occupation.IdZanimanja).ToList();
                zanimanjeKompetencijeDict.Add(
                    new KeyValuePair<_AjaxOdabranaZanimanja, List<ZanimanjeKompetencije_Result>>(occupation, kompetencije)
                    );
            }
            string renderedHtml = UtilitiesClass.RenderViewToString(this.ControllerContext, "~/Views/HKOWebViews/Kompetencije/_KompetencijeTabbedList.cshtml", zanimanjeKompetencijeDict);
            ajaxResponse.message = renderedHtml;
            return Json(ajaxResponse, JsonRequestBehavior.AllowGet);
        }
    }
}