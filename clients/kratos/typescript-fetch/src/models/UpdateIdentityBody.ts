/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6
 * Contact: office@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { IdentityWithCredentials } from './IdentityWithCredentials';
import {
    IdentityWithCredentialsFromJSON,
    IdentityWithCredentialsFromJSONTyped,
    IdentityWithCredentialsToJSON,
} from './IdentityWithCredentials';

/**
 * Update Identity Body
 * @export
 * @interface UpdateIdentityBody
 */
export interface UpdateIdentityBody {
    /**
     * 
     * @type {IdentityWithCredentials}
     * @memberof UpdateIdentityBody
     */
    credentials?: IdentityWithCredentials;
    /**
     * Store metadata about the user which is only accessible through admin APIs such as `GET /admin/identities/<id>`.
     * @type {any}
     * @memberof UpdateIdentityBody
     */
    metadata_admin?: any | null;
    /**
     * Store metadata about the identity which the identity itself can see when calling for example the
     * session endpoint. Do not store sensitive information (e.g. credit score) about the identity in this field.
     * @type {any}
     * @memberof UpdateIdentityBody
     */
    metadata_public?: any | null;
    /**
     * SchemaID is the ID of the JSON Schema to be used for validating the identity's traits. If set
     * will update the Identity's SchemaID.
     * @type {string}
     * @memberof UpdateIdentityBody
     */
    schema_id: string;
    /**
     * State is the identity's state.
     * active StateActive
     * inactive StateInactive
     * @type {string}
     * @memberof UpdateIdentityBody
     */
    state: UpdateIdentityBodyStateEnum;
    /**
     * Traits represent an identity's traits. The identity is able to create, modify, and delete traits
     * in a self-service manner. The input will always be validated against the JSON Schema defined
     * in `schema_id`.
     * @type {object}
     * @memberof UpdateIdentityBody
     */
    traits: object;
}


/**
 * @export
 */
export const UpdateIdentityBodyStateEnum = {
    Active: 'active',
    Inactive: 'inactive'
} as const;
export type UpdateIdentityBodyStateEnum = typeof UpdateIdentityBodyStateEnum[keyof typeof UpdateIdentityBodyStateEnum];


/**
 * Check if a given object implements the UpdateIdentityBody interface.
 */
export function instanceOfUpdateIdentityBody(value: object): value is UpdateIdentityBody {
    if (!('schema_id' in value) || value['schema_id'] === undefined) return false;
    if (!('state' in value) || value['state'] === undefined) return false;
    if (!('traits' in value) || value['traits'] === undefined) return false;
    return true;
}

export function UpdateIdentityBodyFromJSON(json: any): UpdateIdentityBody {
    return UpdateIdentityBodyFromJSONTyped(json, false);
}

export function UpdateIdentityBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateIdentityBody {
    if (json == null) {
        return json;
    }
    return {
        
        'credentials': json['credentials'] == null ? undefined : IdentityWithCredentialsFromJSON(json['credentials']),
        'metadata_admin': json['metadata_admin'] == null ? undefined : json['metadata_admin'],
        'metadata_public': json['metadata_public'] == null ? undefined : json['metadata_public'],
        'schema_id': json['schema_id'],
        'state': json['state'],
        'traits': json['traits'],
    };
}

export function UpdateIdentityBodyToJSON(value?: UpdateIdentityBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'credentials': IdentityWithCredentialsToJSON(value['credentials']),
        'metadata_admin': value['metadata_admin'],
        'metadata_public': value['metadata_public'],
        'schema_id': value['schema_id'],
        'state': value['state'],
        'traits': value['traits'],
    };
}

