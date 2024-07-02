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
 * @interface EmailTemplateDataBody
 */
export interface EmailTemplateDataBody {
    /**
     * 
     * @type {string}
     * @memberof EmailTemplateDataBody
     */
    html: string;
    /**
     * 
     * @type {string}
     * @memberof EmailTemplateDataBody
     */
    plaintext: string;
}

/**
 * Check if a given object implements the EmailTemplateDataBody interface.
 */
export function instanceOfEmailTemplateDataBody(value: object): boolean {
    if (!('html' in value)) return false;
    if (!('plaintext' in value)) return false;
    return true;
}

export function EmailTemplateDataBodyFromJSON(json: any): EmailTemplateDataBody {
    return EmailTemplateDataBodyFromJSONTyped(json, false);
}

export function EmailTemplateDataBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): EmailTemplateDataBody {
    if (json == null) {
        return json;
    }
    return {
        
        'html': json['html'],
        'plaintext': json['plaintext'],
    };
}

export function EmailTemplateDataBodyToJSON(value?: EmailTemplateDataBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'html': value['html'],
        'plaintext': value['plaintext'],
    };
}

