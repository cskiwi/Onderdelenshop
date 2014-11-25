using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Onderdelenshop
{
	[DependsOn(typeof(AbpWebApiModule), typeof(OnderdelenshopApplicationModule))]
    public class OnderdelenshopWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
				.ForAll<IApplicationService>(Assembly.GetAssembly(typeof(OnderdelenshopApplicationModule)), "tasksystem")
                .Build();
        }
    }
}
