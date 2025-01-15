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

// checks if the UpdateLoginFlowWithOidcMethod type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &UpdateLoginFlowWithOidcMethod{}

// UpdateLoginFlowWithOidcMethod Update Login Flow with OpenID Connect Method
type UpdateLoginFlowWithOidcMethod struct {
	// The CSRF Token
	CsrfToken *string `json:"csrf_token,omitempty"`
	// IDToken is an optional id token provided by an OIDC provider  If submitted, it is verified using the OIDC provider's public key set and the claims are used to populate the OIDC credentials of the identity. If the OIDC provider does not store additional claims (such as name, etc.) in the IDToken itself, you can use the `traits` field to populate the identity's traits. Note, that Apple only includes the users email in the IDToken.  Supported providers are Apple Google
	IdToken *string `json:"id_token,omitempty"`
	// IDTokenNonce is the nonce, used when generating the IDToken. If the provider supports nonce validation, the nonce will be validated against this value and required.
	IdTokenNonce *string `json:"id_token_nonce,omitempty"`
	// Method to use  This field must be set to `oidc` when using the oidc method.
	Method string `json:"method"`
	// The provider to register with
	Provider string `json:"provider"`
	// The identity traits. This is a placeholder for the registration flow.
	Traits map[string]interface{} `json:"traits,omitempty"`
	// Transient data to pass along to any webhooks
	TransientPayload map[string]interface{} `json:"transient_payload,omitempty"`
	// UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: `login_hint` (string): The `login_hint` parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. `hd` (string): The `hd` parameter limits the login/registration process to a Google Organization, e.g. `mycollege.edu`. `prompt` (string): The `prompt` specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. `select_account`.
	UpstreamParameters map[string]interface{} `json:"upstream_parameters,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _UpdateLoginFlowWithOidcMethod UpdateLoginFlowWithOidcMethod

// NewUpdateLoginFlowWithOidcMethod instantiates a new UpdateLoginFlowWithOidcMethod object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewUpdateLoginFlowWithOidcMethod(method string, provider string) *UpdateLoginFlowWithOidcMethod {
	this := UpdateLoginFlowWithOidcMethod{}
	this.Method = method
	this.Provider = provider
	return &this
}

// NewUpdateLoginFlowWithOidcMethodWithDefaults instantiates a new UpdateLoginFlowWithOidcMethod object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewUpdateLoginFlowWithOidcMethodWithDefaults() *UpdateLoginFlowWithOidcMethod {
	this := UpdateLoginFlowWithOidcMethod{}
	return &this
}

// GetCsrfToken returns the CsrfToken field value if set, zero value otherwise.
func (o *UpdateLoginFlowWithOidcMethod) GetCsrfToken() string {
	if o == nil || IsNil(o.CsrfToken) {
		var ret string
		return ret
	}
	return *o.CsrfToken
}

// GetCsrfTokenOk returns a tuple with the CsrfToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateLoginFlowWithOidcMethod) GetCsrfTokenOk() (*string, bool) {
	if o == nil || IsNil(o.CsrfToken) {
		return nil, false
	}
	return o.CsrfToken, true
}

// HasCsrfToken returns a boolean if a field has been set.
func (o *UpdateLoginFlowWithOidcMethod) HasCsrfToken() bool {
	if o != nil && !IsNil(o.CsrfToken) {
		return true
	}

	return false
}

// SetCsrfToken gets a reference to the given string and assigns it to the CsrfToken field.
func (o *UpdateLoginFlowWithOidcMethod) SetCsrfToken(v string) {
	o.CsrfToken = &v
}

// GetIdToken returns the IdToken field value if set, zero value otherwise.
func (o *UpdateLoginFlowWithOidcMethod) GetIdToken() string {
	if o == nil || IsNil(o.IdToken) {
		var ret string
		return ret
	}
	return *o.IdToken
}

// GetIdTokenOk returns a tuple with the IdToken field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateLoginFlowWithOidcMethod) GetIdTokenOk() (*string, bool) {
	if o == nil || IsNil(o.IdToken) {
		return nil, false
	}
	return o.IdToken, true
}

// HasIdToken returns a boolean if a field has been set.
func (o *UpdateLoginFlowWithOidcMethod) HasIdToken() bool {
	if o != nil && !IsNil(o.IdToken) {
		return true
	}

	return false
}

// SetIdToken gets a reference to the given string and assigns it to the IdToken field.
func (o *UpdateLoginFlowWithOidcMethod) SetIdToken(v string) {
	o.IdToken = &v
}

// GetIdTokenNonce returns the IdTokenNonce field value if set, zero value otherwise.
func (o *UpdateLoginFlowWithOidcMethod) GetIdTokenNonce() string {
	if o == nil || IsNil(o.IdTokenNonce) {
		var ret string
		return ret
	}
	return *o.IdTokenNonce
}

// GetIdTokenNonceOk returns a tuple with the IdTokenNonce field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateLoginFlowWithOidcMethod) GetIdTokenNonceOk() (*string, bool) {
	if o == nil || IsNil(o.IdTokenNonce) {
		return nil, false
	}
	return o.IdTokenNonce, true
}

// HasIdTokenNonce returns a boolean if a field has been set.
func (o *UpdateLoginFlowWithOidcMethod) HasIdTokenNonce() bool {
	if o != nil && !IsNil(o.IdTokenNonce) {
		return true
	}

	return false
}

// SetIdTokenNonce gets a reference to the given string and assigns it to the IdTokenNonce field.
func (o *UpdateLoginFlowWithOidcMethod) SetIdTokenNonce(v string) {
	o.IdTokenNonce = &v
}

// GetMethod returns the Method field value
func (o *UpdateLoginFlowWithOidcMethod) GetMethod() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Method
}

// GetMethodOk returns a tuple with the Method field value
// and a boolean to check if the value has been set.
func (o *UpdateLoginFlowWithOidcMethod) GetMethodOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Method, true
}

// SetMethod sets field value
func (o *UpdateLoginFlowWithOidcMethod) SetMethod(v string) {
	o.Method = v
}

// GetProvider returns the Provider field value
func (o *UpdateLoginFlowWithOidcMethod) GetProvider() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Provider
}

// GetProviderOk returns a tuple with the Provider field value
// and a boolean to check if the value has been set.
func (o *UpdateLoginFlowWithOidcMethod) GetProviderOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Provider, true
}

// SetProvider sets field value
func (o *UpdateLoginFlowWithOidcMethod) SetProvider(v string) {
	o.Provider = v
}

// GetTraits returns the Traits field value if set, zero value otherwise.
func (o *UpdateLoginFlowWithOidcMethod) GetTraits() map[string]interface{} {
	if o == nil || IsNil(o.Traits) {
		var ret map[string]interface{}
		return ret
	}
	return o.Traits
}

// GetTraitsOk returns a tuple with the Traits field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateLoginFlowWithOidcMethod) GetTraitsOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.Traits) {
		return map[string]interface{}{}, false
	}
	return o.Traits, true
}

// HasTraits returns a boolean if a field has been set.
func (o *UpdateLoginFlowWithOidcMethod) HasTraits() bool {
	if o != nil && !IsNil(o.Traits) {
		return true
	}

	return false
}

// SetTraits gets a reference to the given map[string]interface{} and assigns it to the Traits field.
func (o *UpdateLoginFlowWithOidcMethod) SetTraits(v map[string]interface{}) {
	o.Traits = v
}

// GetTransientPayload returns the TransientPayload field value if set, zero value otherwise.
func (o *UpdateLoginFlowWithOidcMethod) GetTransientPayload() map[string]interface{} {
	if o == nil || IsNil(o.TransientPayload) {
		var ret map[string]interface{}
		return ret
	}
	return o.TransientPayload
}

// GetTransientPayloadOk returns a tuple with the TransientPayload field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateLoginFlowWithOidcMethod) GetTransientPayloadOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.TransientPayload) {
		return map[string]interface{}{}, false
	}
	return o.TransientPayload, true
}

// HasTransientPayload returns a boolean if a field has been set.
func (o *UpdateLoginFlowWithOidcMethod) HasTransientPayload() bool {
	if o != nil && !IsNil(o.TransientPayload) {
		return true
	}

	return false
}

// SetTransientPayload gets a reference to the given map[string]interface{} and assigns it to the TransientPayload field.
func (o *UpdateLoginFlowWithOidcMethod) SetTransientPayload(v map[string]interface{}) {
	o.TransientPayload = v
}

// GetUpstreamParameters returns the UpstreamParameters field value if set, zero value otherwise.
func (o *UpdateLoginFlowWithOidcMethod) GetUpstreamParameters() map[string]interface{} {
	if o == nil || IsNil(o.UpstreamParameters) {
		var ret map[string]interface{}
		return ret
	}
	return o.UpstreamParameters
}

// GetUpstreamParametersOk returns a tuple with the UpstreamParameters field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *UpdateLoginFlowWithOidcMethod) GetUpstreamParametersOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.UpstreamParameters) {
		return map[string]interface{}{}, false
	}
	return o.UpstreamParameters, true
}

// HasUpstreamParameters returns a boolean if a field has been set.
func (o *UpdateLoginFlowWithOidcMethod) HasUpstreamParameters() bool {
	if o != nil && !IsNil(o.UpstreamParameters) {
		return true
	}

	return false
}

// SetUpstreamParameters gets a reference to the given map[string]interface{} and assigns it to the UpstreamParameters field.
func (o *UpdateLoginFlowWithOidcMethod) SetUpstreamParameters(v map[string]interface{}) {
	o.UpstreamParameters = v
}

func (o UpdateLoginFlowWithOidcMethod) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o UpdateLoginFlowWithOidcMethod) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.CsrfToken) {
		toSerialize["csrf_token"] = o.CsrfToken
	}
	if !IsNil(o.IdToken) {
		toSerialize["id_token"] = o.IdToken
	}
	if !IsNil(o.IdTokenNonce) {
		toSerialize["id_token_nonce"] = o.IdTokenNonce
	}
	toSerialize["method"] = o.Method
	toSerialize["provider"] = o.Provider
	if !IsNil(o.Traits) {
		toSerialize["traits"] = o.Traits
	}
	if !IsNil(o.TransientPayload) {
		toSerialize["transient_payload"] = o.TransientPayload
	}
	if !IsNil(o.UpstreamParameters) {
		toSerialize["upstream_parameters"] = o.UpstreamParameters
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *UpdateLoginFlowWithOidcMethod) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"method",
		"provider",
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

	varUpdateLoginFlowWithOidcMethod := _UpdateLoginFlowWithOidcMethod{}

	err = json.Unmarshal(data, &varUpdateLoginFlowWithOidcMethod)

	if err != nil {
		return err
	}

	*o = UpdateLoginFlowWithOidcMethod(varUpdateLoginFlowWithOidcMethod)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "csrf_token")
		delete(additionalProperties, "id_token")
		delete(additionalProperties, "id_token_nonce")
		delete(additionalProperties, "method")
		delete(additionalProperties, "provider")
		delete(additionalProperties, "traits")
		delete(additionalProperties, "transient_payload")
		delete(additionalProperties, "upstream_parameters")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableUpdateLoginFlowWithOidcMethod struct {
	value *UpdateLoginFlowWithOidcMethod
	isSet bool
}

func (v NullableUpdateLoginFlowWithOidcMethod) Get() *UpdateLoginFlowWithOidcMethod {
	return v.value
}

func (v *NullableUpdateLoginFlowWithOidcMethod) Set(val *UpdateLoginFlowWithOidcMethod) {
	v.value = val
	v.isSet = true
}

func (v NullableUpdateLoginFlowWithOidcMethod) IsSet() bool {
	return v.isSet
}

func (v *NullableUpdateLoginFlowWithOidcMethod) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUpdateLoginFlowWithOidcMethod(val *UpdateLoginFlowWithOidcMethod) *NullableUpdateLoginFlowWithOidcMethod {
	return &NullableUpdateLoginFlowWithOidcMethod{value: val, isSet: true}
}

func (v NullableUpdateLoginFlowWithOidcMethod) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUpdateLoginFlowWithOidcMethod) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


