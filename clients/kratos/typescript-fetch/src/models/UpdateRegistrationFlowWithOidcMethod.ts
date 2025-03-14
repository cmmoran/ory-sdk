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
 * Update Registration Flow with OpenID Connect Method
 * @export
 * @interface UpdateRegistrationFlowWithOidcMethod
 */
export interface UpdateRegistrationFlowWithOidcMethod {
    /**
     * The CSRF Token
     * @type {string}
     * @memberof UpdateRegistrationFlowWithOidcMethod
     */
    csrf_token?: string;
    /**
     * IDToken is an optional id token provided by an OIDC provider
     * 
     * If submitted, it is verified using the OIDC provider's public key set and the claims are used to populate
     * the OIDC credentials of the identity.
     * If the OIDC provider does not store additional claims (such as name, etc.) in the IDToken itself, you can use
     * the `traits` field to populate the identity's traits. Note, that Apple only includes the users email in the IDToken.
     * 
     * Supported providers are
     * Apple
     * Google
     * @type {string}
     * @memberof UpdateRegistrationFlowWithOidcMethod
     */
    id_token?: string;
    /**
     * IDTokenNonce is the nonce, used when generating the IDToken.
     * If the provider supports nonce validation, the nonce will be validated against this value and is required.
     * @type {string}
     * @memberof UpdateRegistrationFlowWithOidcMethod
     */
    id_token_nonce?: string;
    /**
     * Method to use
     * 
     * This field must be set to `oidc` when using the oidc method.
     * @type {string}
     * @memberof UpdateRegistrationFlowWithOidcMethod
     */
    method: string;
    /**
     * The provider to register with
     * @type {string}
     * @memberof UpdateRegistrationFlowWithOidcMethod
     */
    provider: string;
    /**
     * The identity traits
     * @type {object}
     * @memberof UpdateRegistrationFlowWithOidcMethod
     */
    traits?: object;
    /**
     * Transient data to pass along to any webhooks
     * @type {object}
     * @memberof UpdateRegistrationFlowWithOidcMethod
     */
    transient_payload?: object;
    /**
     * UpstreamParameters are the parameters that are passed to the upstream identity provider.
     * 
     * These parameters are optional and depend on what the upstream identity provider supports.
     * Supported parameters are:
     * `login_hint` (string): The `login_hint` parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session.
     * `hd` (string): The `hd` parameter limits the login/registration process to a Google Organization, e.g. `mycollege.edu`.
     * `prompt` (string): The `prompt` specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. `select_account`.
     * @type {object}
     * @memberof UpdateRegistrationFlowWithOidcMethod
     */
    upstream_parameters?: object;
}

/**
 * Check if a given object implements the UpdateRegistrationFlowWithOidcMethod interface.
 */
export function instanceOfUpdateRegistrationFlowWithOidcMethod(value: object): value is UpdateRegistrationFlowWithOidcMethod {
    if (!('method' in value) || value['method'] === undefined) return false;
    if (!('provider' in value) || value['provider'] === undefined) return false;
    return true;
}

export function UpdateRegistrationFlowWithOidcMethodFromJSON(json: any): UpdateRegistrationFlowWithOidcMethod {
    return UpdateRegistrationFlowWithOidcMethodFromJSONTyped(json, false);
}

export function UpdateRegistrationFlowWithOidcMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateRegistrationFlowWithOidcMethod {
    if (json == null) {
        return json;
    }
    return {
        
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'id_token': json['id_token'] == null ? undefined : json['id_token'],
        'id_token_nonce': json['id_token_nonce'] == null ? undefined : json['id_token_nonce'],
        'method': json['method'],
        'provider': json['provider'],
        'traits': json['traits'] == null ? undefined : json['traits'],
        'transient_payload': json['transient_payload'] == null ? undefined : json['transient_payload'],
        'upstream_parameters': json['upstream_parameters'] == null ? undefined : json['upstream_parameters'],
    };
}

export function UpdateRegistrationFlowWithOidcMethodToJSON(json: any): UpdateRegistrationFlowWithOidcMethod {
    return UpdateRegistrationFlowWithOidcMethodToJSONTyped(json, false);
}

export function UpdateRegistrationFlowWithOidcMethodToJSONTyped(value?: UpdateRegistrationFlowWithOidcMethod | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    return {
        
        'csrf_token': value['csrf_token'],
        'id_token': value['id_token'],
        'id_token_nonce': value['id_token_nonce'],
        'method': value['method'],
        'provider': value['provider'],
        'traits': value['traits'],
        'transient_payload': value['transient_payload'],
        'upstream_parameters': value['upstream_parameters'],
    };
}

