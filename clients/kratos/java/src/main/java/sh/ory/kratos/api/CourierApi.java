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

import sh.ory.kratos.ApiCallback;
import sh.ory.kratos.ApiClient;
import sh.ory.kratos.ApiException;
import sh.ory.kratos.ApiResponse;
import sh.ory.kratos.Configuration;
import sh.ory.kratos.Pair;
import sh.ory.kratos.ProgressRequestBody;
import sh.ory.kratos.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import sh.ory.kratos.model.CourierMessageStatus;
import sh.ory.kratos.model.ErrorGeneric;
import sh.ory.kratos.model.Message;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class CourierApi {
    private ApiClient localVarApiClient;
    private int localHostIndex;
    private String localCustomBaseUrl;

    public CourierApi() {
        this(Configuration.getDefaultApiClient());
    }

    public CourierApi(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return localVarApiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    public int getHostIndex() {
        return localHostIndex;
    }

    public void setHostIndex(int hostIndex) {
        this.localHostIndex = hostIndex;
    }

    public String getCustomBaseUrl() {
        return localCustomBaseUrl;
    }

    public void setCustomBaseUrl(String customBaseUrl) {
        this.localCustomBaseUrl = customBaseUrl;
    }

    /**
     * Build call for getCourierMessage
     * @param id MessageID is the ID of the message. (required)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> message </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> errorGeneric </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> errorGeneric </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call getCourierMessageCall(String id, final ApiCallback _callback) throws ApiException {
        String basePath = null;
        // Operation Servers
        String[] localBasePaths = new String[] {  };

        // Determine Base Path to Use
        if (localCustomBaseUrl != null){
            basePath = localCustomBaseUrl;
        } else if ( localBasePaths.length > 0 ) {
            basePath = localBasePaths[localHostIndex];
        } else {
            basePath = null;
        }

        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/admin/courier/messages/{id}"
            .replace("{" + "id" + "}", localVarApiClient.escapeString(id.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        if (localVarContentType != null) {
            localVarHeaderParams.put("Content-Type", localVarContentType);
        }

        String[] localVarAuthNames = new String[] { "oryAccessToken" };
        return localVarApiClient.buildCall(basePath, localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call getCourierMessageValidateBeforeCall(String id, final ApiCallback _callback) throws ApiException {
        // verify the required parameter 'id' is set
        if (id == null) {
            throw new ApiException("Missing the required parameter 'id' when calling getCourierMessage(Async)");
        }

        return getCourierMessageCall(id, _callback);

    }

    /**
     * Get a Message
     * Gets a specific messages by the given ID.
     * @param id MessageID is the ID of the message. (required)
     * @return Message
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> message </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> errorGeneric </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> errorGeneric </td><td>  -  </td></tr>
     </table>
     */
    public Message getCourierMessage(String id) throws ApiException {
        ApiResponse<Message> localVarResp = getCourierMessageWithHttpInfo(id);
        return localVarResp.getData();
    }

    /**
     * Get a Message
     * Gets a specific messages by the given ID.
     * @param id MessageID is the ID of the message. (required)
     * @return ApiResponse&lt;Message&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> message </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> errorGeneric </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> errorGeneric </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<Message> getCourierMessageWithHttpInfo(String id) throws ApiException {
        okhttp3.Call localVarCall = getCourierMessageValidateBeforeCall(id, null);
        Type localVarReturnType = new TypeToken<Message>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    /**
     * Get a Message (asynchronously)
     * Gets a specific messages by the given ID.
     * @param id MessageID is the ID of the message. (required)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> message </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> errorGeneric </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> errorGeneric </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call getCourierMessageAsync(String id, final ApiCallback<Message> _callback) throws ApiException {

        okhttp3.Call localVarCall = getCourierMessageValidateBeforeCall(id, _callback);
        Type localVarReturnType = new TypeToken<Message>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }
    /**
     * Build call for listCourierMessages
     * @param pageSize Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)
     * @param pageToken Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)
     * @param status Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)
     * @param recipient Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> Paginated Courier Message List Response </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> errorGeneric </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> errorGeneric </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call listCourierMessagesCall(Long pageSize, String pageToken, CourierMessageStatus status, String recipient, final ApiCallback _callback) throws ApiException {
        String basePath = null;
        // Operation Servers
        String[] localBasePaths = new String[] {  };

        // Determine Base Path to Use
        if (localCustomBaseUrl != null){
            basePath = localCustomBaseUrl;
        } else if ( localBasePaths.length > 0 ) {
            basePath = localBasePaths[localHostIndex];
        } else {
            basePath = null;
        }

        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/admin/courier/messages";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        if (pageSize != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("page_size", pageSize));
        }

        if (pageToken != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("page_token", pageToken));
        }

        if (status != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("status", status));
        }

        if (recipient != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("recipient", recipient));
        }

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        if (localVarContentType != null) {
            localVarHeaderParams.put("Content-Type", localVarContentType);
        }

        String[] localVarAuthNames = new String[] { "oryAccessToken" };
        return localVarApiClient.buildCall(basePath, localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call listCourierMessagesValidateBeforeCall(Long pageSize, String pageToken, CourierMessageStatus status, String recipient, final ApiCallback _callback) throws ApiException {
        return listCourierMessagesCall(pageSize, pageToken, status, recipient, _callback);

    }

    /**
     * List Messages
     * Lists all messages by given status and recipient.
     * @param pageSize Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)
     * @param pageToken Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)
     * @param status Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)
     * @param recipient Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)
     * @return List&lt;Message&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> Paginated Courier Message List Response </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> errorGeneric </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> errorGeneric </td><td>  -  </td></tr>
     </table>
     */
    public List<Message> listCourierMessages(Long pageSize, String pageToken, CourierMessageStatus status, String recipient) throws ApiException {
        ApiResponse<List<Message>> localVarResp = listCourierMessagesWithHttpInfo(pageSize, pageToken, status, recipient);
        return localVarResp.getData();
    }

    /**
     * List Messages
     * Lists all messages by given status and recipient.
     * @param pageSize Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)
     * @param pageToken Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)
     * @param status Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)
     * @param recipient Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)
     * @return ApiResponse&lt;List&lt;Message&gt;&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> Paginated Courier Message List Response </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> errorGeneric </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> errorGeneric </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<List<Message>> listCourierMessagesWithHttpInfo(Long pageSize, String pageToken, CourierMessageStatus status, String recipient) throws ApiException {
        okhttp3.Call localVarCall = listCourierMessagesValidateBeforeCall(pageSize, pageToken, status, recipient, null);
        Type localVarReturnType = new TypeToken<List<Message>>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    /**
     * List Messages (asynchronously)
     * Lists all messages by given status and recipient.
     * @param pageSize Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)
     * @param pageToken Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)
     * @param status Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)
     * @param recipient Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> Paginated Courier Message List Response </td><td>  -  </td></tr>
        <tr><td> 400 </td><td> errorGeneric </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> errorGeneric </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call listCourierMessagesAsync(Long pageSize, String pageToken, CourierMessageStatus status, String recipient, final ApiCallback<List<Message>> _callback) throws ApiException {

        okhttp3.Call localVarCall = listCourierMessagesValidateBeforeCall(pageSize, pageToken, status, recipient, _callback);
        Type localVarReturnType = new TypeToken<List<Message>>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }
}
