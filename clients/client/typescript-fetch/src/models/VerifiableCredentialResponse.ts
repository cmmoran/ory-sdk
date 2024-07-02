/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.2
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
 * @interface VerifiableCredentialResponse
 */
export interface VerifiableCredentialResponse {
    /**
     * 
     * @type {string}
     * @memberof VerifiableCredentialResponse
     */
    credential_draft_00?: string;
    /**
     * 
     * @type {string}
     * @memberof VerifiableCredentialResponse
     */
    format?: string;
}

/**
 * Check if a given object implements the VerifiableCredentialResponse interface.
 */
export function instanceOfVerifiableCredentialResponse(value: object): boolean {
    return true;
}

export function VerifiableCredentialResponseFromJSON(json: any): VerifiableCredentialResponse {
    return VerifiableCredentialResponseFromJSONTyped(json, false);
}

export function VerifiableCredentialResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): VerifiableCredentialResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'credential_draft_00': json['credential_draft_00'] == null ? undefined : json['credential_draft_00'],
        'format': json['format'] == null ? undefined : json['format'],
    };
}

export function VerifiableCredentialResponseToJSON(value?: VerifiableCredentialResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'credential_draft_00': value['credential_draft_00'],
        'format': value['format'],
    };
}

