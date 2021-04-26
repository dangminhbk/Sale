using System.Threading.Tasks;
using MDH.EASYPOS.Permissions;
using MDH.EASYPOS.Localization;
using MDH.EASYPOS.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace MDH.EASYPOS.Blazor.Server.Menus
{
    public class EASYPOSMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var administration = context.Menu.GetAdministration();
            var l = context.GetLocalizer<EASYPOSResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    EASYPOSMenus.Home,
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home",
                    order: 0
                )
            );
            
            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

            if (context.IsGrantedAsync(EASYPOSPermissions.Sale.Default).Result)
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(EASYPOSMenus.Sale, l["Menu:Sale"], "/Sales/Sale")
                );
            }
            if (context.IsGrantedAsync(EASYPOSPermissions.SaleDetail.Default).Result)
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(EASYPOSMenus.SaleDetail, l["Menu:SaleDetail"], "/Sales/SaleDetail")
                );
            }

            return Task.CompletedTask;
        }
    }
}
