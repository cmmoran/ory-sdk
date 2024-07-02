/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.2
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;

/// CredentialSupportedDraft00 : Includes information about the supported verifiable credentials.
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct CredentialSupportedDraft00 {
    /// OpenID Connect Verifiable Credentials Cryptographic Binding Methods Supported  Contains a list of cryptographic binding methods supported for signing the proof.
    #[serde(rename = "cryptographic_binding_methods_supported", skip_serializing_if = "Option::is_none")]
    pub cryptographic_binding_methods_supported: Option<Vec<String>>,
    /// OpenID Connect Verifiable Credentials Cryptographic Suites Supported  Contains a list of cryptographic suites methods supported for signing the proof.
    #[serde(rename = "cryptographic_suites_supported", skip_serializing_if = "Option::is_none")]
    pub cryptographic_suites_supported: Option<Vec<String>>,
    /// OpenID Connect Verifiable Credentials Format  Contains the format that is supported by this authorization server.
    #[serde(rename = "format", skip_serializing_if = "Option::is_none")]
    pub format: Option<String>,
    /// OpenID Connect Verifiable Credentials Types  Contains the types of verifiable credentials supported.
    #[serde(rename = "types", skip_serializing_if = "Option::is_none")]
    pub types: Option<Vec<String>>,
}

impl CredentialSupportedDraft00 {
    /// Includes information about the supported verifiable credentials.
    pub fn new() -> CredentialSupportedDraft00 {
        CredentialSupportedDraft00 {
            cryptographic_binding_methods_supported: None,
            cryptographic_suites_supported: None,
            format: None,
            types: None,
        }
    }
}

