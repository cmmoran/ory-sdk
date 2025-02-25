/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6
 * Contact: office@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * Update Settings Flow with Profile Method
 * @export
 * @interface UpdateSettingsFlowWithProfileMethod
 */
export interface UpdateSettingsFlowWithProfileMethod {
    /**
     * The Anti-CSRF Token
     * 
     * This token is only required when performing browser flows.
     * @type {string}
     * @memberof UpdateSettingsFlowWithProfileMethod
     */
    csrf_token?: string;
    /**
     * Method
     * 
     * Should be set to profile when trying to update a profile.
     * @type {string}
     * @memberof UpdateSettingsFlowWithProfileMethod
     */
    method: string;
    /**
     * Traits
     * 
     * The identity's traits.
     * @type {object}
     * @memberof UpdateSettingsFlowWithProfileMethod
     */
    traits: object;
    /**
     * Transient data to pass along to any webhooks
     * @type {object}
     * @memberof UpdateSettingsFlowWithProfileMethod
     */
    transient_payload?: object;
}

/**
 * Check if a given object implements the UpdateSettingsFlowWithProfileMethod interface.
 */
export function instanceOfUpdateSettingsFlowWithProfileMethod(value: object): value is UpdateSettingsFlowWithProfileMethod {
    if (!('method' in value) || value['method'] === undefined) return false;
    if (!('traits' in value) || value['traits'] === undefined) return false;
    return true;
}

export function UpdateSettingsFlowWithProfileMethodFromJSON(json: any): UpdateSettingsFlowWithProfileMethod {
    return UpdateSettingsFlowWithProfileMethodFromJSONTyped(json, false);
}

export function UpdateSettingsFlowWithProfileMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateSettingsFlowWithProfileMethod {
    if (json == null) {
        return json;
    }
    return {
        
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'method': json['method'],
        'traits': json['traits'],
        'transient_payload': json['transient_payload'] == null ? undefined : json['transient_payload'],
    };
}

export function UpdateSettingsFlowWithProfileMethodToJSON(value?: UpdateSettingsFlowWithProfileMethod | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'csrf_token': value['csrf_token'],
        'method': value['method'],
        'traits': value['traits'],
        'transient_payload': value['transient_payload'],
    };
}

