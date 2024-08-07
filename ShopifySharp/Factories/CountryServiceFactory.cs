#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using System;
using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

[Obsolete("https://shopify.dev/changelog/deprecation-notice-country-and-province-endpoints-in-admin-rest-api")]
public interface ICountryServiceFactory : IServiceFactory<ICountryService>;

[Obsolete("https://shopify.dev/changelog/deprecation-notice-country-and-province-endpoints-in-admin-rest-api")]
public class CountryServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICountryServiceFactory
{
    /// <inheritDoc />
    public virtual ICountryService Create(string shopDomain, string accessToken)
    {
        ICountryService service = shopifyDomainUtility is null ? new CountryService(shopDomain, accessToken) : new CountryService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICountryService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
