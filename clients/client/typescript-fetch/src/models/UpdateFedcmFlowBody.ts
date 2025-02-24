/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.8
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface UpdateFedcmFlowBody
 */
export interface UpdateFedcmFlowBody {
    /**
     * CSRFToken is the anti-CSRF token.
     * @type {string}
     * @memberof UpdateFedcmFlowBody
     */
    csrf_token: string;
    /**
     * Nonce is the nonce that was used in the `navigator.credentials.get` call. If
     * specified, it must match the `nonce` claim in the token.
     * @type {string}
     * @memberof UpdateFedcmFlowBody
     */
    nonce?: string;
    /**
     * Token contains the result of `navigator.credentials.get`.
     * @type {string}
     * @memberof UpdateFedcmFlowBody
     */
    token: string;
}

/**
 * Check if a given object implements the UpdateFedcmFlowBody interface.
 */
export function instanceOfUpdateFedcmFlowBody(value: object): value is UpdateFedcmFlowBody {
    if (!('csrf_token' in value) || value['csrf_token'] === undefined) return false;
    if (!('token' in value) || value['token'] === undefined) return false;
    return true;
}

export function UpdateFedcmFlowBodyFromJSON(json: any): UpdateFedcmFlowBody {
    return UpdateFedcmFlowBodyFromJSONTyped(json, false);
}

export function UpdateFedcmFlowBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateFedcmFlowBody {
    if (json == null) {
        return json;
    }
    return {
        
        'csrf_token': json['csrf_token'],
        'nonce': json['nonce'] == null ? undefined : json['nonce'],
        'token': json['token'],
    };
}

export function UpdateFedcmFlowBodyToJSON(value?: UpdateFedcmFlowBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'csrf_token': value['csrf_token'],
        'nonce': value['nonce'],
        'token': value['token'],
    };
}

