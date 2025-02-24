/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.9
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { OAuth2ConsentRequestOpenIDConnectContext } from './OAuth2ConsentRequestOpenIDConnectContext';
import {
    OAuth2ConsentRequestOpenIDConnectContextFromJSON,
    OAuth2ConsentRequestOpenIDConnectContextFromJSONTyped,
    OAuth2ConsentRequestOpenIDConnectContextToJSON,
} from './OAuth2ConsentRequestOpenIDConnectContext';
import type { OAuth2Client } from './OAuth2Client';
import {
    OAuth2ClientFromJSON,
    OAuth2ClientFromJSONTyped,
    OAuth2ClientToJSON,
} from './OAuth2Client';

/**
 * 
 * @export
 * @interface OAuth2ConsentRequest
 */
export interface OAuth2ConsentRequest {
    /**
     * ACR represents the Authentication AuthorizationContext Class Reference value for this authentication session. You can use it
     * to express that, for example, a user authenticated using two factor authentication.
     * @type {string}
     * @memberof OAuth2ConsentRequest
     */
    acr?: string;
    /**
     * 
     * @type {Array<string>}
     * @memberof OAuth2ConsentRequest
     */
    amr?: Array<string>;
    /**
     * Challenge is used to retrieve/accept/deny the consent request.
     * @type {string}
     * @memberof OAuth2ConsentRequest
     */
    challenge: string;
    /**
     * 
     * @type {OAuth2Client}
     * @memberof OAuth2ConsentRequest
     */
    client?: OAuth2Client;
    /**
     * ConsentRequestID is the ID of the consent request.
     * @type {string}
     * @memberof OAuth2ConsentRequest
     */
    consent_request_id?: string;
    /**
     * 
     * @type {object}
     * @memberof OAuth2ConsentRequest
     */
    context?: object;
    /**
     * LoginChallenge is the login challenge this consent challenge belongs to. It can be used to associate
     * a login and consent request in the login & consent app.
     * @type {string}
     * @memberof OAuth2ConsentRequest
     */
    login_challenge?: string;
    /**
     * LoginSessionID is the login session ID. If the user-agent reuses a login session (via cookie / remember flag)
     * this ID will remain the same. If the user-agent did not have an existing authentication session (e.g. remember is false)
     * this will be a new random value. This value is used as the "sid" parameter in the ID Token and in OIDC Front-/Back-
     * channel logout. It's value can generally be used to associate consecutive login requests by a certain user.
     * @type {string}
     * @memberof OAuth2ConsentRequest
     */
    login_session_id?: string;
    /**
     * 
     * @type {OAuth2ConsentRequestOpenIDConnectContext}
     * @memberof OAuth2ConsentRequest
     */
    oidc_context?: OAuth2ConsentRequestOpenIDConnectContext;
    /**
     * RequestURL is the original OAuth 2.0 Authorization URL requested by the OAuth 2.0 client. It is the URL which
     * initiates the OAuth 2.0 Authorization Code or OAuth 2.0 Implicit flow. This URL is typically not needed, but
     * might come in handy if you want to deal with additional request parameters.
     * @type {string}
     * @memberof OAuth2ConsentRequest
     */
    request_url?: string;
    /**
     * 
     * @type {Array<string>}
     * @memberof OAuth2ConsentRequest
     */
    requested_access_token_audience?: Array<string>;
    /**
     * 
     * @type {Array<string>}
     * @memberof OAuth2ConsentRequest
     */
    requested_scope?: Array<string>;
    /**
     * Skip, if true, implies that the client has requested the same scopes from the same user previously.
     * If true, you must not ask the user to grant the requested scopes. You must however either allow or deny the
     * consent request using the usual API call.
     * @type {boolean}
     * @memberof OAuth2ConsentRequest
     */
    skip?: boolean;
    /**
     * Subject is the user ID of the end-user that authenticated. Now, that end user needs to grant or deny the scope
     * requested by the OAuth 2.0 client.
     * @type {string}
     * @memberof OAuth2ConsentRequest
     */
    subject?: string;
}

/**
 * Check if a given object implements the OAuth2ConsentRequest interface.
 */
export function instanceOfOAuth2ConsentRequest(value: object): value is OAuth2ConsentRequest {
    if (!('challenge' in value) || value['challenge'] === undefined) return false;
    return true;
}

export function OAuth2ConsentRequestFromJSON(json: any): OAuth2ConsentRequest {
    return OAuth2ConsentRequestFromJSONTyped(json, false);
}

export function OAuth2ConsentRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): OAuth2ConsentRequest {
    if (json == null) {
        return json;
    }
    return {
        
        'acr': json['acr'] == null ? undefined : json['acr'],
        'amr': json['amr'] == null ? undefined : json['amr'],
        'challenge': json['challenge'],
        'client': json['client'] == null ? undefined : OAuth2ClientFromJSON(json['client']),
        'consent_request_id': json['consent_request_id'] == null ? undefined : json['consent_request_id'],
        'context': json['context'] == null ? undefined : json['context'],
        'login_challenge': json['login_challenge'] == null ? undefined : json['login_challenge'],
        'login_session_id': json['login_session_id'] == null ? undefined : json['login_session_id'],
        'oidc_context': json['oidc_context'] == null ? undefined : OAuth2ConsentRequestOpenIDConnectContextFromJSON(json['oidc_context']),
        'request_url': json['request_url'] == null ? undefined : json['request_url'],
        'requested_access_token_audience': json['requested_access_token_audience'] == null ? undefined : json['requested_access_token_audience'],
        'requested_scope': json['requested_scope'] == null ? undefined : json['requested_scope'],
        'skip': json['skip'] == null ? undefined : json['skip'],
        'subject': json['subject'] == null ? undefined : json['subject'],
    };
}

export function OAuth2ConsentRequestToJSON(value?: OAuth2ConsentRequest | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'acr': value['acr'],
        'amr': value['amr'],
        'challenge': value['challenge'],
        'client': OAuth2ClientToJSON(value['client']),
        'consent_request_id': value['consent_request_id'],
        'context': value['context'],
        'login_challenge': value['login_challenge'],
        'login_session_id': value['login_session_id'],
        'oidc_context': OAuth2ConsentRequestOpenIDConnectContextToJSON(value['oidc_context']),
        'request_url': value['request_url'],
        'requested_access_token_audience': value['requested_access_token_audience'],
        'requested_scope': value['requested_scope'],
        'skip': value['skip'],
        'subject': value['subject'],
    };
}

