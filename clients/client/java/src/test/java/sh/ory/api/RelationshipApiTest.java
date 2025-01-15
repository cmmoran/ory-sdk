/*
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


package sh.ory.api;

import sh.ory.ApiException;
import sh.ory.model.CheckOplSyntaxResult;
import sh.ory.model.CreateRelationshipBody;
import sh.ory.model.ErrorGeneric;
import sh.ory.model.Relationship;
import sh.ory.model.RelationshipNamespaces;
import sh.ory.model.RelationshipPatch;
import sh.ory.model.Relationships;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for RelationshipApi
 */
@Disabled
public class RelationshipApiTest {

    private final RelationshipApi api = new RelationshipApi();

    /**
     * Check the syntax of an OPL file
     *
     * The OPL file is expected in the body of the request.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void checkOplSyntaxTest() throws ApiException {
        String body = null;
        CheckOplSyntaxResult response = api.checkOplSyntax(body);
        // TODO: test validations
    }

    /**
     * Create a Relationship
     *
     * Use this endpoint to create a relationship.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void createRelationshipTest() throws ApiException {
        CreateRelationshipBody createRelationshipBody = null;
        Relationship response = api.createRelationship(createRelationshipBody);
        // TODO: test validations
    }

    /**
     * Delete Relationships
     *
     * Use this endpoint to delete relationships
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void deleteRelationshipsTest() throws ApiException {
        String namespace = null;
        String _object = null;
        String relation = null;
        String subjectId = null;
        String subjectSetNamespace = null;
        String subjectSetObject = null;
        String subjectSetRelation = null;
        api.deleteRelationships(namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
        // TODO: test validations
    }

    /**
     * Query relationships
     *
     * Get all relationships that match the query. Only the namespace field is required.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getRelationshipsTest() throws ApiException {
        String pageToken = null;
        Long pageSize = null;
        String namespace = null;
        String _object = null;
        String relation = null;
        String subjectId = null;
        String subjectSetNamespace = null;
        String subjectSetObject = null;
        String subjectSetRelation = null;
        Relationships response = api.getRelationships(pageToken, pageSize, namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
        // TODO: test validations
    }

    /**
     * Query namespaces
     *
     * Get all namespaces
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void listRelationshipNamespacesTest() throws ApiException {
        RelationshipNamespaces response = api.listRelationshipNamespaces();
        // TODO: test validations
    }

    /**
     * Patch Multiple Relationships
     *
     * Use this endpoint to patch one or more relationships.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void patchRelationshipsTest() throws ApiException {
        List<RelationshipPatch> relationshipPatch = null;
        api.patchRelationships(relationshipPatch);
        // TODO: test validations
    }

}
