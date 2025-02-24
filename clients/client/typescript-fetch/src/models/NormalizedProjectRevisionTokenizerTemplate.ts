/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.8
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface NormalizedProjectRevisionTokenizerTemplate
 */
export interface NormalizedProjectRevisionTokenizerTemplate {
    /**
     * Claims mapper URL
     * @type {string}
     * @memberof NormalizedProjectRevisionTokenizerTemplate
     */
    claims_mapper_url?: string;
    /**
     * The Project's Revision Creation Date
     * @type {Date}
     * @memberof NormalizedProjectRevisionTokenizerTemplate
     */
    readonly created_at?: Date;
    /**
     * The revision ID.
     * @type {string}
     * @memberof NormalizedProjectRevisionTokenizerTemplate
     */
    readonly id?: string;
    /**
     * JSON Web Key URL
     * @type {string}
     * @memberof NormalizedProjectRevisionTokenizerTemplate
     */
    jwks_url?: string;
    /**
     * The unique key of the template
     * @type {string}
     * @memberof NormalizedProjectRevisionTokenizerTemplate
     */
    key?: string;
    /**
     * The Revision's ID this schema belongs to
     * @type {string}
     * @memberof NormalizedProjectRevisionTokenizerTemplate
     */
    project_revision_id?: string;
    /**
     * Token time to live
     * @type {string}
     * @memberof NormalizedProjectRevisionTokenizerTemplate
     */
    ttl?: string;
    /**
     * Last Time Project's Revision was Updated
     * @type {Date}
     * @memberof NormalizedProjectRevisionTokenizerTemplate
     */
    readonly updated_at?: Date;
}

/**
 * Check if a given object implements the NormalizedProjectRevisionTokenizerTemplate interface.
 */
export function instanceOfNormalizedProjectRevisionTokenizerTemplate(value: object): value is NormalizedProjectRevisionTokenizerTemplate {
    return true;
}

export function NormalizedProjectRevisionTokenizerTemplateFromJSON(json: any): NormalizedProjectRevisionTokenizerTemplate {
    return NormalizedProjectRevisionTokenizerTemplateFromJSONTyped(json, false);
}

export function NormalizedProjectRevisionTokenizerTemplateFromJSONTyped(json: any, ignoreDiscriminator: boolean): NormalizedProjectRevisionTokenizerTemplate {
    if (json == null) {
        return json;
    }
    return {
        
        'claims_mapper_url': json['claims_mapper_url'] == null ? undefined : json['claims_mapper_url'],
        'created_at': json['created_at'] == null ? undefined : (new Date(json['created_at'])),
        'id': json['id'] == null ? undefined : json['id'],
        'jwks_url': json['jwks_url'] == null ? undefined : json['jwks_url'],
        'key': json['key'] == null ? undefined : json['key'],
        'project_revision_id': json['project_revision_id'] == null ? undefined : json['project_revision_id'],
        'ttl': json['ttl'] == null ? undefined : json['ttl'],
        'updated_at': json['updated_at'] == null ? undefined : (new Date(json['updated_at'])),
    };
}

export function NormalizedProjectRevisionTokenizerTemplateToJSON(value?: Omit<NormalizedProjectRevisionTokenizerTemplate, 'created_at'|'id'|'updated_at'> | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'claims_mapper_url': value['claims_mapper_url'],
        'jwks_url': value['jwks_url'],
        'key': value['key'],
        'project_revision_id': value['project_revision_id'],
        'ttl': value['ttl'],
    };
}

