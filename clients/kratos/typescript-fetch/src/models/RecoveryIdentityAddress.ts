/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6-alpha.2
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
 * @interface RecoveryIdentityAddress
 */
export interface RecoveryIdentityAddress {
    /**
     * CreatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof RecoveryIdentityAddress
     */
    created_at?: Date;
    /**
     * 
     * @type {string}
     * @memberof RecoveryIdentityAddress
     */
    id: string;
    /**
     * UpdatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof RecoveryIdentityAddress
     */
    updated_at?: Date;
    /**
     * 
     * @type {string}
     * @memberof RecoveryIdentityAddress
     */
    value: string;
    /**
     * 
     * @type {string}
     * @memberof RecoveryIdentityAddress
     */
    via: string;
}

/**
 * Check if a given object implements the RecoveryIdentityAddress interface.
 */
export function instanceOfRecoveryIdentityAddress(value: object): value is RecoveryIdentityAddress {
    if (!('id' in value) || value['id'] === undefined) return false;
    if (!('value' in value) || value['value'] === undefined) return false;
    if (!('via' in value) || value['via'] === undefined) return false;
    return true;
}

export function RecoveryIdentityAddressFromJSON(json: any): RecoveryIdentityAddress {
    return RecoveryIdentityAddressFromJSONTyped(json, false);
}

export function RecoveryIdentityAddressFromJSONTyped(json: any, ignoreDiscriminator: boolean): RecoveryIdentityAddress {
    if (json == null) {
        return json;
    }
    return {
        
        'created_at': json['created_at'] == null ? undefined : (new Date(json['created_at'])),
        'id': json['id'],
        'updated_at': json['updated_at'] == null ? undefined : (new Date(json['updated_at'])),
        'value': json['value'],
        'via': json['via'],
    };
}

export function RecoveryIdentityAddressToJSON(value?: RecoveryIdentityAddress | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'created_at': value['created_at'] == null ? undefined : ((value['created_at']).toISOString()),
        'id': value['id'],
        'updated_at': value['updated_at'] == null ? undefined : ((value['updated_at']).toISOString()),
        'value': value['value'],
        'via': value['via'],
    };
}

