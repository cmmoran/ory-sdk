/*
 * ORY Keto
 *
 * Ory Keto is a cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.
 *
 * The version of the OpenAPI document: v0.7.0-alpha.1
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct RelationQuery {
    /// Namespace of the Relation Tuple
    #[serde(rename = "namespace")]
    pub namespace: String,
    /// Object of the Relation Tuple
    #[serde(rename = "object", skip_serializing_if = "Option::is_none")]
    pub object: Option<String>,
    /// Relation of the Relation Tuple
    #[serde(rename = "relation", skip_serializing_if = "Option::is_none")]
    pub relation: Option<String>,
    /// SubjectID of the Relation Tuple  Either SubjectSet or SubjectID can be provided.
    #[serde(rename = "subject_id", skip_serializing_if = "Option::is_none")]
    pub subject_id: Option<String>,
    #[serde(rename = "subject_set", skip_serializing_if = "Option::is_none")]
    pub subject_set: Option<Box<crate::models::SubjectSet>>,
}

impl RelationQuery {
    pub fn new(namespace: String) -> RelationQuery {
        RelationQuery {
            namespace,
            object: None,
            relation: None,
            subject_id: None,
            subject_set: None,
        }
    }
}


