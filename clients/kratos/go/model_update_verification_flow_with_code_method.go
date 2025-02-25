/*
Ory Identities API

This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

API version: v1.3.6-alpha.1
Contact: office@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// checks if the UpdateVerificationFlowWithCodeMethod type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &UpdateVerificationFlowWithCodeMethod{}

// UpdateVerificationFlowWithCodeMethod struct for UpdateVerificationFlowWithCodeMethod
type UpdateVerificationFlowWithCodeMethod struct {
	// Code from the recovery email  If you want to submit a code, use this field, but make sure to _not_ include the email field, as well.
	Code *string `json:"code,omitempty"`
	// Sending the anti-csrf token is only required for browser login flows.
	CsrfToken *string `json:"csrf_token,omitempty"`
	// The email address to verify  If the email belongs to a valid account, a verifiation email will be sent.  If you want to notify the email address if the account does not exist, see the [notify_unknown_recipients flag](https://www.ory.sh/docs/kratos/self-service/flows/verify-email-account-activation#attempted-verification-notifications)  If a code was already sent, including this field in the payload will invalidate the sent code and re-send a new code.  format: email
	Email *string `json:"email,omitempty"`
	// Method is the method that should be used for this verification flow  Allowed values are `link` and `code`. link VerificationStrategyLink code VerificationStrategyCode
	Method string `json:"method"`
	// Transient data to pass along to any webhooks
	TransientPayload map[string]interface{} `json:"transient_payload,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _UpdateVerificationFlowWithCodeMethod UpdateVerificationFlowWithCodeMethod

// NewUpdateVerificationFlowWithCodeMethod instantiates a new UpdateVerificationFlowWithCodeMethod object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewUpdateVerificationFlowWithCodeMethod(method string) *UpdateVerificationFlowWithCodeMethod {
	this := UpdateVerificationFlowWithCodeMethod{}
	this.Method = method
	return &this
}

// NewUpdateVerificationFlowWithCodeMethodWithDefaults instantiates a new UpdateVerificationFlowWithCodeMethod object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewUpdateVerificationFlowWithCodeMethodWithDefaults() *UpdateVerificationFlowWithCodeMethod {
	this := UpdateVerificationFlowWithCodeMethod{}
	return &this
}

// GetCode returns the Code field value if set, zero value otherwise.
func (o *UpdateVerificationFlowWithCodeMethod) GetCode() string {
	if o == nil || IsNil(o.Code) {
		var ret string
		return ret
	}
	return *o.Code
}

// GetCodeOk returns a tuple with the Code field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateVerificationFlowWithCodeMethod) GetCodeOk() (*string, bool) {
	if o == nil || IsNil(o.Code) {
		return nil, false
	}
	return o.Code, true
}

// HasCode returns a boolean if a field has been set.
func (o *UpdateVerificationFlowWithCodeMethod) HasCode() bool {
	if o != nil && !IsNil(o.Code) {
		return true
	}

	return false
}

// SetCode gets a reference to the given string and assigns it to the Code field.
func (o *UpdateVerificationFlowWithCodeMethod) SetCode(v string) {
	o.Code = &v
}

// GetCsrfToken returns the CsrfToken field value if set, zero value otherwise.
func (o *UpdateVerificationFlowWithCodeMethod) GetCsrfToken() string {
	if o == nil || IsNil(o.CsrfToken) {
		var ret string
		return ret
	}
	return *o.CsrfToken
}

// GetCsrfTokenOk returns a tuple with the CsrfToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateVerificationFlowWithCodeMethod) GetCsrfTokenOk() (*string, bool) {
	if o == nil || IsNil(o.CsrfToken) {
		return nil, false
	}
	return o.CsrfToken, true
}

// HasCsrfToken returns a boolean if a field has been set.
func (o *UpdateVerificationFlowWithCodeMethod) HasCsrfToken() bool {
	if o != nil && !IsNil(o.CsrfToken) {
		return true
	}

	return false
}

// SetCsrfToken gets a reference to the given string and assigns it to the CsrfToken field.
func (o *UpdateVerificationFlowWithCodeMethod) SetCsrfToken(v string) {
	o.CsrfToken = &v
}

// GetEmail returns the Email field value if set, zero value otherwise.
func (o *UpdateVerificationFlowWithCodeMethod) GetEmail() string {
	if o == nil || IsNil(o.Email) {
		var ret string
		return ret
	}
	return *o.Email
}

// GetEmailOk returns a tuple with the Email field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateVerificationFlowWithCodeMethod) GetEmailOk() (*string, bool) {
	if o == nil || IsNil(o.Email) {
		return nil, false
	}
	return o.Email, true
}

// HasEmail returns a boolean if a field has been set.
func (o *UpdateVerificationFlowWithCodeMethod) HasEmail() bool {
	if o != nil && !IsNil(o.Email) {
		return true
	}

	return false
}

// SetEmail gets a reference to the given string and assigns it to the Email field.
func (o *UpdateVerificationFlowWithCodeMethod) SetEmail(v string) {
	o.Email = &v
}

// GetMethod returns the Method field value
func (o *UpdateVerificationFlowWithCodeMethod) GetMethod() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Method
}

// GetMethodOk returns a tuple with the Method field value
// and a boolean to check if the value has been set.
func (o *UpdateVerificationFlowWithCodeMethod) GetMethodOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Method, true
}

// SetMethod sets field value
func (o *UpdateVerificationFlowWithCodeMethod) SetMethod(v string) {
	o.Method = v
}

// GetTransientPayload returns the TransientPayload field value if set, zero value otherwise.
func (o *UpdateVerificationFlowWithCodeMethod) GetTransientPayload() map[string]interface{} {
	if o == nil || IsNil(o.TransientPayload) {
		var ret map[string]interface{}
		return ret
	}
	return o.TransientPayload
}

// GetTransientPayloadOk returns a tuple with the TransientPayload field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateVerificationFlowWithCodeMethod) GetTransientPayloadOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.TransientPayload) {
		return map[string]interface{}{}, false
	}
	return o.TransientPayload, true
}

// HasTransientPayload returns a boolean if a field has been set.
func (o *UpdateVerificationFlowWithCodeMethod) HasTransientPayload() bool {
	if o != nil && !IsNil(o.TransientPayload) {
		return true
	}

	return false
}

// SetTransientPayload gets a reference to the given map[string]interface{} and assigns it to the TransientPayload field.
func (o *UpdateVerificationFlowWithCodeMethod) SetTransientPayload(v map[string]interface{}) {
	o.TransientPayload = v
}

func (o UpdateVerificationFlowWithCodeMethod) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o UpdateVerificationFlowWithCodeMethod) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Code) {
		toSerialize["code"] = o.Code
	}
	if !IsNil(o.CsrfToken) {
		toSerialize["csrf_token"] = o.CsrfToken
	}
	if !IsNil(o.Email) {
		toSerialize["email"] = o.Email
	}
	toSerialize["method"] = o.Method
	if !IsNil(o.TransientPayload) {
		toSerialize["transient_payload"] = o.TransientPayload
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *UpdateVerificationFlowWithCodeMethod) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"method",
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

	varUpdateVerificationFlowWithCodeMethod := _UpdateVerificationFlowWithCodeMethod{}

	err = json.Unmarshal(data, &varUpdateVerificationFlowWithCodeMethod)

	if err != nil {
		return err
	}

	*o = UpdateVerificationFlowWithCodeMethod(varUpdateVerificationFlowWithCodeMethod)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "code")
		delete(additionalProperties, "csrf_token")
		delete(additionalProperties, "email")
		delete(additionalProperties, "method")
		delete(additionalProperties, "transient_payload")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableUpdateVerificationFlowWithCodeMethod struct {
	value *UpdateVerificationFlowWithCodeMethod
	isSet bool
}

func (v NullableUpdateVerificationFlowWithCodeMethod) Get() *UpdateVerificationFlowWithCodeMethod {
	return v.value
}

func (v *NullableUpdateVerificationFlowWithCodeMethod) Set(val *UpdateVerificationFlowWithCodeMethod) {
	v.value = val
	v.isSet = true
}

func (v NullableUpdateVerificationFlowWithCodeMethod) IsSet() bool {
	return v.isSet
}

func (v *NullableUpdateVerificationFlowWithCodeMethod) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUpdateVerificationFlowWithCodeMethod(val *UpdateVerificationFlowWithCodeMethod) *NullableUpdateVerificationFlowWithCodeMethod {
	return &NullableUpdateVerificationFlowWithCodeMethod{value: val, isSet: true}
}

func (v NullableUpdateVerificationFlowWithCodeMethod) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUpdateVerificationFlowWithCodeMethod) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


