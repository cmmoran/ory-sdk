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


/**
 * The authenticator assurance level can be one of "aal1", "aal2", or "aal3". A higher number means that it is harder
 * for an attacker to compromise the account.
 * 
 * Generally, "aal1" implies that one authentication factor was used while AAL2 implies that two factors (e.g.
 * password + TOTP) have been used.
 * 
 * To learn more about these levels please head over to: https://www.ory.sh/kratos/docs/concepts/credentials
 * @export
 */
export const AuthenticatorAssuranceLevel = {
    Aal0: 'aal0',
    Aal1: 'aal1',
    Aal2: 'aal2',
    Aal3: 'aal3'
} as const;
export type AuthenticatorAssuranceLevel = typeof AuthenticatorAssuranceLevel[keyof typeof AuthenticatorAssuranceLevel];


export function instanceOfAuthenticatorAssuranceLevel(value: any): boolean {
    for (const key in AuthenticatorAssuranceLevel) {
        if (Object.prototype.hasOwnProperty.call(AuthenticatorAssuranceLevel, key)) {
            if ((AuthenticatorAssuranceLevel as Record<string, AuthenticatorAssuranceLevel>)[key] === value) {
                return true;
            }
        }
    }
    return false;
}

export function AuthenticatorAssuranceLevelFromJSON(json: any): AuthenticatorAssuranceLevel {
    return AuthenticatorAssuranceLevelFromJSONTyped(json, false);
}

export function AuthenticatorAssuranceLevelFromJSONTyped(json: any, ignoreDiscriminator: boolean): AuthenticatorAssuranceLevel {
    return json as AuthenticatorAssuranceLevel;
}

export function AuthenticatorAssuranceLevelToJSON(value?: AuthenticatorAssuranceLevel | null): any {
    return value as any;
}

