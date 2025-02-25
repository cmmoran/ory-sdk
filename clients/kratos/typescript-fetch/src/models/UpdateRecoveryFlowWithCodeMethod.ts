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
/**
 * Update Recovery Flow with Code Method
 * @export
 * @interface UpdateRecoveryFlowWithCodeMethod
 */
export interface UpdateRecoveryFlowWithCodeMethod {
    /**
     * Code from the recovery email
     * 
     * If you want to submit a code, use this field, but make sure to _not_ include the email field, as well.
     * @type {string}
     * @memberof UpdateRecoveryFlowWithCodeMethod
     */
    code?: string;
    /**
     * Sending the anti-csrf token is only required for browser login flows.
     * @type {string}
     * @memberof UpdateRecoveryFlowWithCodeMethod
     */
    csrf_token?: string;
    /**
     * The email address of the account to recover
     * 
     * If the email belongs to a valid account, a recovery email will be sent.
     * 
     * If you want to notify the email address if the account does not exist, see
     * the [notify_unknown_recipients flag](https://www.ory.sh/docs/kratos/self-service/flows/account-recovery-password-reset#attempted-recovery-notifications)
     * 
     * If a code was already sent, including this field in the payload will invalidate the sent code and re-send a new code.
     * 
     * format: email
     * @type {string}
     * @memberof UpdateRecoveryFlowWithCodeMethod
     */
    email?: string;
    /**
     * Method is the method that should be used for this recovery flow
     * 
     * Allowed values are `link` and `code`.
     * link RecoveryStrategyLink
     * code RecoveryStrategyCode
     * @type {string}
     * @memberof UpdateRecoveryFlowWithCodeMethod
     */
    method: UpdateRecoveryFlowWithCodeMethodMethodEnum;
    /**
     * Transient data to pass along to any webhooks
     * @type {object}
     * @memberof UpdateRecoveryFlowWithCodeMethod
     */
    transient_payload?: object;
}


/**
 * @export
 */
export const UpdateRecoveryFlowWithCodeMethodMethodEnum = {
    Link: 'link',
    Code: 'code'
} as const;
export type UpdateRecoveryFlowWithCodeMethodMethodEnum = typeof UpdateRecoveryFlowWithCodeMethodMethodEnum[keyof typeof UpdateRecoveryFlowWithCodeMethodMethodEnum];


/**
 * Check if a given object implements the UpdateRecoveryFlowWithCodeMethod interface.
 */
export function instanceOfUpdateRecoveryFlowWithCodeMethod(value: object): value is UpdateRecoveryFlowWithCodeMethod {
    if (!('method' in value) || value['method'] === undefined) return false;
    return true;
}

export function UpdateRecoveryFlowWithCodeMethodFromJSON(json: any): UpdateRecoveryFlowWithCodeMethod {
    return UpdateRecoveryFlowWithCodeMethodFromJSONTyped(json, false);
}

export function UpdateRecoveryFlowWithCodeMethodFromJSONTyped(json: any, ignoreDiscriminator: boolean): UpdateRecoveryFlowWithCodeMethod {
    if (json == null) {
        return json;
    }
    return {
        
        'code': json['code'] == null ? undefined : json['code'],
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'email': json['email'] == null ? undefined : json['email'],
        'method': json['method'],
        'transient_payload': json['transient_payload'] == null ? undefined : json['transient_payload'],
    };
}

export function UpdateRecoveryFlowWithCodeMethodToJSON(value?: UpdateRecoveryFlowWithCodeMethod | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'code': value['code'],
        'csrf_token': value['csrf_token'],
        'email': value['email'],
        'method': value['method'],
        'transient_payload': value['transient_payload'],
    };
}

