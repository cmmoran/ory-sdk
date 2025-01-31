/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.5
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { CourierMessageStatus } from './CourierMessageStatus';
import {
    CourierMessageStatusFromJSON,
    CourierMessageStatusFromJSONTyped,
    CourierMessageStatusToJSON,
} from './CourierMessageStatus';
import type { MessageDispatch } from './MessageDispatch';
import {
    MessageDispatchFromJSON,
    MessageDispatchFromJSONTyped,
    MessageDispatchToJSON,
} from './MessageDispatch';
import type { CourierMessageType } from './CourierMessageType';
import {
    CourierMessageTypeFromJSON,
    CourierMessageTypeFromJSONTyped,
    CourierMessageTypeToJSON,
} from './CourierMessageType';

/**
 * 
 * @export
 * @interface Message
 */
export interface Message {
    /**
     * 
     * @type {string}
     * @memberof Message
     */
    body: string;
    /**
     * 
     * @type {string}
     * @memberof Message
     */
    channel?: string;
    /**
     * CreatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof Message
     */
    created_at: Date;
    /**
     * Dispatches store information about the attempts of delivering a message
     * May contain an error if any happened, or just the `success` state.
     * @type {Array<MessageDispatch>}
     * @memberof Message
     */
    dispatches?: Array<MessageDispatch>;
    /**
     * 
     * @type {string}
     * @memberof Message
     */
    id: string;
    /**
     * 
     * @type {string}
     * @memberof Message
     */
    recipient: string;
    /**
     * 
     * @type {number}
     * @memberof Message
     */
    send_count: number;
    /**
     * 
     * @type {CourierMessageStatus}
     * @memberof Message
     */
    status: CourierMessageStatus;
    /**
     * 
     * @type {string}
     * @memberof Message
     */
    subject: string;
    /**
     * 
     * recovery_invalid TypeRecoveryInvalid
     * recovery_valid TypeRecoveryValid
     * recovery_code_invalid TypeRecoveryCodeInvalid
     * recovery_code_valid TypeRecoveryCodeValid
     * verification_invalid TypeVerificationInvalid
     * verification_valid TypeVerificationValid
     * verification_code_invalid TypeVerificationCodeInvalid
     * verification_code_valid TypeVerificationCodeValid
     * stub TypeTestStub
     * login_code_valid TypeLoginCodeValid
     * registration_code_valid TypeRegistrationCodeValid
     * @type {string}
     * @memberof Message
     */
    template_type: MessageTemplateTypeEnum;
    /**
     * 
     * @type {CourierMessageType}
     * @memberof Message
     */
    type: CourierMessageType;
    /**
     * UpdatedAt is a helper struct field for gobuffalo.pop.
     * @type {Date}
     * @memberof Message
     */
    updated_at: Date;
}


/**
 * @export
 */
export const MessageTemplateTypeEnum = {
    RecoveryInvalid: 'recovery_invalid',
    RecoveryValid: 'recovery_valid',
    RecoveryCodeInvalid: 'recovery_code_invalid',
    RecoveryCodeValid: 'recovery_code_valid',
    VerificationInvalid: 'verification_invalid',
    VerificationValid: 'verification_valid',
    VerificationCodeInvalid: 'verification_code_invalid',
    VerificationCodeValid: 'verification_code_valid',
    Stub: 'stub',
    LoginCodeValid: 'login_code_valid',
    RegistrationCodeValid: 'registration_code_valid'
} as const;
export type MessageTemplateTypeEnum = typeof MessageTemplateTypeEnum[keyof typeof MessageTemplateTypeEnum];


/**
 * Check if a given object implements the Message interface.
 */
export function instanceOfMessage(value: object): value is Message {
    if (!('body' in value) || value['body'] === undefined) return false;
    if (!('created_at' in value) || value['created_at'] === undefined) return false;
    if (!('id' in value) || value['id'] === undefined) return false;
    if (!('recipient' in value) || value['recipient'] === undefined) return false;
    if (!('send_count' in value) || value['send_count'] === undefined) return false;
    if (!('status' in value) || value['status'] === undefined) return false;
    if (!('subject' in value) || value['subject'] === undefined) return false;
    if (!('template_type' in value) || value['template_type'] === undefined) return false;
    if (!('type' in value) || value['type'] === undefined) return false;
    if (!('updated_at' in value) || value['updated_at'] === undefined) return false;
    return true;
}

export function MessageFromJSON(json: any): Message {
    return MessageFromJSONTyped(json, false);
}

export function MessageFromJSONTyped(json: any, ignoreDiscriminator: boolean): Message {
    if (json == null) {
        return json;
    }
    return {
        
        'body': json['body'],
        'channel': json['channel'] == null ? undefined : json['channel'],
        'created_at': (new Date(json['created_at'])),
        'dispatches': json['dispatches'] == null ? undefined : ((json['dispatches'] as Array<any>).map(MessageDispatchFromJSON)),
        'id': json['id'],
        'recipient': json['recipient'],
        'send_count': json['send_count'],
        'status': CourierMessageStatusFromJSON(json['status']),
        'subject': json['subject'],
        'template_type': json['template_type'],
        'type': CourierMessageTypeFromJSON(json['type']),
        'updated_at': (new Date(json['updated_at'])),
    };
}

export function MessageToJSON(value?: Message | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'body': value['body'],
        'channel': value['channel'],
        'created_at': ((value['created_at']).toISOString()),
        'dispatches': value['dispatches'] == null ? undefined : ((value['dispatches'] as Array<any>).map(MessageDispatchToJSON)),
        'id': value['id'],
        'recipient': value['recipient'],
        'send_count': value['send_count'],
        'status': CourierMessageStatusToJSON(value['status']),
        'subject': value['subject'],
        'template_type': value['template_type'],
        'type': CourierMessageTypeToJSON(value['type']),
        'updated_at': ((value['updated_at']).toISOString()),
    };
}

