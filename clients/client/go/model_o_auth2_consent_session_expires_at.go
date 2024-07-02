/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.12.2
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"time"
)

// checks if the OAuth2ConsentSessionExpiresAt type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &OAuth2ConsentSessionExpiresAt{}

// OAuth2ConsentSessionExpiresAt struct for OAuth2ConsentSessionExpiresAt
type OAuth2ConsentSessionExpiresAt struct {
	AccessToken *time.Time `json:"access_token,omitempty"`
	AuthorizeCode *time.Time `json:"authorize_code,omitempty"`
	IdToken *time.Time `json:"id_token,omitempty"`
	ParContext *time.Time `json:"par_context,omitempty"`
	RefreshToken *time.Time `json:"refresh_token,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _OAuth2ConsentSessionExpiresAt OAuth2ConsentSessionExpiresAt

// NewOAuth2ConsentSessionExpiresAt instantiates a new OAuth2ConsentSessionExpiresAt object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewOAuth2ConsentSessionExpiresAt() *OAuth2ConsentSessionExpiresAt {
	this := OAuth2ConsentSessionExpiresAt{}
	return &this
}

// NewOAuth2ConsentSessionExpiresAtWithDefaults instantiates a new OAuth2ConsentSessionExpiresAt object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewOAuth2ConsentSessionExpiresAtWithDefaults() *OAuth2ConsentSessionExpiresAt {
	this := OAuth2ConsentSessionExpiresAt{}
	return &this
}

// GetAccessToken returns the AccessToken field value if set, zero value otherwise.
func (o *OAuth2ConsentSessionExpiresAt) GetAccessToken() time.Time {
	if o == nil || IsNil(o.AccessToken) {
		var ret time.Time
		return ret
	}
	return *o.AccessToken
}

// GetAccessTokenOk returns a tuple with the AccessToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSessionExpiresAt) GetAccessTokenOk() (*time.Time, bool) {
	if o == nil || IsNil(o.AccessToken) {
		return nil, false
	}
	return o.AccessToken, true
}

// HasAccessToken returns a boolean if a field has been set.
func (o *OAuth2ConsentSessionExpiresAt) HasAccessToken() bool {
	if o != nil && !IsNil(o.AccessToken) {
		return true
	}

	return false
}

// SetAccessToken gets a reference to the given time.Time and assigns it to the AccessToken field.
func (o *OAuth2ConsentSessionExpiresAt) SetAccessToken(v time.Time) {
	o.AccessToken = &v
}

// GetAuthorizeCode returns the AuthorizeCode field value if set, zero value otherwise.
func (o *OAuth2ConsentSessionExpiresAt) GetAuthorizeCode() time.Time {
	if o == nil || IsNil(o.AuthorizeCode) {
		var ret time.Time
		return ret
	}
	return *o.AuthorizeCode
}

// GetAuthorizeCodeOk returns a tuple with the AuthorizeCode field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSessionExpiresAt) GetAuthorizeCodeOk() (*time.Time, bool) {
	if o == nil || IsNil(o.AuthorizeCode) {
		return nil, false
	}
	return o.AuthorizeCode, true
}

// HasAuthorizeCode returns a boolean if a field has been set.
func (o *OAuth2ConsentSessionExpiresAt) HasAuthorizeCode() bool {
	if o != nil && !IsNil(o.AuthorizeCode) {
		return true
	}

	return false
}

// SetAuthorizeCode gets a reference to the given time.Time and assigns it to the AuthorizeCode field.
func (o *OAuth2ConsentSessionExpiresAt) SetAuthorizeCode(v time.Time) {
	o.AuthorizeCode = &v
}

// GetIdToken returns the IdToken field value if set, zero value otherwise.
func (o *OAuth2ConsentSessionExpiresAt) GetIdToken() time.Time {
	if o == nil || IsNil(o.IdToken) {
		var ret time.Time
		return ret
	}
	return *o.IdToken
}

// GetIdTokenOk returns a tuple with the IdToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSessionExpiresAt) GetIdTokenOk() (*time.Time, bool) {
	if o == nil || IsNil(o.IdToken) {
		return nil, false
	}
	return o.IdToken, true
}

// HasIdToken returns a boolean if a field has been set.
func (o *OAuth2ConsentSessionExpiresAt) HasIdToken() bool {
	if o != nil && !IsNil(o.IdToken) {
		return true
	}

	return false
}

// SetIdToken gets a reference to the given time.Time and assigns it to the IdToken field.
func (o *OAuth2ConsentSessionExpiresAt) SetIdToken(v time.Time) {
	o.IdToken = &v
}

// GetParContext returns the ParContext field value if set, zero value otherwise.
func (o *OAuth2ConsentSessionExpiresAt) GetParContext() time.Time {
	if o == nil || IsNil(o.ParContext) {
		var ret time.Time
		return ret
	}
	return *o.ParContext
}

// GetParContextOk returns a tuple with the ParContext field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSessionExpiresAt) GetParContextOk() (*time.Time, bool) {
	if o == nil || IsNil(o.ParContext) {
		return nil, false
	}
	return o.ParContext, true
}

// HasParContext returns a boolean if a field has been set.
func (o *OAuth2ConsentSessionExpiresAt) HasParContext() bool {
	if o != nil && !IsNil(o.ParContext) {
		return true
	}

	return false
}

// SetParContext gets a reference to the given time.Time and assigns it to the ParContext field.
func (o *OAuth2ConsentSessionExpiresAt) SetParContext(v time.Time) {
	o.ParContext = &v
}

// GetRefreshToken returns the RefreshToken field value if set, zero value otherwise.
func (o *OAuth2ConsentSessionExpiresAt) GetRefreshToken() time.Time {
	if o == nil || IsNil(o.RefreshToken) {
		var ret time.Time
		return ret
	}
	return *o.RefreshToken
}

// GetRefreshTokenOk returns a tuple with the RefreshToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OAuth2ConsentSessionExpiresAt) GetRefreshTokenOk() (*time.Time, bool) {
	if o == nil || IsNil(o.RefreshToken) {
		return nil, false
	}
	return o.RefreshToken, true
}

// HasRefreshToken returns a boolean if a field has been set.
func (o *OAuth2ConsentSessionExpiresAt) HasRefreshToken() bool {
	if o != nil && !IsNil(o.RefreshToken) {
		return true
	}

	return false
}

// SetRefreshToken gets a reference to the given time.Time and assigns it to the RefreshToken field.
func (o *OAuth2ConsentSessionExpiresAt) SetRefreshToken(v time.Time) {
	o.RefreshToken = &v
}

func (o OAuth2ConsentSessionExpiresAt) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o OAuth2ConsentSessionExpiresAt) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.AccessToken) {
		toSerialize["access_token"] = o.AccessToken
	}
	if !IsNil(o.AuthorizeCode) {
		toSerialize["authorize_code"] = o.AuthorizeCode
	}
	if !IsNil(o.IdToken) {
		toSerialize["id_token"] = o.IdToken
	}
	if !IsNil(o.ParContext) {
		toSerialize["par_context"] = o.ParContext
	}
	if !IsNil(o.RefreshToken) {
		toSerialize["refresh_token"] = o.RefreshToken
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *OAuth2ConsentSessionExpiresAt) UnmarshalJSON(data []byte) (err error) {
	varOAuth2ConsentSessionExpiresAt := _OAuth2ConsentSessionExpiresAt{}

	err = json.Unmarshal(data, &varOAuth2ConsentSessionExpiresAt)

	if err != nil {
		return err
	}

	*o = OAuth2ConsentSessionExpiresAt(varOAuth2ConsentSessionExpiresAt)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "access_token")
		delete(additionalProperties, "authorize_code")
		delete(additionalProperties, "id_token")
		delete(additionalProperties, "par_context")
		delete(additionalProperties, "refresh_token")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableOAuth2ConsentSessionExpiresAt struct {
	value *OAuth2ConsentSessionExpiresAt
	isSet bool
}

func (v NullableOAuth2ConsentSessionExpiresAt) Get() *OAuth2ConsentSessionExpiresAt {
	return v.value
}

func (v *NullableOAuth2ConsentSessionExpiresAt) Set(val *OAuth2ConsentSessionExpiresAt) {
	v.value = val
	v.isSet = true
}

func (v NullableOAuth2ConsentSessionExpiresAt) IsSet() bool {
	return v.isSet
}

func (v *NullableOAuth2ConsentSessionExpiresAt) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableOAuth2ConsentSessionExpiresAt(val *OAuth2ConsentSessionExpiresAt) *NullableOAuth2ConsentSessionExpiresAt {
	return &NullableOAuth2ConsentSessionExpiresAt{value: val, isSet: true}
}

func (v NullableOAuth2ConsentSessionExpiresAt) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableOAuth2ConsentSessionExpiresAt) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


