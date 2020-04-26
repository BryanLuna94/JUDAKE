using System.Net.Http;
using System.Web.Http.Cors;

namespace JUDAKE.WebApi.Utility.Factories
{
    public class CorsPolicyFactory : ICorsPolicyProviderFactory
    {
        readonly ICorsPolicyProvider _provider = new WACorsPolicyAttribute();

        public ICorsPolicyProvider GetCorsPolicyProvider(HttpRequestMessage request)
        {
            return _provider;
        }
    }
}