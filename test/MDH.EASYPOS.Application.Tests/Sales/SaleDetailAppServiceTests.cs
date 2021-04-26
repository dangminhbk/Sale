using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MDH.EASYPOS.Sales
{
    public class SaleDetailAppServiceTests : EASYPOSApplicationTestBase
    {
        private readonly ISaleDetailAppService _saleDetailAppService;

        public SaleDetailAppServiceTests()
        {
            _saleDetailAppService = GetRequiredService<ISaleDetailAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
