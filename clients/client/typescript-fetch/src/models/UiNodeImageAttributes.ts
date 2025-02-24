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
 * @interface UiNodeImageAttributes
 */
export interface UiNodeImageAttributes {
    /**
     * Height of the image
     * @type {number}
     * @memberof UiNodeImageAttributes
     */
    height: number;
    /**
     * A unique identifier
     * @type {string}
     * @memberof UiNodeImageAttributes
     */
    id: string;
    /**
     * NodeType represents this node's types. It is a mirror of `node.type` and
     * is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is "img".
     * text Text
     * input Input
     * img Image
     * a Anchor
     * script Script
     * @type {string}
     * @memberof UiNodeImageAttributes
     */
    node_type: UiNodeImageAttributesNodeTypeEnum;
    /**
     * The image's source URL.
     * 
     * format: uri
     * @type {string}
     * @memberof UiNodeImageAttributes
     */
    src: string;
    /**
     * Width of the image
     * @type {number}
     * @memberof UiNodeImageAttributes
     */
    width: number;
}


/**
 * @export
 */
export const UiNodeImageAttributesNodeTypeEnum = {
    Text: 'text',
    Input: 'input',
    Img: 'img',
    A: 'a',
    Script: 'script'
} as const;
export type UiNodeImageAttributesNodeTypeEnum = typeof UiNodeImageAttributesNodeTypeEnum[keyof typeof UiNodeImageAttributesNodeTypeEnum];


/**
 * Check if a given object implements the UiNodeImageAttributes interface.
 */
export function instanceOfUiNodeImageAttributes(value: object): value is UiNodeImageAttributes {
    if (!('height' in value) || value['height'] === undefined) return false;
    if (!('id' in value) || value['id'] === undefined) return false;
    if (!('node_type' in value) || value['node_type'] === undefined) return false;
    if (!('src' in value) || value['src'] === undefined) return false;
    if (!('width' in value) || value['width'] === undefined) return false;
    return true;
}

export function UiNodeImageAttributesFromJSON(json: any): UiNodeImageAttributes {
    return UiNodeImageAttributesFromJSONTyped(json, false);
}

export function UiNodeImageAttributesFromJSONTyped(json: any, ignoreDiscriminator: boolean): UiNodeImageAttributes {
    if (json == null) {
        return json;
    }
    return {
        
        'height': json['height'],
        'id': json['id'],
        'node_type': json['node_type'],
        'src': json['src'],
        'width': json['width'],
    };
}

export function UiNodeImageAttributesToJSON(value?: UiNodeImageAttributes | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'height': value['height'],
        'id': value['id'],
        'node_type': value['node_type'],
        'src': value['src'],
        'width': value['width'],
    };
}

