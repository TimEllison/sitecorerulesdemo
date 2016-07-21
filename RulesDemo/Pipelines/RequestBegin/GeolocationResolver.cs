using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Glass.Mapper;
using Sitecore.ApplicationCenter.Applications;
using Sitecore.Mvc.Pipelines.Request.RequestBegin;
using Sitecore.Pipelines.HttpRequest;

namespace RulesDemo.Pipelines.RequestBegin
{
    /// <summary>
    /// Pretend this is your Geolocation service providing the United States State in which your 
    /// user currently resolves to.  The Matching State custom rendering rule uses the value set in the resulting cookie
    /// to determine the conditional rendering outcome.  I've also included a matches non condition to demonstrate the ability 
    /// of Sitecore to not only differ datasource but also to provide a completely different rendering altogether..
    /// </summary>
    public class GeolocationResolver : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            var states = new string[]
            {
                "NC",
                "ND",
                "SD",
                "AK",
                "NY",
                "VA"
            };
            var itemNumber = new Random().Next(0, states.Length);
            if (Sitecore.Context.Database == null || Sitecore.Context.Database.Name == "master")
            {
                itemNumber = 5;
            }
            
            var cookie = args.Context.Request.Cookies.Get("Geolocation") ?? new HttpCookie("Geolocation");
            cookie.Expires = DateTime.UtcNow.AddMinutes(-1);
            cookie["State"] = states[itemNumber];
            args.Context.Request.Cookies.Remove("Geolocation");
            args.Context.Request.Cookies.Add(cookie);
            args.Context.Response.Cookies.Add(cookie);
            Sitecore.Diagnostics.Log.Debug("GEOLOCATION::User state has been set to {0}".Formatted(states[itemNumber]));
        }
    }
}
