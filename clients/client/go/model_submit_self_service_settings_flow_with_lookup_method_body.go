/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.1.0-alpha.8
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// SubmitSelfServiceSettingsFlowWithLookupMethodBody struct for SubmitSelfServiceSettingsFlowWithLookupMethodBody
type SubmitSelfServiceSettingsFlowWithLookupMethodBody struct {
	// CSRFToken is the anti-CSRF token
	CsrfToken *string `json:"csrf_token,omitempty"`
	// If set to true will save the regenerated lookup secrets
	LookupSecretConfirm *bool `json:"lookup_secret_confirm,omitempty"`
	// Disables this method if true.
	LookupSecretDisable *bool `json:"lookup_secret_disable,omitempty"`
	// If set to true will regenerate the lookup secrets
	LookupSecretRegenerate *bool `json:"lookup_secret_regenerate,omitempty"`
	// If set to true will reveal the lookup secrets
	LookupSecretReveal *bool `json:"lookup_secret_reveal,omitempty"`
	// Method  Should be set to \"lookup\" when trying to add, update, or remove a lookup pairing.
	Method string `json:"method"`
}

// NewSubmitSelfServiceSettingsFlowWithLookupMethodBody instantiates a new SubmitSelfServiceSettingsFlowWithLookupMethodBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSubmitSelfServiceSettingsFlowWithLookupMethodBody(method string) *SubmitSelfServiceSettingsFlowWithLookupMethodBody {
	this := SubmitSelfServiceSettingsFlowWithLookupMethodBody{}
	this.Method = method
	return &this
}

// NewSubmitSelfServiceSettingsFlowWithLookupMethodBodyWithDefaults instantiates a new SubmitSelfServiceSettingsFlowWithLookupMethodBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSubmitSelfServiceSettingsFlowWithLookupMethodBodyWithDefaults() *SubmitSelfServiceSettingsFlowWithLookupMethodBody {
	this := SubmitSelfServiceSettingsFlowWithLookupMethodBody{}
	return &this
}

// GetCsrfToken returns the CsrfToken field value if set, zero value otherwise.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetCsrfToken() string {
	if o == nil || o.CsrfToken == nil {
		var ret string
		return ret
	}
	return *o.CsrfToken
}

// GetCsrfTokenOk returns a tuple with the CsrfToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetCsrfTokenOk() (*string, bool) {
	if o == nil || o.CsrfToken == nil {
		return nil, false
	}
	return o.CsrfToken, true
}

// HasCsrfToken returns a boolean if a field has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) HasCsrfToken() bool {
	if o != nil && o.CsrfToken != nil {
		return true
	}

	return false
}

// SetCsrfToken gets a reference to the given string and assigns it to the CsrfToken field.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) SetCsrfToken(v string) {
	o.CsrfToken = &v
}

// GetLookupSecretConfirm returns the LookupSecretConfirm field value if set, zero value otherwise.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetLookupSecretConfirm() bool {
	if o == nil || o.LookupSecretConfirm == nil {
		var ret bool
		return ret
	}
	return *o.LookupSecretConfirm
}

// GetLookupSecretConfirmOk returns a tuple with the LookupSecretConfirm field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetLookupSecretConfirmOk() (*bool, bool) {
	if o == nil || o.LookupSecretConfirm == nil {
		return nil, false
	}
	return o.LookupSecretConfirm, true
}

// HasLookupSecretConfirm returns a boolean if a field has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) HasLookupSecretConfirm() bool {
	if o != nil && o.LookupSecretConfirm != nil {
		return true
	}

	return false
}

// SetLookupSecretConfirm gets a reference to the given bool and assigns it to the LookupSecretConfirm field.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) SetLookupSecretConfirm(v bool) {
	o.LookupSecretConfirm = &v
}

// GetLookupSecretDisable returns the LookupSecretDisable field value if set, zero value otherwise.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetLookupSecretDisable() bool {
	if o == nil || o.LookupSecretDisable == nil {
		var ret bool
		return ret
	}
	return *o.LookupSecretDisable
}

// GetLookupSecretDisableOk returns a tuple with the LookupSecretDisable field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetLookupSecretDisableOk() (*bool, bool) {
	if o == nil || o.LookupSecretDisable == nil {
		return nil, false
	}
	return o.LookupSecretDisable, true
}

// HasLookupSecretDisable returns a boolean if a field has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) HasLookupSecretDisable() bool {
	if o != nil && o.LookupSecretDisable != nil {
		return true
	}

	return false
}

// SetLookupSecretDisable gets a reference to the given bool and assigns it to the LookupSecretDisable field.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) SetLookupSecretDisable(v bool) {
	o.LookupSecretDisable = &v
}

// GetLookupSecretRegenerate returns the LookupSecretRegenerate field value if set, zero value otherwise.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetLookupSecretRegenerate() bool {
	if o == nil || o.LookupSecretRegenerate == nil {
		var ret bool
		return ret
	}
	return *o.LookupSecretRegenerate
}

// GetLookupSecretRegenerateOk returns a tuple with the LookupSecretRegenerate field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetLookupSecretRegenerateOk() (*bool, bool) {
	if o == nil || o.LookupSecretRegenerate == nil {
		return nil, false
	}
	return o.LookupSecretRegenerate, true
}

// HasLookupSecretRegenerate returns a boolean if a field has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) HasLookupSecretRegenerate() bool {
	if o != nil && o.LookupSecretRegenerate != nil {
		return true
	}

	return false
}

// SetLookupSecretRegenerate gets a reference to the given bool and assigns it to the LookupSecretRegenerate field.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) SetLookupSecretRegenerate(v bool) {
	o.LookupSecretRegenerate = &v
}

// GetLookupSecretReveal returns the LookupSecretReveal field value if set, zero value otherwise.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetLookupSecretReveal() bool {
	if o == nil || o.LookupSecretReveal == nil {
		var ret bool
		return ret
	}
	return *o.LookupSecretReveal
}

// GetLookupSecretRevealOk returns a tuple with the LookupSecretReveal field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetLookupSecretRevealOk() (*bool, bool) {
	if o == nil || o.LookupSecretReveal == nil {
		return nil, false
	}
	return o.LookupSecretReveal, true
}

// HasLookupSecretReveal returns a boolean if a field has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) HasLookupSecretReveal() bool {
	if o != nil && o.LookupSecretReveal != nil {
		return true
	}

	return false
}

// SetLookupSecretReveal gets a reference to the given bool and assigns it to the LookupSecretReveal field.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) SetLookupSecretReveal(v bool) {
	o.LookupSecretReveal = &v
}

// GetMethod returns the Method field value
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetMethod() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Method
}

// GetMethodOk returns a tuple with the Method field value
// and a boolean to check if the value has been set.
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) GetMethodOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Method, true
}

// SetMethod sets field value
func (o *SubmitSelfServiceSettingsFlowWithLookupMethodBody) SetMethod(v string) {
	o.Method = v
}

func (o SubmitSelfServiceSettingsFlowWithLookupMethodBody) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.CsrfToken != nil {
		toSerialize["csrf_token"] = o.CsrfToken
	}
	if o.LookupSecretConfirm != nil {
		toSerialize["lookup_secret_confirm"] = o.LookupSecretConfirm
	}
	if o.LookupSecretDisable != nil {
		toSerialize["lookup_secret_disable"] = o.LookupSecretDisable
	}
	if o.LookupSecretRegenerate != nil {
		toSerialize["lookup_secret_regenerate"] = o.LookupSecretRegenerate
	}
	if o.LookupSecretReveal != nil {
		toSerialize["lookup_secret_reveal"] = o.LookupSecretReveal
	}
	if true {
		toSerialize["method"] = o.Method
	}
	return json.Marshal(toSerialize)
}

type NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody struct {
	value *SubmitSelfServiceSettingsFlowWithLookupMethodBody
	isSet bool
}

func (v NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody) Get() *SubmitSelfServiceSettingsFlowWithLookupMethodBody {
	return v.value
}

func (v *NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody) Set(val *SubmitSelfServiceSettingsFlowWithLookupMethodBody) {
	v.value = val
	v.isSet = true
}

func (v NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody) IsSet() bool {
	return v.isSet
}

func (v *NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSubmitSelfServiceSettingsFlowWithLookupMethodBody(val *SubmitSelfServiceSettingsFlowWithLookupMethodBody) *NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody {
	return &NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody{value: val, isSet: true}
}

func (v NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSubmitSelfServiceSettingsFlowWithLookupMethodBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


