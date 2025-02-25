/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6
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
} from './GenericError';

/**
 * Is sent when a flow is replaced by a different flow of the same class
 * @export
 * @interface ErrorFlowReplaced
 */
export interface ErrorFlowReplaced {
    /**
     * 
     * @type {GenericError}
     * @memberof ErrorFlowReplaced
     */
    error?: GenericError;
    /**
     * The flow ID that should be used for the new flow as it contains the correct messages.
     * @type {string}
     * @memberof ErrorFlowReplaced
     */
    use_flow_id?: string;
}

/**
 * Check if a given object implements the ErrorFlowReplaced interface.
 */
export function instanceOfErrorFlowReplaced(value: object): value is ErrorFlowReplaced {
    return true;
}

export function ErrorFlowReplacedFromJSON(json: any): ErrorFlowReplaced {
    return ErrorFlowReplacedFromJSONTyped(json, false);
}

export function ErrorFlowReplacedFromJSONTyped(json: any, ignoreDiscriminator: boolean): ErrorFlowReplaced {
    if (json == null) {
        return json;
    }
    return {
        
        'error': json['error'] == null ? undefined : GenericErrorFromJSON(json['error']),
        'use_flow_id': json['use_flow_id'] == null ? undefined : json['use_flow_id'],
    };
}

export function ErrorFlowReplacedToJSON(value?: ErrorFlowReplaced | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'error': GenericErrorToJSON(value['error']),
        'use_flow_id': value['use_flow_id'],
    };
}

