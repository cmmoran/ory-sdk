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
    /// KratosUiText
    /// </summary>
    public partial class KratosUiText : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiText" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="text">The message text. Written in american english.</param>
        /// <param name="type">The message type. info Info error Error success Success</param>
        /// <param name="context">The message&#39;s context. Useful when customizing messages.</param>
        [JsonConstructor]
        public KratosUiText(long id, string text, TypeEnum type, Option<Object?> context = default)
        {
            Id = id;
            Text = text;
            Type = type;
            ContextOption = context;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The message type. info Info error Error success Success
        /// </summary>
        /// <value>The message type. info Info error Error success Success</value>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Info for value: info
            /// </summary>
            Info = 1,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            Error = 2,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            Success = 3
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("info"))
                return TypeEnum.Info;

            if (value.Equals("error"))
                return TypeEnum.Error;

            if (value.Equals("success"))
                return TypeEnum.Success;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("info"))
                return TypeEnum.Info;

            if (value.Equals("error"))
                return TypeEnum.Error;

            if (value.Equals("success"))
                return TypeEnum.Success;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum value)
        {
            if (value == TypeEnum.Info)
                return "info";

            if (value == TypeEnum.Error)
                return "error";

            if (value == TypeEnum.Success)
                return "success";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// The message type. info Info error Error success Success
        /// </summary>
        /// <value>The message type. info Info error Error success Success</value>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// The message text. Written in american english.
        /// </summary>
        /// <value>The message text. Written in american english.</value>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Used to track the state of Context
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ContextOption { get; private set; }

        /// <summary>
        /// The message&#39;s context. Useful when customizing messages.
        /// </summary>
        /// <value>The message&#39;s context. Useful when customizing messages.</value>
        [JsonPropertyName("context")]
        public Object? Context { get { return this.ContextOption; } set { this.ContextOption = new(value); } }

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
            sb.Append("class KratosUiText {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
    /// A Json converter for type <see cref="KratosUiText" />
    /// </summary>
    public class KratosUiTextJsonConverter : JsonConverter<KratosUiText>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUiText" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUiText Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<string?> text = default;
            Option<KratosUiText.TypeEnum?> type = default;
            Option<Object?> context = default;

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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "text":
                            text = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<KratosUiText.TypeEnum?>(KratosUiText.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        case "context":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                context = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class KratosUiText.", nameof(id));

            if (!text.IsSet)
                throw new ArgumentException("Property is required for class KratosUiText.", nameof(text));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class KratosUiText.", nameof(type));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class KratosUiText.");

            if (text.IsSet && text.Value == null)
                throw new ArgumentNullException(nameof(text), "Property is not nullable for class KratosUiText.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class KratosUiText.");

            if (context.IsSet && context.Value == null)
                throw new ArgumentNullException(nameof(context), "Property is not nullable for class KratosUiText.");

            return new KratosUiText(id.Value!.Value!, text.Value!, type.Value!.Value!, context);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUiText" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiText"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUiText kratosUiText, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUiText, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUiText" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiText"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUiText kratosUiText, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUiText.Text == null)
                throw new ArgumentNullException(nameof(kratosUiText.Text), "Property is required for class KratosUiText.");

            if (kratosUiText.ContextOption.IsSet && kratosUiText.Context == null)
                throw new ArgumentNullException(nameof(kratosUiText.Context), "Property is required for class KratosUiText.");

            writer.WriteNumber("id", kratosUiText.Id);

            writer.WriteString("text", kratosUiText.Text);

            var typeRawValue = KratosUiText.TypeEnumToJsonValue(kratosUiText.Type);
            writer.WriteString("type", typeRawValue);
            if (kratosUiText.ContextOption.IsSet)
            {
                writer.WritePropertyName("context");
                JsonSerializer.Serialize(writer, kratosUiText.Context, jsonSerializerOptions);
            }
        }
    }
}
