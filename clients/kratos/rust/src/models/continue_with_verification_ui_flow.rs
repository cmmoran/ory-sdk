/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.4.0-alpha.0
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ContinueWithVerificationUiFlow {
    /// The ID of the verification flow
    #[serde(rename = "id")]
    pub id: String,
    /// The URL of the verification flow  If this value is set, redirect the user's browser to this URL. This value is typically unset for native clients / API flows.
    #[serde(rename = "url", skip_serializing_if = "Option::is_none")]
    pub url: Option<String>,
    /// The address that should be verified in this flow
    #[serde(rename = "verifiable_address")]
    pub verifiable_address: String,
}

impl ContinueWithVerificationUiFlow {
    pub fn new(id: String, verifiable_address: String) -> ContinueWithVerificationUiFlow {
        ContinueWithVerificationUiFlow {
            id,
            url: None,
            verifiable_address,
        }
    }
}

