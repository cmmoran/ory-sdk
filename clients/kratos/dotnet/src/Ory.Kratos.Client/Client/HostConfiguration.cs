/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.4.0-alpha.0
 * Contact: office@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Ory.Kratos.Client.Api;
using Ory.Kratos.Client.Model;

namespace Ory.Kratos.Client.Client
{
    /// <summary>
    /// Provides hosting configuration for Ory.Kratos.Client
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosAuthenticatorAssuranceLevelJsonConverter());
            _jsonOptions.Converters.Add(new KratosAuthenticatorAssuranceLevelNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosBatchPatchIdentitiesResponseJsonConverter());
            _jsonOptions.Converters.Add(new KratosConsistencyRequestParametersJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithRecoveryUiJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithRecoveryUiFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithRedirectBrowserToJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithSetOrySessionTokenJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithSettingsUiJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithSettingsUiFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithVerificationUiJsonConverter());
            _jsonOptions.Converters.Add(new KratosContinueWithVerificationUiFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosCourierMessageStatusJsonConverter());
            _jsonOptions.Converters.Add(new KratosCourierMessageStatusNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosCourierMessageTypeJsonConverter());
            _jsonOptions.Converters.Add(new KratosCourierMessageTypeNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosCreateFedcmFlowResponseJsonConverter());
            _jsonOptions.Converters.Add(new KratosCreateIdentityBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosCreateRecoveryCodeForIdentityBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosCreateRecoveryLinkForIdentityBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosDeleteMySessionsCountJsonConverter());
            _jsonOptions.Converters.Add(new KratosErrorAuthenticatorAssuranceLevelNotSatisfiedJsonConverter());
            _jsonOptions.Converters.Add(new KratosErrorBrowserLocationChangeRequiredJsonConverter());
            _jsonOptions.Converters.Add(new KratosErrorFlowReplacedJsonConverter());
            _jsonOptions.Converters.Add(new KratosErrorGenericJsonConverter());
            _jsonOptions.Converters.Add(new KratosFlowErrorJsonConverter());
            _jsonOptions.Converters.Add(new KratosGenericErrorJsonConverter());
            _jsonOptions.Converters.Add(new KratosGetVersion200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new KratosHealthNotReadyStatusJsonConverter());
            _jsonOptions.Converters.Add(new KratosHealthStatusJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityCredentialsJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityCredentialsCodeJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityCredentialsCodeAddressJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityCredentialsOidcJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityCredentialsOidcProviderJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityCredentialsPasswordJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityPatchJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityPatchResponseJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentitySchemaContainerJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityWithCredentialsJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityWithCredentialsOidcJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityWithCredentialsOidcConfigJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityWithCredentialsOidcConfigProviderJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityWithCredentialsPasswordJsonConverter());
            _jsonOptions.Converters.Add(new KratosIdentityWithCredentialsPasswordConfigJsonConverter());
            _jsonOptions.Converters.Add(new KratosIsAlive200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new KratosIsReady503ResponseJsonConverter());
            _jsonOptions.Converters.Add(new KratosJsonPatchJsonConverter());
            _jsonOptions.Converters.Add(new KratosLoginFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosLoginFlowStateJsonConverter());
            _jsonOptions.Converters.Add(new KratosLoginFlowStateNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosLogoutFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosMessageJsonConverter());
            _jsonOptions.Converters.Add(new KratosMessageDispatchJsonConverter());
            _jsonOptions.Converters.Add(new KratosNeedsPrivilegedSessionErrorJsonConverter());
            _jsonOptions.Converters.Add(new KratosOAuth2ClientJsonConverter());
            _jsonOptions.Converters.Add(new KratosOAuth2ConsentRequestOpenIDConnectContextJsonConverter());
            _jsonOptions.Converters.Add(new KratosOAuth2LoginRequestJsonConverter());
            _jsonOptions.Converters.Add(new KratosPatchIdentitiesBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosPerformNativeLogoutBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosProviderJsonConverter());
            _jsonOptions.Converters.Add(new KratosRecoveryCodeForIdentityJsonConverter());
            _jsonOptions.Converters.Add(new KratosRecoveryFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosRecoveryFlowStateJsonConverter());
            _jsonOptions.Converters.Add(new KratosRecoveryFlowStateNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosRecoveryIdentityAddressJsonConverter());
            _jsonOptions.Converters.Add(new KratosRecoveryLinkForIdentityJsonConverter());
            _jsonOptions.Converters.Add(new KratosRegistrationFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosRegistrationFlowStateJsonConverter());
            _jsonOptions.Converters.Add(new KratosRegistrationFlowStateNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosSelfServiceFlowExpiredErrorJsonConverter());
            _jsonOptions.Converters.Add(new KratosSessionJsonConverter());
            _jsonOptions.Converters.Add(new KratosSessionAuthenticationMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosSessionDeviceJsonConverter());
            _jsonOptions.Converters.Add(new KratosSettingsFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosSettingsFlowStateJsonConverter());
            _jsonOptions.Converters.Add(new KratosSettingsFlowStateNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosSuccessfulCodeExchangeResponseJsonConverter());
            _jsonOptions.Converters.Add(new KratosSuccessfulNativeLoginJsonConverter());
            _jsonOptions.Converters.Add(new KratosSuccessfulNativeRegistrationJsonConverter());
            _jsonOptions.Converters.Add(new KratosTokenPaginationJsonConverter());
            _jsonOptions.Converters.Add(new KratosTokenPaginationHeadersJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiContainerJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeAnchorAttributesJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeAttributesJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeDivisionAttributesJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeImageAttributesJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeInputAttributesJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeMetaJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeScriptAttributesJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiNodeTextAttributesJsonConverter());
            _jsonOptions.Converters.Add(new KratosUiTextJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateFedcmFlowBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateIdentityBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowWithCodeMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowWithIdentifierFirstMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowWithLookupSecretMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowWithOidcMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowWithPasskeyMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowWithPasswordMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowWithTotpMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateLoginFlowWithWebAuthnMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRecoveryFlowBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRecoveryFlowWithCodeMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRecoveryFlowWithLinkMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRegistrationFlowBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRegistrationFlowWithCodeMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRegistrationFlowWithOidcMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRegistrationFlowWithPasskeyMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRegistrationFlowWithPasswordMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRegistrationFlowWithProfileMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateRegistrationFlowWithWebAuthnMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateSettingsFlowBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateSettingsFlowWithLookupMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateSettingsFlowWithOidcMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateSettingsFlowWithPasskeyMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateSettingsFlowWithPasswordMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateSettingsFlowWithProfileMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateSettingsFlowWithTotpMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateSettingsFlowWithWebAuthnMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateVerificationFlowBodyJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateVerificationFlowWithCodeMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosUpdateVerificationFlowWithLinkMethodJsonConverter());
            _jsonOptions.Converters.Add(new KratosVerifiableIdentityAddressJsonConverter());
            _jsonOptions.Converters.Add(new KratosVerificationFlowJsonConverter());
            _jsonOptions.Converters.Add(new KratosVerificationFlowStateJsonConverter());
            _jsonOptions.Converters.Add(new KratosVerificationFlowStateNullableJsonConverter());
            _jsonOptions.Converters.Add(new KratosVersionJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<CourierApiEvents>();
            _services.AddTransient<ICourierApi, CourierApi>();
            _services.AddSingleton<FrontendApiEvents>();
            _services.AddTransient<IFrontendApi, FrontendApi>();
            _services.AddSingleton<IdentityApiEvents>();
            _services.AddTransient<IIdentityApi, IdentityApi>();
            _services.AddSingleton<MetadataApiEvents>();
            _services.AddTransient<IMetadataApi, MetadataApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<ICourierApi, CourierApi>(client));
            builders.Add(_services.AddHttpClient<IFrontendApi, FrontendApi>(client));
            builders.Add(_services.AddHttpClient<IIdentityApi, IdentityApi>(client));
            builders.Add(_services.AddHttpClient<IMetadataApi, MetadataApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
