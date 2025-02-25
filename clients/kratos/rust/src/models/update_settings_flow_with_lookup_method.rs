/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.7
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// UpdateSettingsFlowWithLookupMethod : Update Settings Flow with Lookup Method
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct UpdateSettingsFlowWithLookupMethod {
    /// CSRFToken is the anti-CSRF token
    #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
    pub csrf_token: Option<String>,
    /// If set to true will save the regenerated lookup secrets
    #[serde(rename = "lookup_secret_confirm", skip_serializing_if = "Option::is_none")]
    pub lookup_secret_confirm: Option<bool>,
    /// Disables this method if true.
    #[serde(rename = "lookup_secret_disable", skip_serializing_if = "Option::is_none")]
    pub lookup_secret_disable: Option<bool>,
    /// If set to true will regenerate the lookup secrets
    #[serde(rename = "lookup_secret_regenerate", skip_serializing_if = "Option::is_none")]
    pub lookup_secret_regenerate: Option<bool>,
    /// If set to true will reveal the lookup secrets
    #[serde(rename = "lookup_secret_reveal", skip_serializing_if = "Option::is_none")]
    pub lookup_secret_reveal: Option<bool>,
    /// Method  Should be set to \"lookup\" when trying to add, update, or remove a lookup pairing.
    #[serde(rename = "method")]
    pub method: String,
    /// Transient data to pass along to any webhooks
    #[serde(rename = "transient_payload", skip_serializing_if = "Option::is_none")]
    pub transient_payload: Option<serde_json::Value>,
}

impl UpdateSettingsFlowWithLookupMethod {
    /// Update Settings Flow with Lookup Method
    pub fn new(method: String) -> UpdateSettingsFlowWithLookupMethod {
        UpdateSettingsFlowWithLookupMethod {
            csrf_token: None,
            lookup_secret_confirm: None,
            lookup_secret_disable: None,
            lookup_secret_regenerate: None,
            lookup_secret_reveal: None,
            method,
            transient_payload: None,
        }
    }
}

