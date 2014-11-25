using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Localization;
using Abp.Localization.Sources.Xml;
using Abp.Modules;

namespace Onderdelenshop.Web
{
    [DependsOn(typeof(OnderdelenshopDataModule), typeof(OnderdelenshopApplicationModule), typeof(OnderdelenshopWebApiModule))]
    public class OnderdelenshopWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
			Configuration.Localization.Languages.Add(new LanguageInfo("nl", "Nederlands", "famfamfam-flag-be"));

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    OnderdelenshopConsts.LocalizationSourceName,
                    HttpContext.Current.Server.MapPath("~/Localization/Onderdelenshop")
                    )
                );

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<OnderdelenshopNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
