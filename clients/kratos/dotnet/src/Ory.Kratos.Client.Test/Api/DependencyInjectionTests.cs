/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.4.0-alpha.0
 * Contact: office@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Cryptography;
using Ory.Kratos.Client.Client;
using Ory.Kratos.Client.Api;
using Ory.Kratos.Client.Extensions;
using Xunit;

namespace Ory.Kratos.Client.Test.Api
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {
                ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken1);
            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {
                ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken1);
                options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken1);
                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken1);
                    options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var courierApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ICourierApi>();
            Assert.True(courierApi.HttpClient.BaseAddress != null);

            var frontendApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IFrontendApi>();
            Assert.True(frontendApi.HttpClient.BaseAddress != null);

            var identityApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IIdentityApi>();
            Assert.True(identityApi.HttpClient.BaseAddress != null);

            var metadataApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IMetadataApi>();
            Assert.True(metadataApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var courierApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ICourierApi>();
            Assert.True(courierApi.HttpClient.BaseAddress != null);

            var frontendApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IFrontendApi>();
            Assert.True(frontendApi.HttpClient.BaseAddress != null);

            var identityApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IIdentityApi>();
            Assert.True(identityApi.HttpClient.BaseAddress != null);

            var metadataApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IMetadataApi>();
            Assert.True(metadataApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var courierApi = _hostUsingAddWithAClient.Services.GetRequiredService<ICourierApi>();
            Assert.True(courierApi.HttpClient.BaseAddress != null);
            
            var frontendApi = _hostUsingAddWithAClient.Services.GetRequiredService<IFrontendApi>();
            Assert.True(frontendApi.HttpClient.BaseAddress != null);
            
            var identityApi = _hostUsingAddWithAClient.Services.GetRequiredService<IIdentityApi>();
            Assert.True(identityApi.HttpClient.BaseAddress != null);
            
            var metadataApi = _hostUsingAddWithAClient.Services.GetRequiredService<IMetadataApi>();
            Assert.True(metadataApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var courierApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ICourierApi>();
            Assert.True(courierApi.HttpClient.BaseAddress != null);

            var frontendApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IFrontendApi>();
            Assert.True(frontendApi.HttpClient.BaseAddress != null);

            var identityApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IIdentityApi>();
            Assert.True(identityApi.HttpClient.BaseAddress != null);

            var metadataApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IMetadataApi>();
            Assert.True(metadataApi.HttpClient.BaseAddress != null);
        }
    }
}
