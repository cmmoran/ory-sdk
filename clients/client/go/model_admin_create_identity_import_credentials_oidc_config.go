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

// AdminCreateIdentityImportCredentialsOidcConfig struct for AdminCreateIdentityImportCredentialsOidcConfig
type AdminCreateIdentityImportCredentialsOidcConfig struct {
	Config *AdminCreateIdentityImportCredentialsPasswordConfig `json:"config,omitempty"`
	// A list of OpenID Connect Providers
	Providers []AdminCreateIdentityImportCredentialsOidcProvider `json:"providers,omitempty"`
}

// NewAdminCreateIdentityImportCredentialsOidcConfig instantiates a new AdminCreateIdentityImportCredentialsOidcConfig object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewAdminCreateIdentityImportCredentialsOidcConfig() *AdminCreateIdentityImportCredentialsOidcConfig {
	this := AdminCreateIdentityImportCredentialsOidcConfig{}
	return &this
}

// NewAdminCreateIdentityImportCredentialsOidcConfigWithDefaults instantiates a new AdminCreateIdentityImportCredentialsOidcConfig object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewAdminCreateIdentityImportCredentialsOidcConfigWithDefaults() *AdminCreateIdentityImportCredentialsOidcConfig {
	this := AdminCreateIdentityImportCredentialsOidcConfig{}
	return &this
}

// GetConfig returns the Config field value if set, zero value otherwise.
func (o *AdminCreateIdentityImportCredentialsOidcConfig) GetConfig() AdminCreateIdentityImportCredentialsPasswordConfig {
	if o == nil || o.Config == nil {
		var ret AdminCreateIdentityImportCredentialsPasswordConfig
		return ret
	}
	return *o.Config
}

// GetConfigOk returns a tuple with the Config field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *AdminCreateIdentityImportCredentialsOidcConfig) GetConfigOk() (*AdminCreateIdentityImportCredentialsPasswordConfig, bool) {
	if o == nil || o.Config == nil {
		return nil, false
	}
	return o.Config, true
}

// HasConfig returns a boolean if a field has been set.
func (o *AdminCreateIdentityImportCredentialsOidcConfig) HasConfig() bool {
	if o != nil && o.Config != nil {
		return true
	}

	return false
}

// SetConfig gets a reference to the given AdminCreateIdentityImportCredentialsPasswordConfig and assigns it to the Config field.
func (o *AdminCreateIdentityImportCredentialsOidcConfig) SetConfig(v AdminCreateIdentityImportCredentialsPasswordConfig) {
	o.Config = &v
}

// GetProviders returns the Providers field value if set, zero value otherwise.
func (o *AdminCreateIdentityImportCredentialsOidcConfig) GetProviders() []AdminCreateIdentityImportCredentialsOidcProvider {
	if o == nil || o.Providers == nil {
		var ret []AdminCreateIdentityImportCredentialsOidcProvider
		return ret
	}
	return o.Providers
}

// GetProvidersOk returns a tuple with the Providers field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *AdminCreateIdentityImportCredentialsOidcConfig) GetProvidersOk() ([]AdminCreateIdentityImportCredentialsOidcProvider, bool) {
	if o == nil || o.Providers == nil {
		return nil, false
	}
	return o.Providers, true
}

// HasProviders returns a boolean if a field has been set.
func (o *AdminCreateIdentityImportCredentialsOidcConfig) HasProviders() bool {
	if o != nil && o.Providers != nil {
		return true
	}

	return false
}

// SetProviders gets a reference to the given []AdminCreateIdentityImportCredentialsOidcProvider and assigns it to the Providers field.
func (o *AdminCreateIdentityImportCredentialsOidcConfig) SetProviders(v []AdminCreateIdentityImportCredentialsOidcProvider) {
	o.Providers = v
}

func (o AdminCreateIdentityImportCredentialsOidcConfig) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Config != nil {
		toSerialize["config"] = o.Config
	}
	if o.Providers != nil {
		toSerialize["providers"] = o.Providers
	}
	return json.Marshal(toSerialize)
}

type NullableAdminCreateIdentityImportCredentialsOidcConfig struct {
	value *AdminCreateIdentityImportCredentialsOidcConfig
	isSet bool
}

func (v NullableAdminCreateIdentityImportCredentialsOidcConfig) Get() *AdminCreateIdentityImportCredentialsOidcConfig {
	return v.value
}

func (v *NullableAdminCreateIdentityImportCredentialsOidcConfig) Set(val *AdminCreateIdentityImportCredentialsOidcConfig) {
	v.value = val
	v.isSet = true
}

func (v NullableAdminCreateIdentityImportCredentialsOidcConfig) IsSet() bool {
	return v.isSet
}

func (v *NullableAdminCreateIdentityImportCredentialsOidcConfig) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableAdminCreateIdentityImportCredentialsOidcConfig(val *AdminCreateIdentityImportCredentialsOidcConfig) *NullableAdminCreateIdentityImportCredentialsOidcConfig {
	return &NullableAdminCreateIdentityImportCredentialsOidcConfig{value: val, isSet: true}
}

func (v NullableAdminCreateIdentityImportCredentialsOidcConfig) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableAdminCreateIdentityImportCredentialsOidcConfig) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


