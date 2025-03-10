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
 * Create Identity and Import Password Credentials Configuration
 * @export
 * @interface IdentityWithCredentialsPasswordConfig
 */
export interface IdentityWithCredentialsPasswordConfig {
    /**
     * The hashed password in [PHC format](https://www.ory.sh/docs/kratos/manage-identities/import-user-accounts-identities#hashed-passwords)
     * @type {string}
     * @memberof IdentityWithCredentialsPasswordConfig
     */
    hashed_password?: string;
    /**
     * The password in plain text if no hash is available.
     * @type {string}
     * @memberof IdentityWithCredentialsPasswordConfig
     */
    password?: string;
    /**
     * If set to true, the password will be migrated using the password migration hook.
     * @type {boolean}
     * @memberof IdentityWithCredentialsPasswordConfig
     */
    use_password_migration_hook?: boolean;
}

/**
 * Check if a given object implements the IdentityWithCredentialsPasswordConfig interface.
 */
export function instanceOfIdentityWithCredentialsPasswordConfig(value: object): value is IdentityWithCredentialsPasswordConfig {
    return true;
}

export function IdentityWithCredentialsPasswordConfigFromJSON(json: any): IdentityWithCredentialsPasswordConfig {
    return IdentityWithCredentialsPasswordConfigFromJSONTyped(json, false);
}

export function IdentityWithCredentialsPasswordConfigFromJSONTyped(json: any, ignoreDiscriminator: boolean): IdentityWithCredentialsPasswordConfig {
    if (json == null) {
        return json;
    }
    return {
        
        'hashed_password': json['hashed_password'] == null ? undefined : json['hashed_password'],
        'password': json['password'] == null ? undefined : json['password'],
        'use_password_migration_hook': json['use_password_migration_hook'] == null ? undefined : json['use_password_migration_hook'],
    };
}

export function IdentityWithCredentialsPasswordConfigToJSON(json: any): IdentityWithCredentialsPasswordConfig {
    return IdentityWithCredentialsPasswordConfigToJSONTyped(json, false);
}

export function IdentityWithCredentialsPasswordConfigToJSONTyped(value?: IdentityWithCredentialsPasswordConfig | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'hashed_password': value['hashed_password'],
        'password': value['password'],
        'use_password_migration_hook': value['use_password_migration_hook'],
    };
}

