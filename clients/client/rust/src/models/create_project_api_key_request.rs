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
pub struct CreateProjectApiKeyRequest {
    /// The Token Name  A descriptive name for the token.  in: body
    #[serde(rename = "name")]
    pub name: String,
}

impl CreateProjectApiKeyRequest {
    pub fn new(name: String) -> CreateProjectApiKeyRequest {
        CreateProjectApiKeyRequest {
            name,
        }
    }
}

