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

/// UiNodeInputAttributes : InputAttributes represents the attributes of an input node
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct UiNodeInputAttributes {
    /// The autocomplete attribute for the input. email InputAttributeAutocompleteEmail tel InputAttributeAutocompleteTel url InputAttributeAutocompleteUrl current-password InputAttributeAutocompleteCurrentPassword new-password InputAttributeAutocompleteNewPassword one-time-code InputAttributeAutocompleteOneTimeCode
    #[serde(rename = "autocomplete", skip_serializing_if = "Option::is_none")]
    pub autocomplete: Option<AutocompleteEnum>,
    /// Sets the input's disabled field to true or false.
    #[serde(rename = "disabled")]
    pub disabled: bool,
    #[serde(rename = "label", skip_serializing_if = "Option::is_none")]
    pub label: Option<Box<models::UiText>>,
    /// The input's element name.
    #[serde(rename = "name")]
    pub name: String,
    /// NodeType represents this node's types. It is a mirror of `node.type` and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \"input\". text Text input Input img Image a Anchor script Script
    #[serde(rename = "node_type")]
    pub node_type: NodeTypeEnum,
    /// OnClick may contain javascript which should be executed on click. This is primarily used for WebAuthn.
    #[serde(rename = "onclick", skip_serializing_if = "Option::is_none")]
    pub onclick: Option<String>,
    /// OnLoad may contain javascript which should be executed on load. This is primarily used for WebAuthn.
    #[serde(rename = "onload", skip_serializing_if = "Option::is_none")]
    pub onload: Option<String>,
    /// The input's pattern.
    #[serde(rename = "pattern", skip_serializing_if = "Option::is_none")]
    pub pattern: Option<String>,
    /// Mark this input field as required.
    #[serde(rename = "required", skip_serializing_if = "Option::is_none")]
    pub required: Option<bool>,
    /// The input's element type. text InputAttributeTypeText password InputAttributeTypePassword number InputAttributeTypeNumber checkbox InputAttributeTypeCheckbox hidden InputAttributeTypeHidden email InputAttributeTypeEmail tel InputAttributeTypeTel submit InputAttributeTypeSubmit button InputAttributeTypeButton datetime-local InputAttributeTypeDateTimeLocal date InputAttributeTypeDate url InputAttributeTypeURI
    #[serde(rename = "type")]
    pub r#type: TypeEnum,
    /// The input's value.
    #[serde(rename = "value", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub value: Option<Option<serde_json::Value>>,
}

impl UiNodeInputAttributes {
    /// InputAttributes represents the attributes of an input node
    pub fn new(disabled: bool, name: String, node_type: NodeTypeEnum, r#type: TypeEnum) -> UiNodeInputAttributes {
        UiNodeInputAttributes {
            autocomplete: None,
            disabled,
            label: None,
            name,
            node_type,
            onclick: None,
            onload: None,
            pattern: None,
            required: None,
            r#type,
            value: None,
        }
    }
}
/// The autocomplete attribute for the input. email InputAttributeAutocompleteEmail tel InputAttributeAutocompleteTel url InputAttributeAutocompleteUrl current-password InputAttributeAutocompleteCurrentPassword new-password InputAttributeAutocompleteNewPassword one-time-code InputAttributeAutocompleteOneTimeCode
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum AutocompleteEnum {
    #[serde(rename = "email")]
    Email,
    #[serde(rename = "tel")]
    Tel,
    #[serde(rename = "url")]
    Url,
    #[serde(rename = "current-password")]
    CurrentPassword,
    #[serde(rename = "new-password")]
    NewPassword,
    #[serde(rename = "one-time-code")]
    OneTimeCode,
}

impl Default for AutocompleteEnum {
    fn default() -> AutocompleteEnum {
        Self::Email
    }
}
/// NodeType represents this node's types. It is a mirror of `node.type` and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \"input\". text Text input Input img Image a Anchor script Script
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum NodeTypeEnum {
    #[serde(rename = "text")]
    Text,
    #[serde(rename = "input")]
    Input,
    #[serde(rename = "img")]
    Img,
    #[serde(rename = "a")]
    A,
    #[serde(rename = "script")]
    Script,
}

impl Default for NodeTypeEnum {
    fn default() -> NodeTypeEnum {
        Self::Text
    }
}
/// The input's element type. text InputAttributeTypeText password InputAttributeTypePassword number InputAttributeTypeNumber checkbox InputAttributeTypeCheckbox hidden InputAttributeTypeHidden email InputAttributeTypeEmail tel InputAttributeTypeTel submit InputAttributeTypeSubmit button InputAttributeTypeButton datetime-local InputAttributeTypeDateTimeLocal date InputAttributeTypeDate url InputAttributeTypeURI
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum TypeEnum {
    #[serde(rename = "text")]
    Text,
    #[serde(rename = "password")]
    Password,
    #[serde(rename = "number")]
    Number,
    #[serde(rename = "checkbox")]
    Checkbox,
    #[serde(rename = "hidden")]
    Hidden,
    #[serde(rename = "email")]
    Email,
    #[serde(rename = "tel")]
    Tel,
    #[serde(rename = "submit")]
    Submit,
    #[serde(rename = "button")]
    Button,
    #[serde(rename = "datetime-local")]
    DatetimeLocal,
    #[serde(rename = "date")]
    Date,
    #[serde(rename = "url")]
    Url,
}

impl Default for TypeEnum {
    fn default() -> TypeEnum {
        Self::Text
    }
}

