/* tslint:disable */
/* eslint-disable */
/**
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6-alpha.1
 * Contact: office@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { VerifiableIdentityAddress } from './VerifiableIdentityAddress';
import {
    VerifiableIdentityAddressFromJSON,
    VerifiableIdentityAddressFromJSONTyped,
    VerifiableIdentityAddressToJSON,
} from './VerifiableIdentityAddress';
import type { RecoveryIdentityAddress } from './RecoveryIdentityAddress';
import {
    RecoveryIdentityAddressFromJSON,
    RecoveryIdentityAddressFromJSONTyped,
    RecoveryIdentityAddressToJSON,
} from './RecoveryIdentityAddress';
import type { IdentityCredentials } from './IdentityCredentials';
import {
    IdentityCredentialsFromJSON,
    IdentityCredentialsFromJSONTyped,
    IdentityCredentialsToJSON,
} from './IdentityCredentials';

/**
 * An [identity](https://www.ory.sh/docs/kratos/concepts/identity-user-model) represents a (human) user in Ory.
 * @export
 * @interface Identity
 */
export interface Identity {
    /**
     * CreatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof Identity
     */
    created_at?: Date;
    /**
     * Credentials represents all credentials that can be used for authenticating this identity.
     * @type {{ [key: string]: IdentityCredentials; }}
     * @memberof Identity
     */
    credentials?: { [key: string]: IdentityCredentials; };
    /**
     * ID is the identity's unique identifier.
     * 
     * The Identity ID can not be changed and can not be chosen. This ensures future
     * compatibility and optimization for distributed stores such as CockroachDB.
     * @type {string}
     * @memberof Identity
     */
    id: string;
    /**
     * NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-
     * @type {any}
     * @memberof Identity
     */
    metadata_admin?: any | null;
    /**
     * NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-
     * @type {any}
     * @memberof Identity
     */
    metadata_public?: any | null;
    /**
     * 
     * @type {string}
     * @memberof Identity
     */
    organization_id?: string | null;
    /**
     * RecoveryAddresses contains all the addresses that can be used to recover an identity.
     * @type {Array<RecoveryIdentityAddress>}
     * @memberof Identity
     */
    recovery_addresses?: Array<RecoveryIdentityAddress>;
    /**
     * SchemaID is the ID of the JSON Schema to be used for validating the identity's traits.
     * @type {string}
     * @memberof Identity
     */
    schema_id: string;
    /**
     * SchemaURL is the URL of the endpoint where the identity's traits schema can be fetched from.
     * 
     * format: url
     * @type {string}
     * @memberof Identity
     */
    schema_url: string;
    /**
     * State is the identity's state.
     * 
     * This value has currently no effect.
     * active StateActive
     * inactive StateInactive
     * @type {string}
     * @memberof Identity
     */
    state?: IdentityStateEnum;
    /**
     * 
     * @type {Date}
     * @memberof Identity
     */
    state_changed_at?: Date;
    /**
     * Traits represent an identity's traits. The identity is able to create, modify, and delete traits
     * in a self-service manner. The input will always be validated against the JSON Schema defined
     * in `schema_url`.
     * @type {any}
     * @memberof Identity
     */
    traits: any | null;
    /**
     * UpdatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof Identity
     */
    updated_at?: Date;
    /**
     * VerifiableAddresses contains all the addresses that can be verified by the user.
     * @type {Array<VerifiableIdentityAddress>}
     * @memberof Identity
     */
    verifiable_addresses?: Array<VerifiableIdentityAddress>;
}


/**
 * @export
 */
export const IdentityStateEnum = {
    Active: 'active',
    Inactive: 'inactive'
} as const;
export type IdentityStateEnum = typeof IdentityStateEnum[keyof typeof IdentityStateEnum];


/**
 * Check if a given object implements the Identity interface.
 */
export function instanceOfIdentity(value: object): value is Identity {
    if (!('id' in value) || value['id'] === undefined) return false;
    if (!('schema_id' in value) || value['schema_id'] === undefined) return false;
    if (!('schema_url' in value) || value['schema_url'] === undefined) return false;
    if (!('traits' in value) || value['traits'] === undefined) return false;
    return true;
}

export function IdentityFromJSON(json: any): Identity {
    return IdentityFromJSONTyped(json, false);
}

export function IdentityFromJSONTyped(json: any, ignoreDiscriminator: boolean): Identity {
    if (json == null) {
        return json;
    }
    return {
        
        'created_at': json['created_at'] == null ? undefined : (new Date(json['created_at'])),
        'credentials': json['credentials'] == null ? undefined : (mapValues(json['credentials'], IdentityCredentialsFromJSON)),
        'id': json['id'],
        'metadata_admin': json['metadata_admin'] == null ? undefined : json['metadata_admin'],
        'metadata_public': json['metadata_public'] == null ? undefined : json['metadata_public'],
        'organization_id': json['organization_id'] == null ? undefined : json['organization_id'],
        'recovery_addresses': json['recovery_addresses'] == null ? undefined : ((json['recovery_addresses'] as Array<any>).map(RecoveryIdentityAddressFromJSON)),
        'schema_id': json['schema_id'],
        'schema_url': json['schema_url'],
        'state': json['state'] == null ? undefined : json['state'],
        'state_changed_at': json['state_changed_at'] == null ? undefined : (new Date(json['state_changed_at'])),
        'traits': json['traits'],
        'updated_at': json['updated_at'] == null ? undefined : (new Date(json['updated_at'])),
        'verifiable_addresses': json['verifiable_addresses'] == null ? undefined : ((json['verifiable_addresses'] as Array<any>).map(VerifiableIdentityAddressFromJSON)),
    };
}

export function IdentityToJSON(value?: Identity | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'created_at': value['created_at'] == null ? undefined : ((value['created_at']).toISOString()),
        'credentials': value['credentials'] == null ? undefined : (mapValues(value['credentials'], IdentityCredentialsToJSON)),
        'id': value['id'],
        'metadata_admin': value['metadata_admin'],
        'metadata_public': value['metadata_public'],
        'organization_id': value['organization_id'],
        'recovery_addresses': value['recovery_addresses'] == null ? undefined : ((value['recovery_addresses'] as Array<any>).map(RecoveryIdentityAddressToJSON)),
        'schema_id': value['schema_id'],
        'schema_url': value['schema_url'],
        'state': value['state'],
        'state_changed_at': value['state_changed_at'] == null ? undefined : ((value['state_changed_at']).toISOString()),
        'traits': value['traits'],
        'updated_at': value['updated_at'] == null ? undefined : ((value['updated_at']).toISOString()),
        'verifiable_addresses': value['verifiable_addresses'] == null ? undefined : ((value['verifiable_addresses'] as Array<any>).map(VerifiableIdentityAddressToJSON)),
    };
}

