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
import type { GenericError } from './GenericError';
import {
    GenericErrorFromJSON,
    GenericErrorFromJSONTyped,
    GenericErrorToJSON,
    GenericErrorToJSONTyped,
} from './GenericError';

/**
 * 
 * @export
 * @interface NeedsPrivilegedSessionError
 */
export interface NeedsPrivilegedSessionError {
    /**
     * 
     * @type {GenericError}
     * @memberof NeedsPrivilegedSessionError
     */
    error?: GenericError;
    /**
     * Points to where to redirect the user to next.
     * @type {string}
     * @memberof NeedsPrivilegedSessionError
     */
    redirect_browser_to: string;
}

/**
 * Check if a given object implements the NeedsPrivilegedSessionError interface.
 */
export function instanceOfNeedsPrivilegedSessionError(value: object): value is NeedsPrivilegedSessionError {
    if (!('redirect_browser_to' in value) || value['redirect_browser_to'] === undefined) return false;
    return true;
}

export function NeedsPrivilegedSessionErrorFromJSON(json: any): NeedsPrivilegedSessionError {
    return NeedsPrivilegedSessionErrorFromJSONTyped(json, false);
}

export function NeedsPrivilegedSessionErrorFromJSONTyped(json: any, ignoreDiscriminator: boolean): NeedsPrivilegedSessionError {
    if (json == null) {
        return json;
    }
    return {
        
        'error': json['error'] == null ? undefined : GenericErrorFromJSON(json['error']),
        'redirect_browser_to': json['redirect_browser_to'],
    };
}

export function NeedsPrivilegedSessionErrorToJSON(json: any): NeedsPrivilegedSessionError {
    return NeedsPrivilegedSessionErrorToJSONTyped(json, false);
}

export function NeedsPrivilegedSessionErrorToJSONTyped(value?: NeedsPrivilegedSessionError | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'error': GenericErrorToJSON(value['error']),
        'redirect_browser_to': value['redirect_browser_to'],
    };
}

