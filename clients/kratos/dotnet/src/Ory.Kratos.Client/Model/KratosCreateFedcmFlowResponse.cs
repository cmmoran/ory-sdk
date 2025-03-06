// <auto-generated>
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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Ory.Kratos.Client.Client;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// Contains a list of all available FedCM providers.
    /// </summary>
    public partial class KratosCreateFedcmFlowResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosCreateFedcmFlowResponse" /> class.
        /// </summary>
        /// <param name="csrfToken">csrfToken</param>
        /// <param name="providers">providers</param>
        [JsonConstructor]
        public KratosCreateFedcmFlowResponse(Option<string?> csrfToken = default, Option<List<KratosProvider>?> providers = default)
        {
            CsrfTokenOption = csrfToken;
            ProvidersOption = providers;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CsrfToken
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CsrfTokenOption { get; private set; }

        /// <summary>
        /// Gets or Sets CsrfToken
        /// </summary>
        [JsonPropertyName("csrf_token")]
        public string? CsrfToken { get { return this.CsrfTokenOption; } set { this.CsrfTokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of Providers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<KratosProvider>?> ProvidersOption { get; private set; }

        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [JsonPropertyName("providers")]
        public List<KratosProvider>? Providers { get { return this.ProvidersOption; } set { this.ProvidersOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosCreateFedcmFlowResponse {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="KratosCreateFedcmFlowResponse" />
    /// </summary>
    public class KratosCreateFedcmFlowResponseJsonConverter : JsonConverter<KratosCreateFedcmFlowResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosCreateFedcmFlowResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosCreateFedcmFlowResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> csrfToken = default;
            Option<List<KratosProvider>?> providers = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "providers":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                providers = new Option<List<KratosProvider>?>(JsonSerializer.Deserialize<List<KratosProvider>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosCreateFedcmFlowResponse.");

            if (providers.IsSet && providers.Value == null)
                throw new ArgumentNullException(nameof(providers), "Property is not nullable for class KratosCreateFedcmFlowResponse.");

            return new KratosCreateFedcmFlowResponse(csrfToken, providers);
        }

        /// <summary>
        /// Serializes a <see cref="KratosCreateFedcmFlowResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCreateFedcmFlowResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosCreateFedcmFlowResponse kratosCreateFedcmFlowResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosCreateFedcmFlowResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosCreateFedcmFlowResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCreateFedcmFlowResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosCreateFedcmFlowResponse kratosCreateFedcmFlowResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosCreateFedcmFlowResponse.CsrfTokenOption.IsSet && kratosCreateFedcmFlowResponse.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosCreateFedcmFlowResponse.CsrfToken), "Property is required for class KratosCreateFedcmFlowResponse.");

            if (kratosCreateFedcmFlowResponse.ProvidersOption.IsSet && kratosCreateFedcmFlowResponse.Providers == null)
                throw new ArgumentNullException(nameof(kratosCreateFedcmFlowResponse.Providers), "Property is required for class KratosCreateFedcmFlowResponse.");

            if (kratosCreateFedcmFlowResponse.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosCreateFedcmFlowResponse.CsrfToken);

            if (kratosCreateFedcmFlowResponse.ProvidersOption.IsSet)
            {
                writer.WritePropertyName("providers");
                JsonSerializer.Serialize(writer, kratosCreateFedcmFlowResponse.Providers, jsonSerializerOptions);
            }
        }
    }
}
