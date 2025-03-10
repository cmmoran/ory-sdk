/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.4.0-alpha.0
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
 * @interface ContinueWithVerificationUiFlow
 */
export interface ContinueWithVerificationUiFlow {
    /**
     * The ID of the verification flow
     * @type {string}
     * @memberof ContinueWithVerificationUiFlow
     */
    id: string;
    /**
     * The URL of the verification flow
     * 
     * If this value is set, redirect the user's browser to this URL. This value is typically unset for native clients / API flows.
     * @type {string}
     * @memberof ContinueWithVerificationUiFlow
     */
    url?: string;
    /**
     * The address that should be verified in this flow
     * @type {string}
     * @memberof ContinueWithVerificationUiFlow
     */
    verifiable_address: string;
}

/**
 * Check if a given object implements the ContinueWithVerificationUiFlow interface.
 */
export function instanceOfContinueWithVerificationUiFlow(value: object): value is ContinueWithVerificationUiFlow {
    if (!('id' in value) || value['id'] === undefined) return false;
    if (!('verifiable_address' in value) || value['verifiable_address'] === undefined) return false;
    return true;
}

export function ContinueWithVerificationUiFlowFromJSON(json: any): ContinueWithVerificationUiFlow {
    return ContinueWithVerificationUiFlowFromJSONTyped(json, false);
}

export function ContinueWithVerificationUiFlowFromJSONTyped(json: any, ignoreDiscriminator: boolean): ContinueWithVerificationUiFlow {
    if (json == null) {
        return json;
    }
    return {
        
        'id': json['id'],
        'url': json['url'] == null ? undefined : json['url'],
        'verifiable_address': json['verifiable_address'],
    };
}

export function ContinueWithVerificationUiFlowToJSON(json: any): ContinueWithVerificationUiFlow {
    return ContinueWithVerificationUiFlowToJSONTyped(json, false);
}

export function ContinueWithVerificationUiFlowToJSONTyped(value?: ContinueWithVerificationUiFlow | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'id': value['id'],
        'url': value['url'],
        'verifiable_address': value['verifiable_address'],
    };
}

