/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.7
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
 * @interface HealthNotReadyStatus
 */
export interface HealthNotReadyStatus {
    /**
     * Errors contains a list of errors that caused the not ready status.
     * @type {{ [key: string]: string; }}
     * @memberof HealthNotReadyStatus
     */
    errors?: { [key: string]: string; };
}

/**
 * Check if a given object implements the HealthNotReadyStatus interface.
 */
export function instanceOfHealthNotReadyStatus(value: object): value is HealthNotReadyStatus {
    return true;
}

export function HealthNotReadyStatusFromJSON(json: any): HealthNotReadyStatus {
    return HealthNotReadyStatusFromJSONTyped(json, false);
}

export function HealthNotReadyStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): HealthNotReadyStatus {
    if (json == null) {
        return json;
    }
    return {
        
        'errors': json['errors'] == null ? undefined : json['errors'],
    };
}

export function HealthNotReadyStatusToJSON(value?: HealthNotReadyStatus | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'errors': value['errors'],
    };
}

