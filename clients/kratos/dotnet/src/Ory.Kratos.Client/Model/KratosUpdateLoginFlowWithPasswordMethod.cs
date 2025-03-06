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
    /// Update Login Flow with Password Method
    /// </summary>
    public partial class KratosUpdateLoginFlowWithPasswordMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowWithPasswordMethod" /> class.
        /// </summary>
        /// <param name="identifier">Identifier is the email or username of the user trying to log in.</param>
        /// <param name="method">Method should be set to \&quot;password\&quot; when logging in using the identifier and password strategy.</param>
        /// <param name="password">The user&#39;s password.</param>
        /// <param name="csrfToken">Sending the anti-csrf token is only required for browser login flows.</param>
        /// <param name="passwordIdentifier">Identifier is the email or username of the user trying to log in. This field is deprecated!</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks</param>
        [JsonConstructor]
        public KratosUpdateLoginFlowWithPasswordMethod(string identifier, string method, string password, Option<string?> csrfToken = default, Option<string?> passwordIdentifier = default, Option<Object?> transientPayload = default)
        {
            Identifier = identifier;
            Method = method;
            Password = password;
            CsrfTokenOption = csrfToken;
            PasswordIdentifierOption = passwordIdentifier;
            TransientPayloadOption = transientPayload;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Identifier is the email or username of the user trying to log in.
        /// </summary>
        /// <value>Identifier is the email or username of the user trying to log in.</value>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Method should be set to \&quot;password\&quot; when logging in using the identifier and password strategy.
        /// </summary>
        /// <value>Method should be set to \&quot;password\&quot; when logging in using the identifier and password strategy.</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// The user&#39;s password.
        /// </summary>
        /// <value>The user&#39;s password.</value>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Used to track the state of CsrfToken
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CsrfTokenOption { get; private set; }

        /// <summary>
        /// Sending the anti-csrf token is only required for browser login flows.
        /// </summary>
        /// <value>Sending the anti-csrf token is only required for browser login flows.</value>
        [JsonPropertyName("csrf_token")]
        public string? CsrfToken { get { return this.CsrfTokenOption; } set { this.CsrfTokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of PasswordIdentifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PasswordIdentifierOption { get; private set; }

        /// <summary>
        /// Identifier is the email or username of the user trying to log in. This field is deprecated!
        /// </summary>
        /// <value>Identifier is the email or username of the user trying to log in. This field is deprecated!</value>
        [JsonPropertyName("password_identifier")]
        public string? PasswordIdentifier { get { return this.PasswordIdentifierOption; } set { this.PasswordIdentifierOption = new(value); } }

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
            sb.Append("class KratosUpdateLoginFlowWithPasswordMethod {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  PasswordIdentifier: ").Append(PasswordIdentifier).Append("\n");
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
    /// A Json converter for type <see cref="KratosUpdateLoginFlowWithPasswordMethod" />
    /// </summary>
    public class KratosUpdateLoginFlowWithPasswordMethodJsonConverter : JsonConverter<KratosUpdateLoginFlowWithPasswordMethod>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateLoginFlowWithPasswordMethod" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateLoginFlowWithPasswordMethod Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> identifier = default;
            Option<string?> method = default;
            Option<string?> password = default;
            Option<string?> csrfToken = default;
            Option<string?> passwordIdentifier = default;
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
                        case "identifier":
                            identifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "method":
                            method = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "password":
                            password = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "password_identifier":
                            passwordIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
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

            if (!identifier.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateLoginFlowWithPasswordMethod.", nameof(identifier));

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateLoginFlowWithPasswordMethod.", nameof(method));

            if (!password.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateLoginFlowWithPasswordMethod.", nameof(password));

            if (identifier.IsSet && identifier.Value == null)
                throw new ArgumentNullException(nameof(identifier), "Property is not nullable for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (password.IsSet && password.Value == null)
                throw new ArgumentNullException(nameof(password), "Property is not nullable for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (passwordIdentifier.IsSet && passwordIdentifier.Value == null)
                throw new ArgumentNullException(nameof(passwordIdentifier), "Property is not nullable for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (transientPayload.IsSet && transientPayload.Value == null)
                throw new ArgumentNullException(nameof(transientPayload), "Property is not nullable for class KratosUpdateLoginFlowWithPasswordMethod.");

            return new KratosUpdateLoginFlowWithPasswordMethod(identifier.Value!, method.Value!, password.Value!, csrfToken, passwordIdentifier, transientPayload);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateLoginFlowWithPasswordMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateLoginFlowWithPasswordMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateLoginFlowWithPasswordMethod kratosUpdateLoginFlowWithPasswordMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUpdateLoginFlowWithPasswordMethod, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateLoginFlowWithPasswordMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateLoginFlowWithPasswordMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateLoginFlowWithPasswordMethod kratosUpdateLoginFlowWithPasswordMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUpdateLoginFlowWithPasswordMethod.Identifier == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithPasswordMethod.Identifier), "Property is required for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (kratosUpdateLoginFlowWithPasswordMethod.Method == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithPasswordMethod.Method), "Property is required for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (kratosUpdateLoginFlowWithPasswordMethod.Password == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithPasswordMethod.Password), "Property is required for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (kratosUpdateLoginFlowWithPasswordMethod.CsrfTokenOption.IsSet && kratosUpdateLoginFlowWithPasswordMethod.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithPasswordMethod.CsrfToken), "Property is required for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (kratosUpdateLoginFlowWithPasswordMethod.PasswordIdentifierOption.IsSet && kratosUpdateLoginFlowWithPasswordMethod.PasswordIdentifier == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithPasswordMethod.PasswordIdentifier), "Property is required for class KratosUpdateLoginFlowWithPasswordMethod.");

            if (kratosUpdateLoginFlowWithPasswordMethod.TransientPayloadOption.IsSet && kratosUpdateLoginFlowWithPasswordMethod.TransientPayload == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithPasswordMethod.TransientPayload), "Property is required for class KratosUpdateLoginFlowWithPasswordMethod.");

            writer.WriteString("identifier", kratosUpdateLoginFlowWithPasswordMethod.Identifier);

            writer.WriteString("method", kratosUpdateLoginFlowWithPasswordMethod.Method);

            writer.WriteString("password", kratosUpdateLoginFlowWithPasswordMethod.Password);

            if (kratosUpdateLoginFlowWithPasswordMethod.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosUpdateLoginFlowWithPasswordMethod.CsrfToken);

            if (kratosUpdateLoginFlowWithPasswordMethod.PasswordIdentifierOption.IsSet)
                writer.WriteString("password_identifier", kratosUpdateLoginFlowWithPasswordMethod.PasswordIdentifier);

            if (kratosUpdateLoginFlowWithPasswordMethod.TransientPayloadOption.IsSet)
            {
                writer.WritePropertyName("transient_payload");
                JsonSerializer.Serialize(writer, kratosUpdateLoginFlowWithPasswordMethod.TransientPayload, jsonSerializerOptions);
            }
        }
    }
}
