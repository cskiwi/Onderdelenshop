using Abp.Application.Services;

namespace Onderdelenshop{
	/// <summary>
	///     Derive your application services from this class.
	/// </summary>
	public abstract class OnderdelenshopAppServiceBase : ApplicationService{
		protected OnderdelenshopAppServiceBase(){
			LocalizationSourceName = OnderdelenshopConsts.LocalizationSourceName;
		}
	}
}