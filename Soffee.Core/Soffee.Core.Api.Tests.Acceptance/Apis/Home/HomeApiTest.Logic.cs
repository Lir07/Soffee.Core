using FluentAssertions;
using Xunit;

namespace Soffee.Core.Api.Tests.Acceptance.Apis.Home
{
    public partial class HomeApiTest
    {
        [Fact]
        public async Task ShouldReturnMessageAsync()
        {
            //given
            string expectedHomeMsg = "Hello";

            //when
            string actualHomeMsg =
                await this.soffeeApiBroker.GetHomeMsgAsync();

            //then
            actualHomeMsg.Should().BeEquivalentTo(expectedHomeMsg);

        }
    }
}
