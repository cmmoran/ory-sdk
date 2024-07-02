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
 * @interface SchemaPatch
 */
export interface SchemaPatch {
    /**
     * The json schema
     * @type {object}
     * @memberof SchemaPatch
     */
    data: object;
    /**
     * The user defined schema name
     * @type {string}
     * @memberof SchemaPatch
     */
    name: string;
}

/**
 * Check if a given object implements the SchemaPatch interface.
 */
export function instanceOfSchemaPatch(value: object): boolean {
    if (!('data' in value)) return false;
    if (!('name' in value)) return false;
    return true;
}

export function SchemaPatchFromJSON(json: any): SchemaPatch {
    return SchemaPatchFromJSONTyped(json, false);
}

export function SchemaPatchFromJSONTyped(json: any, ignoreDiscriminator: boolean): SchemaPatch {
    if (json == null) {
        return json;
    }
    return {
        
        'data': json['data'],
        'name': json['name'],
    };
}

export function SchemaPatchToJSON(value?: SchemaPatch | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'data': value['data'],
        'name': value['name'],
    };
}

