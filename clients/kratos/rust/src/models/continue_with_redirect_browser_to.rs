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

/// ContinueWithRedirectBrowserTo : Indicates, that the UI flow could be continued by showing a recovery ui
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ContinueWithRedirectBrowserTo {
    /// Action will always be `redirect_browser_to` redirect_browser_to ContinueWithActionRedirectBrowserToString
    #[serde(rename = "action")]
    pub action: ActionEnum,
    /// The URL to redirect the browser to
    #[serde(rename = "redirect_browser_to")]
    pub redirect_browser_to: String,
}

impl ContinueWithRedirectBrowserTo {
    /// Indicates, that the UI flow could be continued by showing a recovery ui
    pub fn new(action: ActionEnum, redirect_browser_to: String) -> ContinueWithRedirectBrowserTo {
        ContinueWithRedirectBrowserTo {
            action,
            redirect_browser_to,
        }
    }
}
/// Action will always be `redirect_browser_to` redirect_browser_to ContinueWithActionRedirectBrowserToString
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum ActionEnum {
    #[serde(rename = "redirect_browser_to")]
    RedirectBrowserTo,
}

impl Default for ActionEnum {
    fn default() -> ActionEnum {
        Self::RedirectBrowserTo
    }
}

