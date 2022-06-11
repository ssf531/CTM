using System.Threading.Tasks;
using CTM.Models.TokenAuth;
using CTM.Web.Controllers;
using Shouldly;
using Xunit;

namespace CTM.Web.Tests.Controllers
{
    public class HomeController_Tests: CTMWebTestBase
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