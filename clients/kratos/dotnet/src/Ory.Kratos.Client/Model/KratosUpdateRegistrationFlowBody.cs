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
    /// Update Registration Request Body
    /// </summary>
    public partial class KratosUpdateRegistrationFlowBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateRegistrationFlowWithPasswordMethod"></param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithPasswordMethod kratosUpdateRegistrationFlowWithPasswordMethod)
        {
            KratosUpdateRegistrationFlowWithPasswordMethod = kratosUpdateRegistrationFlowWithPasswordMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateRegistrationFlowWithOidcMethod"></param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithOidcMethod kratosUpdateRegistrationFlowWithOidcMethod)
        {
            KratosUpdateRegistrationFlowWithOidcMethod = kratosUpdateRegistrationFlowWithOidcMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateRegistrationFlowWithWebAuthnMethod"></param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithWebAuthnMethod kratosUpdateRegistrationFlowWithWebAuthnMethod)
        {
            KratosUpdateRegistrationFlowWithWebAuthnMethod = kratosUpdateRegistrationFlowWithWebAuthnMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateRegistrationFlowWithCodeMethod"></param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithCodeMethod kratosUpdateRegistrationFlowWithCodeMethod)
        {
            KratosUpdateRegistrationFlowWithCodeMethod = kratosUpdateRegistrationFlowWithCodeMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateRegistrationFlowWithPasskeyMethod"></param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithPasskeyMethod kratosUpdateRegistrationFlowWithPasskeyMethod)
        {
            KratosUpdateRegistrationFlowWithPasskeyMethod = kratosUpdateRegistrationFlowWithPasskeyMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateRegistrationFlowWithProfileMethod"></param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithProfileMethod kratosUpdateRegistrationFlowWithProfileMethod)
        {
            KratosUpdateRegistrationFlowWithProfileMethod = kratosUpdateRegistrationFlowWithProfileMethod;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets KratosUpdateRegistrationFlowWithPasswordMethod
        /// </summary>
        public KratosUpdateRegistrationFlowWithPasswordMethod? KratosUpdateRegistrationFlowWithPasswordMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateRegistrationFlowWithOidcMethod
        /// </summary>
        public KratosUpdateRegistrationFlowWithOidcMethod? KratosUpdateRegistrationFlowWithOidcMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateRegistrationFlowWithWebAuthnMethod
        /// </summary>
        public KratosUpdateRegistrationFlowWithWebAuthnMethod? KratosUpdateRegistrationFlowWithWebAuthnMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateRegistrationFlowWithCodeMethod
        /// </summary>
        public KratosUpdateRegistrationFlowWithCodeMethod? KratosUpdateRegistrationFlowWithCodeMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateRegistrationFlowWithPasskeyMethod
        /// </summary>
        public KratosUpdateRegistrationFlowWithPasskeyMethod? KratosUpdateRegistrationFlowWithPasskeyMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateRegistrationFlowWithProfileMethod
        /// </summary>
        public KratosUpdateRegistrationFlowWithProfileMethod? KratosUpdateRegistrationFlowWithProfileMethod { get; set; }

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
            sb.Append("class KratosUpdateRegistrationFlowBody {\n");
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosUpdateRegistrationFlowBody" />
    /// </summary>
    public class KratosUpdateRegistrationFlowBodyJsonConverter : JsonConverter<KratosUpdateRegistrationFlowBody>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateRegistrationFlowBody" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateRegistrationFlowBody Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> method = default;

            Utf8JsonReader utf8JsonReaderDiscriminator = utf8JsonReader;
            while (utf8JsonReaderDiscriminator.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (utf8JsonReaderDiscriminator.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReaderDiscriminator.GetString();
                    utf8JsonReaderDiscriminator.Read();
                    if (localVarJsonPropertyName?.Equals("method") ?? false)
                    {
                        string? discriminator = utf8JsonReaderDiscriminator.GetString();
                        if (discriminator?.Equals("code") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("oidc") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("passkey") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("password") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("profile") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("webauthn") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateRegistrationFlowWithCodeMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateRegistrationFlowWithOidcMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateRegistrationFlowWithPasskeyMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateRegistrationFlowWithPasswordMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateRegistrationFlowWithProfileMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateRegistrationFlowWithWebAuthnMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                    }
                }
            }

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
                        default:
                            break;
                    }
                }
            }

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateRegistrationFlowBody.", nameof(method));

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateRegistrationFlowBody.");

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            if ( != null)
                return new KratosUpdateRegistrationFlowBody();

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateRegistrationFlowBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateRegistrationFlowBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateRegistrationFlowBody kratosUpdateRegistrationFlowBody, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithPasswordMethod != null)
            {
                KratosUpdateRegistrationFlowWithPasswordMethodJsonConverter kratosUpdateRegistrationFlowWithPasswordMethodJsonConverter = (KratosUpdateRegistrationFlowWithPasswordMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithPasswordMethod.GetType()));
                kratosUpdateRegistrationFlowWithPasswordMethodJsonConverter.WriteProperties(writer, kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithPasswordMethod, jsonSerializerOptions);
            }

            if (kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithOidcMethod != null)
            {
                KratosUpdateRegistrationFlowWithOidcMethodJsonConverter kratosUpdateRegistrationFlowWithOidcMethodJsonConverter = (KratosUpdateRegistrationFlowWithOidcMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithOidcMethod.GetType()));
                kratosUpdateRegistrationFlowWithOidcMethodJsonConverter.WriteProperties(writer, kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithOidcMethod, jsonSerializerOptions);
            }

            if (kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithWebAuthnMethod != null)
            {
                KratosUpdateRegistrationFlowWithWebAuthnMethodJsonConverter kratosUpdateRegistrationFlowWithWebAuthnMethodJsonConverter = (KratosUpdateRegistrationFlowWithWebAuthnMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithWebAuthnMethod.GetType()));
                kratosUpdateRegistrationFlowWithWebAuthnMethodJsonConverter.WriteProperties(writer, kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithWebAuthnMethod, jsonSerializerOptions);
            }

            if (kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithCodeMethod != null)
            {
                KratosUpdateRegistrationFlowWithCodeMethodJsonConverter kratosUpdateRegistrationFlowWithCodeMethodJsonConverter = (KratosUpdateRegistrationFlowWithCodeMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithCodeMethod.GetType()));
                kratosUpdateRegistrationFlowWithCodeMethodJsonConverter.WriteProperties(writer, kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithCodeMethod, jsonSerializerOptions);
            }

            if (kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithPasskeyMethod != null)
            {
                KratosUpdateRegistrationFlowWithPasskeyMethodJsonConverter kratosUpdateRegistrationFlowWithPasskeyMethodJsonConverter = (KratosUpdateRegistrationFlowWithPasskeyMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithPasskeyMethod.GetType()));
                kratosUpdateRegistrationFlowWithPasskeyMethodJsonConverter.WriteProperties(writer, kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithPasskeyMethod, jsonSerializerOptions);
            }

            if (kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithProfileMethod != null)
            {
                KratosUpdateRegistrationFlowWithProfileMethodJsonConverter kratosUpdateRegistrationFlowWithProfileMethodJsonConverter = (KratosUpdateRegistrationFlowWithProfileMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithProfileMethod.GetType()));
                kratosUpdateRegistrationFlowWithProfileMethodJsonConverter.WriteProperties(writer, kratosUpdateRegistrationFlowBody.KratosUpdateRegistrationFlowWithProfileMethod, jsonSerializerOptions);
            }

            WriteProperties(writer, kratosUpdateRegistrationFlowBody, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateRegistrationFlowBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateRegistrationFlowBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateRegistrationFlowBody kratosUpdateRegistrationFlowBody, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
