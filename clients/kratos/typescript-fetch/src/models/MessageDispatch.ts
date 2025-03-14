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
 * MessageDispatch represents an attempt of sending a courier message
 * It contains the status of the attempt (failed or successful) and the error if any occured
 * @export
 * @interface MessageDispatch
 */
export interface MessageDispatch {
    /**
     * CreatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof MessageDispatch
     */
    created_at: Date;
    /**
     * 
     * @type {object}
     * @memberof MessageDispatch
     */
    error?: object;
    /**
     * The ID of this message dispatch
     * @type {string}
     * @memberof MessageDispatch
     */
    id: string;
    /**
     * The ID of the message being dispatched
     * @type {string}
     * @memberof MessageDispatch
     */
    message_id: string;
    /**
     * The status of this dispatch
     * Either "failed" or "success"
     * failed CourierMessageDispatchStatusFailed
     * success CourierMessageDispatchStatusSuccess
     * @type {string}
     * @memberof MessageDispatch
     */
    status: MessageDispatchStatusEnum;
    /**
     * UpdatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof MessageDispatch
     */
    updated_at: Date;
}


/**
 * @export
 */
export const MessageDispatchStatusEnum = {
    Failed: 'failed',
    Success: 'success',
    UnknownDefaultOpenApi: '11184809'
} as const;
export type MessageDispatchStatusEnum = typeof MessageDispatchStatusEnum[keyof typeof MessageDispatchStatusEnum];


/**
 * Check if a given object implements the MessageDispatch interface.
 */
export function instanceOfMessageDispatch(value: object): value is MessageDispatch {
    if (!('created_at' in value) || value['created_at'] === undefined) return false;
    if (!('id' in value) || value['id'] === undefined) return false;
    if (!('message_id' in value) || value['message_id'] === undefined) return false;
    if (!('status' in value) || value['status'] === undefined) return false;
    if (!('updated_at' in value) || value['updated_at'] === undefined) return false;
    return true;
}

export function MessageDispatchFromJSON(json: any): MessageDispatch {
    return MessageDispatchFromJSONTyped(json, false);
}

export function MessageDispatchFromJSONTyped(json: any, ignoreDiscriminator: boolean): MessageDispatch {
    if (json == null) {
        return json;
    }
    return {
        
        'created_at': (new Date(json['created_at'])),
        'error': json['error'] == null ? undefined : json['error'],
        'id': json['id'],
        'message_id': json['message_id'],
        'status': json['status'],
        'updated_at': (new Date(json['updated_at'])),
    };
}

export function MessageDispatchToJSON(json: any): MessageDispatch {
    return MessageDispatchToJSONTyped(json, false);
}

export function MessageDispatchToJSONTyped(value?: MessageDispatch | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'created_at': ((value['created_at']).toISOString()),
        'error': value['error'],
        'id': value['id'],
        'message_id': value['message_id'],
        'status': value['status'],
        'updated_at': ((value['updated_at']).toISOString()),
    };
}

