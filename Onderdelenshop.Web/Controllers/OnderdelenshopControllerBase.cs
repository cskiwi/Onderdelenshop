using Abp.Web.Mvc.Controllers;

namespace Onderdelenshop.Web.Controllers
{
    public abstract class OnderdelenshopControllerBase : AbpController
    {
        protected OnderdelenshopControllerBase()
        {
            LocalizationSourceName = OnderdelenshopConsts.LocalizationSourceName;
        }
    }
}