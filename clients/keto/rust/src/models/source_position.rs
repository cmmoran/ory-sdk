/*
 * Ory Keto API
 *
 * Documentation for all of Ory Keto's REST APIs. gRPC is documented separately. 
 *
 * The version of the OpenAPI document: v0.11.0-alpha.0
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SourcePosition {
    #[serde(rename = "Line", skip_serializing_if = "Option::is_none")]
    pub line: Option<i64>,
    #[serde(rename = "column", skip_serializing_if = "Option::is_none")]
    pub column: Option<i64>,
}

impl Default for SourcePosition {
    fn default() -> Self {
        Self::new()
    }
}

impl SourcePosition {
    pub fn new() -> SourcePosition {
        SourcePosition {
                line: None,
                column: None,
        }
    }
}


