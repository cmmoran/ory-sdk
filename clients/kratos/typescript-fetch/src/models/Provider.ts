/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.7
 * Contact: office@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface Provider
 */
export interface Provider {
    /**
     * The RP's client identifier, issued by the IdP.
     * @type {string}
     * @memberof Provider
     */
    client_id?: string;
    /**
     * A full path of the IdP config file.
     * @type {string}
     * @memberof Provider
     */
    config_url?: string;
    /**
     * By specifying one of domain_hints values provided by the accounts endpoints,
     * the FedCM dialog selectively shows the specified account.
     * @type {string}
     * @memberof Provider
     */
    domain_hint?: string;
    /**
     * Array of strings that specifies the user information ("name", " email",
     * "picture") that RP needs IdP to share with them.
     * 
     * Note: Field API is supported by Chrome 132 and later.
     * @type {Array<string>}
     * @memberof Provider
     */
    fields?: Array<string>;
    /**
     * By specifying one of login_hints values provided by the accounts endpoints,
     * the FedCM dialog selectively shows the specified account.
     * @type {string}
     * @memberof Provider
     */
    login_hint?: string;
    /**
     * A random string to ensure the response is issued for this specific request.
     * Prevents replay attacks.
     * @type {string}
     * @memberof Provider
     */
    nonce?: string;
    /**
     * Custom object that allows to specify additional key-value parameters:
     * scope: A string value containing additional permissions that RP needs to
     * request, for example " drive.readonly calendar.readonly"
     * nonce: A random string to ensure the response is issued for this specific
     * request. Prevents replay attacks.
     * 
     * Other custom key-value parameters.
     * 
     * Note: parameters is supported from Chrome 132.
     * @type {{ [key: string]: string; }}
     * @memberof Provider
     */
    parameters?: { [key: string]: string; };
}

/**
 * Check if a given object implements the Provider interface.
 */
export function instanceOfProvider(value: object): value is Provider {
    return true;
}

export function ProviderFromJSON(json: any): Provider {
    return ProviderFromJSONTyped(json, false);
}

export function ProviderFromJSONTyped(json: any, ignoreDiscriminator: boolean): Provider {
    if (json == null) {
        return json;
    }
    return {
        
        'client_id': json['client_id'] == null ? undefined : json['client_id'],
        'config_url': json['config_url'] == null ? undefined : json['config_url'],
        'domain_hint': json['domain_hint'] == null ? undefined : json['domain_hint'],
        'fields': json['fields'] == null ? undefined : json['fields'],
        'login_hint': json['login_hint'] == null ? undefined : json['login_hint'],
        'nonce': json['nonce'] == null ? undefined : json['nonce'],
        'parameters': json['parameters'] == null ? undefined : json['parameters'],
    };
}

export function ProviderToJSON(value?: Provider | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'client_id': value['client_id'],
        'config_url': value['config_url'],
        'domain_hint': value['domain_hint'],
        'fields': value['fields'],
        'login_hint': value['login_hint'],
        'nonce': value['nonce'],
        'parameters': value['parameters'],
    };
}

