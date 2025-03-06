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

/// ContinueWithSetOrySessionToken : Indicates that a session was issued, and the application should use this token for authenticated requests
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ContinueWithSetOrySessionToken {
    /// Action will always be `set_ory_session_token` set_ory_session_token ContinueWithActionSetOrySessionTokenString
    #[serde(rename = "action")]
    pub action: ActionEnum,
    /// Token is the token of the session
    #[serde(rename = "ory_session_token")]
    pub ory_session_token: String,
}

impl ContinueWithSetOrySessionToken {
    /// Indicates that a session was issued, and the application should use this token for authenticated requests
    pub fn new(action: ActionEnum, ory_session_token: String) -> ContinueWithSetOrySessionToken {
        ContinueWithSetOrySessionToken {
            action,
            ory_session_token,
        }
    }
}
/// Action will always be `set_ory_session_token` set_ory_session_token ContinueWithActionSetOrySessionTokenString
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum ActionEnum {
    #[serde(rename = "set_ory_session_token")]
    SetOrySessionToken,
}

impl Default for ActionEnum {
    fn default() -> ActionEnum {
        Self::SetOrySessionToken
    }
}

