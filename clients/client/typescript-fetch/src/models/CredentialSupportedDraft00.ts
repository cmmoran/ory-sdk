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
 * Includes information about the supported verifiable credentials.
 * @export
 * @interface CredentialSupportedDraft00
 */
export interface CredentialSupportedDraft00 {
    /**
     * OpenID Connect Verifiable Credentials Cryptographic Binding Methods Supported
     * 
     * Contains a list of cryptographic binding methods supported for signing the proof.
     * @type {Array<string>}
     * @memberof CredentialSupportedDraft00
     */
    cryptographic_binding_methods_supported?: Array<string>;
    /**
     * OpenID Connect Verifiable Credentials Cryptographic Suites Supported
     * 
     * Contains a list of cryptographic suites methods supported for signing the proof.
     * @type {Array<string>}
     * @memberof CredentialSupportedDraft00
     */
    cryptographic_suites_supported?: Array<string>;
    /**
     * OpenID Connect Verifiable Credentials Format
     * 
     * Contains the format that is supported by this authorization server.
     * @type {string}
     * @memberof CredentialSupportedDraft00
     */
    format?: string;
    /**
     * OpenID Connect Verifiable Credentials Types
     * 
     * Contains the types of verifiable credentials supported.
     * @type {Array<string>}
     * @memberof CredentialSupportedDraft00
     */
    types?: Array<string>;
}

/**
 * Check if a given object implements the CredentialSupportedDraft00 interface.
 */
export function instanceOfCredentialSupportedDraft00(value: object): value is CredentialSupportedDraft00 {
    return true;
}

export function CredentialSupportedDraft00FromJSON(json: any): CredentialSupportedDraft00 {
    return CredentialSupportedDraft00FromJSONTyped(json, false);
}

export function CredentialSupportedDraft00FromJSONTyped(json: any, ignoreDiscriminator: boolean): CredentialSupportedDraft00 {
    if (json == null) {
        return json;
    }
    return {
        
        'cryptographic_binding_methods_supported': json['cryptographic_binding_methods_supported'] == null ? undefined : json['cryptographic_binding_methods_supported'],
        'cryptographic_suites_supported': json['cryptographic_suites_supported'] == null ? undefined : json['cryptographic_suites_supported'],
        'format': json['format'] == null ? undefined : json['format'],
        'types': json['types'] == null ? undefined : json['types'],
    };
}

export function CredentialSupportedDraft00ToJSON(value?: CredentialSupportedDraft00 | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'cryptographic_binding_methods_supported': value['cryptographic_binding_methods_supported'],
        'cryptographic_suites_supported': value['cryptographic_suites_supported'],
        'format': value['format'],
        'types': value['types'],
    };
}

