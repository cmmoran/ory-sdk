/*
 * Ory Hydra API
 *
 * Documentation for all of Ory Hydra's APIs. 
 *
 * The version of the OpenAPI document: v2.4.0-alpha.1
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// OAuth2ClientTokenLifespans : Lifespans of different token types issued for this OAuth 2.0 Client.
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct OAuth2ClientTokenLifespans {
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "authorization_code_grant_access_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub authorization_code_grant_access_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "authorization_code_grant_id_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub authorization_code_grant_id_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "authorization_code_grant_refresh_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub authorization_code_grant_refresh_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "client_credentials_grant_access_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub client_credentials_grant_access_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "device_authorization_grant_access_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub device_authorization_grant_access_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "device_authorization_grant_id_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub device_authorization_grant_id_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "device_authorization_grant_refresh_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub device_authorization_grant_refresh_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "implicit_grant_access_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub implicit_grant_access_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "implicit_grant_id_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub implicit_grant_id_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "jwt_bearer_grant_access_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub jwt_bearer_grant_access_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "refresh_token_grant_access_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub refresh_token_grant_access_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "refresh_token_grant_id_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub refresh_token_grant_id_token_lifespan: Option<String>,
    /// Specify a time duration in milliseconds, seconds, minutes, hours.
    #[serde(rename = "refresh_token_grant_refresh_token_lifespan", skip_serializing_if = "Option::is_none")]
    pub refresh_token_grant_refresh_token_lifespan: Option<String>,
}

impl OAuth2ClientTokenLifespans {
    /// Lifespans of different token types issued for this OAuth 2.0 Client.
    pub fn new() -> OAuth2ClientTokenLifespans {
        OAuth2ClientTokenLifespans {
            authorization_code_grant_access_token_lifespan: None,
            authorization_code_grant_id_token_lifespan: None,
            authorization_code_grant_refresh_token_lifespan: None,
            client_credentials_grant_access_token_lifespan: None,
            device_authorization_grant_access_token_lifespan: None,
            device_authorization_grant_id_token_lifespan: None,
            device_authorization_grant_refresh_token_lifespan: None,
            implicit_grant_access_token_lifespan: None,
            implicit_grant_id_token_lifespan: None,
            jwt_bearer_grant_access_token_lifespan: None,
            refresh_token_grant_access_token_lifespan: None,
            refresh_token_grant_id_token_lifespan: None,
            refresh_token_grant_refresh_token_lifespan: None,
        }
    }
}

