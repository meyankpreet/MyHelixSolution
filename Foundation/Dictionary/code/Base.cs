using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHelixSolution.Foundation.GlassORM
{
    public class BaseItemF
    {
        public Guid Id { get; set; }
    }
    public class PageModel : BaseItemF
    {
        public string PageHeader { get; set; }
    }

    [SitecoreType]
    public interface IGlassBase
    {
        // Mandatory for Glassmapper DO NOT delete
        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }
        // Mandatory for Glassmapper DO NOT delete
        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string Template { get; set; }
        // Mandatory for Glassmapper DO NOT delete
        [SitecoreId]
        Guid Id { get; set; }
    }
}