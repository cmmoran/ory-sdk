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
 * @interface IdentityCredentialsPassword
 */
export interface IdentityCredentialsPassword {
    /**
     * HashedPassword is a hash-representation of the password.
     * @type {string}
     * @memberof IdentityCredentialsPassword
     */
    hashed_password?: string;
}

/**
 * Check if a given object implements the IdentityCredentialsPassword interface.
 */
export function instanceOfIdentityCredentialsPassword(value: object): boolean {
    return true;
}

export function IdentityCredentialsPasswordFromJSON(json: any): IdentityCredentialsPassword {
    return IdentityCredentialsPasswordFromJSONTyped(json, false);
}

export function IdentityCredentialsPasswordFromJSONTyped(json: any, ignoreDiscriminator: boolean): IdentityCredentialsPassword {
    if (json == null) {
        return json;
    }
    return {
        
        'hashed_password': json['hashed_password'] == null ? undefined : json['hashed_password'],
    };
}

export function IdentityCredentialsPasswordToJSON(value?: IdentityCredentialsPassword | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'hashed_password': value['hashed_password'],
    };
}

