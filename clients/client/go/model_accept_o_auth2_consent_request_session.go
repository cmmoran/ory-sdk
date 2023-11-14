/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.3.0
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// checks if the AcceptOAuth2ConsentRequestSession type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &AcceptOAuth2ConsentRequestSession{}

// AcceptOAuth2ConsentRequestSession struct for AcceptOAuth2ConsentRequestSession
type AcceptOAuth2ConsentRequestSession struct {
	// AccessToken sets session data for the access and refresh token, as well as any future tokens issued by the refresh grant. Keep in mind that this data will be available to anyone performing OAuth 2.0 Challenge Introspection. If only your services can perform OAuth 2.0 Challenge Introspection, this is usually fine. But if third parties can access that endpoint as well, sensitive data from the session might be exposed to them. Use with care!
	AccessToken interface{} `json:"access_token,omitempty"`
	// IDToken sets session data for the OpenID Connect ID token. Keep in mind that the session'id payloads are readable by anyone that has access to the ID Challenge. Use with care!
	IdToken interface{} `json:"id_token,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _AcceptOAuth2ConsentRequestSession AcceptOAuth2ConsentRequestSession

// NewAcceptOAuth2ConsentRequestSession instantiates a new AcceptOAuth2ConsentRequestSession object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewAcceptOAuth2ConsentRequestSession() *AcceptOAuth2ConsentRequestSession {
	this := AcceptOAuth2ConsentRequestSession{}
	return &this
}

// NewAcceptOAuth2ConsentRequestSessionWithDefaults instantiates a new AcceptOAuth2ConsentRequestSession object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewAcceptOAuth2ConsentRequestSessionWithDefaults() *AcceptOAuth2ConsentRequestSession {
	this := AcceptOAuth2ConsentRequestSession{}
	return &this
}

// GetAccessToken returns the AccessToken field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *AcceptOAuth2ConsentRequestSession) GetAccessToken() interface{} {
	if o == nil {
		var ret interface{}
		return ret
	}
	return o.AccessToken
}

// GetAccessTokenOk returns a tuple with the AccessToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *AcceptOAuth2ConsentRequestSession) GetAccessTokenOk() (*interface{}, bool) {
	if o == nil || IsNil(o.AccessToken) {
		return nil, false
	}
	return &o.AccessToken, true
}

// HasAccessToken returns a boolean if a field has been set.
func (o *AcceptOAuth2ConsentRequestSession) HasAccessToken() bool {
	if o != nil && IsNil(o.AccessToken) {
		return true
	}

	return false
}

// SetAccessToken gets a reference to the given interface{} and assigns it to the AccessToken field.
func (o *AcceptOAuth2ConsentRequestSession) SetAccessToken(v interface{}) {
	o.AccessToken = v
}

// GetIdToken returns the IdToken field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *AcceptOAuth2ConsentRequestSession) GetIdToken() interface{} {
	if o == nil {
		var ret interface{}
		return ret
	}
	return o.IdToken
}

// GetIdTokenOk returns a tuple with the IdToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *AcceptOAuth2ConsentRequestSession) GetIdTokenOk() (*interface{}, bool) {
	if o == nil || IsNil(o.IdToken) {
		return nil, false
	}
	return &o.IdToken, true
}

// HasIdToken returns a boolean if a field has been set.
func (o *AcceptOAuth2ConsentRequestSession) HasIdToken() bool {
	if o != nil && IsNil(o.IdToken) {
		return true
	}

	return false
}

// SetIdToken gets a reference to the given interface{} and assigns it to the IdToken field.
func (o *AcceptOAuth2ConsentRequestSession) SetIdToken(v interface{}) {
	o.IdToken = v
}

func (o AcceptOAuth2ConsentRequestSession) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o AcceptOAuth2ConsentRequestSession) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if o.AccessToken != nil {
		toSerialize["access_token"] = o.AccessToken
	}
	if o.IdToken != nil {
		toSerialize["id_token"] = o.IdToken
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *AcceptOAuth2ConsentRequestSession) UnmarshalJSON(bytes []byte) (err error) {
	varAcceptOAuth2ConsentRequestSession := _AcceptOAuth2ConsentRequestSession{}

	err = json.Unmarshal(bytes, &varAcceptOAuth2ConsentRequestSession)

	if err != nil {
		return err
	}

	*o = AcceptOAuth2ConsentRequestSession(varAcceptOAuth2ConsentRequestSession)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(bytes, &additionalProperties); err == nil {
		delete(additionalProperties, "access_token")
		delete(additionalProperties, "id_token")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableAcceptOAuth2ConsentRequestSession struct {
	value *AcceptOAuth2ConsentRequestSession
	isSet bool
}

func (v NullableAcceptOAuth2ConsentRequestSession) Get() *AcceptOAuth2ConsentRequestSession {
	return v.value
}

func (v *NullableAcceptOAuth2ConsentRequestSession) Set(val *AcceptOAuth2ConsentRequestSession) {
	v.value = val
	v.isSet = true
}

func (v NullableAcceptOAuth2ConsentRequestSession) IsSet() bool {
	return v.isSet
}

func (v *NullableAcceptOAuth2ConsentRequestSession) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableAcceptOAuth2ConsentRequestSession(val *AcceptOAuth2ConsentRequestSession) *NullableAcceptOAuth2ConsentRequestSession {
	return &NullableAcceptOAuth2ConsentRequestSession{value: val, isSet: true}
}

func (v NullableAcceptOAuth2ConsentRequestSession) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableAcceptOAuth2ConsentRequestSession) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


