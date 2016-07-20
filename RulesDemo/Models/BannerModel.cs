using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration.Fluent;
using Glass.Mapper.Sc.Fields;

namespace RulesDemo.Models
{
    [SitecoreType(TemplateId=Constants.TemplateIds.BannerTemplate)]
    public class BannerModel
    {
        [SitecoreField("Banner Background")]
        public virtual Image BackgroundImage { get; set; }

        [SitecoreField("Banner Tagline")]
        public virtual string BannerTagline { get; set; }
    }
}
