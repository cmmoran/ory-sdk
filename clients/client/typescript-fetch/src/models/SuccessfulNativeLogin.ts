/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.5
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { ContinueWith } from './ContinueWith';
import {
    ContinueWithFromJSON,
    ContinueWithFromJSONTyped,
    ContinueWithToJSON,
} from './ContinueWith';
import type { Session } from './Session';
import {
    SessionFromJSON,
    SessionFromJSONTyped,
    SessionToJSON,
} from './Session';

/**
 * The Response for Login Flows via API
 * @export
 * @interface SuccessfulNativeLogin
 */
export interface SuccessfulNativeLogin {
    /**
     * Contains a list of actions, that could follow this flow
     * 
     * It can, for example, this will contain a reference to the verification flow, created as part of the user's
     * registration or the token of the session.
     * @type {Array<ContinueWith>}
     * @memberof SuccessfulNativeLogin
     */
    continue_with?: Array<ContinueWith>;
    /**
     * 
     * @type {Session}
     * @memberof SuccessfulNativeLogin
     */
    session: Session;
    /**
     * The Session Token
     * 
     * A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization
     * Header:
     * 
     * Authorization: bearer ${session-token}
     * 
     * The session token is only issued for API flows, not for Browser flows!
     * @type {string}
     * @memberof SuccessfulNativeLogin
     */
    session_token?: string;
}

/**
 * Check if a given object implements the SuccessfulNativeLogin interface.
 */
export function instanceOfSuccessfulNativeLogin(value: object): value is SuccessfulNativeLogin {
    if (!('session' in value) || value['session'] === undefined) return false;
    return true;
}

export function SuccessfulNativeLoginFromJSON(json: any): SuccessfulNativeLogin {
    return SuccessfulNativeLoginFromJSONTyped(json, false);
}

export function SuccessfulNativeLoginFromJSONTyped(json: any, ignoreDiscriminator: boolean): SuccessfulNativeLogin {
    if (json == null) {
        return json;
    }
    return {
        
        'continue_with': json['continue_with'] == null ? undefined : ((json['continue_with'] as Array<any>).map(ContinueWithFromJSON)),
        'session': SessionFromJSON(json['session']),
        'session_token': json['session_token'] == null ? undefined : json['session_token'],
    };
}

export function SuccessfulNativeLoginToJSON(value?: SuccessfulNativeLogin | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'continue_with': value['continue_with'] == null ? undefined : ((value['continue_with'] as Array<any>).map(ContinueWithToJSON)),
        'session': SessionToJSON(value['session']),
        'session_token': value['session_token'],
    };
}

