/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.5
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ErrorAuthenticatorAssuranceLevelNotSatisfied {
    #[serde(rename = "error", skip_serializing_if = "Option::is_none")]
    pub error: Option<Box<models::GenericError>>,
    /// Points to where to redirect the user to next.
    #[serde(rename = "redirect_browser_to", skip_serializing_if = "Option::is_none")]
    pub redirect_browser_to: Option<String>,
}

impl ErrorAuthenticatorAssuranceLevelNotSatisfied {
    pub fn new() -> ErrorAuthenticatorAssuranceLevelNotSatisfied {
        ErrorAuthenticatorAssuranceLevelNotSatisfied {
            error: None,
            redirect_browser_to: None,
        }
    }
}

