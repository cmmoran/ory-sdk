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

/// CreateRecoveryLinkForIdentityBody : Create Recovery Link for Identity Request Body
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct CreateRecoveryLinkForIdentityBody {
    /// Link Expires In  The recovery link will expire after that amount of time has passed. Defaults to the configuration value of `selfservice.methods.code.config.lifespan`.
    #[serde(rename = "expires_in", skip_serializing_if = "Option::is_none")]
    pub expires_in: Option<String>,
    /// Identity to Recover  The identity's ID you wish to recover.
    #[serde(rename = "identity_id")]
    pub identity_id: String,
}

impl CreateRecoveryLinkForIdentityBody {
    /// Create Recovery Link for Identity Request Body
    pub fn new(identity_id: String) -> CreateRecoveryLinkForIdentityBody {
        CreateRecoveryLinkForIdentityBody {
            expires_in: None,
            identity_id,
        }
    }
}

