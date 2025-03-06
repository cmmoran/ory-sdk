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
 * 
 * @export
 * @interface TokenPaginationHeaders
 */
export interface TokenPaginationHeaders {
    /**
     * The link header contains pagination links.
     * 
     * For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
     * 
     * in: header
     * @type {string}
     * @memberof TokenPaginationHeaders
     */
    link?: string;
    /**
     * The total number of clients.
     * 
     * in: header
     * @type {string}
     * @memberof TokenPaginationHeaders
     */
    x_total_count?: string;
}

/**
 * Check if a given object implements the TokenPaginationHeaders interface.
 */
export function instanceOfTokenPaginationHeaders(value: object): value is TokenPaginationHeaders {
    return true;
}

export function TokenPaginationHeadersFromJSON(json: any): TokenPaginationHeaders {
    return TokenPaginationHeadersFromJSONTyped(json, false);
}

export function TokenPaginationHeadersFromJSONTyped(json: any, ignoreDiscriminator: boolean): TokenPaginationHeaders {
    if (json == null) {
        return json;
    }
    return {
        
        'link': json['link'] == null ? undefined : json['link'],
        'x_total_count': json['x-total-count'] == null ? undefined : json['x-total-count'],
    };
}

export function TokenPaginationHeadersToJSON(json: any): TokenPaginationHeaders {
    return TokenPaginationHeadersToJSONTyped(json, false);
}

export function TokenPaginationHeadersToJSONTyped(value?: TokenPaginationHeaders | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'link': value['link'],
        'x-total-count': value['x_total_count'],
    };
}

