/*
 * ORY Oathkeeper
 *
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * The version of the OpenAPI document: v0.0.0-alpha.51
 * Contact: hi@ory.am
 * Generated by: https://openapi-generator.tech
 */

/// SwaggerRuleResponse : SwaggerRuleResponse A rule



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SwaggerRuleResponse {
    #[serde(rename = "Body", skip_serializing_if = "Option::is_none")]
    pub body: Option<Box<crate::models::SwaggerRule>>,
}

impl SwaggerRuleResponse {
    /// SwaggerRuleResponse A rule
    pub fn new() -> SwaggerRuleResponse {
        SwaggerRuleResponse {
            body: None,
        }
    }
}


