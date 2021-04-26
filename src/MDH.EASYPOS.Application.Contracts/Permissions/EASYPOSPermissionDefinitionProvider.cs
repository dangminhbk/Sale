using MDH.EASYPOS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MDH.EASYPOS.Permissions
{
    public class EASYPOSPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(EASYPOSPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(EASYPOSPermissions.MyPermission1, L("Permission:MyPermission1"));

            var salePermission = myGroup.AddPermission(EASYPOSPermissions.Sale.Default, L("Permission:Sale"));
            salePermission.AddChild(EASYPOSPermissions.Sale.Create, L("Permission:Create"));
            salePermission.AddChild(EASYPOSPermissions.Sale.Update, L("Permission:Update"));
            salePermission.AddChild(EASYPOSPermissions.Sale.Delete, L("Permission:Delete"));

            var saleDetailPermission = myGroup.AddPermission(EASYPOSPermissions.SaleDetail.Default, L("Permission:SaleDetail"));
            saleDetailPermission.AddChild(EASYPOSPermissions.SaleDetail.Create, L("Permission:Create"));
            saleDetailPermission.AddChild(EASYPOSPermissions.SaleDetail.Update, L("Permission:Update"));
            saleDetailPermission.AddChild(EASYPOSPermissions.SaleDetail.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<EASYPOSResource>(name);
        }
    }
}
