using System.Reflection;
using Abp.Modules;

namespace Onderdelenshop{
	public class OnderdelenshopCoreModule : AbpModule{
		public override void Initialize(){
			IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
		}
	}
}