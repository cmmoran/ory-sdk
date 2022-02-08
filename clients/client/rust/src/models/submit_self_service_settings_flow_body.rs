/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.75
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
#[serde(tag = "method")]
pub enum SubmitSelfServiceSettingsFlowBody {
    #[serde(rename="oidc")]
    SubmitSelfServiceSettingsFlowWithOidcMethodBody {
        /// Flow ID is the flow's ID.  in: query
        #[serde(rename = "flow", skip_serializing_if = "Option::is_none")]
        flow: Option<String>,
        /// Link this provider  Either this or `unlink` must be set.  type: string in: body
        #[serde(rename = "link", skip_serializing_if = "Option::is_none")]
        link: Option<String>,
        /// The identity's traits  in: body
        #[serde(rename = "traits", skip_serializing_if = "Option::is_none")]
        traits: Option<serde_json::Value>,
        /// Unlink this provider  Either this or `link` must be set.  type: string in: body
        #[serde(rename = "unlink", skip_serializing_if = "Option::is_none")]
        unlink: Option<String>,
    },
    #[serde(rename="password")]
    SubmitSelfServiceSettingsFlowWithPasswordMethodBody {
        /// CSRFToken is the anti-CSRF token
        #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
        csrf_token: Option<String>,
        /// Password is the updated password
        #[serde(rename = "password")]
        password: String,
    },
    #[serde(rename="profile")]
    SubmitSelfServiceSettingsFlowWithProfileMethodBody {
        /// The Anti-CSRF Token  This token is only required when performing browser flows.
        #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
        csrf_token: Option<String>,
        /// Traits contains all of the identity's traits.
        #[serde(rename = "traits")]
        traits: serde_json::Value,
    },
    #[serde(rename="totp")]
    SubmitSelfServiceSettingsFlowWithTotpMethodBody {
        /// CSRFToken is the anti-CSRF token
        #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
        csrf_token: Option<String>,
        /// ValidationTOTP must contain a valid TOTP based on the
        #[serde(rename = "totp_code", skip_serializing_if = "Option::is_none")]
        totp_code: Option<String>,
        /// UnlinkTOTP if true will remove the TOTP pairing, effectively removing the credential. This can be used to set up a new TOTP device.
        #[serde(rename = "totp_unlink", skip_serializing_if = "Option::is_none")]
        totp_unlink: Option<bool>,
    },
}




