/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6-alpha.2
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
import type { UiNode } from './UiNode';
import {
    UiNodeFromJSON,
    UiNodeFromJSONTyped,
    UiNodeToJSON,
} from './UiNode';

/**
 * Container represents a HTML Form. The container can work with both HTTP Form and JSON requests
 * @export
 * @interface UiContainer
 */
export interface UiContainer {
    /**
     * Action should be used as the form action URL `<form action="{{ .Action }}" method="post">`.
     * @type {string}
     * @memberof UiContainer
     */
    action: string;
    /**
     * 
     * @type {Array<UiText>}
     * @memberof UiContainer
     */
    messages?: Array<UiText>;
    /**
     * Method is the form method (e.g. POST)
     * @type {string}
     * @memberof UiContainer
     */
    method: string;
    /**
     * 
     * @type {Array<UiNode>}
     * @memberof UiContainer
     */
    nodes: Array<UiNode>;
}

/**
 * Check if a given object implements the UiContainer interface.
 */
export function instanceOfUiContainer(value: object): value is UiContainer {
    if (!('action' in value) || value['action'] === undefined) return false;
    if (!('method' in value) || value['method'] === undefined) return false;
    if (!('nodes' in value) || value['nodes'] === undefined) return false;
    return true;
}

export function UiContainerFromJSON(json: any): UiContainer {
    return UiContainerFromJSONTyped(json, false);
}

export function UiContainerFromJSONTyped(json: any, ignoreDiscriminator: boolean): UiContainer {
    if (json == null) {
        return json;
    }
    return {
        
        'action': json['action'],
        'messages': json['messages'] == null ? undefined : ((json['messages'] as Array<any>).map(UiTextFromJSON)),
        'method': json['method'],
        'nodes': ((json['nodes'] as Array<any>).map(UiNodeFromJSON)),
    };
}

export function UiContainerToJSON(value?: UiContainer | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'action': value['action'],
        'messages': value['messages'] == null ? undefined : ((value['messages'] as Array<any>).map(UiTextToJSON)),
        'method': value['method'],
        'nodes': ((value['nodes'] as Array<any>).map(UiNodeToJSON)),
    };
}

