using Abp.Application.Navigation;
using Abp.Localization;

namespace Onderdelenshop.Web{
	/// <summary>
	///     This class defines menus for the application.
	///     It uses ABP's menu system.
	///     When you add menu items here, they are automatically appear in angular application.
	///     See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
	/// </summary>
	/// 
	public class OnderdelenshopNavigationProvider : NavigationProvider{
		public override void SetNavigation(INavigationProviderContext context){
			context.Manager.MainMenu
				.AddItem(
					new MenuItemDefinition(
						"Home",
						new LocalizableString("HomePage", OnderdelenshopConsts.LocalizationSourceName),
						url: "#/",
						icon: "fa fa-home"
						)
				).AddItem(
					new MenuItemDefinition(
						"ListParts",
						new LocalizableString("ListParts", OnderdelenshopConsts.LocalizationSourceName),
						url: "#/list",
						icon: "fa fa-wrench"
						)
				).AddItem(
					new MenuItemDefinition(
						"Administration",
						new LocalizableString("Administration", OnderdelenshopConsts.LocalizationSourceName),
						icon: "fa fa-cogs"
						).AddItem(
							new MenuItemDefinition(
								"UserManagement",
								new LocalizableString("UserManagement", OnderdelenshopConsts.LocalizationSourceName),
								url: "#/Administration/Users",
								icon: "fa fa-users",
								requiredPermissionName: "SimpleTaskSystem.Permissions.UserManagement"
								)
						).AddItem(
							new MenuItemDefinition(
								"RoleManagement",
								new LocalizableString("RoleManagement", OnderdelenshopConsts.LocalizationSourceName),
								url: "#/Administration/Roles",
								icon: "fa fa-star",
								requiredPermissionName: "SimpleTaskSystem.Permissions.RoleManagement"
								)
						)
				);
		}
	}
}