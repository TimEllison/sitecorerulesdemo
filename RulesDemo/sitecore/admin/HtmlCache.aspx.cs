using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarMax.Online.Web.Models.Base;
using Sitecore.Caching;
using Sitecore.Data;
using Sitecore.Sites;

namespace CarMax.Online.Web.sitecore.admin
{
    public partial class HtmlCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cache = CacheManager.GetHtmlCache(SiteContext.GetSite("carmax"));

            var context = new Glass.Mapper.Sc.SitecoreContext(Database.GetDatabase("master"));
            var renderings =
                context.Query<ContentBase>(
                    "/sitecore/layout/Renderings/Carmax//*[@@templatename='View rendering' or @@templatename='Controller rendering']");

            var data = from rendering in renderings
                let keys =
                    cache.InnerCache.GetCacheKeys()
                        .ToArray()
                        .Where(x => x.ToString().ToLower().Contains(rendering.FullPath.ToLower()))
                select new
                {
                    Name = rendering.FullPath,
                    CacheCount = keys.Count()
                };

            foreach (var item in data)
            {
               TableBody.Controls.Add(new LiteralControl(string.Format("<tr><td>{0}</td><td>{1}</tr>", item.Name, item.CacheCount)));
            }
        }
    }
}