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

// UpdateSettingsFlowBody - Update Settings Flow Request Body
type UpdateSettingsFlowBody struct {
	UpdateSettingsFlowWithLookupMethod *UpdateSettingsFlowWithLookupMethod
	UpdateSettingsFlowWithOidcMethod *UpdateSettingsFlowWithOidcMethod
	UpdateSettingsFlowWithPasskeyMethod *UpdateSettingsFlowWithPasskeyMethod
	UpdateSettingsFlowWithPasswordMethod *UpdateSettingsFlowWithPasswordMethod
	UpdateSettingsFlowWithProfileMethod *UpdateSettingsFlowWithProfileMethod
	UpdateSettingsFlowWithTotpMethod *UpdateSettingsFlowWithTotpMethod
	UpdateSettingsFlowWithWebAuthnMethod *UpdateSettingsFlowWithWebAuthnMethod
}

// UpdateSettingsFlowWithLookupMethodAsUpdateSettingsFlowBody is a convenience function that returns UpdateSettingsFlowWithLookupMethod wrapped in UpdateSettingsFlowBody
func UpdateSettingsFlowWithLookupMethodAsUpdateSettingsFlowBody(v *UpdateSettingsFlowWithLookupMethod) UpdateSettingsFlowBody {
	return UpdateSettingsFlowBody{
		UpdateSettingsFlowWithLookupMethod: v,
	}
}

// UpdateSettingsFlowWithOidcMethodAsUpdateSettingsFlowBody is a convenience function that returns UpdateSettingsFlowWithOidcMethod wrapped in UpdateSettingsFlowBody
func UpdateSettingsFlowWithOidcMethodAsUpdateSettingsFlowBody(v *UpdateSettingsFlowWithOidcMethod) UpdateSettingsFlowBody {
	return UpdateSettingsFlowBody{
		UpdateSettingsFlowWithOidcMethod: v,
	}
}

// UpdateSettingsFlowWithPasskeyMethodAsUpdateSettingsFlowBody is a convenience function that returns UpdateSettingsFlowWithPasskeyMethod wrapped in UpdateSettingsFlowBody
func UpdateSettingsFlowWithPasskeyMethodAsUpdateSettingsFlowBody(v *UpdateSettingsFlowWithPasskeyMethod) UpdateSettingsFlowBody {
	return UpdateSettingsFlowBody{
		UpdateSettingsFlowWithPasskeyMethod: v,
	}
}

// UpdateSettingsFlowWithPasswordMethodAsUpdateSettingsFlowBody is a convenience function that returns UpdateSettingsFlowWithPasswordMethod wrapped in UpdateSettingsFlowBody
func UpdateSettingsFlowWithPasswordMethodAsUpdateSettingsFlowBody(v *UpdateSettingsFlowWithPasswordMethod) UpdateSettingsFlowBody {
	return UpdateSettingsFlowBody{
		UpdateSettingsFlowWithPasswordMethod: v,
	}
}

// UpdateSettingsFlowWithProfileMethodAsUpdateSettingsFlowBody is a convenience function that returns UpdateSettingsFlowWithProfileMethod wrapped in UpdateSettingsFlowBody
func UpdateSettingsFlowWithProfileMethodAsUpdateSettingsFlowBody(v *UpdateSettingsFlowWithProfileMethod) UpdateSettingsFlowBody {
	return UpdateSettingsFlowBody{
		UpdateSettingsFlowWithProfileMethod: v,
	}
}

// UpdateSettingsFlowWithTotpMethodAsUpdateSettingsFlowBody is a convenience function that returns UpdateSettingsFlowWithTotpMethod wrapped in UpdateSettingsFlowBody
func UpdateSettingsFlowWithTotpMethodAsUpdateSettingsFlowBody(v *UpdateSettingsFlowWithTotpMethod) UpdateSettingsFlowBody {
	return UpdateSettingsFlowBody{
		UpdateSettingsFlowWithTotpMethod: v,
	}
}

// UpdateSettingsFlowWithWebAuthnMethodAsUpdateSettingsFlowBody is a convenience function that returns UpdateSettingsFlowWithWebAuthnMethod wrapped in UpdateSettingsFlowBody
func UpdateSettingsFlowWithWebAuthnMethodAsUpdateSettingsFlowBody(v *UpdateSettingsFlowWithWebAuthnMethod) UpdateSettingsFlowBody {
	return UpdateSettingsFlowBody{
		UpdateSettingsFlowWithWebAuthnMethod: v,
	}
}


// Unmarshal JSON data into one of the pointers in the struct
func (dst *UpdateSettingsFlowBody) UnmarshalJSON(data []byte) error {
	var err error
	// use discriminator value to speed up the lookup
	var jsonDict map[string]interface{}
	err = newStrictDecoder(data).Decode(&jsonDict)
	if err != nil {
		return fmt.Errorf("failed to unmarshal JSON into map for the discriminator lookup")
	}

	// check if the discriminator value is 'lookup_secret'
	if jsonDict["method"] == "lookup_secret" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithLookupMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithLookupMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithLookupMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithLookupMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithLookupMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'oidc'
	if jsonDict["method"] == "oidc" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithOidcMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithOidcMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithOidcMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithOidcMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithOidcMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'passkey'
	if jsonDict["method"] == "passkey" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithPasskeyMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithPasskeyMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithPasskeyMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithPasskeyMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithPasskeyMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'password'
	if jsonDict["method"] == "password" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithPasswordMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithPasswordMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithPasswordMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithPasswordMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithPasswordMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'profile'
	if jsonDict["method"] == "profile" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithProfileMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithProfileMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithProfileMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithProfileMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithProfileMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'totp'
	if jsonDict["method"] == "totp" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithTotpMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithTotpMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithTotpMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithTotpMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithTotpMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'webauthn'
	if jsonDict["method"] == "webauthn" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithWebAuthnMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithWebAuthnMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithWebAuthnMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithWebAuthnMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithWebAuthnMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateSettingsFlowWithLookupMethod'
	if jsonDict["method"] == "updateSettingsFlowWithLookupMethod" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithLookupMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithLookupMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithLookupMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithLookupMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithLookupMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateSettingsFlowWithOidcMethod'
	if jsonDict["method"] == "updateSettingsFlowWithOidcMethod" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithOidcMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithOidcMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithOidcMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithOidcMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithOidcMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateSettingsFlowWithPasskeyMethod'
	if jsonDict["method"] == "updateSettingsFlowWithPasskeyMethod" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithPasskeyMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithPasskeyMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithPasskeyMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithPasskeyMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithPasskeyMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateSettingsFlowWithPasswordMethod'
	if jsonDict["method"] == "updateSettingsFlowWithPasswordMethod" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithPasswordMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithPasswordMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithPasswordMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithPasswordMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithPasswordMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateSettingsFlowWithProfileMethod'
	if jsonDict["method"] == "updateSettingsFlowWithProfileMethod" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithProfileMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithProfileMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithProfileMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithProfileMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithProfileMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateSettingsFlowWithTotpMethod'
	if jsonDict["method"] == "updateSettingsFlowWithTotpMethod" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithTotpMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithTotpMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithTotpMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithTotpMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithTotpMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateSettingsFlowWithWebAuthnMethod'
	if jsonDict["method"] == "updateSettingsFlowWithWebAuthnMethod" {
		// try to unmarshal JSON data into UpdateSettingsFlowWithWebAuthnMethod
		err = json.Unmarshal(data, &dst.UpdateSettingsFlowWithWebAuthnMethod)
		if err == nil {
			return nil // data stored in dst.UpdateSettingsFlowWithWebAuthnMethod, return on the first match
		} else {
			dst.UpdateSettingsFlowWithWebAuthnMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateSettingsFlowBody as UpdateSettingsFlowWithWebAuthnMethod: %s", err.Error())
		}
	}

	return nil
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src UpdateSettingsFlowBody) MarshalJSON() ([]byte, error) {
	if src.UpdateSettingsFlowWithLookupMethod != nil {
		return json.Marshal(&src.UpdateSettingsFlowWithLookupMethod)
	}

	if src.UpdateSettingsFlowWithOidcMethod != nil {
		return json.Marshal(&src.UpdateSettingsFlowWithOidcMethod)
	}

	if src.UpdateSettingsFlowWithPasskeyMethod != nil {
		return json.Marshal(&src.UpdateSettingsFlowWithPasskeyMethod)
	}

	if src.UpdateSettingsFlowWithPasswordMethod != nil {
		return json.Marshal(&src.UpdateSettingsFlowWithPasswordMethod)
	}

	if src.UpdateSettingsFlowWithProfileMethod != nil {
		return json.Marshal(&src.UpdateSettingsFlowWithProfileMethod)
	}

	if src.UpdateSettingsFlowWithTotpMethod != nil {
		return json.Marshal(&src.UpdateSettingsFlowWithTotpMethod)
	}

	if src.UpdateSettingsFlowWithWebAuthnMethod != nil {
		return json.Marshal(&src.UpdateSettingsFlowWithWebAuthnMethod)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *UpdateSettingsFlowBody) GetActualInstance() (interface{}) {
	if obj == nil {
		return nil
	}
	if obj.UpdateSettingsFlowWithLookupMethod != nil {
		return obj.UpdateSettingsFlowWithLookupMethod
	}

	if obj.UpdateSettingsFlowWithOidcMethod != nil {
		return obj.UpdateSettingsFlowWithOidcMethod
	}

	if obj.UpdateSettingsFlowWithPasskeyMethod != nil {
		return obj.UpdateSettingsFlowWithPasskeyMethod
	}

	if obj.UpdateSettingsFlowWithPasswordMethod != nil {
		return obj.UpdateSettingsFlowWithPasswordMethod
	}

	if obj.UpdateSettingsFlowWithProfileMethod != nil {
		return obj.UpdateSettingsFlowWithProfileMethod
	}

	if obj.UpdateSettingsFlowWithTotpMethod != nil {
		return obj.UpdateSettingsFlowWithTotpMethod
	}

	if obj.UpdateSettingsFlowWithWebAuthnMethod != nil {
		return obj.UpdateSettingsFlowWithWebAuthnMethod
	}

	// all schemas are nil
	return nil
}

type NullableUpdateSettingsFlowBody struct {
	value *UpdateSettingsFlowBody
	isSet bool
}

func (v NullableUpdateSettingsFlowBody) Get() *UpdateSettingsFlowBody {
	return v.value
}

func (v *NullableUpdateSettingsFlowBody) Set(val *UpdateSettingsFlowBody) {
	v.value = val
	v.isSet = true
}

func (v NullableUpdateSettingsFlowBody) IsSet() bool {
	return v.isSet
}

func (v *NullableUpdateSettingsFlowBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUpdateSettingsFlowBody(val *UpdateSettingsFlowBody) *NullableUpdateSettingsFlowBody {
	return &NullableUpdateSettingsFlowBody{value: val, isSet: true}
}

func (v NullableUpdateSettingsFlowBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUpdateSettingsFlowBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


