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
)

// checks if the IdentityCredentialsCode type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &IdentityCredentialsCode{}

// IdentityCredentialsCode CredentialsCode represents a one time login/registration code
type IdentityCredentialsCode struct {
	Addresses []IdentityCredentialsCodeAddress `json:"addresses,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _IdentityCredentialsCode IdentityCredentialsCode

// NewIdentityCredentialsCode instantiates a new IdentityCredentialsCode object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewIdentityCredentialsCode() *IdentityCredentialsCode {
	this := IdentityCredentialsCode{}
	return &this
}

// NewIdentityCredentialsCodeWithDefaults instantiates a new IdentityCredentialsCode object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewIdentityCredentialsCodeWithDefaults() *IdentityCredentialsCode {
	this := IdentityCredentialsCode{}
	return &this
}

// GetAddresses returns the Addresses field value if set, zero value otherwise.
func (o *IdentityCredentialsCode) GetAddresses() []IdentityCredentialsCodeAddress {
	if o == nil || IsNil(o.Addresses) {
		var ret []IdentityCredentialsCodeAddress
		return ret
	}
	return o.Addresses
}

// GetAddressesOk returns a tuple with the Addresses field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *IdentityCredentialsCode) GetAddressesOk() ([]IdentityCredentialsCodeAddress, bool) {
	if o == nil || IsNil(o.Addresses) {
		return nil, false
	}
	return o.Addresses, true
}

// HasAddresses returns a boolean if a field has been set.
func (o *IdentityCredentialsCode) HasAddresses() bool {
	if o != nil && !IsNil(o.Addresses) {
		return true
	}

	return false
}

// SetAddresses gets a reference to the given []IdentityCredentialsCodeAddress and assigns it to the Addresses field.
func (o *IdentityCredentialsCode) SetAddresses(v []IdentityCredentialsCodeAddress) {
	o.Addresses = v
}

func (o IdentityCredentialsCode) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o IdentityCredentialsCode) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Addresses) {
		toSerialize["addresses"] = o.Addresses
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *IdentityCredentialsCode) UnmarshalJSON(data []byte) (err error) {
	varIdentityCredentialsCode := _IdentityCredentialsCode{}

	err = json.Unmarshal(data, &varIdentityCredentialsCode)

	if err != nil {
		return err
	}

	*o = IdentityCredentialsCode(varIdentityCredentialsCode)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "addresses")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableIdentityCredentialsCode struct {
	value *IdentityCredentialsCode
	isSet bool
}

func (v NullableIdentityCredentialsCode) Get() *IdentityCredentialsCode {
	return v.value
}

func (v *NullableIdentityCredentialsCode) Set(val *IdentityCredentialsCode) {
	v.value = val
	v.isSet = true
}

func (v NullableIdentityCredentialsCode) IsSet() bool {
	return v.isSet
}

func (v *NullableIdentityCredentialsCode) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableIdentityCredentialsCode(val *IdentityCredentialsCode) *NullableIdentityCredentialsCode {
	return &NullableIdentityCredentialsCode{value: val, isSet: true}
}

func (v NullableIdentityCredentialsCode) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableIdentityCredentialsCode) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


