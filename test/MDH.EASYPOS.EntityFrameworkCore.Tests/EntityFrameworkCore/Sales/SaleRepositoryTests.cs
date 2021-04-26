using System;
using System.Threading.Tasks;
using MDH.EASYPOS.Sales;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MDH.EASYPOS.EntityFrameworkCore.Sales
{
    public class SaleRepositoryTests : EASYPOSEntityFrameworkCoreTestBase
    {
        private readonly ISaleRepository _saleRepository;

        public SaleRepositoryTests()
        {
            _saleRepository = GetRequiredService<ISaleRepository>();
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
