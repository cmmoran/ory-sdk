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
import type { SessionDevice } from './SessionDevice';
import {
    SessionDeviceFromJSON,
    SessionDeviceFromJSONTyped,
    SessionDeviceToJSON,
    SessionDeviceToJSONTyped,
} from './SessionDevice';
import type { SessionAuthenticationMethod } from './SessionAuthenticationMethod';
import {
    SessionAuthenticationMethodFromJSON,
    SessionAuthenticationMethodFromJSONTyped,
    SessionAuthenticationMethodToJSON,
    SessionAuthenticationMethodToJSONTyped,
} from './SessionAuthenticationMethod';
import type { AuthenticatorAssuranceLevel } from './AuthenticatorAssuranceLevel';
import {
    AuthenticatorAssuranceLevelFromJSON,
    AuthenticatorAssuranceLevelFromJSONTyped,
    AuthenticatorAssuranceLevelToJSON,
    AuthenticatorAssuranceLevelToJSONTyped,
} from './AuthenticatorAssuranceLevel';
import type { Identity } from './Identity';
import {
    IdentityFromJSON,
    IdentityFromJSONTyped,
    IdentityToJSON,
    IdentityToJSONTyped,
} from './Identity';

/**
 * A Session
 * @export
 * @interface Session
 */
export interface Session {
    /**
     * Active state. If false the session is no longer active.
     * @type {boolean}
     * @memberof Session
     */
    active?: boolean;
    /**
     * The Session Authentication Timestamp
     * 
     * When this session was authenticated at. If multi-factor authentication was used this
     * is the time when the last factor was authenticated (e.g. the TOTP code challenge was completed).
     * @type {Date}
     * @memberof Session
     */
    authenticated_at?: Date;
    /**
     * A list of authenticators which were used to authenticate the session.
     * @type {Array<SessionAuthenticationMethod>}
     * @memberof Session
     */
    authentication_methods?: Array<SessionAuthenticationMethod>;
    /**
     * 
     * @type {AuthenticatorAssuranceLevel}
     * @memberof Session
     */
    authenticator_assurance_level?: AuthenticatorAssuranceLevel;
    /**
     * Devices has history of all endpoints where the session was used
     * @type {Array<SessionDevice>}
     * @memberof Session
     */
    devices?: Array<SessionDevice>;
    /**
     * The Session Expiry
     * 
     * When this session expires at.
     * @type {Date}
     * @memberof Session
     */
    expires_at?: Date;
    /**
     * Session ID
     * @type {string}
     * @memberof Session
     */
    id: string;
    /**
     * 
     * @type {Identity}
     * @memberof Session
     */
    identity?: Identity;
    /**
     * The Session Issuance Timestamp
     * 
     * When this session was issued at. Usually equal or close to `authenticated_at`.
     * @type {Date}
     * @memberof Session
     */
    issued_at?: Date;
    /**
     * Tokenized is the tokenized (e.g. JWT) version of the session.
     * 
     * It is only set when the `tokenize` query parameter was set to a valid tokenize template during calls to `/session/whoami`.
     * @type {string}
     * @memberof Session
     */
    tokenized?: string;
}



/**
 * Check if a given object implements the Session interface.
 */
export function instanceOfSession(value: object): value is Session {
    if (!('id' in value) || value['id'] === undefined) return false;
    return true;
}

export function SessionFromJSON(json: any): Session {
    return SessionFromJSONTyped(json, false);
}

export function SessionFromJSONTyped(json: any, ignoreDiscriminator: boolean): Session {
    if (json == null) {
        return json;
    }
    return {
        
        'active': json['active'] == null ? undefined : json['active'],
        'authenticated_at': json['authenticated_at'] == null ? undefined : (new Date(json['authenticated_at'])),
        'authentication_methods': json['authentication_methods'] == null ? undefined : ((json['authentication_methods'] as Array<any>).map(SessionAuthenticationMethodFromJSON)),
        'authenticator_assurance_level': json['authenticator_assurance_level'] == null ? undefined : AuthenticatorAssuranceLevelFromJSON(json['authenticator_assurance_level']),
        'devices': json['devices'] == null ? undefined : ((json['devices'] as Array<any>).map(SessionDeviceFromJSON)),
        'expires_at': json['expires_at'] == null ? undefined : (new Date(json['expires_at'])),
        'id': json['id'],
        'identity': json['identity'] == null ? undefined : IdentityFromJSON(json['identity']),
        'issued_at': json['issued_at'] == null ? undefined : (new Date(json['issued_at'])),
        'tokenized': json['tokenized'] == null ? undefined : json['tokenized'],
    };
}

export function SessionToJSON(json: any): Session {
    return SessionToJSONTyped(json, false);
}

export function SessionToJSONTyped(value?: Session | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'active': value['active'],
        'authenticated_at': value['authenticated_at'] == null ? undefined : ((value['authenticated_at']).toISOString()),
        'authentication_methods': value['authentication_methods'] == null ? undefined : ((value['authentication_methods'] as Array<any>).map(SessionAuthenticationMethodToJSON)),
        'authenticator_assurance_level': AuthenticatorAssuranceLevelToJSON(value['authenticator_assurance_level']),
        'devices': value['devices'] == null ? undefined : ((value['devices'] as Array<any>).map(SessionDeviceToJSON)),
        'expires_at': value['expires_at'] == null ? undefined : ((value['expires_at']).toISOString()),
        'id': value['id'],
        'identity': IdentityToJSON(value['identity']),
        'issued_at': value['issued_at'] == null ? undefined : ((value['issued_at']).toISOString()),
        'tokenized': value['tokenized'],
    };
}

