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

import type { UiNodeAnchorAttributes } from './UiNodeAnchorAttributes';
import {
    instanceOfUiNodeAnchorAttributes,
    UiNodeAnchorAttributesFromJSON,
    UiNodeAnchorAttributesFromJSONTyped,
    UiNodeAnchorAttributesToJSON,
} from './UiNodeAnchorAttributes';
import type { UiNodeImageAttributes } from './UiNodeImageAttributes';
import {
    instanceOfUiNodeImageAttributes,
    UiNodeImageAttributesFromJSON,
    UiNodeImageAttributesFromJSONTyped,
    UiNodeImageAttributesToJSON,
} from './UiNodeImageAttributes';
import type { UiNodeInputAttributes } from './UiNodeInputAttributes';
import {
    instanceOfUiNodeInputAttributes,
    UiNodeInputAttributesFromJSON,
    UiNodeInputAttributesFromJSONTyped,
    UiNodeInputAttributesToJSON,
} from './UiNodeInputAttributes';
import type { UiNodeScriptAttributes } from './UiNodeScriptAttributes';
import {
    instanceOfUiNodeScriptAttributes,
    UiNodeScriptAttributesFromJSON,
    UiNodeScriptAttributesFromJSONTyped,
    UiNodeScriptAttributesToJSON,
} from './UiNodeScriptAttributes';
import type { UiNodeTextAttributes } from './UiNodeTextAttributes';
import {
    instanceOfUiNodeTextAttributes,
    UiNodeTextAttributesFromJSON,
    UiNodeTextAttributesFromJSONTyped,
    UiNodeTextAttributesToJSON,
} from './UiNodeTextAttributes';

/**
 * @type UiNodeAttributes
 * 
 * @export
 */
export type UiNodeAttributes = { node_type: 'a' } & UiNodeAnchorAttributes | { node_type: 'img' } & UiNodeImageAttributes | { node_type: 'input' } & UiNodeInputAttributes | { node_type: 'script' } & UiNodeScriptAttributes | { node_type: 'text' } & UiNodeTextAttributes;

export function UiNodeAttributesFromJSON(json: any): UiNodeAttributes {
    return UiNodeAttributesFromJSONTyped(json, false);
}

export function UiNodeAttributesFromJSONTyped(json: any, ignoreDiscriminator: boolean): UiNodeAttributes {
    if (json == null) {
        return json;
    }
    switch (json['node_type']) {
        case 'a':
            return Object.assign({}, UiNodeAnchorAttributesFromJSONTyped(json, true), { node_type: 'a' } as const);
        case 'img':
            return Object.assign({}, UiNodeImageAttributesFromJSONTyped(json, true), { node_type: 'img' } as const);
        case 'input':
            return Object.assign({}, UiNodeInputAttributesFromJSONTyped(json, true), { node_type: 'input' } as const);
        case 'script':
            return Object.assign({}, UiNodeScriptAttributesFromJSONTyped(json, true), { node_type: 'script' } as const);
        case 'text':
            return Object.assign({}, UiNodeTextAttributesFromJSONTyped(json, true), { node_type: 'text' } as const);
        default:
            throw new Error(`No variant of UiNodeAttributes exists with 'node_type=${json['node_type']}'`);
    }
}

export function UiNodeAttributesToJSON(json: any): any {
    return UiNodeAttributesToJSONTyped(json, false);
}

export function UiNodeAttributesToJSONTyped(value?: UiNodeAttributes | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }
    switch (value['node_type']) {
        case 'a':
            return Object.assign({}, UiNodeAnchorAttributesToJSON(value), { node_type: 'a' } as const);
        case 'img':
            return Object.assign({}, UiNodeImageAttributesToJSON(value), { node_type: 'img' } as const);
        case 'input':
            return Object.assign({}, UiNodeInputAttributesToJSON(value), { node_type: 'input' } as const);
        case 'script':
            return Object.assign({}, UiNodeScriptAttributesToJSON(value), { node_type: 'script' } as const);
        case 'text':
            return Object.assign({}, UiNodeTextAttributesToJSON(value), { node_type: 'text' } as const);
        default:
            throw new Error(`No variant of UiNodeAttributes exists with 'node_type=${value['node_type']}'`);
    }

}

