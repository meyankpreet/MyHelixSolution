using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Web.Mvc;
using MyHelixSolution.Feature.Demo.Models;
using Sitecore.Collections;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHelixSolution.Feature.Demo.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        public ActionResult Indexdemo()
        {


            IMvcContext mvcContext = new MvcContext();
            var eventsItem = mvcContext.SitecoreService.GetItem<Sitecore.Data.Items.Item>(new Guid("5D468B60-FDC5-490C-905B-ED9DA93449E4"));
           // var ds = mvcContext.SitecoreService.GetItem<Page>(new Guid("C82DFC32-4043-4799-BA41-38779CA8359B"));
            var ds = mvcContext.SitecoreService.GetItem<Page>(mvcContext.DataSourceItem.ID.ToString());
            var dss = mvcContext.GetDataSourceItem<Page>();// SitecoreService.GetItem<Page>(new Guid("5D468B60-FDC5-490C-905B-ED9DA93449E4"));
            
            return View(dss);
        }
    }

   
}