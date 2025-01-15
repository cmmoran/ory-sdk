/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.1
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import type { UpdateSettingsFlowWithLookupMethod } from './UpdateSettingsFlowWithLookupMethod';
import {
    instanceOfUpdateSettingsFlowWithLookupMethod,
    UpdateSettingsFlowWithLookupMethodFromJSON,
    UpdateSettingsFlowWithLookupMethodFromJSONTyped,
    UpdateSettingsFlowWithLookupMethodToJSON,
} from './UpdateSettingsFlowWithLookupMethod';
import type { UpdateSettingsFlowWithOidcMethod } from './UpdateSettingsFlowWithOidcMethod';
import {
    instanceOfUpdateSettingsFlowWithOidcMethod,
    UpdateSettingsFlowWithOidcMethodFromJSON,
    UpdateSettingsFlowWithOidcMethodFromJSONTyped,
    UpdateSettingsFlowWithOidcMethodToJSON,
} from './UpdateSettingsFlowWithOidcMethod';
import type { UpdateSettingsFlowWithPasskeyMethod } from './UpdateSettingsFlowWithPasskeyMethod';
import {
    instanceOfUpdateSettingsFlowWithPasskeyMethod,
    UpdateSettingsFlowWithPasskeyMethodFromJSON,
    UpdateSettingsFlowWithPasskeyMethodFromJSONTyped,
    UpdateSettingsFlowWithPasskeyMethodToJSON,
} from './UpdateSettingsFlowWithPasskeyMethod';
import type { UpdateSettingsFlowWithPasswordMethod } from './UpdateSettingsFlowWithPasswordMethod';
import {
    instanceOfUpdateSettingsFlowWithPasswordMethod,
    UpdateSettingsFlowWithPasswordMethodFromJSON,
    UpdateSettingsFlowWithPasswordMethodFromJSONTyped,
    UpdateSettingsFlowWithPasswordMethodToJSON,
} from './UpdateSettingsFlowWithPasswordMethod';
import type { UpdateSettingsFlowWithProfileMethod } from './UpdateSettingsFlowWithProfileMethod';
import {
    instanceOfUpdateSettingsFlowWithProfileMethod,
    UpdateSettingsFlowWithProfileMethodFromJSON,
    UpdateSettingsFlowWithProfileMethodFromJSONTyped,
    UpdateSettingsFlowWithProfileMethodToJSON,
} from './UpdateSettingsFlowWithProfileMethod';
import type { UpdateSettingsFlowWithTotpMethod } from './UpdateSettingsFlowWithTotpMethod';
import {
    instanceOfUpdateSettingsFlowWithTotpMethod,
    UpdateSettingsFlowWithTotpMethodFromJSON,
    UpdateSettingsFlowWithTotpMethodFromJSONTyped,
    UpdateSettingsFlowWithTotpMethodToJSON,
} from './UpdateSettingsFlowWithTotpMethod';
import type { UpdateSettingsFlowWithWebAuthnMethod } from './UpdateSettingsFlowWithWebAuthnMethod';
import {
    instanceOfUpdateSettingsFlowWithWebAuthnMethod,
    UpdateSettingsFlowWithWebAuthnMethodFromJSON,
    UpdateSettingsFlowWithWebAuthnMethodFromJSONTyped,
    UpdateSettingsFlowWithWebAuthnMethodToJSON,
} from './UpdateSettingsFlowWithWebAuthnMethod';

/**
 * @type UpdateSettingsFlowBody
 * Update Settings Flow Request Body
 * @export
 */
export type UpdateSettingsFlowBody = { method: 'lookup_secret' } & UpdateSettingsFlowWithLookupMethod | { method: 'oidc' } & UpdateSettingsFlowWithOidcMethod | { method: 'passkey' } & UpdateSettingsFlowWithPasskeyMethod | { method: 'password' } & UpdateSettingsFlowWithPasswordMethod | { method: 'profile' } & UpdateSettingsFlowWithProfileMethod | { method: 'totp' } & UpdateSettingsFlowWithTotpMethod | { method: 'webauthn' } & UpdateSettingsFlowWithWebAuthnMethod;

export function UpdateSettingsFlowBodyFromJSON(json: any): UpdateSettingsFlowBody {
    return UpdateSettingsFlowBodyFromJSONTyped(json, false);
}

export function UpdateSettingsFlowBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateSettingsFlowBody {
    if (json == null) {
        return json;
    }
    switch (json['method']) {
        case 'lookup_secret':
            return Object.assign({}, UpdateSettingsFlowWithLookupMethodFromJSONTyped(json, true), { method: 'lookup_secret' } as const);
        case 'oidc':
            return Object.assign({}, UpdateSettingsFlowWithOidcMethodFromJSONTyped(json, true), { method: 'oidc' } as const);
        case 'passkey':
            return Object.assign({}, UpdateSettingsFlowWithPasskeyMethodFromJSONTyped(json, true), { method: 'passkey' } as const);
        case 'password':
            return Object.assign({}, UpdateSettingsFlowWithPasswordMethodFromJSONTyped(json, true), { method: 'password' } as const);
        case 'profile':
            return Object.assign({}, UpdateSettingsFlowWithProfileMethodFromJSONTyped(json, true), { method: 'profile' } as const);
        case 'totp':
            return Object.assign({}, UpdateSettingsFlowWithTotpMethodFromJSONTyped(json, true), { method: 'totp' } as const);
        case 'webauthn':
            return Object.assign({}, UpdateSettingsFlowWithWebAuthnMethodFromJSONTyped(json, true), { method: 'webauthn' } as const);
        default:
            throw new Error(`No variant of UpdateSettingsFlowBody exists with 'method=${json['method']}'`);
    }
}

export function UpdateSettingsFlowBodyToJSON(value?: UpdateSettingsFlowBody | null): any {
    if (value == null) {
        return value;
    }
    switch (value['method']) {
        case 'lookup_secret':
            return UpdateSettingsFlowWithLookupMethodToJSON(value);
        case 'oidc':
            return UpdateSettingsFlowWithOidcMethodToJSON(value);
        case 'passkey':
            return UpdateSettingsFlowWithPasskeyMethodToJSON(value);
        case 'password':
            return UpdateSettingsFlowWithPasswordMethodToJSON(value);
        case 'profile':
            return UpdateSettingsFlowWithProfileMethodToJSON(value);
        case 'totp':
            return UpdateSettingsFlowWithTotpMethodToJSON(value);
        case 'webauthn':
            return UpdateSettingsFlowWithWebAuthnMethodToJSON(value);
        default:
            throw new Error(`No variant of UpdateSettingsFlowBody exists with 'method=${value['method']}'`);
    }

}

