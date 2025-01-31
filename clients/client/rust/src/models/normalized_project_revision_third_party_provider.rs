/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.5
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct NormalizedProjectRevisionThirdPartyProvider {
    #[serde(rename = "additional_id_token_audiences", skip_serializing_if = "Option::is_none")]
    pub additional_id_token_audiences: Option<Vec<String>>,
    #[serde(rename = "apple_private_key", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub apple_private_key: Option<Option<String>>,
    /// Apple Private Key Identifier  Sign In with Apple Private Key Identifier needed for generating a JWT token for client secret
    #[serde(rename = "apple_private_key_id", skip_serializing_if = "Option::is_none")]
    pub apple_private_key_id: Option<String>,
    /// Apple Developer Team ID  Apple Developer Team ID needed for generating a JWT token for client secret
    #[serde(rename = "apple_team_id", skip_serializing_if = "Option::is_none")]
    pub apple_team_id: Option<String>,
    /// AuthURL is the authorize url, typically something like: https://example.org/oauth2/auth Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when `provider` is set to `generic`.
    #[serde(rename = "auth_url", skip_serializing_if = "Option::is_none")]
    pub auth_url: Option<String>,
    /// Tenant is the Azure AD Tenant to use for authentication, and must be set when `provider` is set to `microsoft`.  Can be either `common`, `organizations`, `consumers` for a multitenant application or a specific tenant like `8eaef023-2b34-4da1-9baa-8bc8c9d6a490` or `contoso.onmicrosoft.com`.
    #[serde(rename = "azure_tenant", skip_serializing_if = "Option::is_none")]
    pub azure_tenant: Option<String>,
    #[serde(rename = "claims_source", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub claims_source: Option<Option<String>>,
    /// ClientID is the application's Client ID.
    #[serde(rename = "client_id", skip_serializing_if = "Option::is_none")]
    pub client_id: Option<String>,
    #[serde(rename = "client_secret", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub client_secret: Option<Option<String>>,
    /// The Project's Revision Creation Date
    #[serde(rename = "created_at", skip_serializing_if = "Option::is_none")]
    pub created_at: Option<String>,
    #[serde(rename = "id", skip_serializing_if = "Option::is_none")]
    pub id: Option<String>,
    /// IssuerURL is the OpenID Connect Server URL. You can leave this empty if `provider` is not set to `generic`. If set, neither `auth_url` nor `token_url` are required.
    #[serde(rename = "issuer_url", skip_serializing_if = "Option::is_none")]
    pub issuer_url: Option<String>,
    /// Label represents an optional label which can be used in the UI generation.
    #[serde(rename = "label", skip_serializing_if = "Option::is_none")]
    pub label: Option<String>,
    /// Mapper specifies the JSONNet code snippet which uses the OpenID Connect Provider's data (e.g. GitHub or Google profile information) to hydrate the identity's data.
    #[serde(rename = "mapper_url", skip_serializing_if = "Option::is_none")]
    pub mapper_url: Option<String>,
    #[serde(rename = "organization_id", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub organization_id: Option<Option<String>>,
    /// PKCE controls if the OpenID Connect OAuth2 flow should use PKCE (Proof Key for Code Exchange). Possible values are: `auto` (default), `never`, `force`. `auto`: PKCE is used if the provider supports it. Requires setting `issuer_url`. `never`: Disable PKCE entirely for this provider, even if the provider advertises support for it. `force`: Always use PKCE, even if the provider does not advertise support for it. OAuth2 flows will fail if the provider does not support PKCE. IMPORTANT: If you set this to `force`, you must whitelist a different return URL for your OAuth2 client in the provider's configuration. Instead of <base-url>/self-service/methods/oidc/callback/<provider>, you must use <base-url>/self-service/methods/oidc/callback (Note the missing <provider> path segment and no trailing slash).
    #[serde(rename = "pkce", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub pkce: Option<Option<PkceEnum>>,
    /// The Revision's ID this schema belongs to
    #[serde(rename = "project_revision_id", skip_serializing_if = "Option::is_none")]
    pub project_revision_id: Option<String>,
    /// Provider is either \"generic\" for a generic OAuth 2.0 / OpenID Connect Provider or one of: generic google github gitlab microsoft discord slack facebook vk yandex apple
    #[serde(rename = "provider", skip_serializing_if = "Option::is_none")]
    pub provider: Option<String>,
    /// ID is the provider's ID
    #[serde(rename = "provider_id", skip_serializing_if = "Option::is_none")]
    pub provider_id: Option<String>,
    #[serde(rename = "requested_claims", skip_serializing_if = "Option::is_none")]
    pub requested_claims: Option<serde_json::Value>,
    #[serde(rename = "scope", skip_serializing_if = "Option::is_none")]
    pub scope: Option<Vec<String>>,
    /// State indicates the state of the provider  Only providers with state `enabled` will be used for authentication enabled ThirdPartyProviderStateEnabled disabled ThirdPartyProviderStateDisabled
    #[serde(rename = "state", skip_serializing_if = "Option::is_none")]
    pub state: Option<StateEnum>,
    #[serde(rename = "subject_source", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub subject_source: Option<Option<String>>,
    /// TokenURL is the token url, typically something like: https://example.org/oauth2/token  Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when `provider` is set to `generic`.
    #[serde(rename = "token_url", skip_serializing_if = "Option::is_none")]
    pub token_url: Option<String>,
    /// Last Time Project's Revision was Updated
    #[serde(rename = "updated_at", skip_serializing_if = "Option::is_none")]
    pub updated_at: Option<String>,
}

impl NormalizedProjectRevisionThirdPartyProvider {
    pub fn new() -> NormalizedProjectRevisionThirdPartyProvider {
        NormalizedProjectRevisionThirdPartyProvider {
            additional_id_token_audiences: None,
            apple_private_key: None,
            apple_private_key_id: None,
            apple_team_id: None,
            auth_url: None,
            azure_tenant: None,
            claims_source: None,
            client_id: None,
            client_secret: None,
            created_at: None,
            id: None,
            issuer_url: None,
            label: None,
            mapper_url: None,
            organization_id: None,
            pkce: None,
            project_revision_id: None,
            provider: None,
            provider_id: None,
            requested_claims: None,
            scope: None,
            state: None,
            subject_source: None,
            token_url: None,
            updated_at: None,
        }
    }
}
/// PKCE controls if the OpenID Connect OAuth2 flow should use PKCE (Proof Key for Code Exchange). Possible values are: `auto` (default), `never`, `force`. `auto`: PKCE is used if the provider supports it. Requires setting `issuer_url`. `never`: Disable PKCE entirely for this provider, even if the provider advertises support for it. `force`: Always use PKCE, even if the provider does not advertise support for it. OAuth2 flows will fail if the provider does not support PKCE. IMPORTANT: If you set this to `force`, you must whitelist a different return URL for your OAuth2 client in the provider's configuration. Instead of <base-url>/self-service/methods/oidc/callback/<provider>, you must use <base-url>/self-service/methods/oidc/callback (Note the missing <provider> path segment and no trailing slash).
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum PkceEnum {
    #[serde(rename = "auto")]
    Auto,
    #[serde(rename = "never")]
    Never,
    #[serde(rename = "force")]
    Force,
}

impl Default for PkceEnum {
    fn default() -> PkceEnum {
        Self::Auto
    }
}
/// State indicates the state of the provider  Only providers with state `enabled` will be used for authentication enabled ThirdPartyProviderStateEnabled disabled ThirdPartyProviderStateDisabled
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum StateEnum {
    #[serde(rename = "enabled")]
    Enabled,
    #[serde(rename = "disabled")]
    Disabled,
}

impl Default for StateEnum {
    fn default() -> StateEnum {
        Self::Enabled
    }
}

