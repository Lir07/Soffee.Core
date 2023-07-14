using Soffee.Core.Api.Tests.Acceptance.Brokers;
using Xunit;

namespace Soffee.Core.Api.Tests.Acceptance.Apis.Home
{
    [Collection(nameof(ApiTestCollection))]
    public partial class HomeApiTest
    {
        private readonly SoffeeApiBroker soffeeApiBroker;
        public HomeApiTest(SoffeeApiBroker soffeeApiBroker) =>
            this.soffeeApiBroker = soffeeApiBroker;

    }
}
