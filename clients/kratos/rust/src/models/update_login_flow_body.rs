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

#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
#[serde(tag = "method")]
pub enum UpdateLoginFlowBody {
    #[serde(rename="password")]
    Password(Box<models::UpdateLoginFlowWithPasswordMethod>),
    #[serde(rename="oidc")]
    Oidc(Box<models::UpdateLoginFlowWithOidcMethod>),
    #[serde(rename="totp")]
    Totp(Box<models::UpdateLoginFlowWithTotpMethod>),
    #[serde(rename="webauthn")]
    Webauthn(Box<models::UpdateLoginFlowWithWebAuthnMethod>),
    #[serde(rename="lookup_secret")]
    LookupSecret(Box<models::UpdateLoginFlowWithLookupSecretMethod>),
    #[serde(rename="code")]
    Code(Box<models::UpdateLoginFlowWithCodeMethod>),
    #[serde(rename="passkey")]
    Passkey(Box<models::UpdateLoginFlowWithPasskeyMethod>),
    #[serde(rename="identifier_first")]
    IdentifierFirst(Box<models::UpdateLoginFlowWithIdentifierFirstMethod>),
}

impl Default for UpdateLoginFlowBody {
    fn default() -> Self {
        Self::Password(Default::default())
    }
}


