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

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct Provider {
    /// The RP's client identifier, issued by the IdP.
    #[serde(rename = "client_id", skip_serializing_if = "Option::is_none")]
    pub client_id: Option<String>,
    /// A full path of the IdP config file.
    #[serde(rename = "config_url", skip_serializing_if = "Option::is_none")]
    pub config_url: Option<String>,
    /// By specifying one of domain_hints values provided by the accounts endpoints, the FedCM dialog selectively shows the specified account.
    #[serde(rename = "domain_hint", skip_serializing_if = "Option::is_none")]
    pub domain_hint: Option<String>,
    /// Array of strings that specifies the user information (\"name\", \" email\", \"picture\") that RP needs IdP to share with them.  Note: Field API is supported by Chrome 132 and later.
    #[serde(rename = "fields", skip_serializing_if = "Option::is_none")]
    pub fields: Option<Vec<String>>,
    /// By specifying one of login_hints values provided by the accounts endpoints, the FedCM dialog selectively shows the specified account.
    #[serde(rename = "login_hint", skip_serializing_if = "Option::is_none")]
    pub login_hint: Option<String>,
    /// A random string to ensure the response is issued for this specific request. Prevents replay attacks.
    #[serde(rename = "nonce", skip_serializing_if = "Option::is_none")]
    pub nonce: Option<String>,
    /// Custom object that allows to specify additional key-value parameters: scope: A string value containing additional permissions that RP needs to request, for example \" drive.readonly calendar.readonly\" nonce: A random string to ensure the response is issued for this specific request. Prevents replay attacks.  Other custom key-value parameters.  Note: parameters is supported from Chrome 132.
    #[serde(rename = "parameters", skip_serializing_if = "Option::is_none")]
    pub parameters: Option<std::collections::HashMap<String, String>>,
}

impl Provider {
    pub fn new() -> Provider {
        Provider {
            client_id: None,
            config_url: None,
            domain_hint: None,
            fields: None,
            login_hint: None,
            nonce: None,
            parameters: None,
        }
    }
}

