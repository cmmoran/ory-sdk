/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.16.1
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"time"
	"fmt"
)

// checks if the CreateWorkspaceApiKeyBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &CreateWorkspaceApiKeyBody{}

// CreateWorkspaceApiKeyBody struct for CreateWorkspaceApiKeyBody
type CreateWorkspaceApiKeyBody struct {
	ExpiresAt *time.Time `json:"expires_at,omitempty"`
	// The API Key Name  A descriptive name for the API key.
	Name string `json:"name"`
	AdditionalProperties map[string]interface{}
}

type _CreateWorkspaceApiKeyBody CreateWorkspaceApiKeyBody

// NewCreateWorkspaceApiKeyBody instantiates a new CreateWorkspaceApiKeyBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCreateWorkspaceApiKeyBody(name string) *CreateWorkspaceApiKeyBody {
	this := CreateWorkspaceApiKeyBody{}
	this.Name = name
	return &this
}

// NewCreateWorkspaceApiKeyBodyWithDefaults instantiates a new CreateWorkspaceApiKeyBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCreateWorkspaceApiKeyBodyWithDefaults() *CreateWorkspaceApiKeyBody {
	this := CreateWorkspaceApiKeyBody{}
	return &this
}

// GetExpiresAt returns the ExpiresAt field value if set, zero value otherwise.
func (o *CreateWorkspaceApiKeyBody) GetExpiresAt() time.Time {
	if o == nil || IsNil(o.ExpiresAt) {
		var ret time.Time
		return ret
	}
	return *o.ExpiresAt
}

// GetExpiresAtOk returns a tuple with the ExpiresAt field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateWorkspaceApiKeyBody) GetExpiresAtOk() (*time.Time, bool) {
	if o == nil || IsNil(o.ExpiresAt) {
		return nil, false
	}
	return o.ExpiresAt, true
}

// HasExpiresAt returns a boolean if a field has been set.
func (o *CreateWorkspaceApiKeyBody) HasExpiresAt() bool {
	if o != nil && !IsNil(o.ExpiresAt) {
		return true
	}

	return false
}

// SetExpiresAt gets a reference to the given time.Time and assigns it to the ExpiresAt field.
func (o *CreateWorkspaceApiKeyBody) SetExpiresAt(v time.Time) {
	o.ExpiresAt = &v
}

// GetName returns the Name field value
func (o *CreateWorkspaceApiKeyBody) GetName() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Name
}

// GetNameOk returns a tuple with the Name field value
// and a boolean to check if the value has been set.
func (o *CreateWorkspaceApiKeyBody) GetNameOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Name, true
}

// SetName sets field value
func (o *CreateWorkspaceApiKeyBody) SetName(v string) {
	o.Name = v
}

func (o CreateWorkspaceApiKeyBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o CreateWorkspaceApiKeyBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.ExpiresAt) {
		toSerialize["expires_at"] = o.ExpiresAt
	}
	toSerialize["name"] = o.Name

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *CreateWorkspaceApiKeyBody) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"name",
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

	varCreateWorkspaceApiKeyBody := _CreateWorkspaceApiKeyBody{}

	err = json.Unmarshal(data, &varCreateWorkspaceApiKeyBody)

	if err != nil {
		return err
	}

	*o = CreateWorkspaceApiKeyBody(varCreateWorkspaceApiKeyBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "expires_at")
		delete(additionalProperties, "name")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableCreateWorkspaceApiKeyBody struct {
	value *CreateWorkspaceApiKeyBody
	isSet bool
}

func (v NullableCreateWorkspaceApiKeyBody) Get() *CreateWorkspaceApiKeyBody {
	return v.value
}

func (v *NullableCreateWorkspaceApiKeyBody) Set(val *CreateWorkspaceApiKeyBody) {
	v.value = val
	v.isSet = true
}

func (v NullableCreateWorkspaceApiKeyBody) IsSet() bool {
	return v.isSet
}

func (v *NullableCreateWorkspaceApiKeyBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCreateWorkspaceApiKeyBody(val *CreateWorkspaceApiKeyBody) *NullableCreateWorkspaceApiKeyBody {
	return &NullableCreateWorkspaceApiKeyBody{value: val, isSet: true}
}

func (v NullableCreateWorkspaceApiKeyBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCreateWorkspaceApiKeyBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


