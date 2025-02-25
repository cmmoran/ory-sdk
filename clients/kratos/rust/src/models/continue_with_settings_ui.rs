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

/// ContinueWithSettingsUi : Indicates, that the UI flow could be continued by showing a settings ui
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ContinueWithSettingsUi {
    /// Action will always be `show_settings_ui` show_settings_ui ContinueWithActionShowSettingsUIString
    #[serde(rename = "action")]
    pub action: ActionEnum,
    #[serde(rename = "flow")]
    pub flow: Box<models::ContinueWithSettingsUiFlow>,
}

impl ContinueWithSettingsUi {
    /// Indicates, that the UI flow could be continued by showing a settings ui
    pub fn new(action: ActionEnum, flow: models::ContinueWithSettingsUiFlow) -> ContinueWithSettingsUi {
        ContinueWithSettingsUi {
            action,
            flow: Box::new(flow),
        }
    }
}
/// Action will always be `show_settings_ui` show_settings_ui ContinueWithActionShowSettingsUIString
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum ActionEnum {
    #[serde(rename = "show_settings_ui")]
    ShowSettingsUi,
}

impl Default for ActionEnum {
    fn default() -> ActionEnum {
        Self::ShowSettingsUi
    }
}

