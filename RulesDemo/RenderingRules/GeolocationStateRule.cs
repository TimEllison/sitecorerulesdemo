using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Glass.Mapper.Sc;
using RulesDemo.Models;
using Sitecore.Data.Items;
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
            var context = new SitecoreContext();
            var model = context.GetItem<StandardText>(Guid.Parse(StateCode));
            if (cookie == null) return false;
            return model.Value.Equals(cookie["State"], StringComparison.OrdinalIgnoreCase);
        }
    }
}
