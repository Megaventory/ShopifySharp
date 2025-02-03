#if NETSTANDARD2_0
#else
#nullable enable
#endif

using System;

namespace ShopifySharp.Credentials;

public readonly struct ShopifyPartnerApiCredentials(long partnerOrganizationId, string accessToken)
{
    public long PartnerOrganizationId { get; } = partnerOrganizationId;
    public string AccessToken { get; } = accessToken;

#if NETSTANDARD2_0
        public override bool Equals(object obj)
        {
            return obj is ShopifyPartnerApiCredentials other
                && PartnerOrganizationId == other.PartnerOrganizationId
                && AccessToken == other.AccessToken;
        }
#else
    public override bool Equals(object? obj)
    {
        return obj is ShopifyPartnerApiCredentials other
               && PartnerOrganizationId == other.PartnerOrganizationId
               && AccessToken == other.AccessToken;
    }
#endif

    public override int GetHashCode()
    {
        return (PartnerOrganizationId, AccessToken).GetHashCode();
    }

    public static bool operator ==(ShopifyPartnerApiCredentials left, ShopifyPartnerApiCredentials right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ShopifyPartnerApiCredentials left, ShopifyPartnerApiCredentials right)
    {
        return !(left == right);
    }
}