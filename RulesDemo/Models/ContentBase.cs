using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace RulesDemo.Models
{
    [SitecoreType]
    public class ContentBase
    {
        [SitecoreId]
        public Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public string Name { get; set; }
    }
}
