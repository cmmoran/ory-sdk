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

// checks if the CreateWorkspaceMemberInviteBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &CreateWorkspaceMemberInviteBody{}

// CreateWorkspaceMemberInviteBody Create Workspace Invite Request Body
type CreateWorkspaceMemberInviteBody struct {
	// A email to invite
	InviteeEmail string `json:"invitee_email"`
	// The role the user will have in the workspace owner WorkspaceMemberRoleOwner developer WorkspaceMemberRoleDeveloper
	Role string `json:"role"`
	AdditionalProperties map[string]interface{}
}

type _CreateWorkspaceMemberInviteBody CreateWorkspaceMemberInviteBody

// NewCreateWorkspaceMemberInviteBody instantiates a new CreateWorkspaceMemberInviteBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCreateWorkspaceMemberInviteBody(inviteeEmail string, role string) *CreateWorkspaceMemberInviteBody {
	this := CreateWorkspaceMemberInviteBody{}
	this.InviteeEmail = inviteeEmail
	this.Role = role
	return &this
}

// NewCreateWorkspaceMemberInviteBodyWithDefaults instantiates a new CreateWorkspaceMemberInviteBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCreateWorkspaceMemberInviteBodyWithDefaults() *CreateWorkspaceMemberInviteBody {
	this := CreateWorkspaceMemberInviteBody{}
	return &this
}

// GetInviteeEmail returns the InviteeEmail field value
func (o *CreateWorkspaceMemberInviteBody) GetInviteeEmail() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.InviteeEmail
}

// GetInviteeEmailOk returns a tuple with the InviteeEmail field value
// and a boolean to check if the value has been set.
func (o *CreateWorkspaceMemberInviteBody) GetInviteeEmailOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.InviteeEmail, true
}

// SetInviteeEmail sets field value
func (o *CreateWorkspaceMemberInviteBody) SetInviteeEmail(v string) {
	o.InviteeEmail = v
}

// GetRole returns the Role field value
func (o *CreateWorkspaceMemberInviteBody) GetRole() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Role
}

// GetRoleOk returns a tuple with the Role field value
// and a boolean to check if the value has been set.
func (o *CreateWorkspaceMemberInviteBody) GetRoleOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Role, true
}

// SetRole sets field value
func (o *CreateWorkspaceMemberInviteBody) SetRole(v string) {
	o.Role = v
}

func (o CreateWorkspaceMemberInviteBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o CreateWorkspaceMemberInviteBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["invitee_email"] = o.InviteeEmail
	toSerialize["role"] = o.Role

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *CreateWorkspaceMemberInviteBody) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"invitee_email",
		"role",
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

	varCreateWorkspaceMemberInviteBody := _CreateWorkspaceMemberInviteBody{}

	err = json.Unmarshal(data, &varCreateWorkspaceMemberInviteBody)

	if err != nil {
		return err
	}

	*o = CreateWorkspaceMemberInviteBody(varCreateWorkspaceMemberInviteBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "invitee_email")
		delete(additionalProperties, "role")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableCreateWorkspaceMemberInviteBody struct {
	value *CreateWorkspaceMemberInviteBody
	isSet bool
}

func (v NullableCreateWorkspaceMemberInviteBody) Get() *CreateWorkspaceMemberInviteBody {
	return v.value
}

func (v *NullableCreateWorkspaceMemberInviteBody) Set(val *CreateWorkspaceMemberInviteBody) {
	v.value = val
	v.isSet = true
}

func (v NullableCreateWorkspaceMemberInviteBody) IsSet() bool {
	return v.isSet
}

func (v *NullableCreateWorkspaceMemberInviteBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCreateWorkspaceMemberInviteBody(val *CreateWorkspaceMemberInviteBody) *NullableCreateWorkspaceMemberInviteBody {
	return &NullableCreateWorkspaceMemberInviteBody{value: val, isSet: true}
}

func (v NullableCreateWorkspaceMemberInviteBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCreateWorkspaceMemberInviteBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


