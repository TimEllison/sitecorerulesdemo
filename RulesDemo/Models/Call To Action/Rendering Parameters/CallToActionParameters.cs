using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Shell.Framework.Commands;

namespace RulesDemo.Models.Call_To_Action.Rendering_Parameters
{
    [SitecoreType(TemplateId= "{AA58F297-4635-48CE-8803-DD1344945CBE}", Cachable = true)]
    public class CallToActionParameters
    {
        [SitecoreField("Link Size")]
        public virtual StandardText LinkSize { get; set; }

        [SitecoreField("Sprite")]
        public virtual StandardText Sprite { get; set; }

        [SitecoreField("Show Sprite")]
        public virtual bool ShowSprite { get; set; }
    }
}