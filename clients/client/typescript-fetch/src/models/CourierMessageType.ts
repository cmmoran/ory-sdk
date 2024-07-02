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
 * It can either be `email` or `phone`
 * @export
 */
export const CourierMessageType = {
    Email: 'email',
    Phone: 'phone'
} as const;
export type CourierMessageType = typeof CourierMessageType[keyof typeof CourierMessageType];


export function CourierMessageTypeFromJSON(json: any): CourierMessageType {
    return CourierMessageTypeFromJSONTyped(json, false);
}

export function CourierMessageTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): CourierMessageType {
    return json as CourierMessageType;
}

export function CourierMessageTypeToJSON(value?: CourierMessageType | null): any {
    return value as any;
}

