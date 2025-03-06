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
    /// KratosIsReady503Response
    /// </summary>
    public partial class KratosIsReady503Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIsReady503Response" /> class.
        /// </summary>
        /// <param name="errors">Errors contains a list of errors that caused the not ready status.</param>
        [JsonConstructor]
        public KratosIsReady503Response(Dictionary<string, string> errors)
        {
            Errors = errors;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Errors contains a list of errors that caused the not ready status.
        /// </summary>
        /// <value>Errors contains a list of errors that caused the not ready status.</value>
        [JsonPropertyName("errors")]
        public Dictionary<string, string> Errors { get; set; }

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
            sb.Append("class KratosIsReady503Response {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
    /// A Json converter for type <see cref="KratosIsReady503Response" />
    /// </summary>
    public class KratosIsReady503ResponseJsonConverter : JsonConverter<KratosIsReady503Response>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosIsReady503Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosIsReady503Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Dictionary<string, string>?> errors = default;

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
                        case "errors":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                errors = new Option<Dictionary<string, string>?>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!errors.IsSet)
                throw new ArgumentException("Property is required for class KratosIsReady503Response.", nameof(errors));

            if (errors.IsSet && errors.Value == null)
                throw new ArgumentNullException(nameof(errors), "Property is not nullable for class KratosIsReady503Response.");

            return new KratosIsReady503Response(errors.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="KratosIsReady503Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosIsReady503Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosIsReady503Response kratosIsReady503Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosIsReady503Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosIsReady503Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosIsReady503Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosIsReady503Response kratosIsReady503Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosIsReady503Response.Errors == null)
                throw new ArgumentNullException(nameof(kratosIsReady503Response.Errors), "Property is required for class KratosIsReady503Response.");

            writer.WritePropertyName("errors");
            JsonSerializer.Serialize(writer, kratosIsReady503Response.Errors, jsonSerializerOptions);
        }
    }
}
