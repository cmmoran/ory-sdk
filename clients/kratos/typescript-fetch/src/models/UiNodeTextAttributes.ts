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
import type { UiText } from './UiText';
import {
    UiTextFromJSON,
    UiTextFromJSONTyped,
    UiTextToJSON,
} from './UiText';

/**
 * 
 * @export
 * @interface UiNodeTextAttributes
 */
export interface UiNodeTextAttributes {
    /**
     * A unique identifier
     * @type {string}
     * @memberof UiNodeTextAttributes
     */
    id: string;
    /**
     * NodeType represents this node's types. It is a mirror of `node.type` and
     * is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is "text".
     * text Text
     * input Input
     * img Image
     * a Anchor
     * script Script
     * @type {string}
     * @memberof UiNodeTextAttributes
     */
    node_type: UiNodeTextAttributesNodeTypeEnum;
    /**
     * 
     * @type {UiText}
     * @memberof UiNodeTextAttributes
     */
    text: UiText;
}


/**
 * @export
 */
export const UiNodeTextAttributesNodeTypeEnum = {
    Text: 'text',
    Input: 'input',
    Img: 'img',
    A: 'a',
    Script: 'script'
} as const;
export type UiNodeTextAttributesNodeTypeEnum = typeof UiNodeTextAttributesNodeTypeEnum[keyof typeof UiNodeTextAttributesNodeTypeEnum];


/**
 * Check if a given object implements the UiNodeTextAttributes interface.
 */
export function instanceOfUiNodeTextAttributes(value: object): value is UiNodeTextAttributes {
    if (!('id' in value) || value['id'] === undefined) return false;
    if (!('node_type' in value) || value['node_type'] === undefined) return false;
    if (!('text' in value) || value['text'] === undefined) return false;
    return true;
}

export function UiNodeTextAttributesFromJSON(json: any): UiNodeTextAttributes {
    return UiNodeTextAttributesFromJSONTyped(json, false);
}

export function UiNodeTextAttributesFromJSONTyped(json: any, ignoreDiscriminator: boolean): UiNodeTextAttributes {
    if (json == null) {
        return json;
    }
    return {
        
        'id': json['id'],
        'node_type': json['node_type'],
        'text': UiTextFromJSON(json['text']),
    };
}

export function UiNodeTextAttributesToJSON(value?: UiNodeTextAttributes | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'id': value['id'],
        'node_type': value['node_type'],
        'text': UiTextToJSON(value['text']),
    };
}

