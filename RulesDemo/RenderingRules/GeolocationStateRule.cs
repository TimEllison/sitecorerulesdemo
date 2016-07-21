using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;

namespace RulesDemo.RenderingRules
{
    public class GeolocationStateRule<T> : WhenCondition<T> where T : RuleContext
    {
        public string StateCode { get; set; }
        protected override bool Execute(T ruleContext)
        {
            var cookie = HttpContext.Current.Request.Cookies["Geolocation"];
            if (cookie == null) return false;
            return StateCode == cookie["State"];
        }
    }
}
