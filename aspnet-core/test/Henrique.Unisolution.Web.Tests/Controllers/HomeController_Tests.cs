using System.Threading.Tasks;
using Henrique.Unisolution.Models.TokenAuth;
using Henrique.Unisolution.Web.Controllers;
using Shouldly;
using Xunit;

namespace Henrique.Unisolution.Web.Tests.Controllers
{
    public class HomeController_Tests: UnisolutionWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}