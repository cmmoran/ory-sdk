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
    /// Update Settings Flow with Passkey Method
    /// </summary>
    public partial class KratosUpdateSettingsFlowWithPasskeyMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowWithPasskeyMethod" /> class.
        /// </summary>
        /// <param name="method">Method  Should be set to \&quot;passkey\&quot; when trying to add, update, or remove a webAuthn pairing.</param>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token</param>
        /// <param name="passkeyRemove">Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.</param>
        /// <param name="passkeySettingsRegister">Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.</param>
        [JsonConstructor]
        public KratosUpdateSettingsFlowWithPasskeyMethod(string method, Option<string?> csrfToken = default, Option<string?> passkeyRemove = default, Option<string?> passkeySettingsRegister = default)
        {
            Method = method;
            CsrfTokenOption = csrfToken;
            PasskeyRemoveOption = passkeyRemove;
            PasskeySettingsRegisterOption = passkeySettingsRegister;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Method  Should be set to \&quot;passkey\&quot; when trying to add, update, or remove a webAuthn pairing.
        /// </summary>
        /// <value>Method  Should be set to \&quot;passkey\&quot; when trying to add, update, or remove a webAuthn pairing.</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

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
        /// Used to track the state of PasskeyRemove
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PasskeyRemoveOption { get; private set; }

        /// <summary>
        /// Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.
        /// </summary>
        /// <value>Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.</value>
        [JsonPropertyName("passkey_remove")]
        public string? PasskeyRemove { get { return this.PasskeyRemoveOption; } set { this.PasskeyRemoveOption = new(value); } }

        /// <summary>
        /// Used to track the state of PasskeySettingsRegister
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PasskeySettingsRegisterOption { get; private set; }

        /// <summary>
        /// Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.
        /// </summary>
        /// <value>Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.</value>
        [JsonPropertyName("passkey_settings_register")]
        public string? PasskeySettingsRegister { get { return this.PasskeySettingsRegisterOption; } set { this.PasskeySettingsRegisterOption = new(value); } }

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
            sb.Append("class KratosUpdateSettingsFlowWithPasskeyMethod {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  PasskeyRemove: ").Append(PasskeyRemove).Append("\n");
            sb.Append("  PasskeySettingsRegister: ").Append(PasskeySettingsRegister).Append("\n");
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
    /// A Json converter for type <see cref="KratosUpdateSettingsFlowWithPasskeyMethod" />
    /// </summary>
    public class KratosUpdateSettingsFlowWithPasskeyMethodJsonConverter : JsonConverter<KratosUpdateSettingsFlowWithPasskeyMethod>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateSettingsFlowWithPasskeyMethod" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateSettingsFlowWithPasskeyMethod Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> method = default;
            Option<string?> csrfToken = default;
            Option<string?> passkeyRemove = default;
            Option<string?> passkeySettingsRegister = default;

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
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "passkey_remove":
                            passkeyRemove = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "passkey_settings_register":
                            passkeySettingsRegister = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateSettingsFlowWithPasskeyMethod.", nameof(method));

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateSettingsFlowWithPasskeyMethod.");

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosUpdateSettingsFlowWithPasskeyMethod.");

            if (passkeyRemove.IsSet && passkeyRemove.Value == null)
                throw new ArgumentNullException(nameof(passkeyRemove), "Property is not nullable for class KratosUpdateSettingsFlowWithPasskeyMethod.");

            if (passkeySettingsRegister.IsSet && passkeySettingsRegister.Value == null)
                throw new ArgumentNullException(nameof(passkeySettingsRegister), "Property is not nullable for class KratosUpdateSettingsFlowWithPasskeyMethod.");

            return new KratosUpdateSettingsFlowWithPasskeyMethod(method.Value!, csrfToken, passkeyRemove, passkeySettingsRegister);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateSettingsFlowWithPasskeyMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateSettingsFlowWithPasskeyMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateSettingsFlowWithPasskeyMethod kratosUpdateSettingsFlowWithPasskeyMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUpdateSettingsFlowWithPasskeyMethod, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateSettingsFlowWithPasskeyMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateSettingsFlowWithPasskeyMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateSettingsFlowWithPasskeyMethod kratosUpdateSettingsFlowWithPasskeyMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUpdateSettingsFlowWithPasskeyMethod.Method == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithPasskeyMethod.Method), "Property is required for class KratosUpdateSettingsFlowWithPasskeyMethod.");

            if (kratosUpdateSettingsFlowWithPasskeyMethod.CsrfTokenOption.IsSet && kratosUpdateSettingsFlowWithPasskeyMethod.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithPasskeyMethod.CsrfToken), "Property is required for class KratosUpdateSettingsFlowWithPasskeyMethod.");

            if (kratosUpdateSettingsFlowWithPasskeyMethod.PasskeyRemoveOption.IsSet && kratosUpdateSettingsFlowWithPasskeyMethod.PasskeyRemove == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithPasskeyMethod.PasskeyRemove), "Property is required for class KratosUpdateSettingsFlowWithPasskeyMethod.");

            if (kratosUpdateSettingsFlowWithPasskeyMethod.PasskeySettingsRegisterOption.IsSet && kratosUpdateSettingsFlowWithPasskeyMethod.PasskeySettingsRegister == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithPasskeyMethod.PasskeySettingsRegister), "Property is required for class KratosUpdateSettingsFlowWithPasskeyMethod.");

            writer.WriteString("method", kratosUpdateSettingsFlowWithPasskeyMethod.Method);

            if (kratosUpdateSettingsFlowWithPasskeyMethod.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosUpdateSettingsFlowWithPasskeyMethod.CsrfToken);

            if (kratosUpdateSettingsFlowWithPasskeyMethod.PasskeyRemoveOption.IsSet)
                writer.WriteString("passkey_remove", kratosUpdateSettingsFlowWithPasskeyMethod.PasskeyRemove);

            if (kratosUpdateSettingsFlowWithPasskeyMethod.PasskeySettingsRegisterOption.IsSet)
                writer.WriteString("passkey_settings_register", kratosUpdateSettingsFlowWithPasskeyMethod.PasskeySettingsRegister);
        }
    }
}
