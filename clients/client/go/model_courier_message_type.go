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

// CourierMessageType It can either be `email` or `phone`
type CourierMessageType string

// List of courierMessageType
const (
	COURIERMESSAGETYPE_EMAIL CourierMessageType = "email"
	COURIERMESSAGETYPE_PHONE CourierMessageType = "phone"
)

// All allowed values of CourierMessageType enum
var AllowedCourierMessageTypeEnumValues = []CourierMessageType{
	"email",
	"phone",
}

func (v *CourierMessageType) UnmarshalJSON(src []byte) error {
	var value string
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := CourierMessageType(value)
	for _, existing := range AllowedCourierMessageTypeEnumValues {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid CourierMessageType", value)
}

// NewCourierMessageTypeFromValue returns a pointer to a valid CourierMessageType
// for the value passed as argument, or an error if the value passed is not allowed by the enum
func NewCourierMessageTypeFromValue(v string) (*CourierMessageType, error) {
	ev := CourierMessageType(v)
	if ev.IsValid() {
		return &ev, nil
	} else {
		return nil, fmt.Errorf("invalid value '%v' for CourierMessageType: valid values are %v", v, AllowedCourierMessageTypeEnumValues)
	}
}

// IsValid return true if the value is valid for the enum, false otherwise
func (v CourierMessageType) IsValid() bool {
	for _, existing := range AllowedCourierMessageTypeEnumValues {
		if existing == v {
			return true
		}
	}
	return false
}

// Ptr returns reference to courierMessageType value
func (v CourierMessageType) Ptr() *CourierMessageType {
	return &v
}

type NullableCourierMessageType struct {
	value *CourierMessageType
	isSet bool
}

func (v NullableCourierMessageType) Get() *CourierMessageType {
	return v.value
}

func (v *NullableCourierMessageType) Set(val *CourierMessageType) {
	v.value = val
	v.isSet = true
}

func (v NullableCourierMessageType) IsSet() bool {
	return v.isSet
}

func (v *NullableCourierMessageType) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCourierMessageType(val *CourierMessageType) *NullableCourierMessageType {
	return &NullableCourierMessageType{value: val, isSet: true}
}

func (v NullableCourierMessageType) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCourierMessageType) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

