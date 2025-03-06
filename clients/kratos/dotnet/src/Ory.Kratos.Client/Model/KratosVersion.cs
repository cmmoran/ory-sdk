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
    /// KratosVersion
    /// </summary>
    public partial class KratosVersion : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosVersion" /> class.
        /// </summary>
        /// <param name="varVersion">Version is the service&#39;s version.</param>
        [JsonConstructor]
        public KratosVersion(Option<string?> varVersion = default)
        {
            VarVersionOption = varVersion;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of VarVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VarVersionOption { get; private set; }

        /// <summary>
        /// Version is the service&#39;s version.
        /// </summary>
        /// <value>Version is the service&#39;s version.</value>
        [JsonPropertyName("version")]
        public string? VarVersion { get { return this.VarVersionOption; } set { this.VarVersionOption = new(value); } }

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
            sb.Append("class KratosVersion {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
    /// A Json converter for type <see cref="KratosVersion" />
    /// </summary>
    public class KratosVersionJsonConverter : JsonConverter<KratosVersion>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosVersion" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosVersion Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> varVersion = default;

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
                        case "version":
                            varVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class KratosVersion.");

            return new KratosVersion(varVersion);
        }

        /// <summary>
        /// Serializes a <see cref="KratosVersion" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosVersion"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosVersion kratosVersion, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosVersion, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosVersion" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosVersion"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosVersion kratosVersion, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosVersion.VarVersionOption.IsSet && kratosVersion.VarVersion == null)
                throw new ArgumentNullException(nameof(kratosVersion.VarVersion), "Property is required for class KratosVersion.");

            if (kratosVersion.VarVersionOption.IsSet)
                writer.WriteString("version", kratosVersion.VarVersion);
        }
    }
}
