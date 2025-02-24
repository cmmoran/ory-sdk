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

// checks if the CredentialSupportedDraft00 type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &CredentialSupportedDraft00{}

// CredentialSupportedDraft00 Includes information about the supported verifiable credentials.
type CredentialSupportedDraft00 struct {
	// OpenID Connect Verifiable Credentials Cryptographic Binding Methods Supported  Contains a list of cryptographic binding methods supported for signing the proof.
	CryptographicBindingMethodsSupported []string `json:"cryptographic_binding_methods_supported,omitempty"`
	// OpenID Connect Verifiable Credentials Cryptographic Suites Supported  Contains a list of cryptographic suites methods supported for signing the proof.
	CryptographicSuitesSupported []string `json:"cryptographic_suites_supported,omitempty"`
	// OpenID Connect Verifiable Credentials Format  Contains the format that is supported by this authorization server.
	Format *string `json:"format,omitempty"`
	// OpenID Connect Verifiable Credentials Types  Contains the types of verifiable credentials supported.
	Types []string `json:"types,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _CredentialSupportedDraft00 CredentialSupportedDraft00

// NewCredentialSupportedDraft00 instantiates a new CredentialSupportedDraft00 object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCredentialSupportedDraft00() *CredentialSupportedDraft00 {
	this := CredentialSupportedDraft00{}
	return &this
}

// NewCredentialSupportedDraft00WithDefaults instantiates a new CredentialSupportedDraft00 object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCredentialSupportedDraft00WithDefaults() *CredentialSupportedDraft00 {
	this := CredentialSupportedDraft00{}
	return &this
}

// GetCryptographicBindingMethodsSupported returns the CryptographicBindingMethodsSupported field value if set, zero value otherwise.
func (o *CredentialSupportedDraft00) GetCryptographicBindingMethodsSupported() []string {
	if o == nil || IsNil(o.CryptographicBindingMethodsSupported) {
		var ret []string
		return ret
	}
	return o.CryptographicBindingMethodsSupported
}

// GetCryptographicBindingMethodsSupportedOk returns a tuple with the CryptographicBindingMethodsSupported field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CredentialSupportedDraft00) GetCryptographicBindingMethodsSupportedOk() ([]string, bool) {
	if o == nil || IsNil(o.CryptographicBindingMethodsSupported) {
		return nil, false
	}
	return o.CryptographicBindingMethodsSupported, true
}

// HasCryptographicBindingMethodsSupported returns a boolean if a field has been set.
func (o *CredentialSupportedDraft00) HasCryptographicBindingMethodsSupported() bool {
	if o != nil && !IsNil(o.CryptographicBindingMethodsSupported) {
		return true
	}

	return false
}

// SetCryptographicBindingMethodsSupported gets a reference to the given []string and assigns it to the CryptographicBindingMethodsSupported field.
func (o *CredentialSupportedDraft00) SetCryptographicBindingMethodsSupported(v []string) {
	o.CryptographicBindingMethodsSupported = v
}

// GetCryptographicSuitesSupported returns the CryptographicSuitesSupported field value if set, zero value otherwise.
func (o *CredentialSupportedDraft00) GetCryptographicSuitesSupported() []string {
	if o == nil || IsNil(o.CryptographicSuitesSupported) {
		var ret []string
		return ret
	}
	return o.CryptographicSuitesSupported
}

// GetCryptographicSuitesSupportedOk returns a tuple with the CryptographicSuitesSupported field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CredentialSupportedDraft00) GetCryptographicSuitesSupportedOk() ([]string, bool) {
	if o == nil || IsNil(o.CryptographicSuitesSupported) {
		return nil, false
	}
	return o.CryptographicSuitesSupported, true
}

// HasCryptographicSuitesSupported returns a boolean if a field has been set.
func (o *CredentialSupportedDraft00) HasCryptographicSuitesSupported() bool {
	if o != nil && !IsNil(o.CryptographicSuitesSupported) {
		return true
	}

	return false
}

// SetCryptographicSuitesSupported gets a reference to the given []string and assigns it to the CryptographicSuitesSupported field.
func (o *CredentialSupportedDraft00) SetCryptographicSuitesSupported(v []string) {
	o.CryptographicSuitesSupported = v
}

// GetFormat returns the Format field value if set, zero value otherwise.
func (o *CredentialSupportedDraft00) GetFormat() string {
	if o == nil || IsNil(o.Format) {
		var ret string
		return ret
	}
	return *o.Format
}

// GetFormatOk returns a tuple with the Format field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CredentialSupportedDraft00) GetFormatOk() (*string, bool) {
	if o == nil || IsNil(o.Format) {
		return nil, false
	}
	return o.Format, true
}

// HasFormat returns a boolean if a field has been set.
func (o *CredentialSupportedDraft00) HasFormat() bool {
	if o != nil && !IsNil(o.Format) {
		return true
	}

	return false
}

// SetFormat gets a reference to the given string and assigns it to the Format field.
func (o *CredentialSupportedDraft00) SetFormat(v string) {
	o.Format = &v
}

// GetTypes returns the Types field value if set, zero value otherwise.
func (o *CredentialSupportedDraft00) GetTypes() []string {
	if o == nil || IsNil(o.Types) {
		var ret []string
		return ret
	}
	return o.Types
}

// GetTypesOk returns a tuple with the Types field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CredentialSupportedDraft00) GetTypesOk() ([]string, bool) {
	if o == nil || IsNil(o.Types) {
		return nil, false
	}
	return o.Types, true
}

// HasTypes returns a boolean if a field has been set.
func (o *CredentialSupportedDraft00) HasTypes() bool {
	if o != nil && !IsNil(o.Types) {
		return true
	}

	return false
}

// SetTypes gets a reference to the given []string and assigns it to the Types field.
func (o *CredentialSupportedDraft00) SetTypes(v []string) {
	o.Types = v
}

func (o CredentialSupportedDraft00) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o CredentialSupportedDraft00) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.CryptographicBindingMethodsSupported) {
		toSerialize["cryptographic_binding_methods_supported"] = o.CryptographicBindingMethodsSupported
	}
	if !IsNil(o.CryptographicSuitesSupported) {
		toSerialize["cryptographic_suites_supported"] = o.CryptographicSuitesSupported
	}
	if !IsNil(o.Format) {
		toSerialize["format"] = o.Format
	}
	if !IsNil(o.Types) {
		toSerialize["types"] = o.Types
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *CredentialSupportedDraft00) UnmarshalJSON(data []byte) (err error) {
	varCredentialSupportedDraft00 := _CredentialSupportedDraft00{}

	err = json.Unmarshal(data, &varCredentialSupportedDraft00)

	if err != nil {
		return err
	}

	*o = CredentialSupportedDraft00(varCredentialSupportedDraft00)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "cryptographic_binding_methods_supported")
		delete(additionalProperties, "cryptographic_suites_supported")
		delete(additionalProperties, "format")
		delete(additionalProperties, "types")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableCredentialSupportedDraft00 struct {
	value *CredentialSupportedDraft00
	isSet bool
}

func (v NullableCredentialSupportedDraft00) Get() *CredentialSupportedDraft00 {
	return v.value
}

func (v *NullableCredentialSupportedDraft00) Set(val *CredentialSupportedDraft00) {
	v.value = val
	v.isSet = true
}

func (v NullableCredentialSupportedDraft00) IsSet() bool {
	return v.isSet
}

func (v *NullableCredentialSupportedDraft00) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCredentialSupportedDraft00(val *CredentialSupportedDraft00) *NullableCredentialSupportedDraft00 {
	return &NullableCredentialSupportedDraft00{value: val, isSet: true}
}

func (v NullableCredentialSupportedDraft00) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCredentialSupportedDraft00) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


