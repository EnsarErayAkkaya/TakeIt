using System.Threading.Tasks;
using TakeIt.Web.Controllers;
using Shouldly;
using Xunit;

namespace TakeIt.Web.Tests.Controllers
{
    public class HomeController_Tests: TakeItWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
