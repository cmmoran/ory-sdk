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

/// UiContainer : Container represents a HTML Form. The container can work with both HTTP Form and JSON requests
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct UiContainer {
    /// Action should be used as the form action URL `<form action=\"{{ .Action }}\" method=\"post\">`.
    #[serde(rename = "action")]
    pub action: String,
    #[serde(rename = "messages", skip_serializing_if = "Option::is_none")]
    pub messages: Option<Vec<models::UiText>>,
    /// Method is the form method (e.g. POST)
    #[serde(rename = "method")]
    pub method: String,
    #[serde(rename = "nodes")]
    pub nodes: Vec<models::UiNode>,
}

impl UiContainer {
    /// Container represents a HTML Form. The container can work with both HTTP Form and JSON requests
    pub fn new(action: String, method: String, nodes: Vec<models::UiNode>) -> UiContainer {
        UiContainer {
            action,
            messages: None,
            method,
            nodes,
        }
    }
}

