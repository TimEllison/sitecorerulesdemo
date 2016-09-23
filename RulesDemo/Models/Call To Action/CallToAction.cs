using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace RulesDemo.Models.Call_To_Action
{
    [SitecoreType(TemplateId= "{D65837DE-AE7E-4A46-AF99-314336C28BBE}", Cachable =true)]
    public class CallToAction : ContentBase
    {
        [SitecoreField("CTA Link")]
        public virtual Link CtaLink { get; set; }  

        [SitecoreField("CTA Text")]
        public virtual string CtaText { get; set; }
    }
}