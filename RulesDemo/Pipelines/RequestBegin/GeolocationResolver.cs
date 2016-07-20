using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Sitecore.Mvc.Pipelines.Request.RequestBegin;
using Sitecore.Pipelines.HttpRequest;

namespace RulesDemo.Pipelines.RequestBegin
{
    public class GeolocationResolver : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            if (Sitecore.Context.Database == null || Sitecore.Context.Database.Name == "core") return;
            var states = new string[]
            {
                "NC",
                "VA",
                "ND",
                "SD",
                "AK",
                "AZ",
                "DC",
                "NY",
                "VA",
                "AL",
                "IL",
                "SC"
            };
            var itemNumber = new Random().Next(0, 11);
            if (Sitecore.Context.Database.Name == "master")
            {
                itemNumber = 1;
            }
            else if (Sitecore.Context.Database.Name == "web")
            {
                var cookie = args.Context.Request.Cookies.Get("Geolocation") ?? new HttpCookie("Geolocation");
                cookie.Expires = DateTime.UtcNow.AddMinutes(20);
                cookie["State"] = states[itemNumber];
                args.Context.Response.Cookies.Add(cookie);
            }
        }
    }
}
