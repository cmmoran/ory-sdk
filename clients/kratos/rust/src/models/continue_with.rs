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

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
#[serde(tag = "action")]
pub enum ContinueWith {
    #[serde(rename="show_verification_ui")]
    ShowVerificationUi(Box<models::ContinueWithVerificationUi>),
    #[serde(rename="set_ory_session_token")]
    SetOrySessionToken(Box<models::ContinueWithSetOrySessionToken>),
    #[serde(rename="show_settings_ui")]
    ShowSettingsUi(Box<models::ContinueWithSettingsUi>),
    #[serde(rename="show_recovery_ui")]
    ShowRecoveryUi(Box<models::ContinueWithRecoveryUi>),
    #[serde(rename="redirect_browser_to")]
    RedirectBrowserTo(Box<models::ContinueWithRedirectBrowserTo>),
}

impl Default for ContinueWith {
    fn default() -> Self {
        Self::ShowVerificationUi(Default::default())
    }
}


