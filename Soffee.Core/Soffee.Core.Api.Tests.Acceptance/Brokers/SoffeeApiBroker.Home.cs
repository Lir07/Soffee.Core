namespace Soffee.Core.Api.Tests.Acceptance.Brokers
{
    public partial class SoffeeApiBroker
    {
        private const string HomeRelativeUrl = "api/home";

        public async ValueTask<string> GetHomeMsgAsync() =>
            await this.apiFactoryClient.GetContentStringAsync(HomeRelativeUrl);
    }
}
