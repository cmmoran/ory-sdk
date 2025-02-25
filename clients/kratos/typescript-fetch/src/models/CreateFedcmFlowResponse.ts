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
import type { Provider } from './Provider';
import {
    ProviderFromJSON,
    ProviderFromJSONTyped,
    ProviderToJSON,
} from './Provider';

/**
 * Contains a list of all available FedCM providers.
 * @export
 * @interface CreateFedcmFlowResponse
 */
export interface CreateFedcmFlowResponse {
    /**
     * 
     * @type {string}
     * @memberof CreateFedcmFlowResponse
     */
    csrf_token?: string;
    /**
     * 
     * @type {Array<Provider>}
     * @memberof CreateFedcmFlowResponse
     */
    providers?: Array<Provider>;
}

/**
 * Check if a given object implements the CreateFedcmFlowResponse interface.
 */
export function instanceOfCreateFedcmFlowResponse(value: object): value is CreateFedcmFlowResponse {
    return true;
}

export function CreateFedcmFlowResponseFromJSON(json: any): CreateFedcmFlowResponse {
    return CreateFedcmFlowResponseFromJSONTyped(json, false);
}

export function CreateFedcmFlowResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): CreateFedcmFlowResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'csrf_token': json['csrf_token'] == null ? undefined : json['csrf_token'],
        'providers': json['providers'] == null ? undefined : ((json['providers'] as Array<any>).map(ProviderFromJSON)),
    };
}

export function CreateFedcmFlowResponseToJSON(value?: CreateFedcmFlowResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'csrf_token': value['csrf_token'],
        'providers': value['providers'] == null ? undefined : ((value['providers'] as Array<any>).map(ProviderToJSON)),
    };
}

