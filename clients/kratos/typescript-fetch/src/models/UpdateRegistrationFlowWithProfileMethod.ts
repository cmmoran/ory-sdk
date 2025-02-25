/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.4
 * Contact: office@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * Update Registration Flow with Profile Method
 * @export
 * @interface UpdateRegistrationFlowWithProfileMethod
 */
export interface UpdateRegistrationFlowWithProfileMethod {
    /**
     * The Anti-CSRF Token
     * 
     * This token is only required when performing browser flows.
     * @type {string}
     * @memberof UpdateRegistrationFlowWithProfileMethod
     */
    csrf_token?: string;
    /**
     * Method
     * 
     * Should be set to profile when trying to update a profile.
     * @type {string}
     * @memberof UpdateRegistrationFlowWithProfileMethod
     */
    method: string;
    /**
     * Screen requests navigation to a previous screen.
     * 
     * This must be set to credential-selection to go back to the credential
     * selection screen.
     * credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential
     * previous RegistrationScreenPrevious
     * @type {string}
     * @memberof UpdateRegistrationFlowWithProfileMethod
     */
    screen?: UpdateRegistrationFlowWithProfileMethodScreenEnum;
    /**
     * Traits
     * 
     * The identity's traits.
     * @type {object}
     * @memberof UpdateRegistrationFlowWithProfileMethod
     */
    traits: object;
    /**
     * Transient data to pass along to any webhooks
     * @type {object}
     * @memberof UpdateRegistrationFlowWithProfileMethod
     */
    transient_payload?: object;
}


/**
 * @export
 */
export const UpdateRegistrationFlowWithProfileMethodScreenEnum = {
    CredentialSelection: 'credential-selection',
    Previous: 'previous'
} as const;
export type UpdateRegistrationFlowWithProfileMethodScreenEnum = typeof UpdateRegistrationFlowWithProfileMethodScreenEnum[keyof typeof UpdateRegistrationFlowWithProfileMethodScreenEnum];


/**
 * Check if a given object implements the UpdateRegistrationFlowWithProfileMethod interface.
 */
export function instanceOfUpdateRegistrationFlowWithProfileMethod(value: object): value is UpdateRegistrationFlowWithProfileMethod {
    if (!('method' in value) || value['method'] === undefined) return false;
    if (!('traits' in value) || value['traits'] === undefined) return false;
    return true;
}

export function UpdateRegistrationFlowWithProfileMethodFromJSON(json: any): UpdateRegistrationFlowWithProfileMethod {
    return UpdateRegistrationFlowWithProfileMethodFromJSONTyped(json, false);
}

export function UpdateRegistrationFlowWithProfileMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateRegistrationFlowWithProfileMethod {
    if (json == null) {
        return json;
    }
    return {
        
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'method': json['method'],
        'screen': json['screen'] == null ? undefined : json['screen'],
        'traits': json['traits'],
        'transient_payload': json['transient_payload'] == null ? undefined : json['transient_payload'],
    };
}

export function UpdateRegistrationFlowWithProfileMethodToJSON(value?: UpdateRegistrationFlowWithProfileMethod | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'csrf_token': value['csrf_token'],
        'method': value['method'],
        'screen': value['screen'],
        'traits': value['traits'],
        'transient_payload': value['transient_payload'],
    };
}

