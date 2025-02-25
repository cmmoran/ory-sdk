/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6-alpha.1
 * Contact: office@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * Update Login Flow with Lookup Secret Method
 * @export
 * @interface UpdateLoginFlowWithLookupSecretMethod
 */
export interface UpdateLoginFlowWithLookupSecretMethod {
    /**
     * Sending the anti-csrf token is only required for browser login flows.
     * @type {string}
     * @memberof UpdateLoginFlowWithLookupSecretMethod
     */
    csrf_token?: string;
    /**
     * The lookup secret.
     * @type {string}
     * @memberof UpdateLoginFlowWithLookupSecretMethod
     */
    lookup_secret: string;
    /**
     * Method should be set to "lookup_secret" when logging in using the lookup_secret strategy.
     * @type {string}
     * @memberof UpdateLoginFlowWithLookupSecretMethod
     */
    method: string;
}

/**
 * Check if a given object implements the UpdateLoginFlowWithLookupSecretMethod interface.
 */
export function instanceOfUpdateLoginFlowWithLookupSecretMethod(value: object): value is UpdateLoginFlowWithLookupSecretMethod {
    if (!('lookup_secret' in value) || value['lookup_secret'] === undefined) return false;
    if (!('method' in value) || value['method'] === undefined) return false;
    return true;
}

export function UpdateLoginFlowWithLookupSecretMethodFromJSON(json: any): UpdateLoginFlowWithLookupSecretMethod {
    return UpdateLoginFlowWithLookupSecretMethodFromJSONTyped(json, false);
}

export function UpdateLoginFlowWithLookupSecretMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateLoginFlowWithLookupSecretMethod {
    if (json == null) {
        return json;
    }
    return {
        
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'lookup_secret': json['lookup_secret'],
        'method': json['method'],
    };
}

export function UpdateLoginFlowWithLookupSecretMethodToJSON(value?: UpdateLoginFlowWithLookupSecretMethod | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'csrf_token': value['csrf_token'],
        'lookup_secret': value['lookup_secret'],
        'method': value['method'],
    };
}

