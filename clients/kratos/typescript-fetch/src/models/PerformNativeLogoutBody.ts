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
 * Perform Native Logout Request Body
 * @export
 * @interface PerformNativeLogoutBody
 */
export interface PerformNativeLogoutBody {
    /**
     * The Session Token
     * 
     * Invalidate this session token.
     * @type {string}
     * @memberof PerformNativeLogoutBody
     */
    session_token: string;
}

/**
 * Check if a given object implements the PerformNativeLogoutBody interface.
 */
export function instanceOfPerformNativeLogoutBody(value: object): value is PerformNativeLogoutBody {
    if (!('session_token' in value) || value['session_token'] === undefined) return false;
    return true;
}

export function PerformNativeLogoutBodyFromJSON(json: any): PerformNativeLogoutBody {
    return PerformNativeLogoutBodyFromJSONTyped(json, false);
}

export function PerformNativeLogoutBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): PerformNativeLogoutBody {
    if (json == null) {
        return json;
    }
    return {
        
        'session_token': json['session_token'],
    };
}

export function PerformNativeLogoutBodyToJSON(json: any): PerformNativeLogoutBody {
    return PerformNativeLogoutBodyToJSONTyped(json, false);
}

export function PerformNativeLogoutBodyToJSONTyped(value?: PerformNativeLogoutBody | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'session_token': value['session_token'],
    };
}

