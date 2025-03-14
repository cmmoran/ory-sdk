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
    /// This might include a label and other information that can optionally be used to render UIs.
    /// </summary>
    public partial class KratosUiNodeMeta : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeMeta" /> class.
        /// </summary>
        /// <param name="label">label</param>
        [JsonConstructor]
        public KratosUiNodeMeta(Option<KratosUiText?> label = default)
        {
            LabelOption = label;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Label
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<KratosUiText?> LabelOption { get; private set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [JsonPropertyName("label")]
        public KratosUiText? Label { get { return this.LabelOption; } set { this.LabelOption = new(value); } }

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
            sb.Append("class KratosUiNodeMeta {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
    /// A Json converter for type <see cref="KratosUiNodeMeta" />
    /// </summary>
    public class KratosUiNodeMetaJsonConverter : JsonConverter<KratosUiNodeMeta>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUiNodeMeta" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUiNodeMeta Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<KratosUiText?> label = default;

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
                        case "label":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                label = new Option<KratosUiText?>(JsonSerializer.Deserialize<KratosUiText>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (label.IsSet && label.Value == null)
                throw new ArgumentNullException(nameof(label), "Property is not nullable for class KratosUiNodeMeta.");

            return new KratosUiNodeMeta(label);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUiNodeMeta" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNodeMeta"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUiNodeMeta kratosUiNodeMeta, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUiNodeMeta, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUiNodeMeta" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNodeMeta"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUiNodeMeta kratosUiNodeMeta, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUiNodeMeta.LabelOption.IsSet && kratosUiNodeMeta.Label == null)
                throw new ArgumentNullException(nameof(kratosUiNodeMeta.Label), "Property is required for class KratosUiNodeMeta.");

            if (kratosUiNodeMeta.LabelOption.IsSet)
            {
                writer.WritePropertyName("label");
                JsonSerializer.Serialize(writer, kratosUiNodeMeta.Label, jsonSerializerOptions);
            }
        }
    }
}
