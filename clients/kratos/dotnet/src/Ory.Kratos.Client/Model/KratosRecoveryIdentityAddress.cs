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
    /// KratosRecoveryIdentityAddress
    /// </summary>
    public partial class KratosRecoveryIdentityAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosRecoveryIdentityAddress" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="value">value</param>
        /// <param name="via">via</param>
        /// <param name="createdAt">CreatedAt is a helper struct field for gobuffalo.pop.</param>
        /// <param name="updatedAt">UpdatedAt is a helper struct field for gobuffalo.pop.</param>
        [JsonConstructor]
        public KratosRecoveryIdentityAddress(string id, string value, string via, Option<DateTime?> createdAt = default, Option<DateTime?> updatedAt = default)
        {
            Id = id;
            Value = value;
            Via = via;
            CreatedAtOption = createdAt;
            UpdatedAtOption = updatedAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Via
        /// </summary>
        [JsonPropertyName("via")]
        public string Via { get; set; }

        /// <summary>
        /// Used to track the state of CreatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreatedAtOption { get; private set; }

        /// <summary>
        /// CreatedAt is a helper struct field for gobuffalo.pop.
        /// </summary>
        /// <value>CreatedAt is a helper struct field for gobuffalo.pop.</value>
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get { return this.CreatedAtOption; } set { this.CreatedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of UpdatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> UpdatedAtOption { get; private set; }

        /// <summary>
        /// UpdatedAt is a helper struct field for gobuffalo.pop.
        /// </summary>
        /// <value>UpdatedAt is a helper struct field for gobuffalo.pop.</value>
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get { return this.UpdatedAtOption; } set { this.UpdatedAtOption = new(value); } }

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
            sb.Append("class KratosRecoveryIdentityAddress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Via: ").Append(Via).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
    /// A Json converter for type <see cref="KratosRecoveryIdentityAddress" />
    /// </summary>
    public class KratosRecoveryIdentityAddressJsonConverter : JsonConverter<KratosRecoveryIdentityAddress>
    {
        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="KratosRecoveryIdentityAddress" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosRecoveryIdentityAddress Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<string?> value = default;
            Option<string?> via = default;
            Option<DateTime?> createdAt = default;
            Option<DateTime?> updatedAt = default;

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
                                id = new Option<string?>(utf8JsonReader.GetGuid());
                            break;
                        case "value":
                            value = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "via":
                            via = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "created_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "updated_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryIdentityAddress.", nameof(id));

            if (!value.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryIdentityAddress.", nameof(value));

            if (!via.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryIdentityAddress.", nameof(via));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class KratosRecoveryIdentityAddress.");

            if (value.IsSet && value.Value == null)
                throw new ArgumentNullException(nameof(value), "Property is not nullable for class KratosRecoveryIdentityAddress.");

            if (via.IsSet && via.Value == null)
                throw new ArgumentNullException(nameof(via), "Property is not nullable for class KratosRecoveryIdentityAddress.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class KratosRecoveryIdentityAddress.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class KratosRecoveryIdentityAddress.");

            return new KratosRecoveryIdentityAddress(id.Value!, value.Value!, via.Value!, createdAt, updatedAt);
        }

        /// <summary>
        /// Serializes a <see cref="KratosRecoveryIdentityAddress" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosRecoveryIdentityAddress"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosRecoveryIdentityAddress kratosRecoveryIdentityAddress, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosRecoveryIdentityAddress, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosRecoveryIdentityAddress" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosRecoveryIdentityAddress"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosRecoveryIdentityAddress kratosRecoveryIdentityAddress, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosRecoveryIdentityAddress.Id == null)
                throw new ArgumentNullException(nameof(kratosRecoveryIdentityAddress.Id), "Property is required for class KratosRecoveryIdentityAddress.");

            if (kratosRecoveryIdentityAddress.Value == null)
                throw new ArgumentNullException(nameof(kratosRecoveryIdentityAddress.Value), "Property is required for class KratosRecoveryIdentityAddress.");

            if (kratosRecoveryIdentityAddress.Via == null)
                throw new ArgumentNullException(nameof(kratosRecoveryIdentityAddress.Via), "Property is required for class KratosRecoveryIdentityAddress.");

            writer.WriteString("id", kratosRecoveryIdentityAddress.Id);

            writer.WriteString("value", kratosRecoveryIdentityAddress.Value);

            writer.WriteString("via", kratosRecoveryIdentityAddress.Via);

            if (kratosRecoveryIdentityAddress.CreatedAtOption.IsSet)
                writer.WriteString("created_at", kratosRecoveryIdentityAddress.CreatedAtOption.Value!.Value.ToString(CreatedAtFormat));

            if (kratosRecoveryIdentityAddress.UpdatedAtOption.IsSet)
                writer.WriteString("updated_at", kratosRecoveryIdentityAddress.UpdatedAtOption.Value!.Value.ToString(UpdatedAtFormat));
        }
    }
}
