/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6-alpha.2
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// UiNodeMeta : This might include a label and other information that can optionally be used to render UIs.
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct UiNodeMeta {
    #[serde(rename = "label", skip_serializing_if = "Option::is_none")]
    pub label: Option<Box<models::UiText>>,
}

impl UiNodeMeta {
    /// This might include a label and other information that can optionally be used to render UIs.
    pub fn new() -> UiNodeMeta {
        UiNodeMeta {
            label: None,
        }
    }
}

