#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IOrderRiskServiceFactory : IServiceFactory<IOrderRiskService>;

public class OrderRiskServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IOrderRiskServiceFactory
{
    /// <inheritDoc />
    public virtual IOrderRiskService Create(string shopDomain, string accessToken)
    {
        IOrderRiskService service = shopifyDomainUtility is null ? new OrderRiskService(shopDomain, accessToken) : new OrderRiskService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IOrderRiskService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
