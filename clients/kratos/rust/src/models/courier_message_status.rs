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

/// CourierMessageStatus : A Message's Status
/// A Message's Status
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum CourierMessageStatus {
    #[serde(rename = "queued")]
    Queued,
    #[serde(rename = "sent")]
    Sent,
    #[serde(rename = "processing")]
    Processing,
    #[serde(rename = "abandoned")]
    Abandoned,

}

impl std::fmt::Display for CourierMessageStatus {
    fn fmt(&self, f: &mut std::fmt::Formatter) -> std::fmt::Result {
        match self {
            Self::Queued => write!(f, "queued"),
            Self::Sent => write!(f, "sent"),
            Self::Processing => write!(f, "processing"),
            Self::Abandoned => write!(f, "abandoned"),
        }
    }
}

impl Default for CourierMessageStatus {
    fn default() -> CourierMessageStatus {
        Self::Queued
    }
}

