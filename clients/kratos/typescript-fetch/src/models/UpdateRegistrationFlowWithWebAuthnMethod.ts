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
 * Update Registration Flow with WebAuthn Method
 * @export
 * @interface UpdateRegistrationFlowWithWebAuthnMethod
 */
export interface UpdateRegistrationFlowWithWebAuthnMethod {
    /**
     * CSRFToken is the anti-CSRF token
     * @type {string}
     * @memberof UpdateRegistrationFlowWithWebAuthnMethod
     */
    csrf_token?: string;
    /**
     * Method
     * 
     * Should be set to "webauthn" when trying to add, update, or remove a webAuthn pairing.
     * @type {string}
     * @memberof UpdateRegistrationFlowWithWebAuthnMethod
     */
    method: string;
    /**
     * The identity's traits
     * @type {object}
     * @memberof UpdateRegistrationFlowWithWebAuthnMethod
     */
    traits: object;
    /**
     * Transient data to pass along to any webhooks
     * @type {object}
     * @memberof UpdateRegistrationFlowWithWebAuthnMethod
     */
    transient_payload?: object;
    /**
     * Register a WebAuthn Security Key
     * 
     * It is expected that the JSON returned by the WebAuthn registration process
     * is included here.
     * @type {string}
     * @memberof UpdateRegistrationFlowWithWebAuthnMethod
     */
    webauthn_register?: string;
    /**
     * Name of the WebAuthn Security Key to be Added
     * 
     * A human-readable name for the security key which will be added.
     * @type {string}
     * @memberof UpdateRegistrationFlowWithWebAuthnMethod
     */
    webauthn_register_displayname?: string;
}

/**
 * Check if a given object implements the UpdateRegistrationFlowWithWebAuthnMethod interface.
 */
export function instanceOfUpdateRegistrationFlowWithWebAuthnMethod(value: object): value is UpdateRegistrationFlowWithWebAuthnMethod {
    if (!('method' in value) || value['method'] === undefined) return false;
    if (!('traits' in value) || value['traits'] === undefined) return false;
    return true;
}

export function UpdateRegistrationFlowWithWebAuthnMethodFromJSON(json: any): UpdateRegistrationFlowWithWebAuthnMethod {
    return UpdateRegistrationFlowWithWebAuthnMethodFromJSONTyped(json, false);
}

export function UpdateRegistrationFlowWithWebAuthnMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateRegistrationFlowWithWebAuthnMethod {
    if (json == null) {
        return json;
    }
    return {
        
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'method': json['method'],
        'traits': json['traits'],
        'transient_payload': json['transient_payload'] == null ? undefined : json['transient_payload'],
        'webauthn_register': json['webauthn_register'] == null ? undefined : json['webauthn_register'],
        'webauthn_register_displayname': json['webauthn_register_displayname'] == null ? undefined : json['webauthn_register_displayname'],
    };
}

export function UpdateRegistrationFlowWithWebAuthnMethodToJSON(json: any): UpdateRegistrationFlowWithWebAuthnMethod {
    return UpdateRegistrationFlowWithWebAuthnMethodToJSONTyped(json, false);
}

export function UpdateRegistrationFlowWithWebAuthnMethodToJSONTyped(value?: UpdateRegistrationFlowWithWebAuthnMethod | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'csrf_token': value['csrf_token'],
        'method': value['method'],
        'traits': value['traits'],
        'transient_payload': value['transient_payload'],
        'webauthn_register': value['webauthn_register'],
        'webauthn_register_displayname': value['webauthn_register_displayname'],
    };
}

