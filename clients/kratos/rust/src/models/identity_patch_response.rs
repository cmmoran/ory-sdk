/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.7
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// IdentityPatchResponse : Response for a single identity patch
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct IdentityPatchResponse {
    /// The action for this specific patch create ActionCreate  Create this identity. error ActionError  Error indicates that the patch failed.
    #[serde(rename = "action", skip_serializing_if = "Option::is_none")]
    pub action: Option<ActionEnum>,
    #[serde(rename = "error", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub error: Option<Option<serde_json::Value>>,
    /// The identity ID payload of this patch
    #[serde(rename = "identity", skip_serializing_if = "Option::is_none")]
    pub identity: Option<String>,
    /// The ID of this patch response, if an ID was specified in the patch.
    #[serde(rename = "patch_id", skip_serializing_if = "Option::is_none")]
    pub patch_id: Option<String>,
}

impl IdentityPatchResponse {
    /// Response for a single identity patch
    pub fn new() -> IdentityPatchResponse {
        IdentityPatchResponse {
            action: None,
            error: None,
            identity: None,
            patch_id: None,
        }
    }
}
/// The action for this specific patch create ActionCreate  Create this identity. error ActionError  Error indicates that the patch failed.
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum ActionEnum {
    #[serde(rename = "create")]
    Create,
    #[serde(rename = "error")]
    Error,
}

impl Default for ActionEnum {
    fn default() -> ActionEnum {
        Self::Create
    }
}

