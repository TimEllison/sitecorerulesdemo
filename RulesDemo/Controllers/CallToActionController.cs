using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using RulesDemo.Models.Call_To_Action;
using RulesDemo.Models.Call_To_Action.Rendering_Parameters;

namespace RulesDemo.Controllers
{
    public class CallToActionController : GlassController
    {
        // GET: CallToAction
        public ActionResult CallToAction()
        {
            var model = GetLayoutItem<CallToAction>();
            var parameters = GetRenderingParameters<CallToActionParameters>();

            return View(new CallToActionViewModel
            {
                Model = model,
                Parameters = parameters
            });
        }
    }
}