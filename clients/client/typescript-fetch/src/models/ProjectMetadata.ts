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
import type { Workspace } from './Workspace';
import {
    WorkspaceFromJSON,
    WorkspaceFromJSONTyped,
    WorkspaceToJSON,
} from './Workspace';

/**
 * 
 * @export
 * @interface ProjectMetadata
 */
export interface ProjectMetadata {
    /**
     * The Project's Creation Date
     * @type {Date}
     * @memberof ProjectMetadata
     */
    created_at: Date;
    /**
     * The environment of the project.
     * prod Production
     * stage Staging
     * dev Development
     * @type {string}
     * @memberof ProjectMetadata
     */
    environment: ProjectMetadataEnvironmentEnum;
    /**
     * The project's data home region
     * eu-central EUCentral
     * us-east USEast
     * us-west USWest
     * global Global
     * @type {string}
     * @memberof ProjectMetadata
     */
    home_region: ProjectMetadataHomeRegionEnum;
    /**
     * 
     * @type {Array<string>}
     * @memberof ProjectMetadata
     */
    hosts: Array<string>;
    /**
     * The project's ID.
     * @type {string}
     * @memberof ProjectMetadata
     */
    readonly id: string;
    /**
     * The project's name if set
     * @type {string}
     * @memberof ProjectMetadata
     */
    name: string;
    /**
     * The project's slug
     * @type {string}
     * @memberof ProjectMetadata
     */
    readonly slug: string;
    /**
     * The state of the project.
     * running Running
     * halted Halted
     * deleted Deleted
     * @type {string}
     * @memberof ProjectMetadata
     */
    state: ProjectMetadataStateEnum;
    /**
     * 
     * @type {string}
     * @memberof ProjectMetadata
     */
    subscription_id?: string;
    /**
     * 
     * @type {string}
     * @memberof ProjectMetadata
     */
    subscription_plan?: string;
    /**
     * Last Time Project was Updated
     * @type {Date}
     * @memberof ProjectMetadata
     */
    updated_at: Date;
    /**
     * 
     * @type {Workspace}
     * @memberof ProjectMetadata
     */
    workspace?: Workspace;
    /**
     * 
     * @type {string}
     * @memberof ProjectMetadata
     */
    workspace_id?: string;
}


/**
 * @export
 */
export const ProjectMetadataEnvironmentEnum = {
    Prod: 'prod',
    Stage: 'stage',
    Dev: 'dev'
} as const;
export type ProjectMetadataEnvironmentEnum = typeof ProjectMetadataEnvironmentEnum[keyof typeof ProjectMetadataEnvironmentEnum];

/**
 * @export
 */
export const ProjectMetadataHomeRegionEnum = {
    EuCentral: 'eu-central',
    UsEast: 'us-east',
    UsWest: 'us-west',
    Global: 'global'
} as const;
export type ProjectMetadataHomeRegionEnum = typeof ProjectMetadataHomeRegionEnum[keyof typeof ProjectMetadataHomeRegionEnum];

/**
 * @export
 */
export const ProjectMetadataStateEnum = {
    Running: 'running',
    Halted: 'halted',
    Deleted: 'deleted'
} as const;
export type ProjectMetadataStateEnum = typeof ProjectMetadataStateEnum[keyof typeof ProjectMetadataStateEnum];


/**
 * Check if a given object implements the ProjectMetadata interface.
 */
export function instanceOfProjectMetadata(value: object): boolean {
    if (!('created_at' in value)) return false;
    if (!('environment' in value)) return false;
    if (!('home_region' in value)) return false;
    if (!('hosts' in value)) return false;
    if (!('id' in value)) return false;
    if (!('name' in value)) return false;
    if (!('slug' in value)) return false;
    if (!('state' in value)) return false;
    if (!('updated_at' in value)) return false;
    return true;
}

export function ProjectMetadataFromJSON(json: any): ProjectMetadata {
    return ProjectMetadataFromJSONTyped(json, false);
}

export function ProjectMetadataFromJSONTyped(json: any, ignoreDiscriminator: boolean): ProjectMetadata {
    if (json == null) {
        return json;
    }
    return {
        
        'created_at': (new Date(json['created_at'])),
        'environment': json['environment'],
        'home_region': json['home_region'],
        'hosts': json['hosts'],
        'id': json['id'],
        'name': json['name'],
        'slug': json['slug'],
        'state': json['state'],
        'subscription_id': json['subscription_id'] == null ? undefined : json['subscription_id'],
        'subscription_plan': json['subscription_plan'] == null ? undefined : json['subscription_plan'],
        'updated_at': (new Date(json['updated_at'])),
        'workspace': json['workspace'] == null ? undefined : WorkspaceFromJSON(json['workspace']),
        'workspace_id': json['workspace_id'] == null ? undefined : json['workspace_id'],
    };
}

export function ProjectMetadataToJSON(value?: ProjectMetadata | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'created_at': ((value['created_at']).toISOString()),
        'environment': value['environment'],
        'home_region': value['home_region'],
        'hosts': value['hosts'],
        'name': value['name'],
        'state': value['state'],
        'subscription_id': value['subscription_id'],
        'subscription_plan': value['subscription_plan'],
        'updated_at': ((value['updated_at']).toISOString()),
        'workspace': WorkspaceToJSON(value['workspace']),
        'workspace_id': value['workspace_id'],
    };
}

