/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.57
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct ProjectPatch {
    /// URL of Project API  In the future will allow to override Kratos project URL. If set, error is returned. If left empty our hosted URL is used
    #[serde(rename = "api_url", skip_serializing_if = "Option::is_none")]
    pub api_url: Option<String>,
    /// URL where your application is available.  Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow. More fine-grained redirection patterns are available for the individual flows (login, registration, ...).  If left empty, our hosted URL will be used instead. It contains technical information on the identities and is useful when developing a new project or trying out Ory Cloud.
    #[serde(rename = "application_url", skip_serializing_if = "Option::is_none")]
    pub application_url: Option<String>,
    /// Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity's default schema. This allows setting custom fields such as \"address\", specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  If KratosCustomSchemaID is also added to the payload, it will be preferred and replace the value of DefaultIdentitySchemaURL set by the client.  The value of this field can be either any \"https://\" URL - for example a file hosted at GitHub, or a `preset://`-prefixed string.  Available presets are:  preset://email preset://username preset://basic preset://blank
    #[serde(rename = "default_identity_schema_url", skip_serializing_if = "Option::is_none")]
    pub default_identity_schema_url: Option<String>,
    /// Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory's hosted pages.
    #[serde(rename = "error_ui_url")]
    pub error_ui_url: String,
    /// The Custom Schema ID  The custom schema ID is a preferred field over DefaultIdentitySchemaURL, meaning it will override the DefaultIdentitySchemaURL with the custom schema's URL instead of accepting it from the client-side. Once this field is set the given custom schema will be associated with this project.
    #[serde(rename = "kratos_custom_schema_id", skip_serializing_if = "Option::is_none")]
    pub kratos_custom_schema_id: Option<String>,
    /// Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory's hosted pages.
    #[serde(rename = "login_ui_url")]
    pub login_ui_url: String,
    #[serde(rename = "lookup_secret")]
    pub lookup_secret: Box<crate::models::ProjectLookupSecretConfig>,
    /// The project name.  Helps you identify your project.  in: body
    #[serde(rename = "name", skip_serializing_if = "Option::is_none")]
    pub name: Option<String>,
    #[serde(rename = "password")]
    pub password: Box<crate::models::ProjectPasswordConfig>,
    #[serde(rename = "recovery")]
    pub recovery: Box<crate::models::ProjectRecoveryConfig>,
    /// Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory's hosted pages.
    #[serde(rename = "recovery_ui_url")]
    pub recovery_ui_url: String,
    #[serde(rename = "redirection_config", skip_serializing_if = "Option::is_none")]
    pub redirection_config: Option<Box<crate::models::RedirectionConfig>>,
    /// Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory's hosted pages.
    #[serde(rename = "registration_ui_url")]
    pub registration_ui_url: String,
    /// Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration
    #[serde(rename = "session_after_sign_up")]
    pub session_after_sign_up: bool,
    /// Enable Soft 2FA for Login Sessions
    #[serde(rename = "session_soft_2fa")]
    pub session_soft_2fa: bool,
    /// Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session's authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change).
    #[serde(rename = "settings_privileged_session_max_age_seconds")]
    pub settings_privileged_session_max_age_seconds: i64,
    /// Enable Soft 2FA for Self-Service Settings Flows
    #[serde(rename = "settings_soft_2fa")]
    pub settings_soft_2fa: bool,
    /// Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory's hosted pages.
    #[serde(rename = "settings_ui_url")]
    pub settings_ui_url: String,
    #[serde(rename = "totp")]
    pub totp: Box<crate::models::ProjectTotpConfig>,
    #[serde(rename = "verification")]
    pub verification: Box<crate::models::ProjectVerificationConfig>,
    /// Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory's hosted pages.
    #[serde(rename = "verification_ui_url")]
    pub verification_ui_url: String,
    #[serde(rename = "webauthn")]
    pub webauthn: Box<crate::models::ProjectWebAuthnConfig>,
}

impl ProjectPatch {
    pub fn new(error_ui_url: String, login_ui_url: String, lookup_secret: crate::models::ProjectLookupSecretConfig, password: crate::models::ProjectPasswordConfig, recovery: crate::models::ProjectRecoveryConfig, recovery_ui_url: String, registration_ui_url: String, session_after_sign_up: bool, session_soft_2fa: bool, settings_privileged_session_max_age_seconds: i64, settings_soft_2fa: bool, settings_ui_url: String, totp: crate::models::ProjectTotpConfig, verification: crate::models::ProjectVerificationConfig, verification_ui_url: String, webauthn: crate::models::ProjectWebAuthnConfig) -> ProjectPatch {
        ProjectPatch {
            api_url: None,
            application_url: None,
            default_identity_schema_url: None,
            error_ui_url,
            kratos_custom_schema_id: None,
            login_ui_url,
            lookup_secret: Box::new(lookup_secret),
            name: None,
            password: Box::new(password),
            recovery: Box::new(recovery),
            recovery_ui_url,
            redirection_config: None,
            registration_ui_url,
            session_after_sign_up,
            session_soft_2fa,
            settings_privileged_session_max_age_seconds,
            settings_soft_2fa,
            settings_ui_url,
            totp: Box::new(totp),
            verification: Box::new(verification),
            verification_ui_url,
            webauthn: Box::new(webauthn),
        }
    }
}


