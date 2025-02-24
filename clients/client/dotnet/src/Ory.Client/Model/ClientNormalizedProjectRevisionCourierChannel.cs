/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.9
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientNormalizedProjectRevisionCourierChannel
    /// </summary>
    [DataContract(Name = "NormalizedProjectRevisionCourierChannel")]
    public partial class ClientNormalizedProjectRevisionCourierChannel : IValidatableObject
    {
        /// <summary>
        /// HTTP Auth Method to use for the HTTP call  Can either be basic_auth or api_key basic_auth CourierChannelAuthTypeBasicAuth api_key CourierChannelAuthTypeApiKey
        /// </summary>
        /// <value>HTTP Auth Method to use for the HTTP call  Can either be basic_auth or api_key basic_auth CourierChannelAuthTypeBasicAuth api_key CourierChannelAuthTypeApiKey</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestConfigAuthTypeEnum
        {
            /// <summary>
            /// Enum BasicAuth for value: basic_auth
            /// </summary>
            [EnumMember(Value = "basic_auth")]
            BasicAuth = 1,

            /// <summary>
            /// Enum ApiKey for value: api_key
            /// </summary>
            [EnumMember(Value = "api_key")]
            ApiKey = 2
        }


        /// <summary>
        /// HTTP Auth Method to use for the HTTP call  Can either be basic_auth or api_key basic_auth CourierChannelAuthTypeBasicAuth api_key CourierChannelAuthTypeApiKey
        /// </summary>
        /// <value>HTTP Auth Method to use for the HTTP call  Can either be basic_auth or api_key basic_auth CourierChannelAuthTypeBasicAuth api_key CourierChannelAuthTypeApiKey</value>
        [DataMember(Name = "request_config_auth_type", EmitDefaultValue = false)]
        public RequestConfigAuthTypeEnum? RequestConfigAuthType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProjectRevisionCourierChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientNormalizedProjectRevisionCourierChannel()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProjectRevisionCourierChannel" /> class.
        /// </summary>
        /// <param name="channelId">The Channel&#39;s public ID (required).</param>
        /// <param name="requestConfigAuthConfigApiKeyIn">API key location  Can either be \&quot;header\&quot; or \&quot;query\&quot;.</param>
        /// <param name="requestConfigAuthConfigApiKeyName">API key name  Only used if the auth type is api_key.</param>
        /// <param name="requestConfigAuthConfigApiKeyValue">API key value  Only used if the auth type is api_key.</param>
        /// <param name="requestConfigAuthConfigBasicAuthPassword">Basic Auth Password  Only used if the auth type is basic_auth.</param>
        /// <param name="requestConfigAuthConfigBasicAuthUser">Basic Auth Username  Only used if the auth type is basic_auth.</param>
        /// <param name="requestConfigAuthType">HTTP Auth Method to use for the HTTP call  Can either be basic_auth or api_key basic_auth CourierChannelAuthTypeBasicAuth api_key CourierChannelAuthTypeApiKey.</param>
        /// <param name="requestConfigBody">URI pointing to the JsonNet template used for HTTP body payload generation. (required).</param>
        /// <param name="requestConfigHeaders">NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-.</param>
        /// <param name="requestConfigMethod">The HTTP method to use (GET, POST, etc) for the HTTP call (required).</param>
        /// <param name="requestConfigUrl">requestConfigUrl.</param>
        public ClientNormalizedProjectRevisionCourierChannel(string channelId = default(string), string requestConfigAuthConfigApiKeyIn = default(string), string requestConfigAuthConfigApiKeyName = default(string), string requestConfigAuthConfigApiKeyValue = default(string), string requestConfigAuthConfigBasicAuthPassword = default(string), string requestConfigAuthConfigBasicAuthUser = default(string), RequestConfigAuthTypeEnum? requestConfigAuthType = default(RequestConfigAuthTypeEnum?), string requestConfigBody = default(string), Object requestConfigHeaders = default(Object), string requestConfigMethod = default(string), string requestConfigUrl = default(string))
        {
            // to ensure "channelId" is required (not null)
            if (channelId == null)
            {
                throw new ArgumentNullException("channelId is a required property for ClientNormalizedProjectRevisionCourierChannel and cannot be null");
            }
            this.ChannelId = channelId;
            // to ensure "requestConfigBody" is required (not null)
            if (requestConfigBody == null)
            {
                throw new ArgumentNullException("requestConfigBody is a required property for ClientNormalizedProjectRevisionCourierChannel and cannot be null");
            }
            this.RequestConfigBody = requestConfigBody;
            // to ensure "requestConfigMethod" is required (not null)
            if (requestConfigMethod == null)
            {
                throw new ArgumentNullException("requestConfigMethod is a required property for ClientNormalizedProjectRevisionCourierChannel and cannot be null");
            }
            this.RequestConfigMethod = requestConfigMethod;
            this.RequestConfigAuthConfigApiKeyIn = requestConfigAuthConfigApiKeyIn;
            this.RequestConfigAuthConfigApiKeyName = requestConfigAuthConfigApiKeyName;
            this.RequestConfigAuthConfigApiKeyValue = requestConfigAuthConfigApiKeyValue;
            this.RequestConfigAuthConfigBasicAuthPassword = requestConfigAuthConfigBasicAuthPassword;
            this.RequestConfigAuthConfigBasicAuthUser = requestConfigAuthConfigBasicAuthUser;
            this.RequestConfigAuthType = requestConfigAuthType;
            this.RequestConfigHeaders = requestConfigHeaders;
            this.RequestConfigUrl = requestConfigUrl;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Channel&#39;s public ID
        /// </summary>
        /// <value>The Channel&#39;s public ID</value>
        [DataMember(Name = "channel_id", IsRequired = true, EmitDefaultValue = true)]
        public string ChannelId { get; set; }

        /// <summary>
        /// The creation date
        /// </summary>
        /// <value>The creation date</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// API key location  Can either be \&quot;header\&quot; or \&quot;query\&quot;
        /// </summary>
        /// <value>API key location  Can either be \&quot;header\&quot; or \&quot;query\&quot;</value>
        /// <example>header</example>
        [DataMember(Name = "request_config_auth_config_api_key_in", EmitDefaultValue = false)]
        public string RequestConfigAuthConfigApiKeyIn { get; set; }

        /// <summary>
        /// API key name  Only used if the auth type is api_key
        /// </summary>
        /// <value>API key name  Only used if the auth type is api_key</value>
        [DataMember(Name = "request_config_auth_config_api_key_name", EmitDefaultValue = false)]
        public string RequestConfigAuthConfigApiKeyName { get; set; }

        /// <summary>
        /// API key value  Only used if the auth type is api_key
        /// </summary>
        /// <value>API key value  Only used if the auth type is api_key</value>
        [DataMember(Name = "request_config_auth_config_api_key_value", EmitDefaultValue = false)]
        public string RequestConfigAuthConfigApiKeyValue { get; set; }

        /// <summary>
        /// Basic Auth Password  Only used if the auth type is basic_auth
        /// </summary>
        /// <value>Basic Auth Password  Only used if the auth type is basic_auth</value>
        [DataMember(Name = "request_config_auth_config_basic_auth_password", EmitDefaultValue = false)]
        public string RequestConfigAuthConfigBasicAuthPassword { get; set; }

        /// <summary>
        /// Basic Auth Username  Only used if the auth type is basic_auth
        /// </summary>
        /// <value>Basic Auth Username  Only used if the auth type is basic_auth</value>
        [DataMember(Name = "request_config_auth_config_basic_auth_user", EmitDefaultValue = false)]
        public string RequestConfigAuthConfigBasicAuthUser { get; set; }

        /// <summary>
        /// URI pointing to the JsonNet template used for HTTP body payload generation.
        /// </summary>
        /// <value>URI pointing to the JsonNet template used for HTTP body payload generation.</value>
        [DataMember(Name = "request_config_body", IsRequired = true, EmitDefaultValue = true)]
        public string RequestConfigBody { get; set; }

        /// <summary>
        /// NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-
        /// </summary>
        /// <value>NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-</value>
        [DataMember(Name = "request_config_headers", EmitDefaultValue = true)]
        public Object RequestConfigHeaders { get; set; }

        /// <summary>
        /// The HTTP method to use (GET, POST, etc) for the HTTP call
        /// </summary>
        /// <value>The HTTP method to use (GET, POST, etc) for the HTTP call</value>
        /// <example>POST</example>
        [DataMember(Name = "request_config_method", IsRequired = true, EmitDefaultValue = true)]
        public string RequestConfigMethod { get; set; }

        /// <summary>
        /// Gets or Sets RequestConfigUrl
        /// </summary>
        [DataMember(Name = "request_config_url", EmitDefaultValue = false)]
        public string RequestConfigUrl { get; set; }

        /// <summary>
        /// Last upate time
        /// </summary>
        /// <value>Last upate time</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientNormalizedProjectRevisionCourierChannel {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  RequestConfigAuthConfigApiKeyIn: ").Append(RequestConfigAuthConfigApiKeyIn).Append("\n");
            sb.Append("  RequestConfigAuthConfigApiKeyName: ").Append(RequestConfigAuthConfigApiKeyName).Append("\n");
            sb.Append("  RequestConfigAuthConfigApiKeyValue: ").Append(RequestConfigAuthConfigApiKeyValue).Append("\n");
            sb.Append("  RequestConfigAuthConfigBasicAuthPassword: ").Append(RequestConfigAuthConfigBasicAuthPassword).Append("\n");
            sb.Append("  RequestConfigAuthConfigBasicAuthUser: ").Append(RequestConfigAuthConfigBasicAuthUser).Append("\n");
            sb.Append("  RequestConfigAuthType: ").Append(RequestConfigAuthType).Append("\n");
            sb.Append("  RequestConfigBody: ").Append(RequestConfigBody).Append("\n");
            sb.Append("  RequestConfigHeaders: ").Append(RequestConfigHeaders).Append("\n");
            sb.Append("  RequestConfigMethod: ").Append(RequestConfigMethod).Append("\n");
            sb.Append("  RequestConfigUrl: ").Append(RequestConfigUrl).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
