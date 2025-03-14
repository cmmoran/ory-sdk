# kratos-client

Ory Identities API
- API version: v1.4.0-alpha.0
  - Build date: 2025-03-06T19:15:57.465639357Z[Etc/UTC]
  - Generator version: 7.7.0

This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more.



*Automatically generated by the [OpenAPI Generator](https://openapi-generator.tech)*


## Requirements

Building the API client library requires:
1. Java 1.8+
2. Maven (3.8.3+)/Gradle (7.2+)

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn clean install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn clean deploy
```

Refer to the [OSSRH Guide](http://central.sonatype.org/pages/ossrh-guide.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
  <groupId>sh.ory.kratos</groupId>
  <artifactId>kratos-client</artifactId>
  <version>v1.4.0-alpha.0</version>
  <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
  repositories {
    mavenCentral()     // Needed if the 'kratos-client' jar has been published to maven central.
    mavenLocal()       // Needed if the 'kratos-client' jar has been published to the local maven repo.
  }

  dependencies {
     implementation "sh.ory.kratos:kratos-client:v1.4.0-alpha.0"
  }
```

### Others

At first generate the JAR by executing:

```shell
mvn clean package
```

Then manually install the following JARs:

* `target/kratos-client-v1.4.0-alpha.0.jar`
* `target/lib/*.jar`

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

// Import classes:
import sh.ory.kratos.ApiClient;
import sh.ory.kratos.ApiException;
import sh.ory.kratos.Configuration;
import sh.ory.kratos.auth.*;
import sh.ory.kratos.models.*;
import sh.ory.kratos.api.CourierApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://localhost");
    
    // Configure API key authorization: oryAccessToken
    ApiKeyAuth oryAccessToken = (ApiKeyAuth) defaultClient.getAuthentication("oryAccessToken");
    oryAccessToken.setApiKey("YOUR API KEY");
    // Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
    //oryAccessToken.setApiKeyPrefix("Token");

    CourierApi apiInstance = new CourierApi(defaultClient);
    String id = "id_example"; // String | MessageID is the ID of the message.
    try {
      Message result = apiInstance.getCourierMessage(id);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling CourierApi#getCourierMessage");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}

```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CourierApi* | [**getCourierMessage**](docs/CourierApi.md#getCourierMessage) | **GET** /admin/courier/messages/{id} | Get a Message
*CourierApi* | [**listCourierMessages**](docs/CourierApi.md#listCourierMessages) | **GET** /admin/courier/messages | List Messages
*FrontendApi* | [**createBrowserLoginFlow**](docs/FrontendApi.md#createBrowserLoginFlow) | **GET** /self-service/login/browser | Create Login Flow for Browsers
*FrontendApi* | [**createBrowserLogoutFlow**](docs/FrontendApi.md#createBrowserLogoutFlow) | **GET** /self-service/logout/browser | Create a Logout URL for Browsers
*FrontendApi* | [**createBrowserRecoveryFlow**](docs/FrontendApi.md#createBrowserRecoveryFlow) | **GET** /self-service/recovery/browser | Create Recovery Flow for Browsers
*FrontendApi* | [**createBrowserRegistrationFlow**](docs/FrontendApi.md#createBrowserRegistrationFlow) | **GET** /self-service/registration/browser | Create Registration Flow for Browsers
*FrontendApi* | [**createBrowserSettingsFlow**](docs/FrontendApi.md#createBrowserSettingsFlow) | **GET** /self-service/settings/browser | Create Settings Flow for Browsers
*FrontendApi* | [**createBrowserVerificationFlow**](docs/FrontendApi.md#createBrowserVerificationFlow) | **GET** /self-service/verification/browser | Create Verification Flow for Browser Clients
*FrontendApi* | [**createFedcmFlow**](docs/FrontendApi.md#createFedcmFlow) | **GET** /self-service/fed-cm/parameters | Get FedCM Parameters
*FrontendApi* | [**createNativeLoginFlow**](docs/FrontendApi.md#createNativeLoginFlow) | **GET** /self-service/login/api | Create Login Flow for Native Apps
*FrontendApi* | [**createNativeRecoveryFlow**](docs/FrontendApi.md#createNativeRecoveryFlow) | **GET** /self-service/recovery/api | Create Recovery Flow for Native Apps
*FrontendApi* | [**createNativeRegistrationFlow**](docs/FrontendApi.md#createNativeRegistrationFlow) | **GET** /self-service/registration/api | Create Registration Flow for Native Apps
*FrontendApi* | [**createNativeSettingsFlow**](docs/FrontendApi.md#createNativeSettingsFlow) | **GET** /self-service/settings/api | Create Settings Flow for Native Apps
*FrontendApi* | [**createNativeVerificationFlow**](docs/FrontendApi.md#createNativeVerificationFlow) | **GET** /self-service/verification/api | Create Verification Flow for Native Apps
*FrontendApi* | [**disableMyOtherSessions**](docs/FrontendApi.md#disableMyOtherSessions) | **DELETE** /sessions | Disable my other sessions
*FrontendApi* | [**disableMySession**](docs/FrontendApi.md#disableMySession) | **DELETE** /sessions/{id} | Disable one of my sessions
*FrontendApi* | [**exchangeSessionToken**](docs/FrontendApi.md#exchangeSessionToken) | **GET** /sessions/token-exchange | Exchange Session Token
*FrontendApi* | [**getFlowError**](docs/FrontendApi.md#getFlowError) | **GET** /self-service/errors | Get User-Flow Errors
*FrontendApi* | [**getLoginFlow**](docs/FrontendApi.md#getLoginFlow) | **GET** /self-service/login/flows | Get Login Flow
*FrontendApi* | [**getRecoveryFlow**](docs/FrontendApi.md#getRecoveryFlow) | **GET** /self-service/recovery/flows | Get Recovery Flow
*FrontendApi* | [**getRegistrationFlow**](docs/FrontendApi.md#getRegistrationFlow) | **GET** /self-service/registration/flows | Get Registration Flow
*FrontendApi* | [**getSettingsFlow**](docs/FrontendApi.md#getSettingsFlow) | **GET** /self-service/settings/flows | Get Settings Flow
*FrontendApi* | [**getVerificationFlow**](docs/FrontendApi.md#getVerificationFlow) | **GET** /self-service/verification/flows | Get Verification Flow
*FrontendApi* | [**getWebAuthnJavaScript**](docs/FrontendApi.md#getWebAuthnJavaScript) | **GET** /.well-known/ory/webauthn.js | Get WebAuthn JavaScript
*FrontendApi* | [**listMySessions**](docs/FrontendApi.md#listMySessions) | **GET** /sessions | Get My Active Sessions
*FrontendApi* | [**performNativeLogout**](docs/FrontendApi.md#performNativeLogout) | **DELETE** /self-service/logout/api | Perform Logout for Native Apps
*FrontendApi* | [**toSession**](docs/FrontendApi.md#toSession) | **GET** /sessions/whoami | Check Who the Current HTTP Session Belongs To
*FrontendApi* | [**updateFedcmFlow**](docs/FrontendApi.md#updateFedcmFlow) | **POST** /self-service/fed-cm/token | Submit a FedCM token
*FrontendApi* | [**updateLoginFlow**](docs/FrontendApi.md#updateLoginFlow) | **POST** /self-service/login | Submit a Login Flow
*FrontendApi* | [**updateLogoutFlow**](docs/FrontendApi.md#updateLogoutFlow) | **GET** /self-service/logout | Update Logout Flow
*FrontendApi* | [**updateRecoveryFlow**](docs/FrontendApi.md#updateRecoveryFlow) | **POST** /self-service/recovery | Update Recovery Flow
*FrontendApi* | [**updateRegistrationFlow**](docs/FrontendApi.md#updateRegistrationFlow) | **POST** /self-service/registration | Update Registration Flow
*FrontendApi* | [**updateSettingsFlow**](docs/FrontendApi.md#updateSettingsFlow) | **POST** /self-service/settings | Complete Settings Flow
*FrontendApi* | [**updateVerificationFlow**](docs/FrontendApi.md#updateVerificationFlow) | **POST** /self-service/verification | Complete Verification Flow
*IdentityApi* | [**batchPatchIdentities**](docs/IdentityApi.md#batchPatchIdentities) | **PATCH** /admin/identities | Create multiple identities
*IdentityApi* | [**createIdentity**](docs/IdentityApi.md#createIdentity) | **POST** /admin/identities | Create an Identity
*IdentityApi* | [**createRecoveryCodeForIdentity**](docs/IdentityApi.md#createRecoveryCodeForIdentity) | **POST** /admin/recovery/code | Create a Recovery Code
*IdentityApi* | [**createRecoveryLinkForIdentity**](docs/IdentityApi.md#createRecoveryLinkForIdentity) | **POST** /admin/recovery/link | Create a Recovery Link
*IdentityApi* | [**deleteIdentity**](docs/IdentityApi.md#deleteIdentity) | **DELETE** /admin/identities/{id} | Delete an Identity
*IdentityApi* | [**deleteIdentityCredentials**](docs/IdentityApi.md#deleteIdentityCredentials) | **DELETE** /admin/identities/{id}/credentials/{type} | Delete a credential for a specific identity
*IdentityApi* | [**deleteIdentitySessions**](docs/IdentityApi.md#deleteIdentitySessions) | **DELETE** /admin/identities/{id}/sessions | Delete &amp; Invalidate an Identity&#39;s Sessions
*IdentityApi* | [**disableSession**](docs/IdentityApi.md#disableSession) | **DELETE** /admin/sessions/{id} | Deactivate a Session
*IdentityApi* | [**extendSession**](docs/IdentityApi.md#extendSession) | **PATCH** /admin/sessions/{id}/extend | Extend a Session
*IdentityApi* | [**getIdentity**](docs/IdentityApi.md#getIdentity) | **GET** /admin/identities/{id} | Get an Identity
*IdentityApi* | [**getIdentitySchema**](docs/IdentityApi.md#getIdentitySchema) | **GET** /schemas/{id} | Get Identity JSON Schema
*IdentityApi* | [**getSession**](docs/IdentityApi.md#getSession) | **GET** /admin/sessions/{id} | Get Session
*IdentityApi* | [**listIdentities**](docs/IdentityApi.md#listIdentities) | **GET** /admin/identities | List Identities
*IdentityApi* | [**listIdentityDevices**](docs/IdentityApi.md#listIdentityDevices) | **GET** /admin/identities/{id}/devices | List an Identity&#39;s trusted devices
*IdentityApi* | [**listIdentitySchemas**](docs/IdentityApi.md#listIdentitySchemas) | **GET** /schemas | Get all Identity Schemas
*IdentityApi* | [**listIdentitySessions**](docs/IdentityApi.md#listIdentitySessions) | **GET** /admin/identities/{id}/sessions | List an Identity&#39;s Sessions
*IdentityApi* | [**listSessions**](docs/IdentityApi.md#listSessions) | **GET** /admin/sessions | List All Sessions
*IdentityApi* | [**patchIdentity**](docs/IdentityApi.md#patchIdentity) | **PATCH** /admin/identities/{id} | Patch an Identity
*IdentityApi* | [**patchIdentityDevices**](docs/IdentityApi.md#patchIdentityDevices) | **PATCH** /admin/identities/{id}/devices/{device_id} | Patch an Identity&#39;s devices
*IdentityApi* | [**updateIdentity**](docs/IdentityApi.md#updateIdentity) | **PUT** /admin/identities/{id} | Update an Identity
*MetadataApi* | [**getVersion**](docs/MetadataApi.md#getVersion) | **GET** /version | Return Running Software Version.
*MetadataApi* | [**isAlive**](docs/MetadataApi.md#isAlive) | **GET** /health/alive | Check HTTP Server Status
*MetadataApi* | [**isReady**](docs/MetadataApi.md#isReady) | **GET** /health/ready | Check HTTP Server and Database Status


## Documentation for Models

 - [AuthenticatorAssuranceLevel](docs/AuthenticatorAssuranceLevel.md)
 - [BatchPatchIdentitiesResponse](docs/BatchPatchIdentitiesResponse.md)
 - [ConsistencyRequestParameters](docs/ConsistencyRequestParameters.md)
 - [ContinueWith](docs/ContinueWith.md)
 - [ContinueWithRecoveryUi](docs/ContinueWithRecoveryUi.md)
 - [ContinueWithRecoveryUiFlow](docs/ContinueWithRecoveryUiFlow.md)
 - [ContinueWithRedirectBrowserTo](docs/ContinueWithRedirectBrowserTo.md)
 - [ContinueWithSetOrySessionToken](docs/ContinueWithSetOrySessionToken.md)
 - [ContinueWithSettingsUi](docs/ContinueWithSettingsUi.md)
 - [ContinueWithSettingsUiFlow](docs/ContinueWithSettingsUiFlow.md)
 - [ContinueWithVerificationUi](docs/ContinueWithVerificationUi.md)
 - [ContinueWithVerificationUiFlow](docs/ContinueWithVerificationUiFlow.md)
 - [CourierMessageStatus](docs/CourierMessageStatus.md)
 - [CourierMessageType](docs/CourierMessageType.md)
 - [CreateFedcmFlowResponse](docs/CreateFedcmFlowResponse.md)
 - [CreateIdentityBody](docs/CreateIdentityBody.md)
 - [CreateRecoveryCodeForIdentityBody](docs/CreateRecoveryCodeForIdentityBody.md)
 - [CreateRecoveryLinkForIdentityBody](docs/CreateRecoveryLinkForIdentityBody.md)
 - [DeleteMySessionsCount](docs/DeleteMySessionsCount.md)
 - [ErrorAuthenticatorAssuranceLevelNotSatisfied](docs/ErrorAuthenticatorAssuranceLevelNotSatisfied.md)
 - [ErrorBrowserLocationChangeRequired](docs/ErrorBrowserLocationChangeRequired.md)
 - [ErrorFlowReplaced](docs/ErrorFlowReplaced.md)
 - [ErrorGeneric](docs/ErrorGeneric.md)
 - [FlowError](docs/FlowError.md)
 - [GenericError](docs/GenericError.md)
 - [GetVersion200Response](docs/GetVersion200Response.md)
 - [HealthNotReadyStatus](docs/HealthNotReadyStatus.md)
 - [HealthStatus](docs/HealthStatus.md)
 - [Identity](docs/Identity.md)
 - [IdentityCredentials](docs/IdentityCredentials.md)
 - [IdentityCredentialsCode](docs/IdentityCredentialsCode.md)
 - [IdentityCredentialsCodeAddress](docs/IdentityCredentialsCodeAddress.md)
 - [IdentityCredentialsOidc](docs/IdentityCredentialsOidc.md)
 - [IdentityCredentialsOidcProvider](docs/IdentityCredentialsOidcProvider.md)
 - [IdentityCredentialsPassword](docs/IdentityCredentialsPassword.md)
 - [IdentityPatch](docs/IdentityPatch.md)
 - [IdentityPatchResponse](docs/IdentityPatchResponse.md)
 - [IdentitySchemaContainer](docs/IdentitySchemaContainer.md)
 - [IdentityWithCredentials](docs/IdentityWithCredentials.md)
 - [IdentityWithCredentialsOidc](docs/IdentityWithCredentialsOidc.md)
 - [IdentityWithCredentialsOidcConfig](docs/IdentityWithCredentialsOidcConfig.md)
 - [IdentityWithCredentialsOidcConfigProvider](docs/IdentityWithCredentialsOidcConfigProvider.md)
 - [IdentityWithCredentialsPassword](docs/IdentityWithCredentialsPassword.md)
 - [IdentityWithCredentialsPasswordConfig](docs/IdentityWithCredentialsPasswordConfig.md)
 - [IsAlive200Response](docs/IsAlive200Response.md)
 - [IsReady503Response](docs/IsReady503Response.md)
 - [JsonPatch](docs/JsonPatch.md)
 - [LoginFlow](docs/LoginFlow.md)
 - [LoginFlowState](docs/LoginFlowState.md)
 - [LogoutFlow](docs/LogoutFlow.md)
 - [Message](docs/Message.md)
 - [MessageDispatch](docs/MessageDispatch.md)
 - [NeedsPrivilegedSessionError](docs/NeedsPrivilegedSessionError.md)
 - [OAuth2Client](docs/OAuth2Client.md)
 - [OAuth2ConsentRequestOpenIDConnectContext](docs/OAuth2ConsentRequestOpenIDConnectContext.md)
 - [OAuth2LoginRequest](docs/OAuth2LoginRequest.md)
 - [PatchIdentitiesBody](docs/PatchIdentitiesBody.md)
 - [PerformNativeLogoutBody](docs/PerformNativeLogoutBody.md)
 - [Provider](docs/Provider.md)
 - [RecoveryCodeForIdentity](docs/RecoveryCodeForIdentity.md)
 - [RecoveryFlow](docs/RecoveryFlow.md)
 - [RecoveryFlowState](docs/RecoveryFlowState.md)
 - [RecoveryIdentityAddress](docs/RecoveryIdentityAddress.md)
 - [RecoveryLinkForIdentity](docs/RecoveryLinkForIdentity.md)
 - [RegistrationFlow](docs/RegistrationFlow.md)
 - [RegistrationFlowState](docs/RegistrationFlowState.md)
 - [SelfServiceFlowExpiredError](docs/SelfServiceFlowExpiredError.md)
 - [Session](docs/Session.md)
 - [SessionAuthenticationMethod](docs/SessionAuthenticationMethod.md)
 - [SessionDevice](docs/SessionDevice.md)
 - [SettingsFlow](docs/SettingsFlow.md)
 - [SettingsFlowState](docs/SettingsFlowState.md)
 - [SuccessfulCodeExchangeResponse](docs/SuccessfulCodeExchangeResponse.md)
 - [SuccessfulNativeLogin](docs/SuccessfulNativeLogin.md)
 - [SuccessfulNativeRegistration](docs/SuccessfulNativeRegistration.md)
 - [TokenPagination](docs/TokenPagination.md)
 - [TokenPaginationHeaders](docs/TokenPaginationHeaders.md)
 - [UiContainer](docs/UiContainer.md)
 - [UiNode](docs/UiNode.md)
 - [UiNodeAnchorAttributes](docs/UiNodeAnchorAttributes.md)
 - [UiNodeAttributes](docs/UiNodeAttributes.md)
 - [UiNodeDivisionAttributes](docs/UiNodeDivisionAttributes.md)
 - [UiNodeImageAttributes](docs/UiNodeImageAttributes.md)
 - [UiNodeInputAttributes](docs/UiNodeInputAttributes.md)
 - [UiNodeMeta](docs/UiNodeMeta.md)
 - [UiNodeScriptAttributes](docs/UiNodeScriptAttributes.md)
 - [UiNodeTextAttributes](docs/UiNodeTextAttributes.md)
 - [UiText](docs/UiText.md)
 - [UpdateFedcmFlowBody](docs/UpdateFedcmFlowBody.md)
 - [UpdateIdentityBody](docs/UpdateIdentityBody.md)
 - [UpdateLoginFlowBody](docs/UpdateLoginFlowBody.md)
 - [UpdateLoginFlowWithCodeMethod](docs/UpdateLoginFlowWithCodeMethod.md)
 - [UpdateLoginFlowWithIdentifierFirstMethod](docs/UpdateLoginFlowWithIdentifierFirstMethod.md)
 - [UpdateLoginFlowWithLookupSecretMethod](docs/UpdateLoginFlowWithLookupSecretMethod.md)
 - [UpdateLoginFlowWithOidcMethod](docs/UpdateLoginFlowWithOidcMethod.md)
 - [UpdateLoginFlowWithPasskeyMethod](docs/UpdateLoginFlowWithPasskeyMethod.md)
 - [UpdateLoginFlowWithPasswordMethod](docs/UpdateLoginFlowWithPasswordMethod.md)
 - [UpdateLoginFlowWithTotpMethod](docs/UpdateLoginFlowWithTotpMethod.md)
 - [UpdateLoginFlowWithWebAuthnMethod](docs/UpdateLoginFlowWithWebAuthnMethod.md)
 - [UpdateRecoveryFlowBody](docs/UpdateRecoveryFlowBody.md)
 - [UpdateRecoveryFlowWithCodeMethod](docs/UpdateRecoveryFlowWithCodeMethod.md)
 - [UpdateRecoveryFlowWithLinkMethod](docs/UpdateRecoveryFlowWithLinkMethod.md)
 - [UpdateRegistrationFlowBody](docs/UpdateRegistrationFlowBody.md)
 - [UpdateRegistrationFlowWithCodeMethod](docs/UpdateRegistrationFlowWithCodeMethod.md)
 - [UpdateRegistrationFlowWithOidcMethod](docs/UpdateRegistrationFlowWithOidcMethod.md)
 - [UpdateRegistrationFlowWithPasskeyMethod](docs/UpdateRegistrationFlowWithPasskeyMethod.md)
 - [UpdateRegistrationFlowWithPasswordMethod](docs/UpdateRegistrationFlowWithPasswordMethod.md)
 - [UpdateRegistrationFlowWithProfileMethod](docs/UpdateRegistrationFlowWithProfileMethod.md)
 - [UpdateRegistrationFlowWithWebAuthnMethod](docs/UpdateRegistrationFlowWithWebAuthnMethod.md)
 - [UpdateSettingsFlowBody](docs/UpdateSettingsFlowBody.md)
 - [UpdateSettingsFlowWithLookupMethod](docs/UpdateSettingsFlowWithLookupMethod.md)
 - [UpdateSettingsFlowWithOidcMethod](docs/UpdateSettingsFlowWithOidcMethod.md)
 - [UpdateSettingsFlowWithPasskeyMethod](docs/UpdateSettingsFlowWithPasskeyMethod.md)
 - [UpdateSettingsFlowWithPasswordMethod](docs/UpdateSettingsFlowWithPasswordMethod.md)
 - [UpdateSettingsFlowWithProfileMethod](docs/UpdateSettingsFlowWithProfileMethod.md)
 - [UpdateSettingsFlowWithTotpMethod](docs/UpdateSettingsFlowWithTotpMethod.md)
 - [UpdateSettingsFlowWithWebAuthnMethod](docs/UpdateSettingsFlowWithWebAuthnMethod.md)
 - [UpdateVerificationFlowBody](docs/UpdateVerificationFlowBody.md)
 - [UpdateVerificationFlowWithCodeMethod](docs/UpdateVerificationFlowWithCodeMethod.md)
 - [UpdateVerificationFlowWithLinkMethod](docs/UpdateVerificationFlowWithLinkMethod.md)
 - [VerifiableIdentityAddress](docs/VerifiableIdentityAddress.md)
 - [VerificationFlow](docs/VerificationFlow.md)
 - [VerificationFlowState](docs/VerificationFlowState.md)
 - [Version](docs/Version.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="oryAccessToken"></a>
### oryAccessToken

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

office@ory.sh

