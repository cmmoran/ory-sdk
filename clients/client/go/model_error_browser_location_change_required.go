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

// checks if the ErrorBrowserLocationChangeRequired type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &ErrorBrowserLocationChangeRequired{}

// ErrorBrowserLocationChangeRequired struct for ErrorBrowserLocationChangeRequired
type ErrorBrowserLocationChangeRequired struct {
	Error *ErrorGeneric `json:"error,omitempty"`
	// Points to where to redirect the user to next.
	RedirectBrowserTo *string `json:"redirect_browser_to,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _ErrorBrowserLocationChangeRequired ErrorBrowserLocationChangeRequired

// NewErrorBrowserLocationChangeRequired instantiates a new ErrorBrowserLocationChangeRequired object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewErrorBrowserLocationChangeRequired() *ErrorBrowserLocationChangeRequired {
	this := ErrorBrowserLocationChangeRequired{}
	return &this
}

// NewErrorBrowserLocationChangeRequiredWithDefaults instantiates a new ErrorBrowserLocationChangeRequired object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewErrorBrowserLocationChangeRequiredWithDefaults() *ErrorBrowserLocationChangeRequired {
	this := ErrorBrowserLocationChangeRequired{}
	return &this
}

// GetError returns the Error field value if set, zero value otherwise.
func (o *ErrorBrowserLocationChangeRequired) GetError() ErrorGeneric {
	if o == nil || IsNil(o.Error) {
		var ret ErrorGeneric
		return ret
	}
	return *o.Error
}

// GetErrorOk returns a tuple with the Error field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ErrorBrowserLocationChangeRequired) GetErrorOk() (*ErrorGeneric, bool) {
	if o == nil || IsNil(o.Error) {
		return nil, false
	}
	return o.Error, true
}

// HasError returns a boolean if a field has been set.
func (o *ErrorBrowserLocationChangeRequired) HasError() bool {
	if o != nil && !IsNil(o.Error) {
		return true
	}

	return false
}

// SetError gets a reference to the given ErrorGeneric and assigns it to the Error field.
func (o *ErrorBrowserLocationChangeRequired) SetError(v ErrorGeneric) {
	o.Error = &v
}

// GetRedirectBrowserTo returns the RedirectBrowserTo field value if set, zero value otherwise.
func (o *ErrorBrowserLocationChangeRequired) GetRedirectBrowserTo() string {
	if o == nil || IsNil(o.RedirectBrowserTo) {
		var ret string
		return ret
	}
	return *o.RedirectBrowserTo
}

// GetRedirectBrowserToOk returns a tuple with the RedirectBrowserTo field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ErrorBrowserLocationChangeRequired) GetRedirectBrowserToOk() (*string, bool) {
	if o == nil || IsNil(o.RedirectBrowserTo) {
		return nil, false
	}
	return o.RedirectBrowserTo, true
}

// HasRedirectBrowserTo returns a boolean if a field has been set.
func (o *ErrorBrowserLocationChangeRequired) HasRedirectBrowserTo() bool {
	if o != nil && !IsNil(o.RedirectBrowserTo) {
		return true
	}

	return false
}

// SetRedirectBrowserTo gets a reference to the given string and assigns it to the RedirectBrowserTo field.
func (o *ErrorBrowserLocationChangeRequired) SetRedirectBrowserTo(v string) {
	o.RedirectBrowserTo = &v
}

func (o ErrorBrowserLocationChangeRequired) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o ErrorBrowserLocationChangeRequired) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Error) {
		toSerialize["error"] = o.Error
	}
	if !IsNil(o.RedirectBrowserTo) {
		toSerialize["redirect_browser_to"] = o.RedirectBrowserTo
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *ErrorBrowserLocationChangeRequired) UnmarshalJSON(data []byte) (err error) {
	varErrorBrowserLocationChangeRequired := _ErrorBrowserLocationChangeRequired{}

	err = json.Unmarshal(data, &varErrorBrowserLocationChangeRequired)

	if err != nil {
		return err
	}

	*o = ErrorBrowserLocationChangeRequired(varErrorBrowserLocationChangeRequired)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "error")
		delete(additionalProperties, "redirect_browser_to")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableErrorBrowserLocationChangeRequired struct {
	value *ErrorBrowserLocationChangeRequired
	isSet bool
}

func (v NullableErrorBrowserLocationChangeRequired) Get() *ErrorBrowserLocationChangeRequired {
	return v.value
}

func (v *NullableErrorBrowserLocationChangeRequired) Set(val *ErrorBrowserLocationChangeRequired) {
	v.value = val
	v.isSet = true
}

func (v NullableErrorBrowserLocationChangeRequired) IsSet() bool {
	return v.isSet
}

func (v *NullableErrorBrowserLocationChangeRequired) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableErrorBrowserLocationChangeRequired(val *ErrorBrowserLocationChangeRequired) *NullableErrorBrowserLocationChangeRequired {
	return &NullableErrorBrowserLocationChangeRequired{value: val, isSet: true}
}

func (v NullableErrorBrowserLocationChangeRequired) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableErrorBrowserLocationChangeRequired) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


