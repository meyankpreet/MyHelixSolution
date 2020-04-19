using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Collections;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Version = Sitecore.Data.Version;
using MyHelixSolution.Foundation.GlassORM;

namespace MyHelixSolution.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        //private readonly IMvcContext _mvcContext;
        //public NavigationController(IMvcContext mvcContext)
        //{
        //    _mvcContext = mvcContext;
        //}
        // GET: Navigation
        public ActionResult Indexa()
        {
            
            IMvcContext mvcContext = new MvcContext();
            var eventsItem = mvcContext.SitecoreService.GetItem<Sitecore.Data.Items.Item>(new Guid("5D468B60-FDC5-490C-905B-ED9DA93449E4"));
            var ds = mvcContext.SitecoreService.GetItem<Page>(new Guid("5D468B60-FDC5-490C-905B-ED9DA93449E4"));
            //var dss = _mvcContext.SitecoreService.GetItem<Page>(new Guid("5D468B60-FDC5-490C-905B-ED9DA93449E4"));
            
            return View();
        }
    }

    [SitecoreType(AutoMap = true)]
    public class Page: BaseItem     
    {
        
        public virtual Database Database { get; set; }
        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual ID Id { get; set; }
        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; set; }
        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual Version Version { get; set; }
        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string Name { get; set; }

        public override FieldCollection Fields => throw new NotImplementedException();
    }
}