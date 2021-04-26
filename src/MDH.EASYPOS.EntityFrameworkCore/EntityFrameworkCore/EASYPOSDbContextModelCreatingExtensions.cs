using MDH.EASYPOS.Sales;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace MDH.EASYPOS.EntityFrameworkCore
{
    public static class EASYPOSDbContextModelCreatingExtensions
    {
        public static void ConfigureEASYPOS(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(EASYPOSConsts.DbTablePrefix + "YourEntities", EASYPOSConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});


            builder.Entity<Sale>(b =>
            {
                b.ToTable(EASYPOSConsts.DbTablePrefix + "Sales", EASYPOSConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<SaleDetail>(b =>
            {
                b.ToTable(EASYPOSConsts.DbTablePrefix + "SaleDetails", EASYPOSConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}
