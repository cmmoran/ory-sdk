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

// checks if the Money type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &Money{}

// Money struct for Money
type Money struct {
	Cents *int64 `json:"Cents,omitempty"`
	String *string `json:"String,omitempty"`
	Unit *string `json:"Unit,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _Money Money

// NewMoney instantiates a new Money object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewMoney() *Money {
	this := Money{}
	return &this
}

// NewMoneyWithDefaults instantiates a new Money object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewMoneyWithDefaults() *Money {
	this := Money{}
	return &this
}

// GetCents returns the Cents field value if set, zero value otherwise.
func (o *Money) GetCents() int64 {
	if o == nil || IsNil(o.Cents) {
		var ret int64
		return ret
	}
	return *o.Cents
}

// GetCentsOk returns a tuple with the Cents field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Money) GetCentsOk() (*int64, bool) {
	if o == nil || IsNil(o.Cents) {
		return nil, false
	}
	return o.Cents, true
}

// HasCents returns a boolean if a field has been set.
func (o *Money) HasCents() bool {
	if o != nil && !IsNil(o.Cents) {
		return true
	}

	return false
}

// SetCents gets a reference to the given int64 and assigns it to the Cents field.
func (o *Money) SetCents(v int64) {
	o.Cents = &v
}

// GetString returns the String field value if set, zero value otherwise.
func (o *Money) GetString() string {
	if o == nil || IsNil(o.String) {
		var ret string
		return ret
	}
	return *o.String
}

// GetStringOk returns a tuple with the String field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Money) GetStringOk() (*string, bool) {
	if o == nil || IsNil(o.String) {
		return nil, false
	}
	return o.String, true
}

// HasString returns a boolean if a field has been set.
func (o *Money) HasString() bool {
	if o != nil && !IsNil(o.String) {
		return true
	}

	return false
}

// SetString gets a reference to the given string and assigns it to the String field.
func (o *Money) SetString(v string) {
	o.String = &v
}

// GetUnit returns the Unit field value if set, zero value otherwise.
func (o *Money) GetUnit() string {
	if o == nil || IsNil(o.Unit) {
		var ret string
		return ret
	}
	return *o.Unit
}

// GetUnitOk returns a tuple with the Unit field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Money) GetUnitOk() (*string, bool) {
	if o == nil || IsNil(o.Unit) {
		return nil, false
	}
	return o.Unit, true
}

// HasUnit returns a boolean if a field has been set.
func (o *Money) HasUnit() bool {
	if o != nil && !IsNil(o.Unit) {
		return true
	}

	return false
}

// SetUnit gets a reference to the given string and assigns it to the Unit field.
func (o *Money) SetUnit(v string) {
	o.Unit = &v
}

func (o Money) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o Money) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Cents) {
		toSerialize["Cents"] = o.Cents
	}
	if !IsNil(o.String) {
		toSerialize["String"] = o.String
	}
	if !IsNil(o.Unit) {
		toSerialize["Unit"] = o.Unit
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *Money) UnmarshalJSON(data []byte) (err error) {
	varMoney := _Money{}

	err = json.Unmarshal(data, &varMoney)

	if err != nil {
		return err
	}

	*o = Money(varMoney)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "Cents")
		delete(additionalProperties, "String")
		delete(additionalProperties, "Unit")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableMoney struct {
	value *Money
	isSet bool
}

func (v NullableMoney) Get() *Money {
	return v.value
}

func (v *NullableMoney) Set(val *Money) {
	v.value = val
	v.isSet = true
}

func (v NullableMoney) IsSet() bool {
	return v.isSet
}

func (v *NullableMoney) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableMoney(val *Money) *NullableMoney {
	return &NullableMoney{value: val, isSet: true}
}

func (v NullableMoney) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableMoney) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


