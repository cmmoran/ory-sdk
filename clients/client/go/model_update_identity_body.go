/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.16.9
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// checks if the UpdateIdentityBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &UpdateIdentityBody{}

// UpdateIdentityBody Update Identity Body
type UpdateIdentityBody struct {
	Credentials *IdentityWithCredentials `json:"credentials,omitempty"`
	// Store metadata about the user which is only accessible through admin APIs such as `GET /admin/identities/<id>`.
	MetadataAdmin interface{} `json:"metadata_admin,omitempty"`
	// Store metadata about the identity which the identity itself can see when calling for example the session endpoint. Do not store sensitive information (e.g. credit score) about the identity in this field.
	MetadataPublic interface{} `json:"metadata_public,omitempty"`
	// SchemaID is the ID of the JSON Schema to be used for validating the identity's traits. If set will update the Identity's SchemaID.
	SchemaId string `json:"schema_id"`
	// State is the identity's state. active StateActive inactive StateInactive
	State string `json:"state"`
	// Traits represent an identity's traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in `schema_id`.
	Traits map[string]interface{} `json:"traits"`
	AdditionalProperties map[string]interface{}
}

type _UpdateIdentityBody UpdateIdentityBody

// NewUpdateIdentityBody instantiates a new UpdateIdentityBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewUpdateIdentityBody(schemaId string, state string, traits map[string]interface{}) *UpdateIdentityBody {
	this := UpdateIdentityBody{}
	this.SchemaId = schemaId
	this.State = state
	this.Traits = traits
	return &this
}

// NewUpdateIdentityBodyWithDefaults instantiates a new UpdateIdentityBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewUpdateIdentityBodyWithDefaults() *UpdateIdentityBody {
	this := UpdateIdentityBody{}
	return &this
}

// GetCredentials returns the Credentials field value if set, zero value otherwise.
func (o *UpdateIdentityBody) GetCredentials() IdentityWithCredentials {
	if o == nil || IsNil(o.Credentials) {
		var ret IdentityWithCredentials
		return ret
	}
	return *o.Credentials
}

// GetCredentialsOk returns a tuple with the Credentials field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateIdentityBody) GetCredentialsOk() (*IdentityWithCredentials, bool) {
	if o == nil || IsNil(o.Credentials) {
		return nil, false
	}
	return o.Credentials, true
}

// HasCredentials returns a boolean if a field has been set.
func (o *UpdateIdentityBody) HasCredentials() bool {
	if o != nil && !IsNil(o.Credentials) {
		return true
	}

	return false
}

// SetCredentials gets a reference to the given IdentityWithCredentials and assigns it to the Credentials field.
func (o *UpdateIdentityBody) SetCredentials(v IdentityWithCredentials) {
	o.Credentials = &v
}

// GetMetadataAdmin returns the MetadataAdmin field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *UpdateIdentityBody) GetMetadataAdmin() interface{} {
	if o == nil {
		var ret interface{}
		return ret
	}
	return o.MetadataAdmin
}

// GetMetadataAdminOk returns a tuple with the MetadataAdmin field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *UpdateIdentityBody) GetMetadataAdminOk() (*interface{}, bool) {
	if o == nil || IsNil(o.MetadataAdmin) {
		return nil, false
	}
	return &o.MetadataAdmin, true
}

// HasMetadataAdmin returns a boolean if a field has been set.
func (o *UpdateIdentityBody) HasMetadataAdmin() bool {
	if o != nil && !IsNil(o.MetadataAdmin) {
		return true
	}

	return false
}

// SetMetadataAdmin gets a reference to the given interface{} and assigns it to the MetadataAdmin field.
func (o *UpdateIdentityBody) SetMetadataAdmin(v interface{}) {
	o.MetadataAdmin = v
}

// GetMetadataPublic returns the MetadataPublic field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *UpdateIdentityBody) GetMetadataPublic() interface{} {
	if o == nil {
		var ret interface{}
		return ret
	}
	return o.MetadataPublic
}

// GetMetadataPublicOk returns a tuple with the MetadataPublic field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *UpdateIdentityBody) GetMetadataPublicOk() (*interface{}, bool) {
	if o == nil || IsNil(o.MetadataPublic) {
		return nil, false
	}
	return &o.MetadataPublic, true
}

// HasMetadataPublic returns a boolean if a field has been set.
func (o *UpdateIdentityBody) HasMetadataPublic() bool {
	if o != nil && !IsNil(o.MetadataPublic) {
		return true
	}

	return false
}

// SetMetadataPublic gets a reference to the given interface{} and assigns it to the MetadataPublic field.
func (o *UpdateIdentityBody) SetMetadataPublic(v interface{}) {
	o.MetadataPublic = v
}

// GetSchemaId returns the SchemaId field value
func (o *UpdateIdentityBody) GetSchemaId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.SchemaId
}

// GetSchemaIdOk returns a tuple with the SchemaId field value
// and a boolean to check if the value has been set.
func (o *UpdateIdentityBody) GetSchemaIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.SchemaId, true
}

// SetSchemaId sets field value
func (o *UpdateIdentityBody) SetSchemaId(v string) {
	o.SchemaId = v
}

// GetState returns the State field value
func (o *UpdateIdentityBody) GetState() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.State
}

// GetStateOk returns a tuple with the State field value
// and a boolean to check if the value has been set.
func (o *UpdateIdentityBody) GetStateOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.State, true
}

// SetState sets field value
func (o *UpdateIdentityBody) SetState(v string) {
	o.State = v
}

// GetTraits returns the Traits field value
func (o *UpdateIdentityBody) GetTraits() map[string]interface{} {
	if o == nil {
		var ret map[string]interface{}
		return ret
	}

	return o.Traits
}

// GetTraitsOk returns a tuple with the Traits field value
// and a boolean to check if the value has been set.
func (o *UpdateIdentityBody) GetTraitsOk() (map[string]interface{}, bool) {
	if o == nil {
		return map[string]interface{}{}, false
	}
	return o.Traits, true
}

// SetTraits sets field value
func (o *UpdateIdentityBody) SetTraits(v map[string]interface{}) {
	o.Traits = v
}

func (o UpdateIdentityBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o UpdateIdentityBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Credentials) {
		toSerialize["credentials"] = o.Credentials
	}
	if o.MetadataAdmin != nil {
		toSerialize["metadata_admin"] = o.MetadataAdmin
	}
	if o.MetadataPublic != nil {
		toSerialize["metadata_public"] = o.MetadataPublic
	}
	toSerialize["schema_id"] = o.SchemaId
	toSerialize["state"] = o.State
	toSerialize["traits"] = o.Traits

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *UpdateIdentityBody) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"schema_id",
		"state",
		"traits",
	}

	allProperties := make(map[string]interface{})

	err = json.Unmarshal(data, &allProperties)

	if err != nil {
		return err;
	}

	for _, requiredProperty := range(requiredProperties) {
		if _, exists := allProperties[requiredProperty]; !exists {
			return fmt.Errorf("no value given for required property %v", requiredProperty)
		}
	}

	varUpdateIdentityBody := _UpdateIdentityBody{}

	err = json.Unmarshal(data, &varUpdateIdentityBody)

	if err != nil {
		return err
	}

	*o = UpdateIdentityBody(varUpdateIdentityBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "credentials")
		delete(additionalProperties, "metadata_admin")
		delete(additionalProperties, "metadata_public")
		delete(additionalProperties, "schema_id")
		delete(additionalProperties, "state")
		delete(additionalProperties, "traits")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableUpdateIdentityBody struct {
	value *UpdateIdentityBody
	isSet bool
}

func (v NullableUpdateIdentityBody) Get() *UpdateIdentityBody {
	return v.value
}

func (v *NullableUpdateIdentityBody) Set(val *UpdateIdentityBody) {
	v.value = val
	v.isSet = true
}

func (v NullableUpdateIdentityBody) IsSet() bool {
	return v.isSet
}

func (v *NullableUpdateIdentityBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUpdateIdentityBody(val *UpdateIdentityBody) *NullableUpdateIdentityBody {
	return &NullableUpdateIdentityBody{value: val, isSet: true}
}

func (v NullableUpdateIdentityBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUpdateIdentityBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


