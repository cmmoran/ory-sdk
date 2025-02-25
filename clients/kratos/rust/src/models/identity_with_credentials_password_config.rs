/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// IdentityWithCredentialsPasswordConfig : Create Identity and Import Password Credentials Configuration
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct IdentityWithCredentialsPasswordConfig {
    /// The hashed password in [PHC format](https://www.ory.sh/docs/kratos/manage-identities/import-user-accounts-identities#hashed-passwords)
    #[serde(rename = "hashed_password", skip_serializing_if = "Option::is_none")]
    pub hashed_password: Option<String>,
    /// The password in plain text if no hash is available.
    #[serde(rename = "password", skip_serializing_if = "Option::is_none")]
    pub password: Option<String>,
    /// If set to true, the password will be migrated using the password migration hook.
    #[serde(rename = "use_password_migration_hook", skip_serializing_if = "Option::is_none")]
    pub use_password_migration_hook: Option<bool>,
}

impl IdentityWithCredentialsPasswordConfig {
    /// Create Identity and Import Password Credentials Configuration
    pub fn new() -> IdentityWithCredentialsPasswordConfig {
        IdentityWithCredentialsPasswordConfig {
            hashed_password: None,
            password: None,
            use_password_migration_hook: None,
        }
    }
}

