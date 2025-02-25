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
 * A JSONPatch document as defined by RFC 6902
 * @export
 * @interface JsonPatch
 */
export interface JsonPatch {
    /**
     * This field is used together with operation "move" and uses JSON Pointer notation.
     * 
     * Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).
     * @type {string}
     * @memberof JsonPatch
     */
    from?: string;
    /**
     * The operation to be performed. One of "add", "remove", "replace", "move", "copy", or "test".
     * @type {string}
     * @memberof JsonPatch
     */
    op: string;
    /**
     * The path to the target path. Uses JSON pointer notation.
     * 
     * Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).
     * @type {string}
     * @memberof JsonPatch
     */
    path: string;
    /**
     * The value to be used within the operations.
     * 
     * Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).
     * @type {any}
     * @memberof JsonPatch
     */
    value?: any | null;
}

/**
 * Check if a given object implements the JsonPatch interface.
 */
export function instanceOfJsonPatch(value: object): value is JsonPatch {
    if (!('op' in value) || value['op'] === undefined) return false;
    if (!('path' in value) || value['path'] === undefined) return false;
    return true;
}

export function JsonPatchFromJSON(json: any): JsonPatch {
    return JsonPatchFromJSONTyped(json, false);
}

export function JsonPatchFromJSONTyped(json: any, ignoreDiscriminator: boolean): JsonPatch {
    if (json == null) {
        return json;
    }
    return {
        
        'from': json['from'] == null ? undefined : json['from'],
        'op': json['op'],
        'path': json['path'],
        'value': json['value'] == null ? undefined : json['value'],
    };
}

export function JsonPatchToJSON(value?: JsonPatch | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'from': value['from'],
        'op': value['op'],
        'path': value['path'],
        'value': value['value'],
    };
}

