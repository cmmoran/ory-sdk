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
    /// Update Registration Flow with Code Method
    /// </summary>
    public partial class KratosUpdateRegistrationFlowWithCodeMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowWithCodeMethod" /> class.
        /// </summary>
        /// <param name="method">Method to use  This field must be set to &#x60;code&#x60; when using the code method.</param>
        /// <param name="traits">The identity&#39;s traits</param>
        /// <param name="code">The OTP Code sent to the user</param>
        /// <param name="csrfToken">The CSRF Token</param>
        /// <param name="resend">Resend restarts the flow with a new code</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks</param>
        [JsonConstructor]
        public KratosUpdateRegistrationFlowWithCodeMethod(string method, Object traits, Option<string?> code = default, Option<string?> csrfToken = default, Option<string?> resend = default, Option<Object?> transientPayload = default)
        {
            Method = method;
            Traits = traits;
            CodeOption = code;
            CsrfTokenOption = csrfToken;
            ResendOption = resend;
            TransientPayloadOption = transientPayload;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Method to use  This field must be set to &#x60;code&#x60; when using the code method.
        /// </summary>
        /// <value>Method to use  This field must be set to &#x60;code&#x60; when using the code method.</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// The identity&#39;s traits
        /// </summary>
        /// <value>The identity&#39;s traits</value>
        [JsonPropertyName("traits")]
        public Object Traits { get; set; }

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CodeOption { get; private set; }

        /// <summary>
        /// The OTP Code sent to the user
        /// </summary>
        /// <value>The OTP Code sent to the user</value>
        [JsonPropertyName("code")]
        public string? Code { get { return this.CodeOption; } set { this.CodeOption = new(value); } }

        /// <summary>
        /// Used to track the state of CsrfToken
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CsrfTokenOption { get; private set; }

        /// <summary>
        /// The CSRF Token
        /// </summary>
        /// <value>The CSRF Token</value>
        [JsonPropertyName("csrf_token")]
        public string? CsrfToken { get { return this.CsrfTokenOption; } set { this.CsrfTokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of Resend
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ResendOption { get; private set; }

        /// <summary>
        /// Resend restarts the flow with a new code
        /// </summary>
        /// <value>Resend restarts the flow with a new code</value>
        [JsonPropertyName("resend")]
        public string? Resend { get { return this.ResendOption; } set { this.ResendOption = new(value); } }

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
            sb.Append("class KratosUpdateRegistrationFlowWithCodeMethod {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Resend: ").Append(Resend).Append("\n");
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
    /// A Json converter for type <see cref="KratosUpdateRegistrationFlowWithCodeMethod" />
    /// </summary>
    public class KratosUpdateRegistrationFlowWithCodeMethodJsonConverter : JsonConverter<KratosUpdateRegistrationFlowWithCodeMethod>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateRegistrationFlowWithCodeMethod" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateRegistrationFlowWithCodeMethod Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> method = default;
            Option<Object?> traits = default;
            Option<string?> code = default;
            Option<string?> csrfToken = default;
            Option<string?> resend = default;
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
                        case "traits":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                traits = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "code":
                            code = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "resend":
                            resend = new Option<string?>(utf8JsonReader.GetString()!);
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
                throw new ArgumentException("Property is required for class KratosUpdateRegistrationFlowWithCodeMethod.", nameof(method));

            if (!traits.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateRegistrationFlowWithCodeMethod.", nameof(traits));

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (traits.IsSet && traits.Value == null)
                throw new ArgumentNullException(nameof(traits), "Property is not nullable for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (resend.IsSet && resend.Value == null)
                throw new ArgumentNullException(nameof(resend), "Property is not nullable for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (transientPayload.IsSet && transientPayload.Value == null)
                throw new ArgumentNullException(nameof(transientPayload), "Property is not nullable for class KratosUpdateRegistrationFlowWithCodeMethod.");

            return new KratosUpdateRegistrationFlowWithCodeMethod(method.Value!, traits.Value!, code, csrfToken, resend, transientPayload);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateRegistrationFlowWithCodeMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateRegistrationFlowWithCodeMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateRegistrationFlowWithCodeMethod kratosUpdateRegistrationFlowWithCodeMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUpdateRegistrationFlowWithCodeMethod, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateRegistrationFlowWithCodeMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateRegistrationFlowWithCodeMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateRegistrationFlowWithCodeMethod kratosUpdateRegistrationFlowWithCodeMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUpdateRegistrationFlowWithCodeMethod.Method == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithCodeMethod.Method), "Property is required for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (kratosUpdateRegistrationFlowWithCodeMethod.Traits == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithCodeMethod.Traits), "Property is required for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (kratosUpdateRegistrationFlowWithCodeMethod.CodeOption.IsSet && kratosUpdateRegistrationFlowWithCodeMethod.Code == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithCodeMethod.Code), "Property is required for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (kratosUpdateRegistrationFlowWithCodeMethod.CsrfTokenOption.IsSet && kratosUpdateRegistrationFlowWithCodeMethod.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithCodeMethod.CsrfToken), "Property is required for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (kratosUpdateRegistrationFlowWithCodeMethod.ResendOption.IsSet && kratosUpdateRegistrationFlowWithCodeMethod.Resend == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithCodeMethod.Resend), "Property is required for class KratosUpdateRegistrationFlowWithCodeMethod.");

            if (kratosUpdateRegistrationFlowWithCodeMethod.TransientPayloadOption.IsSet && kratosUpdateRegistrationFlowWithCodeMethod.TransientPayload == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithCodeMethod.TransientPayload), "Property is required for class KratosUpdateRegistrationFlowWithCodeMethod.");

            writer.WriteString("method", kratosUpdateRegistrationFlowWithCodeMethod.Method);

            writer.WritePropertyName("traits");
            JsonSerializer.Serialize(writer, kratosUpdateRegistrationFlowWithCodeMethod.Traits, jsonSerializerOptions);
            if (kratosUpdateRegistrationFlowWithCodeMethod.CodeOption.IsSet)
                writer.WriteString("code", kratosUpdateRegistrationFlowWithCodeMethod.Code);

            if (kratosUpdateRegistrationFlowWithCodeMethod.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosUpdateRegistrationFlowWithCodeMethod.CsrfToken);

            if (kratosUpdateRegistrationFlowWithCodeMethod.ResendOption.IsSet)
                writer.WriteString("resend", kratosUpdateRegistrationFlowWithCodeMethod.Resend);

            if (kratosUpdateRegistrationFlowWithCodeMethod.TransientPayloadOption.IsSet)
            {
                writer.WritePropertyName("transient_payload");
                JsonSerializer.Serialize(writer, kratosUpdateRegistrationFlowWithCodeMethod.TransientPayload, jsonSerializerOptions);
            }
        }
    }
}
