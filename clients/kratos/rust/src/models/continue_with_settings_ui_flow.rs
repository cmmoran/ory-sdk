/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ContinueWithSettingsUiFlow {
    /// The ID of the settings flow
    #[serde(rename = "id")]
    pub id: String,
    /// The URL of the settings flow  If this value is set, redirect the user's browser to this URL. This value is typically unset for native clients / API flows.
    #[serde(rename = "url", skip_serializing_if = "Option::is_none")]
    pub url: Option<String>,
}

impl ContinueWithSettingsUiFlow {
    pub fn new(id: String) -> ContinueWithSettingsUiFlow {
        ContinueWithSettingsUiFlow {
            id,
            url: None,
        }
    }
}

