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


/**
 * The experimental state represents the state of a verification flow. This field is EXPERIMENTAL and subject to change!
 * @export
 */
export const VerificationFlowState = {
    ChooseMethod: 'choose_method',
    SentEmail: 'sent_email',
    PassedChallenge: 'passed_challenge'
} as const;
export type VerificationFlowState = typeof VerificationFlowState[keyof typeof VerificationFlowState];


export function instanceOfVerificationFlowState(value: any): boolean {
    for (const key in VerificationFlowState) {
        if (Object.prototype.hasOwnProperty.call(VerificationFlowState, key)) {
            if ((VerificationFlowState as Record<string, VerificationFlowState>)[key] === value) {
                return true;
            }
        }
    }
    return false;
}

export function VerificationFlowStateFromJSON(json: any): VerificationFlowState {
    return VerificationFlowStateFromJSONTyped(json, false);
}

export function VerificationFlowStateFromJSONTyped(json: any, ignoreDiscriminator: boolean): VerificationFlowState {
    return json as VerificationFlowState;
}

export function VerificationFlowStateToJSON(value?: VerificationFlowState | null): any {
    return value as any;
}

