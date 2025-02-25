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

/// PerformNativeLogoutBody : Perform Native Logout Request Body
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct PerformNativeLogoutBody {
    /// The Session Token  Invalidate this session token.
    #[serde(rename = "session_token")]
    pub session_token: String,
}

impl PerformNativeLogoutBody {
    /// Perform Native Logout Request Body
    pub fn new(session_token: String) -> PerformNativeLogoutBody {
        PerformNativeLogoutBody {
            session_token,
        }
    }
}

