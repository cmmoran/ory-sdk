/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.9
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { ProjectBrandingTheme } from './ProjectBrandingTheme';
import {
    ProjectBrandingThemeFromJSON,
    ProjectBrandingThemeFromJSONTyped,
    ProjectBrandingThemeToJSON,
} from './ProjectBrandingTheme';

/**
 * 
 * @export
 * @interface ProjectBranding
 */
export interface ProjectBranding {
    /**
     * The Customization Creation Date
     * @type {Date}
     * @memberof ProjectBranding
     */
    readonly created_at: Date;
    /**
     * 
     * @type {ProjectBrandingTheme}
     * @memberof ProjectBranding
     */
    default_theme: ProjectBrandingTheme;
    /**
     * The customization ID.
     * @type {string}
     * @memberof ProjectBranding
     */
    readonly id: string;
    /**
     * The Project's ID this customization is associated with
     * @type {string}
     * @memberof ProjectBranding
     */
    project_id: string;
    /**
     * 
     * @type {Array<ProjectBrandingTheme>}
     * @memberof ProjectBranding
     */
    themes: Array<ProjectBrandingTheme>;
    /**
     * Last Time Branding was Updated
     * @type {Date}
     * @memberof ProjectBranding
     */
    readonly updated_at: Date;
}

/**
 * Check if a given object implements the ProjectBranding interface.
 */
export function instanceOfProjectBranding(value: object): value is ProjectBranding {
    if (!('created_at' in value) || value['created_at'] === undefined) return false;
    if (!('default_theme' in value) || value['default_theme'] === undefined) return false;
    if (!('id' in value) || value['id'] === undefined) return false;
    if (!('project_id' in value) || value['project_id'] === undefined) return false;
    if (!('themes' in value) || value['themes'] === undefined) return false;
    if (!('updated_at' in value) || value['updated_at'] === undefined) return false;
    return true;
}

export function ProjectBrandingFromJSON(json: any): ProjectBranding {
    return ProjectBrandingFromJSONTyped(json, false);
}

export function ProjectBrandingFromJSONTyped(json: any, ignoreDiscriminator: boolean): ProjectBranding {
    if (json == null) {
        return json;
    }
    return {
        
        'created_at': (new Date(json['created_at'])),
        'default_theme': ProjectBrandingThemeFromJSON(json['default_theme']),
        'id': json['id'],
        'project_id': json['project_id'],
        'themes': ((json['themes'] as Array<any>).map(ProjectBrandingThemeFromJSON)),
        'updated_at': (new Date(json['updated_at'])),
    };
}

export function ProjectBrandingToJSON(value?: Omit<ProjectBranding, 'created_at'|'id'|'updated_at'> | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'default_theme': ProjectBrandingThemeToJSON(value['default_theme']),
        'project_id': value['project_id'],
        'themes': ((value['themes'] as Array<any>).map(ProjectBrandingThemeToJSON)),
    };
}

