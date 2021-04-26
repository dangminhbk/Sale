namespace MDH.EASYPOS.Permissions
{
    public static class EASYPOSPermissions
    {
        public const string GroupName = "EASYPOS";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class Sale
        {
            public const string Default = GroupName + ".Sale";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class SaleDetail
        {
            public const string Default = GroupName + ".SaleDetail";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
