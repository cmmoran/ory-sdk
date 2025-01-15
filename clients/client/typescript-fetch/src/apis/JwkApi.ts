/* tslint:disable */
/* eslint-disable */
/**
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.1
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


import * as runtime from '../runtime';
import type {
  CreateJsonWebKeySet,
  ErrorOAuth2,
  JsonWebKey,
  JsonWebKeySet,
} from '../models/index';
import {
    CreateJsonWebKeySetFromJSON,
    CreateJsonWebKeySetToJSON,
    ErrorOAuth2FromJSON,
    ErrorOAuth2ToJSON,
    JsonWebKeyFromJSON,
    JsonWebKeyToJSON,
    JsonWebKeySetFromJSON,
    JsonWebKeySetToJSON,
} from '../models/index';

export interface CreateJsonWebKeySetRequest {
    set: string;
    createJsonWebKeySet: CreateJsonWebKeySet;
}

export interface DeleteJsonWebKeyRequest {
    set: string;
    kid: string;
}

export interface DeleteJsonWebKeySetRequest {
    set: string;
}

export interface GetJsonWebKeyRequest {
    set: string;
    kid: string;
}

export interface GetJsonWebKeySetRequest {
    set: string;
}

export interface SetJsonWebKeyRequest {
    set: string;
    kid: string;
    jsonWebKey?: JsonWebKey;
}

export interface SetJsonWebKeySetRequest {
    set: string;
    jsonWebKeySet?: JsonWebKeySet;
}

/**
 * 
 */
export class JwkApi extends runtime.BaseAPI {

    /**
     * This endpoint is capable of generating JSON Web Key Sets for you. There a different strategies available, such as symmetric cryptographic keys (HS256, HS512) and asymetric cryptographic keys (RS256, ECDSA). If the specified JSON Web Key Set does not exist, it will be created.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Create JSON Web Key
     */
    async createJsonWebKeySetRaw(requestParameters: CreateJsonWebKeySetRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<JsonWebKeySet>> {
        if (requestParameters['set'] == null) {
            throw new runtime.RequiredError(
                'set',
                'Required parameter "set" was null or undefined when calling createJsonWebKeySet().'
            );
        }

        if (requestParameters['createJsonWebKeySet'] == null) {
            throw new runtime.RequiredError(
                'createJsonWebKeySet',
                'Required parameter "createJsonWebKeySet" was null or undefined when calling createJsonWebKeySet().'
            );
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.accessToken) {
            const token = this.configuration.accessToken;
            const tokenString = await token("oryAccessToken", []);

            if (tokenString) {
                headerParameters["Authorization"] = `Bearer ${tokenString}`;
            }
        }
        const response = await this.request({
            path: `/admin/keys/{set}`.replace(`{${"set"}}`, encodeURIComponent(String(requestParameters['set']))),
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CreateJsonWebKeySetToJSON(requestParameters['createJsonWebKeySet']),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => JsonWebKeySetFromJSON(jsonValue));
    }

    /**
     * This endpoint is capable of generating JSON Web Key Sets for you. There a different strategies available, such as symmetric cryptographic keys (HS256, HS512) and asymetric cryptographic keys (RS256, ECDSA). If the specified JSON Web Key Set does not exist, it will be created.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Create JSON Web Key
     */
    async createJsonWebKeySet(requestParameters: CreateJsonWebKeySetRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<JsonWebKeySet> {
        const response = await this.createJsonWebKeySetRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Use this endpoint to delete a single JSON Web Key.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Delete JSON Web Key
     */
    async deleteJsonWebKeyRaw(requestParameters: DeleteJsonWebKeyRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<void>> {
        if (requestParameters['set'] == null) {
            throw new runtime.RequiredError(
                'set',
                'Required parameter "set" was null or undefined when calling deleteJsonWebKey().'
            );
        }

        if (requestParameters['kid'] == null) {
            throw new runtime.RequiredError(
                'kid',
                'Required parameter "kid" was null or undefined when calling deleteJsonWebKey().'
            );
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.accessToken) {
            const token = this.configuration.accessToken;
            const tokenString = await token("oryAccessToken", []);

            if (tokenString) {
                headerParameters["Authorization"] = `Bearer ${tokenString}`;
            }
        }
        const response = await this.request({
            path: `/admin/keys/{set}/{kid}`.replace(`{${"set"}}`, encodeURIComponent(String(requestParameters['set']))).replace(`{${"kid"}}`, encodeURIComponent(String(requestParameters['kid']))),
            method: 'DELETE',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.VoidApiResponse(response);
    }

    /**
     * Use this endpoint to delete a single JSON Web Key.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Delete JSON Web Key
     */
    async deleteJsonWebKey(requestParameters: DeleteJsonWebKeyRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<void> {
        await this.deleteJsonWebKeyRaw(requestParameters, initOverrides);
    }

    /**
     * Use this endpoint to delete a complete JSON Web Key Set and all the keys in that set.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Delete JSON Web Key Set
     */
    async deleteJsonWebKeySetRaw(requestParameters: DeleteJsonWebKeySetRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<void>> {
        if (requestParameters['set'] == null) {
            throw new runtime.RequiredError(
                'set',
                'Required parameter "set" was null or undefined when calling deleteJsonWebKeySet().'
            );
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.accessToken) {
            const token = this.configuration.accessToken;
            const tokenString = await token("oryAccessToken", []);

            if (tokenString) {
                headerParameters["Authorization"] = `Bearer ${tokenString}`;
            }
        }
        const response = await this.request({
            path: `/admin/keys/{set}`.replace(`{${"set"}}`, encodeURIComponent(String(requestParameters['set']))),
            method: 'DELETE',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.VoidApiResponse(response);
    }

    /**
     * Use this endpoint to delete a complete JSON Web Key Set and all the keys in that set.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Delete JSON Web Key Set
     */
    async deleteJsonWebKeySet(requestParameters: DeleteJsonWebKeySetRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<void> {
        await this.deleteJsonWebKeySetRaw(requestParameters, initOverrides);
    }

    /**
     * This endpoint returns a singular JSON Web Key contained in a set. It is identified by the set and the specific key ID (kid).
     * Get JSON Web Key
     */
    async getJsonWebKeyRaw(requestParameters: GetJsonWebKeyRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<JsonWebKeySet>> {
        if (requestParameters['set'] == null) {
            throw new runtime.RequiredError(
                'set',
                'Required parameter "set" was null or undefined when calling getJsonWebKey().'
            );
        }

        if (requestParameters['kid'] == null) {
            throw new runtime.RequiredError(
                'kid',
                'Required parameter "kid" was null or undefined when calling getJsonWebKey().'
            );
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.accessToken) {
            const token = this.configuration.accessToken;
            const tokenString = await token("oryAccessToken", []);

            if (tokenString) {
                headerParameters["Authorization"] = `Bearer ${tokenString}`;
            }
        }
        const response = await this.request({
            path: `/admin/keys/{set}/{kid}`.replace(`{${"set"}}`, encodeURIComponent(String(requestParameters['set']))).replace(`{${"kid"}}`, encodeURIComponent(String(requestParameters['kid']))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => JsonWebKeySetFromJSON(jsonValue));
    }

    /**
     * This endpoint returns a singular JSON Web Key contained in a set. It is identified by the set and the specific key ID (kid).
     * Get JSON Web Key
     */
    async getJsonWebKey(requestParameters: GetJsonWebKeyRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<JsonWebKeySet> {
        const response = await this.getJsonWebKeyRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * This endpoint can be used to retrieve JWK Sets stored in ORY Hydra.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Retrieve a JSON Web Key Set
     */
    async getJsonWebKeySetRaw(requestParameters: GetJsonWebKeySetRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<JsonWebKeySet>> {
        if (requestParameters['set'] == null) {
            throw new runtime.RequiredError(
                'set',
                'Required parameter "set" was null or undefined when calling getJsonWebKeySet().'
            );
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.accessToken) {
            const token = this.configuration.accessToken;
            const tokenString = await token("oryAccessToken", []);

            if (tokenString) {
                headerParameters["Authorization"] = `Bearer ${tokenString}`;
            }
        }
        const response = await this.request({
            path: `/admin/keys/{set}`.replace(`{${"set"}}`, encodeURIComponent(String(requestParameters['set']))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => JsonWebKeySetFromJSON(jsonValue));
    }

    /**
     * This endpoint can be used to retrieve JWK Sets stored in ORY Hydra.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Retrieve a JSON Web Key Set
     */
    async getJsonWebKeySet(requestParameters: GetJsonWebKeySetRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<JsonWebKeySet> {
        const response = await this.getJsonWebKeySetRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Use this method if you do not want to let Hydra generate the JWKs for you, but instead save your own.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Set JSON Web Key
     */
    async setJsonWebKeyRaw(requestParameters: SetJsonWebKeyRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<JsonWebKey>> {
        if (requestParameters['set'] == null) {
            throw new runtime.RequiredError(
                'set',
                'Required parameter "set" was null or undefined when calling setJsonWebKey().'
            );
        }

        if (requestParameters['kid'] == null) {
            throw new runtime.RequiredError(
                'kid',
                'Required parameter "kid" was null or undefined when calling setJsonWebKey().'
            );
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.accessToken) {
            const token = this.configuration.accessToken;
            const tokenString = await token("oryAccessToken", []);

            if (tokenString) {
                headerParameters["Authorization"] = `Bearer ${tokenString}`;
            }
        }
        const response = await this.request({
            path: `/admin/keys/{set}/{kid}`.replace(`{${"set"}}`, encodeURIComponent(String(requestParameters['set']))).replace(`{${"kid"}}`, encodeURIComponent(String(requestParameters['kid']))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: JsonWebKeyToJSON(requestParameters['jsonWebKey']),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => JsonWebKeyFromJSON(jsonValue));
    }

    /**
     * Use this method if you do not want to let Hydra generate the JWKs for you, but instead save your own.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Set JSON Web Key
     */
    async setJsonWebKey(requestParameters: SetJsonWebKeyRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<JsonWebKey> {
        const response = await this.setJsonWebKeyRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Use this method if you do not want to let Hydra generate the JWKs for you, but instead save your own.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Update a JSON Web Key Set
     */
    async setJsonWebKeySetRaw(requestParameters: SetJsonWebKeySetRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<JsonWebKeySet>> {
        if (requestParameters['set'] == null) {
            throw new runtime.RequiredError(
                'set',
                'Required parameter "set" was null or undefined when calling setJsonWebKeySet().'
            );
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.accessToken) {
            const token = this.configuration.accessToken;
            const tokenString = await token("oryAccessToken", []);

            if (tokenString) {
                headerParameters["Authorization"] = `Bearer ${tokenString}`;
            }
        }
        const response = await this.request({
            path: `/admin/keys/{set}`.replace(`{${"set"}}`, encodeURIComponent(String(requestParameters['set']))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: JsonWebKeySetToJSON(requestParameters['jsonWebKeySet']),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => JsonWebKeySetFromJSON(jsonValue));
    }

    /**
     * Use this method if you do not want to let Hydra generate the JWKs for you, but instead save your own.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
     * Update a JSON Web Key Set
     */
    async setJsonWebKeySet(requestParameters: SetJsonWebKeySetRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<JsonWebKeySet> {
        const response = await this.setJsonWebKeySetRaw(requestParameters, initOverrides);
        return await response.value();
    }

}
