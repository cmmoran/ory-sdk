/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.4
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// PatchIdentitiesBody : Patch Identities Body
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct PatchIdentitiesBody {
    /// Identities holds the list of patches to apply  required
    #[serde(rename = "identities", skip_serializing_if = "Option::is_none")]
    pub identities: Option<Vec<models::IdentityPatch>>,
}

impl PatchIdentitiesBody {
    /// Patch Identities Body
    pub fn new() -> PatchIdentitiesBody {
        PatchIdentitiesBody {
            identities: None,
        }
    }
}

