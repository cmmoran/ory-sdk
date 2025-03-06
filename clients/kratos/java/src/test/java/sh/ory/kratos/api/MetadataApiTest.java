/*
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


package sh.ory.kratos.api;

import sh.ory.kratos.ApiException;
import sh.ory.kratos.model.GetVersion200Response;
import sh.ory.kratos.model.IsAlive200Response;
import sh.ory.kratos.model.IsReady503Response;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for MetadataApi
 */
@Disabled
public class MetadataApiTest {

    private final MetadataApi api = new MetadataApi();

    /**
     * Return Running Software Version.
     *
     * This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getVersionTest() throws ApiException {
        GetVersion200Response response = api.getVersion();
        // TODO: test validations
    }

    /**
     * Check HTTP Server Status
     *
     * This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void isAliveTest() throws ApiException {
        IsAlive200Response response = api.isAlive();
        // TODO: test validations
    }

    /**
     * Check HTTP Server and Database Status
     *
     * This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void isReadyTest() throws ApiException {
        IsAlive200Response response = api.isReady();
        // TODO: test validations
    }

}
