using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;

namespace Soffee.Core.Api.Tests.Acceptance.Brokers
{
    public partial class SoffeeApiBroker
    {
        private readonly WebApplicationFactory<Startup> webApplicationFactory;
        private readonly HttpClient httpClient;
        private readonly IRESTFulApiFactoryClient apiFactoryClient;

        public SoffeeApiBroker()
        {
            this.webApplicationFactory = new WebApplicationFactory<Startup>();
            this.httpClient = this.webApplicationFactory.CreateClient();
            this.apiFactoryClient = new RESTFulApiFactoryClient(this.httpClient);
        }
    }
}
