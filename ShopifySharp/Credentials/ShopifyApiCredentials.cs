#if NETSTANDARD2_0
#else
#nullable enable
#endif

using System;

namespace ShopifySharp.Credentials;

public readonly struct ShopifyApiCredentials(string shopDomain, string accessToken)
{
    public string ShopDomain { get; } = shopDomain;
    public string AccessToken { get; } = accessToken;

#if NETSTANDARD2_0
        public override bool Equals(object obj)
        {
            return obj is ShopifyApiCredentials other
                && ShopDomain == other.ShopDomain
                && AccessToken == other.AccessToken;
        }
#else
    public override bool Equals(object? obj)
    {
        return obj is ShopifyApiCredentials other
               && ShopDomain == other.ShopDomain
               && AccessToken == other.AccessToken;
    }
#endif

    public override int GetHashCode()
    {

        return (ShopDomain, AccessToken).GetHashCode();

    }

    public static bool operator ==(ShopifyApiCredentials left, ShopifyApiCredentials right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ShopifyApiCredentials left, ShopifyApiCredentials right)
    {
        return !(left == right);
    }
}