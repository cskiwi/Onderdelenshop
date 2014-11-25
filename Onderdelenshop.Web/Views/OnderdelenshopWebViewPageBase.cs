using Abp.Web.Mvc.Views;

namespace Onderdelenshop.Web.Views
{
    public abstract class OnderdelenshopWebViewPageBase : OnderdelenshopWebViewPageBase<dynamic>
    {

    }

    public abstract class OnderdelenshopWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected OnderdelenshopWebViewPageBase()
        {
            LocalizationSourceName = OnderdelenshopConsts.LocalizationSourceName;
        }
    }
}