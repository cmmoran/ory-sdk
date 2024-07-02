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
 * Update Event Stream Body
 * @export
 * @interface SetEventStreamBody
 */
export interface SetEventStreamBody {
    /**
     * The AWS IAM role ARN to assume when publishing to the SNS topic.
     * @type {string}
     * @memberof SetEventStreamBody
     */
    role_arn: string;
    /**
     * The AWS SNS topic ARN.
     * @type {string}
     * @memberof SetEventStreamBody
     */
    topic_arn: string;
    /**
     * The type of the event stream (AWS SNS, GCP Pub/Sub, etc).
     * @type {string}
     * @memberof SetEventStreamBody
     */
    type: SetEventStreamBodyTypeEnum;
}


/**
 * @export
 */
export const SetEventStreamBodyTypeEnum = {
    Sns: 'sns'
} as const;
export type SetEventStreamBodyTypeEnum = typeof SetEventStreamBodyTypeEnum[keyof typeof SetEventStreamBodyTypeEnum];


/**
 * Check if a given object implements the SetEventStreamBody interface.
 */
export function instanceOfSetEventStreamBody(value: object): boolean {
    if (!('role_arn' in value)) return false;
    if (!('topic_arn' in value)) return false;
    if (!('type' in value)) return false;
    return true;
}

export function SetEventStreamBodyFromJSON(json: any): SetEventStreamBody {
    return SetEventStreamBodyFromJSONTyped(json, false);
}

export function SetEventStreamBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): SetEventStreamBody {
    if (json == null) {
        return json;
    }
    return {
        
        'role_arn': json['role_arn'],
        'topic_arn': json['topic_arn'],
        'type': json['type'],
    };
}

export function SetEventStreamBodyToJSON(value?: SetEventStreamBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'role_arn': value['role_arn'],
        'topic_arn': value['topic_arn'],
        'type': value['type'],
    };
}

