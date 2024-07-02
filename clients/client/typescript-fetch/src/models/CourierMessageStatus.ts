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


/**
 * A Message's Status
 * @export
 */
export const CourierMessageStatus = {
    Queued: 'queued',
    Sent: 'sent',
    Processing: 'processing',
    Abandoned: 'abandoned'
} as const;
export type CourierMessageStatus = typeof CourierMessageStatus[keyof typeof CourierMessageStatus];


export function CourierMessageStatusFromJSON(json: any): CourierMessageStatus {
    return CourierMessageStatusFromJSONTyped(json, false);
}

export function CourierMessageStatusFromJSONTyped(json: any, ignoreDiscriminator: boolean): CourierMessageStatus {
    return json as CourierMessageStatus;
}

export function CourierMessageStatusToJSON(value?: CourierMessageStatus | null): any {
    return value as any;
}

