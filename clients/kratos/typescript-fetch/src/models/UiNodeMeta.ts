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
 * This might include a label and other information that can optionally
 * be used to render UIs.
 * @export
 * @interface UiNodeMeta
 */
export interface UiNodeMeta {
    /**
     * 
     * @type {UiText}
     * @memberof UiNodeMeta
     */
    label?: UiText;
}

/**
 * Check if a given object implements the UiNodeMeta interface.
 */
export function instanceOfUiNodeMeta(value: object): value is UiNodeMeta {
    return true;
}

export function UiNodeMetaFromJSON(json: any): UiNodeMeta {
    return UiNodeMetaFromJSONTyped(json, false);
}

export function UiNodeMetaFromJSONTyped(json: any, ignoreDiscriminator: boolean): UiNodeMeta {
    if (json == null) {
        return json;
    }
    return {
        
        'label': json['label'] == null ? undefined : UiTextFromJSON(json['label']),
    };
}

export function UiNodeMetaToJSON(value?: UiNodeMeta | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'label': UiTextToJSON(value['label']),
    };
}

