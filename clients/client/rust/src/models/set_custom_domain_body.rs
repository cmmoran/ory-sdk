/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.2
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;

/// SetCustomDomainBody : Update Custom Hostname Body
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct SetCustomDomainBody {
    /// The domain where cookies will be set. Has to be a parent domain of the custom hostname to work.
    #[serde(rename = "cookie_domain", skip_serializing_if = "Option::is_none")]
    pub cookie_domain: Option<String>,
    /// CORS Allowed origins for the custom hostname.
    #[serde(rename = "cors_allowed_origins", skip_serializing_if = "Option::is_none")]
    pub cors_allowed_origins: Option<Vec<String>>,
    /// CORS Enabled for the custom hostname.
    #[serde(rename = "cors_enabled", skip_serializing_if = "Option::is_none")]
    pub cors_enabled: Option<bool>,
    /// The custom UI base URL where the UI will be exposed.
    #[serde(rename = "custom_ui_base_url", skip_serializing_if = "Option::is_none")]
    pub custom_ui_base_url: Option<String>,
    /// The custom hostname where the API will be exposed.
    #[serde(rename = "hostname", skip_serializing_if = "Option::is_none")]
    pub hostname: Option<String>,
}

impl SetCustomDomainBody {
    /// Update Custom Hostname Body
    pub fn new() -> SetCustomDomainBody {
        SetCustomDomainBody {
            cookie_domain: None,
            cors_allowed_origins: None,
            cors_enabled: None,
            custom_ui_base_url: None,
            hostname: None,
        }
    }
}

