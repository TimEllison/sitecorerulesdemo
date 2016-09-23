using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace RulesDemo.Models
{
    [SitecoreType(TemplateId= "{704A6FE9-9DA6-4DF2-B60A-D8FDB3346479}", Cachable=true)]
    public class StandardText : ContentBase
    {
        [SitecoreField("Value")]
        public virtual string Value { get; set; }
    }
}