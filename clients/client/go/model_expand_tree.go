/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v0.2.0-alpha.16
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// ExpandTree struct for ExpandTree
type ExpandTree struct {
	Children []ExpandTree `json:"children,omitempty"`
	SubjectId *string `json:"subject_id,omitempty"`
	SubjectSet *SubjectSet `json:"subject_set,omitempty"`
	Type string `json:"type"`
}

// NewExpandTree instantiates a new ExpandTree object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewExpandTree(type_ string) *ExpandTree {
	this := ExpandTree{}
	this.Type = type_
	return &this
}

// NewExpandTreeWithDefaults instantiates a new ExpandTree object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewExpandTreeWithDefaults() *ExpandTree {
	this := ExpandTree{}
	return &this
}

// GetChildren returns the Children field value if set, zero value otherwise.
func (o *ExpandTree) GetChildren() []ExpandTree {
	if o == nil || o.Children == nil {
		var ret []ExpandTree
		return ret
	}
	return o.Children
}

// GetChildrenOk returns a tuple with the Children field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ExpandTree) GetChildrenOk() ([]ExpandTree, bool) {
	if o == nil || o.Children == nil {
		return nil, false
	}
	return o.Children, true
}

// HasChildren returns a boolean if a field has been set.
func (o *ExpandTree) HasChildren() bool {
	if o != nil && o.Children != nil {
		return true
	}

	return false
}

// SetChildren gets a reference to the given []ExpandTree and assigns it to the Children field.
func (o *ExpandTree) SetChildren(v []ExpandTree) {
	o.Children = v
}

// GetSubjectId returns the SubjectId field value if set, zero value otherwise.
func (o *ExpandTree) GetSubjectId() string {
	if o == nil || o.SubjectId == nil {
		var ret string
		return ret
	}
	return *o.SubjectId
}

// GetSubjectIdOk returns a tuple with the SubjectId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ExpandTree) GetSubjectIdOk() (*string, bool) {
	if o == nil || o.SubjectId == nil {
		return nil, false
	}
	return o.SubjectId, true
}

// HasSubjectId returns a boolean if a field has been set.
func (o *ExpandTree) HasSubjectId() bool {
	if o != nil && o.SubjectId != nil {
		return true
	}

	return false
}

// SetSubjectId gets a reference to the given string and assigns it to the SubjectId field.
func (o *ExpandTree) SetSubjectId(v string) {
	o.SubjectId = &v
}

// GetSubjectSet returns the SubjectSet field value if set, zero value otherwise.
func (o *ExpandTree) GetSubjectSet() SubjectSet {
	if o == nil || o.SubjectSet == nil {
		var ret SubjectSet
		return ret
	}
	return *o.SubjectSet
}

// GetSubjectSetOk returns a tuple with the SubjectSet field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ExpandTree) GetSubjectSetOk() (*SubjectSet, bool) {
	if o == nil || o.SubjectSet == nil {
		return nil, false
	}
	return o.SubjectSet, true
}

// HasSubjectSet returns a boolean if a field has been set.
func (o *ExpandTree) HasSubjectSet() bool {
	if o != nil && o.SubjectSet != nil {
		return true
	}

	return false
}

// SetSubjectSet gets a reference to the given SubjectSet and assigns it to the SubjectSet field.
func (o *ExpandTree) SetSubjectSet(v SubjectSet) {
	o.SubjectSet = &v
}

// GetType returns the Type field value
func (o *ExpandTree) GetType() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Type
}

// GetTypeOk returns a tuple with the Type field value
// and a boolean to check if the value has been set.
func (o *ExpandTree) GetTypeOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Type, true
}

// SetType sets field value
func (o *ExpandTree) SetType(v string) {
	o.Type = v
}

func (o ExpandTree) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Children != nil {
		toSerialize["children"] = o.Children
	}
	if o.SubjectId != nil {
		toSerialize["subject_id"] = o.SubjectId
	}
	if o.SubjectSet != nil {
		toSerialize["subject_set"] = o.SubjectSet
	}
	if true {
		toSerialize["type"] = o.Type
	}
	return json.Marshal(toSerialize)
}

type NullableExpandTree struct {
	value *ExpandTree
	isSet bool
}

func (v NullableExpandTree) Get() *ExpandTree {
	return v.value
}

func (v *NullableExpandTree) Set(val *ExpandTree) {
	v.value = val
	v.isSet = true
}

func (v NullableExpandTree) IsSet() bool {
	return v.isSet
}

func (v *NullableExpandTree) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableExpandTree(val *ExpandTree) *NullableExpandTree {
	return &NullableExpandTree{value: val, isSet: true}
}

func (v NullableExpandTree) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableExpandTree) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


