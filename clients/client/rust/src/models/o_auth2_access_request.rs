/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.21
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct OAuth2AccessRequest {
    /// ClientID is the identifier of the OAuth 2.0 client.
    #[serde(rename = "client_id", skip_serializing_if = "Option::is_none")]
    pub client_id: Option<String>,
    /// GrantTypes is the requests grant types.
    #[serde(rename = "grant_types", skip_serializing_if = "Option::is_none")]
    pub grant_types: Option<Vec<String>>,
    /// GrantedAudience is the list of audiences granted to the OAuth 2.0 client.
    #[serde(rename = "granted_audience", skip_serializing_if = "Option::is_none")]
    pub granted_audience: Option<Vec<String>>,
    /// GrantedScopes is the list of scopes granted to the OAuth 2.0 client.
    #[serde(rename = "granted_scopes", skip_serializing_if = "Option::is_none")]
    pub granted_scopes: Option<Vec<String>>,
}

impl Default for OAuth2AccessRequest {
    fn default() -> Self {
        Self::new()
    }
}

impl OAuth2AccessRequest {
    pub fn new() -> OAuth2AccessRequest {
        OAuth2AccessRequest {
                client_id: None,
                grant_types: None,
                granted_audience: None,
                granted_scopes: None,
        }
    }
}


