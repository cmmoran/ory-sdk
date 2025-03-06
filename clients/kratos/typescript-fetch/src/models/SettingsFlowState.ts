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


/**
 * The experimental state represents the state of a settings flow. This field is EXPERIMENTAL and subject to change!
 * @export
 */
export const SettingsFlowState = {
    ShowForm: 'show_form',
    Success: 'success',
    UnknownDefaultOpenApi: '11184809'
} as const;
export type SettingsFlowState = typeof SettingsFlowState[keyof typeof SettingsFlowState];


export function instanceOfSettingsFlowState(value: any): boolean {
    for (const key in SettingsFlowState) {
        if (Object.prototype.hasOwnProperty.call(SettingsFlowState, key)) {
            if (SettingsFlowState[key as keyof typeof SettingsFlowState] === value) {
                return true;
            }
        }
    }
    return false;
}

export function SettingsFlowStateFromJSON(json: any): SettingsFlowState {
    return SettingsFlowStateFromJSONTyped(json, false);
}

export function SettingsFlowStateFromJSONTyped(json: any, ignoreDiscriminator: boolean): SettingsFlowState {
    return json as SettingsFlowState;
}

export function SettingsFlowStateToJSON(value?: SettingsFlowState | null): any {
    return value as any;
}

export function SettingsFlowStateToJSONTyped(value: any, ignoreDiscriminator: boolean): SettingsFlowState {
    return value as SettingsFlowState;
}

