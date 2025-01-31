/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.16.5
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// checks if the EmailTemplateDataBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &EmailTemplateDataBody{}

// EmailTemplateDataBody struct for EmailTemplateDataBody
type EmailTemplateDataBody struct {
	Html string `json:"html"`
	Plaintext string `json:"plaintext"`
	AdditionalProperties map[string]interface{}
}

type _EmailTemplateDataBody EmailTemplateDataBody

// NewEmailTemplateDataBody instantiates a new EmailTemplateDataBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewEmailTemplateDataBody(html string, plaintext string) *EmailTemplateDataBody {
	this := EmailTemplateDataBody{}
	this.Html = html
	this.Plaintext = plaintext
	return &this
}

// NewEmailTemplateDataBodyWithDefaults instantiates a new EmailTemplateDataBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewEmailTemplateDataBodyWithDefaults() *EmailTemplateDataBody {
	this := EmailTemplateDataBody{}
	return &this
}

// GetHtml returns the Html field value
func (o *EmailTemplateDataBody) GetHtml() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Html
}

// GetHtmlOk returns a tuple with the Html field value
// and a boolean to check if the value has been set.
func (o *EmailTemplateDataBody) GetHtmlOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Html, true
}

// SetHtml sets field value
func (o *EmailTemplateDataBody) SetHtml(v string) {
	o.Html = v
}

// GetPlaintext returns the Plaintext field value
func (o *EmailTemplateDataBody) GetPlaintext() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Plaintext
}

// GetPlaintextOk returns a tuple with the Plaintext field value
// and a boolean to check if the value has been set.
func (o *EmailTemplateDataBody) GetPlaintextOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Plaintext, true
}

// SetPlaintext sets field value
func (o *EmailTemplateDataBody) SetPlaintext(v string) {
	o.Plaintext = v
}

func (o EmailTemplateDataBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o EmailTemplateDataBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["html"] = o.Html
	toSerialize["plaintext"] = o.Plaintext

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *EmailTemplateDataBody) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"html",
		"plaintext",
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

	varEmailTemplateDataBody := _EmailTemplateDataBody{}

	err = json.Unmarshal(data, &varEmailTemplateDataBody)

	if err != nil {
		return err
	}

	*o = EmailTemplateDataBody(varEmailTemplateDataBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "html")
		delete(additionalProperties, "plaintext")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableEmailTemplateDataBody struct {
	value *EmailTemplateDataBody
	isSet bool
}

func (v NullableEmailTemplateDataBody) Get() *EmailTemplateDataBody {
	return v.value
}

func (v *NullableEmailTemplateDataBody) Set(val *EmailTemplateDataBody) {
	v.value = val
	v.isSet = true
}

func (v NullableEmailTemplateDataBody) IsSet() bool {
	return v.isSet
}

func (v *NullableEmailTemplateDataBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableEmailTemplateDataBody(val *EmailTemplateDataBody) *NullableEmailTemplateDataBody {
	return &NullableEmailTemplateDataBody{value: val, isSet: true}
}

func (v NullableEmailTemplateDataBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableEmailTemplateDataBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


