using Xunit;

namespace Soffee.Core.Api.Tests.Acceptance.Brokers
{
    [CollectionDefinition(nameof(ApiTestCollection))]
    public class ApiTestCollection : ICollectionFixture<SoffeeApiBroker>
    {
    }
}
