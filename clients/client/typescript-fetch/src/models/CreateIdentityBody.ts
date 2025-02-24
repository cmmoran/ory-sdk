/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.9
 * Contact: support@ory.sh
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
import type { IdentityWithCredentials } from './IdentityWithCredentials';
import {
    IdentityWithCredentialsFromJSON,
    IdentityWithCredentialsFromJSONTyped,
    IdentityWithCredentialsToJSON,
} from './IdentityWithCredentials';

/**
 * Create Identity Body
 * @export
 * @interface CreateIdentityBody
 */
export interface CreateIdentityBody {
    /**
     * 
     * @type {IdentityWithCredentials}
     * @memberof CreateIdentityBody
     */
    credentials?: IdentityWithCredentials;
    /**
     * Store metadata about the user which is only accessible through admin APIs such as `GET /admin/identities/<id>`.
     * @type {any}
     * @memberof CreateIdentityBody
     */
    metadata_admin?: any | null;
    /**
     * Store metadata about the identity which the identity itself can see when calling for example the
     * session endpoint. Do not store sensitive information (e.g. credit score) about the identity in this field.
     * @type {any}
     * @memberof CreateIdentityBody
     */
    metadata_public?: any | null;
    /**
     * 
     * @type {string}
     * @memberof CreateIdentityBody
     */
    organization_id?: string | null;
    /**
     * RecoveryAddresses contains all the addresses that can be used to recover an identity.
     * 
     * Use this structure to import recovery addresses for an identity. Please keep in mind
     * that the address needs to be represented in the Identity Schema or this field will be overwritten
     * on the next identity update.
     * @type {Array<RecoveryIdentityAddress>}
     * @memberof CreateIdentityBody
     */
    recovery_addresses?: Array<RecoveryIdentityAddress>;
    /**
     * SchemaID is the ID of the JSON Schema to be used for validating the identity's traits.
     * @type {string}
     * @memberof CreateIdentityBody
     */
    schema_id: string;
    /**
     * State is the identity's state.
     * active StateActive
     * inactive StateInactive
     * @type {string}
     * @memberof CreateIdentityBody
     */
    state?: CreateIdentityBodyStateEnum;
    /**
     * Traits represent an identity's traits. The identity is able to create, modify, and delete traits
     * in a self-service manner. The input will always be validated against the JSON Schema defined
     * in `schema_url`.
     * @type {object}
     * @memberof CreateIdentityBody
     */
    traits: object;
    /**
     * VerifiableAddresses contains all the addresses that can be verified by the user.
     * 
     * Use this structure to import verified addresses for an identity. Please keep in mind
     * that the address needs to be represented in the Identity Schema or this field will be overwritten
     * on the next identity update.
     * @type {Array<VerifiableIdentityAddress>}
     * @memberof CreateIdentityBody
     */
    verifiable_addresses?: Array<VerifiableIdentityAddress>;
}


/**
 * @export
 */
export const CreateIdentityBodyStateEnum = {
    Active: 'active',
    Inactive: 'inactive'
} as const;
export type CreateIdentityBodyStateEnum = typeof CreateIdentityBodyStateEnum[keyof typeof CreateIdentityBodyStateEnum];


/**
 * Check if a given object implements the CreateIdentityBody interface.
 */
export function instanceOfCreateIdentityBody(value: object): value is CreateIdentityBody {
    if (!('schema_id' in value) || value['schema_id'] === undefined) return false;
    if (!('traits' in value) || value['traits'] === undefined) return false;
    return true;
}

export function CreateIdentityBodyFromJSON(json: any): CreateIdentityBody {
    return CreateIdentityBodyFromJSONTyped(json, false);
}

export function CreateIdentityBodyFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateIdentityBody {
    if (json == null) {
        return json;
    }
    return {
        
        'credentials': json['credentials'] == null ? undefined : IdentityWithCredentialsFromJSON(json['credentials']),
        'metadata_admin': json['metadata_admin'] == null ? undefined : json['metadata_admin'],
        'metadata_public': json['metadata_public'] == null ? undefined : json['metadata_public'],
        'organization_id': json['organization_id'] == null ? undefined : json['organization_id'],
        'recovery_addresses': json['recovery_addresses'] == null ? undefined : ((json['recovery_addresses'] as Array<any>).map(RecoveryIdentityAddressFromJSON)),
        'schema_id': json['schema_id'],
        'state': json['state'] == null ? undefined : json['state'],
        'traits': json['traits'],
        'verifiable_addresses': json['verifiable_addresses'] == null ? undefined : ((json['verifiable_addresses'] as Array<any>).map(VerifiableIdentityAddressFromJSON)),
    };
}

export function CreateIdentityBodyToJSON(value?: CreateIdentityBody | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'credentials': IdentityWithCredentialsToJSON(value['credentials']),
        'metadata_admin': value['metadata_admin'],
        'metadata_public': value['metadata_public'],
        'organization_id': value['organization_id'],
        'recovery_addresses': value['recovery_addresses'] == null ? undefined : ((value['recovery_addresses'] as Array<any>).map(RecoveryIdentityAddressToJSON)),
        'schema_id': value['schema_id'],
        'state': value['state'],
        'traits': value['traits'],
        'verifiable_addresses': value['verifiable_addresses'] == null ? undefined : ((value['verifiable_addresses'] as Array<any>).map(VerifiableIdentityAddressToJSON)),
    };
}

