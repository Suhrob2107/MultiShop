using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace MultiShop.IdentityServer;

public static class Config
{
    public static IEnumerable<ApiResource> ApiResources => new ApiResource[] // API kaynakları tanımlanıyor
    {
        new ApiResource("ResourceCatalog"){Scopes = { "CatalogFullPermission","CatalogReadPermission" }}, // API kaynakları tanımlanıyor
        new ApiResource("ResourceDiscount"){Scopes = { "DiscountFullPermission" }}, // API kaynakları tanımlanıyor
        new ApiResource("ResourceOrder"){Scopes = { "OrderFullPermission" }}, // API kaynakları tanımlanıyor
        new ApiResource(IdentityServerConstants.LocalApi.ScopeName) // Local API kaynağı tanımlanıyor
    };
    public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[] // Kimlik kaynakları tanımlanıyor
    {
        new IdentityResources.OpenId(), // OpenID Connect standard kimlik kaynağı
        new IdentityResources.Email(), // E-posta kimlik kaynağı
        new IdentityResources.Profile(), // Profil kimlik kaynağı
    };
    public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]  // API kapsamları tanımlanıyor
    {
        new ApiScope("CatalogFullPermission","Full authority for catalog operations"), // API kapsamları tanımlanıyor
        new ApiScope("CatalogReadPermission","Read authority for catalog operations"),
        new ApiScope("DiscountFullPermission","Full authority for discount operations"),
        new ApiScope("OrderFullPermission","Full authority for order operations"),
        new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
    };
    public static IEnumerable<Client> Clients => new Client[] // İstemciler tanımlanıyor
    {
        new Client // Ziyaretçi kullanıcı için istemci tanımı
        {
            ClientId = "MultiShopVisitorId",
            ClientName = "Multi Shop Visitor User",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = {new Secret("multishopsecret".Sha256())},
            AllowedScopes = { "DiscountFullPermission" }
        },
        new Client // Mağaza yöneticisi kullanıcı için istemci tanımı
        {
            ClientId = "MultiShopManagerId",
            ClientName = "Multi Shop Manager User",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = {new Secret("multishopsecret".Sha256())},
            AllowedScopes = { "CatalogReadPermission", "CatalogFullPermission" }
        },
        new Client // Sistem yöneticisi kullanıcı için istemci tanımı
        {
            ClientId = "MultiShopAdminId",
            ClientName = "Multi Shop Admin User",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = {new Secret("multishopsecret".Sha256())},
            AllowedScopes = // İzin verilen kapsamlar tanımlanıyor
            {
                "CatalogReadPermission",
                "CatalogFullPermission",
                "DiscountFullPermission",
                "OrderFullPermission",
                IdentityServerConstants.LocalApi.ScopeName, // Local API kapsamı ekleniyor
                IdentityServerConstants.StandardScopes.Email, // E-posta kapsamı ekleniyor
                IdentityServerConstants.StandardScopes.OpenId, // OpenID kapsamı ekleniyor
                IdentityServerConstants.StandardScopes.Profile //   Profil kapsamı ekleniyor
            },
            AccessTokenLifetime = 600 // Erişim belirteci ömrü 600 saniye olarak ayarlanıyor
        }
    };
}
