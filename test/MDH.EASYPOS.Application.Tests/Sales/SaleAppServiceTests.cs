using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MDH.EASYPOS.Sales
{
    public class SaleAppServiceTests : EASYPOSApplicationTestBase
    {
        private readonly ISaleAppService _saleAppService;

        public SaleAppServiceTests()
        {
            _saleAppService = GetRequiredService<ISaleAppService>();
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
