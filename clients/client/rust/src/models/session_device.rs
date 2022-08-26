/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.21
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SessionDevice {
    /// UserAgent of this device
    #[serde(rename = "user_agent", skip_serializing_if = "Option::is_none")]
    pub user_agent: Option<String>,
}

impl Default for SessionDevice {
    fn default() -> Self {
        Self::new()
    }
}

impl SessionDevice {
    pub fn new() -> SessionDevice {
        SessionDevice {
                user_agent: None,
        }
    }
}


