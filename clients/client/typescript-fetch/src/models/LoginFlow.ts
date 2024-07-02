/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.2
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { AuthenticatorAssuranceLevel } from './AuthenticatorAssuranceLevel';
import {
    AuthenticatorAssuranceLevelFromJSON,
    AuthenticatorAssuranceLevelFromJSONTyped,
    AuthenticatorAssuranceLevelToJSON,
} from './AuthenticatorAssuranceLevel';
import type { OAuth2LoginRequest } from './OAuth2LoginRequest';
import {
    OAuth2LoginRequestFromJSON,
    OAuth2LoginRequestFromJSONTyped,
    OAuth2LoginRequestToJSON,
} from './OAuth2LoginRequest';
import type { UiContainer } from './UiContainer';
import {
    UiContainerFromJSON,
    UiContainerFromJSONTyped,
    UiContainerToJSON,
} from './UiContainer';

/**
 * This object represents a login flow. A login flow is initiated at the "Initiate Login API / Browser Flow"
 * endpoint by a client.
 * 
 * Once a login flow is completed successfully, a session cookie or session token will be issued.
 * @export
 * @interface LoginFlow
 */
export interface LoginFlow {
    /**
     * The active login method
     * 
     * If set contains the login method used. If the flow is new, it is unset.
     * password CredentialsTypePassword
     * oidc CredentialsTypeOIDC
     * totp CredentialsTypeTOTP
     * lookup_secret CredentialsTypeLookup
     * webauthn CredentialsTypeWebAuthn
     * code CredentialsTypeCodeAuth
     * passkey CredentialsTypePasskey
     * profile CredentialsTypeProfile
     * link_recovery CredentialsTypeRecoveryLink  CredentialsTypeRecoveryLink is a special credential type linked to the link strategy (recovery flow).  It is not used within the credentials object itself.
     * code_recovery CredentialsTypeRecoveryCode
     * @type {string}
     * @memberof LoginFlow
     */
    active?: LoginFlowActiveEnum;
    /**
     * CreatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof LoginFlow
     */
    created_at?: Date;
    /**
     * ExpiresAt is the time (UTC) when the flow expires. If the user still wishes to log in,
     * a new flow has to be initiated.
     * @type {Date}
     * @memberof LoginFlow
     */
    expires_at: Date;
    /**
     * ID represents the flow's unique ID. When performing the login flow, this
     * represents the id in the login UI's query parameter: http://<selfservice.flows.login.ui_url>/?flow=<flow_id>
     * @type {string}
     * @memberof LoginFlow
     */
    id: string;
    /**
     * IssuedAt is the time (UTC) when the flow started.
     * @type {Date}
     * @memberof LoginFlow
     */
    issued_at: Date;
    /**
     * Ory OAuth 2.0 Login Challenge.
     * 
     * This value is set using the `login_challenge` query parameter of the registration and login endpoints.
     * If set will cooperate with Ory OAuth2 and OpenID to act as an OAuth2 server / OpenID Provider.
     * @type {string}
     * @memberof LoginFlow
     */
    oauth2_login_challenge?: string;
    /**
     * 
     * @type {OAuth2LoginRequest}
     * @memberof LoginFlow
     */
    oauth2_login_request?: OAuth2LoginRequest;
    /**
     * 
     * @type {string}
     * @memberof LoginFlow
     */
    organization_id?: string;
    /**
     * Refresh stores whether this login flow should enforce re-authentication.
     * @type {boolean}
     * @memberof LoginFlow
     */
    refresh?: boolean;
    /**
     * RequestURL is the initial URL that was requested from Ory Kratos. It can be used
     * to forward information contained in the URL's path or query for example.
     * @type {string}
     * @memberof LoginFlow
     */
    request_url: string;
    /**
     * 
     * @type {AuthenticatorAssuranceLevel}
     * @memberof LoginFlow
     */
    requested_aal?: AuthenticatorAssuranceLevel;
    /**
     * ReturnTo contains the requested return_to URL.
     * @type {string}
     * @memberof LoginFlow
     */
    return_to?: string;
    /**
     * SessionTokenExchangeCode holds the secret code that the client can use to retrieve a session token after the login flow has been completed.
     * This is only set if the client has requested a session token exchange code, and if the flow is of type "api",
     * and only on creating the login flow.
     * @type {string}
     * @memberof LoginFlow
     */
    session_token_exchange_code?: string;
    /**
     * State represents the state of this request:
     * 
     * choose_method: ask the user to choose a method to sign in with
     * sent_email: the email has been sent to the user
     * passed_challenge: the request was successful and the login challenge was passed.
     * @type {any}
     * @memberof LoginFlow
     */
    state: any | null;
    /**
     * TransientPayload is used to pass data from the login to hooks and email templates
     * @type {object}
     * @memberof LoginFlow
     */
    transient_payload?: object;
    /**
     * The flow type can either be `api` or `browser`.
     * @type {string}
     * @memberof LoginFlow
     */
    type: string;
    /**
     * 
     * @type {UiContainer}
     * @memberof LoginFlow
     */
    ui: UiContainer;
    /**
     * UpdatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof LoginFlow
     */
    updated_at?: Date;
}


/**
 * @export
 */
export const LoginFlowActiveEnum = {
    Password: 'password',
    Oidc: 'oidc',
    Totp: 'totp',
    LookupSecret: 'lookup_secret',
    Webauthn: 'webauthn',
    Code: 'code',
    Passkey: 'passkey',
    Profile: 'profile',
    LinkRecovery: 'link_recovery',
    CodeRecovery: 'code_recovery'
} as const;
export type LoginFlowActiveEnum = typeof LoginFlowActiveEnum[keyof typeof LoginFlowActiveEnum];


/**
 * Check if a given object implements the LoginFlow interface.
 */
export function instanceOfLoginFlow(value: object): boolean {
    if (!('expires_at' in value)) return false;
    if (!('id' in value)) return false;
    if (!('issued_at' in value)) return false;
    if (!('request_url' in value)) return false;
    if (!('state' in value)) return false;
    if (!('type' in value)) return false;
    if (!('ui' in value)) return false;
    return true;
}

export function LoginFlowFromJSON(json: any): LoginFlow {
    return LoginFlowFromJSONTyped(json, false);
}

export function LoginFlowFromJSONTyped(json: any, ignoreDiscriminator: boolean): LoginFlow {
    if (json == null) {
        return json;
    }
    return {
        
        'active': json['active'] == null ? undefined : json['active'],
        'created_at': json['created_at'] == null ? undefined : (new Date(json['created_at'])),
        'expires_at': (new Date(json['expires_at'])),
        'id': json['id'],
        'issued_at': (new Date(json['issued_at'])),
        'oauth2_login_challenge': json['oauth2_login_challenge'] == null ? undefined : json['oauth2_login_challenge'],
        'oauth2_login_request': json['oauth2_login_request'] == null ? undefined : OAuth2LoginRequestFromJSON(json['oauth2_login_request']),
        'organization_id': json['organization_id'] == null ? undefined : json['organization_id'],
        'refresh': json['refresh'] == null ? undefined : json['refresh'],
        'request_url': json['request_url'],
        'requested_aal': json['requested_aal'] == null ? undefined : AuthenticatorAssuranceLevelFromJSON(json['requested_aal']),
        'return_to': json['return_to'] == null ? undefined : json['return_to'],
        'session_token_exchange_code': json['session_token_exchange_code'] == null ? undefined : json['session_token_exchange_code'],
        'state': json['state'],
        'transient_payload': json['transient_payload'] == null ? undefined : json['transient_payload'],
        'type': json['type'],
        'ui': UiContainerFromJSON(json['ui']),
        'updated_at': json['updated_at'] == null ? undefined : (new Date(json['updated_at'])),
    };
}

export function LoginFlowToJSON(value?: LoginFlow | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'active': value['active'],
        'created_at': value['created_at'] == null ? undefined : ((value['created_at']).toISOString()),
        'expires_at': ((value['expires_at']).toISOString()),
        'id': value['id'],
        'issued_at': ((value['issued_at']).toISOString()),
        'oauth2_login_challenge': value['oauth2_login_challenge'],
        'oauth2_login_request': OAuth2LoginRequestToJSON(value['oauth2_login_request']),
        'organization_id': value['organization_id'],
        'refresh': value['refresh'],
        'request_url': value['request_url'],
        'requested_aal': AuthenticatorAssuranceLevelToJSON(value['requested_aal']),
        'return_to': value['return_to'],
        'session_token_exchange_code': value['session_token_exchange_code'],
        'state': value['state'],
        'transient_payload': value['transient_payload'],
        'type': value['type'],
        'ui': UiContainerToJSON(value['ui']),
        'updated_at': value['updated_at'] == null ? undefined : ((value['updated_at']).toISOString()),
    };
}

