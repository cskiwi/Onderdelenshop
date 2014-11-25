using System.Reflection;
using Abp.Modules;

namespace Onderdelenshop{
	[DependsOn(typeof (OnderdelenshopCoreModule))]
	public class OnderdelenshopApplicationModule : AbpModule{
		public override void Initialize(){
			IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

			DtoMappings.Map();

		}

	}
}