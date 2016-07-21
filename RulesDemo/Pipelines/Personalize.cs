using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Analytics.Pipelines.Response.CustomizeRendering;

namespace RulesDemo.Pipelines
{
    public class Personalize : Sitecore.Mvc.Analytics.Pipelines.Response.CustomizeRendering.Personalize
    {
        public override void Process(CustomizeRenderingArgs args)
        {
            Assert.ArgumentNotNull((object) args, "args");
            if (args.IsCustomized)
                return;
            this.Evaluate(args);
        }
    }
}
