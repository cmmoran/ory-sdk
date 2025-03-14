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
    /// Update Settings Flow with Password Method
    /// </summary>
    public partial class KratosUpdateSettingsFlowWithPasswordMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowWithPasswordMethod" /> class.
        /// </summary>
        /// <param name="method">Method  Should be set to password when trying to update a password.</param>
        /// <param name="password">Password is the updated password</param>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks</param>
        [JsonConstructor]
        public KratosUpdateSettingsFlowWithPasswordMethod(string method, string password, Option<string?> csrfToken = default, Option<Object?> transientPayload = default)
        {
            Method = method;
            Password = password;
            CsrfTokenOption = csrfToken;
            TransientPayloadOption = transientPayload;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Method  Should be set to password when trying to update a password.
        /// </summary>
        /// <value>Method  Should be set to password when trying to update a password.</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// Password is the updated password
        /// </summary>
        /// <value>Password is the updated password</value>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Used to track the state of CsrfToken
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CsrfTokenOption { get; private set; }

        /// <summary>
        /// CSRFToken is the anti-CSRF token
        /// </summary>
        /// <value>CSRFToken is the anti-CSRF token</value>
        [JsonPropertyName("csrf_token")]
        public string? CsrfToken { get { return this.CsrfTokenOption; } set { this.CsrfTokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of TransientPayload
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> TransientPayloadOption { get; private set; }

        /// <summary>
        /// Transient data to pass along to any webhooks
        /// </summary>
        /// <value>Transient data to pass along to any webhooks</value>
        [JsonPropertyName("transient_payload")]
        public Object? TransientPayload { get { return this.TransientPayloadOption; } set { this.TransientPayloadOption = new(value); } }

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
            sb.Append("class KratosUpdateSettingsFlowWithPasswordMethod {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
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
    /// A Json converter for type <see cref="KratosUpdateSettingsFlowWithPasswordMethod" />
    /// </summary>
    public class KratosUpdateSettingsFlowWithPasswordMethodJsonConverter : JsonConverter<KratosUpdateSettingsFlowWithPasswordMethod>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateSettingsFlowWithPasswordMethod" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateSettingsFlowWithPasswordMethod Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> method = default;
            Option<string?> password = default;
            Option<string?> csrfToken = default;
            Option<Object?> transientPayload = default;

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
                        case "method":
                            method = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "password":
                            password = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "transient_payload":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transientPayload = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateSettingsFlowWithPasswordMethod.", nameof(method));

            if (!password.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateSettingsFlowWithPasswordMethod.", nameof(password));

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateSettingsFlowWithPasswordMethod.");

            if (password.IsSet && password.Value == null)
                throw new ArgumentNullException(nameof(password), "Property is not nullable for class KratosUpdateSettingsFlowWithPasswordMethod.");

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosUpdateSettingsFlowWithPasswordMethod.");

            if (transientPayload.IsSet && transientPayload.Value == null)
                throw new ArgumentNullException(nameof(transientPayload), "Property is not nullable for class KratosUpdateSettingsFlowWithPasswordMethod.");

            return new KratosUpdateSettingsFlowWithPasswordMethod(method.Value!, password.Value!, csrfToken, transientPayload);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateSettingsFlowWithPasswordMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateSettingsFlowWithPasswordMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateSettingsFlowWithPasswordMethod kratosUpdateSettingsFlowWithPasswordMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUpdateSettingsFlowWithPasswordMethod, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateSettingsFlowWithPasswordMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateSettingsFlowWithPasswordMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateSettingsFlowWithPasswordMethod kratosUpdateSettingsFlowWithPasswordMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUpdateSettingsFlowWithPasswordMethod.Method == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithPasswordMethod.Method), "Property is required for class KratosUpdateSettingsFlowWithPasswordMethod.");

            if (kratosUpdateSettingsFlowWithPasswordMethod.Password == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithPasswordMethod.Password), "Property is required for class KratosUpdateSettingsFlowWithPasswordMethod.");

            if (kratosUpdateSettingsFlowWithPasswordMethod.CsrfTokenOption.IsSet && kratosUpdateSettingsFlowWithPasswordMethod.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithPasswordMethod.CsrfToken), "Property is required for class KratosUpdateSettingsFlowWithPasswordMethod.");

            if (kratosUpdateSettingsFlowWithPasswordMethod.TransientPayloadOption.IsSet && kratosUpdateSettingsFlowWithPasswordMethod.TransientPayload == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithPasswordMethod.TransientPayload), "Property is required for class KratosUpdateSettingsFlowWithPasswordMethod.");

            writer.WriteString("method", kratosUpdateSettingsFlowWithPasswordMethod.Method);

            writer.WriteString("password", kratosUpdateSettingsFlowWithPasswordMethod.Password);

            if (kratosUpdateSettingsFlowWithPasswordMethod.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosUpdateSettingsFlowWithPasswordMethod.CsrfToken);

            if (kratosUpdateSettingsFlowWithPasswordMethod.TransientPayloadOption.IsSet)
            {
                writer.WritePropertyName("transient_payload");
                JsonSerializer.Serialize(writer, kratosUpdateSettingsFlowWithPasswordMethod.TransientPayload, jsonSerializerOptions);
            }
        }
    }
}
