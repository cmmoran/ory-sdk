/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.16.5
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// ContinueWith - struct for ContinueWith
type ContinueWith struct {
	ContinueWithRecoveryUi *ContinueWithRecoveryUi
	ContinueWithRedirectBrowserTo *ContinueWithRedirectBrowserTo
	ContinueWithSetOrySessionToken *ContinueWithSetOrySessionToken
	ContinueWithSettingsUi *ContinueWithSettingsUi
	ContinueWithVerificationUi *ContinueWithVerificationUi
}

// ContinueWithRecoveryUiAsContinueWith is a convenience function that returns ContinueWithRecoveryUi wrapped in ContinueWith
func ContinueWithRecoveryUiAsContinueWith(v *ContinueWithRecoveryUi) ContinueWith {
	return ContinueWith{
		ContinueWithRecoveryUi: v,
	}
}

// ContinueWithRedirectBrowserToAsContinueWith is a convenience function that returns ContinueWithRedirectBrowserTo wrapped in ContinueWith
func ContinueWithRedirectBrowserToAsContinueWith(v *ContinueWithRedirectBrowserTo) ContinueWith {
	return ContinueWith{
		ContinueWithRedirectBrowserTo: v,
	}
}

// ContinueWithSetOrySessionTokenAsContinueWith is a convenience function that returns ContinueWithSetOrySessionToken wrapped in ContinueWith
func ContinueWithSetOrySessionTokenAsContinueWith(v *ContinueWithSetOrySessionToken) ContinueWith {
	return ContinueWith{
		ContinueWithSetOrySessionToken: v,
	}
}

// ContinueWithSettingsUiAsContinueWith is a convenience function that returns ContinueWithSettingsUi wrapped in ContinueWith
func ContinueWithSettingsUiAsContinueWith(v *ContinueWithSettingsUi) ContinueWith {
	return ContinueWith{
		ContinueWithSettingsUi: v,
	}
}

// ContinueWithVerificationUiAsContinueWith is a convenience function that returns ContinueWithVerificationUi wrapped in ContinueWith
func ContinueWithVerificationUiAsContinueWith(v *ContinueWithVerificationUi) ContinueWith {
	return ContinueWith{
		ContinueWithVerificationUi: v,
	}
}


// Unmarshal JSON data into one of the pointers in the struct
func (dst *ContinueWith) UnmarshalJSON(data []byte) error {
	var err error
	// use discriminator value to speed up the lookup
	var jsonDict map[string]interface{}
	err = newStrictDecoder(data).Decode(&jsonDict)
	if err != nil {
		return fmt.Errorf("failed to unmarshal JSON into map for the discriminator lookup")
	}

	// check if the discriminator value is 'redirect_browser_to'
	if jsonDict["action"] == "redirect_browser_to" {
		// try to unmarshal JSON data into ContinueWithRedirectBrowserTo
		err = json.Unmarshal(data, &dst.ContinueWithRedirectBrowserTo)
		if err == nil {
			return nil // data stored in dst.ContinueWithRedirectBrowserTo, return on the first match
		} else {
			dst.ContinueWithRedirectBrowserTo = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithRedirectBrowserTo: %s", err.Error())
		}
	}

	// check if the discriminator value is 'set_ory_session_token'
	if jsonDict["action"] == "set_ory_session_token" {
		// try to unmarshal JSON data into ContinueWithSetOrySessionToken
		err = json.Unmarshal(data, &dst.ContinueWithSetOrySessionToken)
		if err == nil {
			return nil // data stored in dst.ContinueWithSetOrySessionToken, return on the first match
		} else {
			dst.ContinueWithSetOrySessionToken = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithSetOrySessionToken: %s", err.Error())
		}
	}

	// check if the discriminator value is 'show_recovery_ui'
	if jsonDict["action"] == "show_recovery_ui" {
		// try to unmarshal JSON data into ContinueWithRecoveryUi
		err = json.Unmarshal(data, &dst.ContinueWithRecoveryUi)
		if err == nil {
			return nil // data stored in dst.ContinueWithRecoveryUi, return on the first match
		} else {
			dst.ContinueWithRecoveryUi = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithRecoveryUi: %s", err.Error())
		}
	}

	// check if the discriminator value is 'show_settings_ui'
	if jsonDict["action"] == "show_settings_ui" {
		// try to unmarshal JSON data into ContinueWithSettingsUi
		err = json.Unmarshal(data, &dst.ContinueWithSettingsUi)
		if err == nil {
			return nil // data stored in dst.ContinueWithSettingsUi, return on the first match
		} else {
			dst.ContinueWithSettingsUi = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithSettingsUi: %s", err.Error())
		}
	}

	// check if the discriminator value is 'show_verification_ui'
	if jsonDict["action"] == "show_verification_ui" {
		// try to unmarshal JSON data into ContinueWithVerificationUi
		err = json.Unmarshal(data, &dst.ContinueWithVerificationUi)
		if err == nil {
			return nil // data stored in dst.ContinueWithVerificationUi, return on the first match
		} else {
			dst.ContinueWithVerificationUi = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithVerificationUi: %s", err.Error())
		}
	}

	// check if the discriminator value is 'continueWithRecoveryUi'
	if jsonDict["action"] == "continueWithRecoveryUi" {
		// try to unmarshal JSON data into ContinueWithRecoveryUi
		err = json.Unmarshal(data, &dst.ContinueWithRecoveryUi)
		if err == nil {
			return nil // data stored in dst.ContinueWithRecoveryUi, return on the first match
		} else {
			dst.ContinueWithRecoveryUi = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithRecoveryUi: %s", err.Error())
		}
	}

	// check if the discriminator value is 'continueWithRedirectBrowserTo'
	if jsonDict["action"] == "continueWithRedirectBrowserTo" {
		// try to unmarshal JSON data into ContinueWithRedirectBrowserTo
		err = json.Unmarshal(data, &dst.ContinueWithRedirectBrowserTo)
		if err == nil {
			return nil // data stored in dst.ContinueWithRedirectBrowserTo, return on the first match
		} else {
			dst.ContinueWithRedirectBrowserTo = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithRedirectBrowserTo: %s", err.Error())
		}
	}

	// check if the discriminator value is 'continueWithSetOrySessionToken'
	if jsonDict["action"] == "continueWithSetOrySessionToken" {
		// try to unmarshal JSON data into ContinueWithSetOrySessionToken
		err = json.Unmarshal(data, &dst.ContinueWithSetOrySessionToken)
		if err == nil {
			return nil // data stored in dst.ContinueWithSetOrySessionToken, return on the first match
		} else {
			dst.ContinueWithSetOrySessionToken = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithSetOrySessionToken: %s", err.Error())
		}
	}

	// check if the discriminator value is 'continueWithSettingsUi'
	if jsonDict["action"] == "continueWithSettingsUi" {
		// try to unmarshal JSON data into ContinueWithSettingsUi
		err = json.Unmarshal(data, &dst.ContinueWithSettingsUi)
		if err == nil {
			return nil // data stored in dst.ContinueWithSettingsUi, return on the first match
		} else {
			dst.ContinueWithSettingsUi = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithSettingsUi: %s", err.Error())
		}
	}

	// check if the discriminator value is 'continueWithVerificationUi'
	if jsonDict["action"] == "continueWithVerificationUi" {
		// try to unmarshal JSON data into ContinueWithVerificationUi
		err = json.Unmarshal(data, &dst.ContinueWithVerificationUi)
		if err == nil {
			return nil // data stored in dst.ContinueWithVerificationUi, return on the first match
		} else {
			dst.ContinueWithVerificationUi = nil
			return fmt.Errorf("failed to unmarshal ContinueWith as ContinueWithVerificationUi: %s", err.Error())
		}
	}

	return nil
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src ContinueWith) MarshalJSON() ([]byte, error) {
	if src.ContinueWithRecoveryUi != nil {
		return json.Marshal(&src.ContinueWithRecoveryUi)
	}

	if src.ContinueWithRedirectBrowserTo != nil {
		return json.Marshal(&src.ContinueWithRedirectBrowserTo)
	}

	if src.ContinueWithSetOrySessionToken != nil {
		return json.Marshal(&src.ContinueWithSetOrySessionToken)
	}

	if src.ContinueWithSettingsUi != nil {
		return json.Marshal(&src.ContinueWithSettingsUi)
	}

	if src.ContinueWithVerificationUi != nil {
		return json.Marshal(&src.ContinueWithVerificationUi)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *ContinueWith) GetActualInstance() (interface{}) {
	if obj == nil {
		return nil
	}
	if obj.ContinueWithRecoveryUi != nil {
		return obj.ContinueWithRecoveryUi
	}

	if obj.ContinueWithRedirectBrowserTo != nil {
		return obj.ContinueWithRedirectBrowserTo
	}

	if obj.ContinueWithSetOrySessionToken != nil {
		return obj.ContinueWithSetOrySessionToken
	}

	if obj.ContinueWithSettingsUi != nil {
		return obj.ContinueWithSettingsUi
	}

	if obj.ContinueWithVerificationUi != nil {
		return obj.ContinueWithVerificationUi
	}

	// all schemas are nil
	return nil
}

type NullableContinueWith struct {
	value *ContinueWith
	isSet bool
}

func (v NullableContinueWith) Get() *ContinueWith {
	return v.value
}

func (v *NullableContinueWith) Set(val *ContinueWith) {
	v.value = val
	v.isSet = true
}

func (v NullableContinueWith) IsSet() bool {
	return v.isSet
}

func (v *NullableContinueWith) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableContinueWith(val *ContinueWith) *NullableContinueWith {
	return &NullableContinueWith{value: val, isSet: true}
}

func (v NullableContinueWith) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableContinueWith) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


