/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.4
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// SessionDevice : Device corresponding to a Session
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct SessionDevice {
    /// Device record ID
    #[serde(rename = "id")]
    pub id: String,
    /// IPAddress of the client
    #[serde(rename = "ip_address", skip_serializing_if = "Option::is_none")]
    pub ip_address: Option<String>,
    /// Geo Location corresponding to the IP Address
    #[serde(rename = "location", skip_serializing_if = "Option::is_none")]
    pub location: Option<String>,
    /// UserAgent of the client
    #[serde(rename = "user_agent", skip_serializing_if = "Option::is_none")]
    pub user_agent: Option<String>,
}

impl SessionDevice {
    /// Device corresponding to a Session
    pub fn new(id: String) -> SessionDevice {
        SessionDevice {
            id,
            ip_address: None,
            location: None,
            user_agent: None,
        }
    }
}

