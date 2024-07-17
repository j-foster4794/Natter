using System.Threading.Tasks;
using Natter.Models.TokenAuth;
using Natter.Web.Controllers;
using Shouldly;
using Xunit;

namespace Natter.Web.Tests.Controllers
{
    public class HomeController_Tests: NatterWebTestBase
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