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

/// ErrorGeneric : The standard Ory JSON API error format.
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ErrorGeneric {
    #[serde(rename = "error")]
    pub error: Box<models::GenericError>,
}

impl ErrorGeneric {
    /// The standard Ory JSON API error format.
    pub fn new(error: models::GenericError) -> ErrorGeneric {
        ErrorGeneric {
            error: Box::new(error),
        }
    }
}

