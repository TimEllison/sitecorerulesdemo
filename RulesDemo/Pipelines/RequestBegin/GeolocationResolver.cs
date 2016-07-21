using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Sitecore.ApplicationCenter.Applications;
using Sitecore.Mvc.Pipelines.Request.RequestBegin;
using Sitecore.Pipelines.HttpRequest;

namespace RulesDemo.Pipelines.RequestBegin
{
    public class GeolocationResolver : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            var states = new string[]
            {
                "NC",
//                "ND",
//                "SD",
//                "AK",
//                "AZ",
//                "DC",
                "NY",
                "VA",
//                "AL",
//                "IL",
//                "SC"
            };
            var itemNumber = new Random().Next(0, states.Length);
            if (Sitecore.Context.Database == null || Sitecore.Context.Database.Name == "master")
            {
                itemNumber = 2;
            }
            
            var cookie = args.Context.Request.Cookies.Get("Geolocation") ?? new HttpCookie("Geolocation");
            cookie.Expires = DateTime.UtcNow.AddMinutes(-1);
            cookie["State"] = states[itemNumber];
            args.Context.Response.Cookies.Add(cookie);
        }
    }
}
