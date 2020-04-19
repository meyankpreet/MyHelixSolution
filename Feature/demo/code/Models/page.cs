using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Collections;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace MyHelixSolution.Feature.Demo.Models
{
    [SitecoreType(AutoMap = true)]
    public class Page : BaseItem
    {

        public virtual string Title { get; set; }
        public virtual string Descripton { get; set; }
        public virtual Image Image { get; set; }


        public virtual Database Database { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual ID Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; set; }
        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual Sitecore.Data.Version Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; set; }

        public override FieldCollection Fields => throw new NotImplementedException();
    }
}