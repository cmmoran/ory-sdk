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
	"fmt"
)

// checks if the CreateEventStreamBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &CreateEventStreamBody{}

// CreateEventStreamBody Create Event Stream Request Body
type CreateEventStreamBody struct {
	// The AWS IAM role ARN to assume when publishing to the SNS topic.
	RoleArn string `json:"role_arn"`
	// The AWS SNS topic ARN.
	TopicArn string `json:"topic_arn"`
	// The type of the event stream (AWS SNS, GCP Pub/Sub, etc).
	Type string `json:"type"`
	AdditionalProperties map[string]interface{}
}

type _CreateEventStreamBody CreateEventStreamBody

// NewCreateEventStreamBody instantiates a new CreateEventStreamBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCreateEventStreamBody(roleArn string, topicArn string, type_ string) *CreateEventStreamBody {
	this := CreateEventStreamBody{}
	this.RoleArn = roleArn
	this.TopicArn = topicArn
	this.Type = type_
	return &this
}

// NewCreateEventStreamBodyWithDefaults instantiates a new CreateEventStreamBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCreateEventStreamBodyWithDefaults() *CreateEventStreamBody {
	this := CreateEventStreamBody{}
	return &this
}

// GetRoleArn returns the RoleArn field value
func (o *CreateEventStreamBody) GetRoleArn() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.RoleArn
}

// GetRoleArnOk returns a tuple with the RoleArn field value
// and a boolean to check if the value has been set.
func (o *CreateEventStreamBody) GetRoleArnOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.RoleArn, true
}

// SetRoleArn sets field value
func (o *CreateEventStreamBody) SetRoleArn(v string) {
	o.RoleArn = v
}

// GetTopicArn returns the TopicArn field value
func (o *CreateEventStreamBody) GetTopicArn() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.TopicArn
}

// GetTopicArnOk returns a tuple with the TopicArn field value
// and a boolean to check if the value has been set.
func (o *CreateEventStreamBody) GetTopicArnOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.TopicArn, true
}

// SetTopicArn sets field value
func (o *CreateEventStreamBody) SetTopicArn(v string) {
	o.TopicArn = v
}

// GetType returns the Type field value
func (o *CreateEventStreamBody) GetType() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Type
}

// GetTypeOk returns a tuple with the Type field value
// and a boolean to check if the value has been set.
func (o *CreateEventStreamBody) GetTypeOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Type, true
}

// SetType sets field value
func (o *CreateEventStreamBody) SetType(v string) {
	o.Type = v
}

func (o CreateEventStreamBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o CreateEventStreamBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["role_arn"] = o.RoleArn
	toSerialize["topic_arn"] = o.TopicArn
	toSerialize["type"] = o.Type

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *CreateEventStreamBody) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"role_arn",
		"topic_arn",
		"type",
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

	varCreateEventStreamBody := _CreateEventStreamBody{}

	err = json.Unmarshal(data, &varCreateEventStreamBody)

	if err != nil {
		return err
	}

	*o = CreateEventStreamBody(varCreateEventStreamBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "role_arn")
		delete(additionalProperties, "topic_arn")
		delete(additionalProperties, "type")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableCreateEventStreamBody struct {
	value *CreateEventStreamBody
	isSet bool
}

func (v NullableCreateEventStreamBody) Get() *CreateEventStreamBody {
	return v.value
}

func (v *NullableCreateEventStreamBody) Set(val *CreateEventStreamBody) {
	v.value = val
	v.isSet = true
}

func (v NullableCreateEventStreamBody) IsSet() bool {
	return v.isSet
}

func (v *NullableCreateEventStreamBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCreateEventStreamBody(val *CreateEventStreamBody) *NullableCreateEventStreamBody {
	return &NullableCreateEventStreamBody{value: val, isSet: true}
}

func (v NullableCreateEventStreamBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCreateEventStreamBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


