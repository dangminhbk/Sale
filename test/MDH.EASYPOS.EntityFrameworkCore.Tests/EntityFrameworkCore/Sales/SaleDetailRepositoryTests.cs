using System;
using System.Threading.Tasks;
using MDH.EASYPOS.Sales;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MDH.EASYPOS.EntityFrameworkCore.Sales
{
    public class SaleDetailRepositoryTests : EASYPOSEntityFrameworkCoreTestBase
    {
        private readonly ISaleDetailRepository _saleDetailRepository;

        public SaleDetailRepositoryTests()
        {
            _saleDetailRepository = GetRequiredService<ISaleDetailRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
