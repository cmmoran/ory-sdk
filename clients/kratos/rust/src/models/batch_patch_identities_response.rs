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

/// BatchPatchIdentitiesResponse : Patch identities response
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct BatchPatchIdentitiesResponse {
    /// The patch responses for the individual identities.
    #[serde(rename = "identities", skip_serializing_if = "Option::is_none")]
    pub identities: Option<Vec<models::IdentityPatchResponse>>,
}

impl BatchPatchIdentitiesResponse {
    /// Patch identities response
    pub fn new() -> BatchPatchIdentitiesResponse {
        BatchPatchIdentitiesResponse {
            identities: None,
        }
    }
}

