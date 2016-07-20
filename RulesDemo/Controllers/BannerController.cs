using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using RulesDemo.Models;

namespace RulesDemo.Controllers
{
    public class BannerController : GlassController
    {
        public ActionResult Welcome()
        {
            var state = HttpContext.Request.Cookies["Geolocation"]["State"];
            return View(new GeolocationModel
            {
                Geolocation = new Geolocation
                {
                    State = state
                }
            });
        }  
    }
}