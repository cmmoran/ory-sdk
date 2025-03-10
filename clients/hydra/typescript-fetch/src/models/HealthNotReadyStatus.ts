/* tslint:disable */
/* eslint-disable */
/**
 * Ory Hydra API
 * Documentation for all of Ory Hydra\'s APIs. 
 *
 * The version of the OpenAPI document: v2.4.0-alpha.1
 * Contact: hi@ory.sh
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

