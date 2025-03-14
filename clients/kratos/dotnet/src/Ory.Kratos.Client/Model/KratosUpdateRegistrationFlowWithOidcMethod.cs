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
    /// Update Registration Flow with OpenID Connect Method
    /// </summary>
    public partial class KratosUpdateRegistrationFlowWithOidcMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowWithOidcMethod" /> class.
        /// </summary>
        /// <param name="method">Method to use  This field must be set to &#x60;oidc&#x60; when using the oidc method.</param>
        /// <param name="provider">The provider to register with</param>
        /// <param name="csrfToken">The CSRF Token</param>
        /// <param name="idToken">IDToken is an optional id token provided by an OIDC provider  If submitted, it is verified using the OIDC provider&#39;s public key set and the claims are used to populate the OIDC credentials of the identity. If the OIDC provider does not store additional claims (such as name, etc.) in the IDToken itself, you can use the &#x60;traits&#x60; field to populate the identity&#39;s traits. Note, that Apple only includes the users email in the IDToken.  Supported providers are Apple Google</param>
        /// <param name="idTokenNonce">IDTokenNonce is the nonce, used when generating the IDToken. If the provider supports nonce validation, the nonce will be validated against this value and is required.</param>
        /// <param name="traits">The identity traits</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks</param>
        /// <param name="upstreamParameters">UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: &#x60;login_hint&#x60; (string): The &#x60;login_hint&#x60; parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. &#x60;hd&#x60; (string): The &#x60;hd&#x60; parameter limits the login/registration process to a Google Organization, e.g. &#x60;mycollege.edu&#x60;. &#x60;prompt&#x60; (string): The &#x60;prompt&#x60; specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. &#x60;select_account&#x60;.</param>
        [JsonConstructor]
        public KratosUpdateRegistrationFlowWithOidcMethod(string method, string provider, Option<string?> csrfToken = default, Option<string?> idToken = default, Option<string?> idTokenNonce = default, Option<Object?> traits = default, Option<Object?> transientPayload = default, Option<Object?> upstreamParameters = default)
        {
            Method = method;
            Provider = provider;
            CsrfTokenOption = csrfToken;
            IdTokenOption = idToken;
            IdTokenNonceOption = idTokenNonce;
            TraitsOption = traits;
            TransientPayloadOption = transientPayload;
            UpstreamParametersOption = upstreamParameters;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Method to use  This field must be set to &#x60;oidc&#x60; when using the oidc method.
        /// </summary>
        /// <value>Method to use  This field must be set to &#x60;oidc&#x60; when using the oidc method.</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// The provider to register with
        /// </summary>
        /// <value>The provider to register with</value>
        [JsonPropertyName("provider")]
        public string Provider { get; set; }

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
        /// Used to track the state of IdToken
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdTokenOption { get; private set; }

        /// <summary>
        /// IDToken is an optional id token provided by an OIDC provider  If submitted, it is verified using the OIDC provider&#39;s public key set and the claims are used to populate the OIDC credentials of the identity. If the OIDC provider does not store additional claims (such as name, etc.) in the IDToken itself, you can use the &#x60;traits&#x60; field to populate the identity&#39;s traits. Note, that Apple only includes the users email in the IDToken.  Supported providers are Apple Google
        /// </summary>
        /// <value>IDToken is an optional id token provided by an OIDC provider  If submitted, it is verified using the OIDC provider&#39;s public key set and the claims are used to populate the OIDC credentials of the identity. If the OIDC provider does not store additional claims (such as name, etc.) in the IDToken itself, you can use the &#x60;traits&#x60; field to populate the identity&#39;s traits. Note, that Apple only includes the users email in the IDToken.  Supported providers are Apple Google</value>
        [JsonPropertyName("id_token")]
        public string? IdToken { get { return this.IdTokenOption; } set { this.IdTokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of IdTokenNonce
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdTokenNonceOption { get; private set; }

        /// <summary>
        /// IDTokenNonce is the nonce, used when generating the IDToken. If the provider supports nonce validation, the nonce will be validated against this value and is required.
        /// </summary>
        /// <value>IDTokenNonce is the nonce, used when generating the IDToken. If the provider supports nonce validation, the nonce will be validated against this value and is required.</value>
        [JsonPropertyName("id_token_nonce")]
        public string? IdTokenNonce { get { return this.IdTokenNonceOption; } set { this.IdTokenNonceOption = new(value); } }

        /// <summary>
        /// Used to track the state of Traits
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> TraitsOption { get; private set; }

        /// <summary>
        /// The identity traits
        /// </summary>
        /// <value>The identity traits</value>
        [JsonPropertyName("traits")]
        public Object? Traits { get { return this.TraitsOption; } set { this.TraitsOption = new(value); } }

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
        /// Used to track the state of UpstreamParameters
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> UpstreamParametersOption { get; private set; }

        /// <summary>
        /// UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: &#x60;login_hint&#x60; (string): The &#x60;login_hint&#x60; parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. &#x60;hd&#x60; (string): The &#x60;hd&#x60; parameter limits the login/registration process to a Google Organization, e.g. &#x60;mycollege.edu&#x60;. &#x60;prompt&#x60; (string): The &#x60;prompt&#x60; specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. &#x60;select_account&#x60;.
        /// </summary>
        /// <value>UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: &#x60;login_hint&#x60; (string): The &#x60;login_hint&#x60; parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. &#x60;hd&#x60; (string): The &#x60;hd&#x60; parameter limits the login/registration process to a Google Organization, e.g. &#x60;mycollege.edu&#x60;. &#x60;prompt&#x60; (string): The &#x60;prompt&#x60; specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. &#x60;select_account&#x60;.</value>
        [JsonPropertyName("upstream_parameters")]
        public Object? UpstreamParameters { get { return this.UpstreamParametersOption; } set { this.UpstreamParametersOption = new(value); } }

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
            sb.Append("class KratosUpdateRegistrationFlowWithOidcMethod {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  IdTokenNonce: ").Append(IdTokenNonce).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
            sb.Append("  UpstreamParameters: ").Append(UpstreamParameters).Append("\n");
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
    /// A Json converter for type <see cref="KratosUpdateRegistrationFlowWithOidcMethod" />
    /// </summary>
    public class KratosUpdateRegistrationFlowWithOidcMethodJsonConverter : JsonConverter<KratosUpdateRegistrationFlowWithOidcMethod>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateRegistrationFlowWithOidcMethod" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateRegistrationFlowWithOidcMethod Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> method = default;
            Option<string?> provider = default;
            Option<string?> csrfToken = default;
            Option<string?> idToken = default;
            Option<string?> idTokenNonce = default;
            Option<Object?> traits = default;
            Option<Object?> transientPayload = default;
            Option<Object?> upstreamParameters = default;

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
                        case "provider":
                            provider = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id_token":
                            idToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id_token_nonce":
                            idTokenNonce = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "traits":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                traits = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "transient_payload":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transientPayload = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "upstream_parameters":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                upstreamParameters = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.", nameof(method));

            if (!provider.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.", nameof(provider));

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (provider.IsSet && provider.Value == null)
                throw new ArgumentNullException(nameof(provider), "Property is not nullable for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (idToken.IsSet && idToken.Value == null)
                throw new ArgumentNullException(nameof(idToken), "Property is not nullable for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (idTokenNonce.IsSet && idTokenNonce.Value == null)
                throw new ArgumentNullException(nameof(idTokenNonce), "Property is not nullable for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (traits.IsSet && traits.Value == null)
                throw new ArgumentNullException(nameof(traits), "Property is not nullable for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (transientPayload.IsSet && transientPayload.Value == null)
                throw new ArgumentNullException(nameof(transientPayload), "Property is not nullable for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (upstreamParameters.IsSet && upstreamParameters.Value == null)
                throw new ArgumentNullException(nameof(upstreamParameters), "Property is not nullable for class KratosUpdateRegistrationFlowWithOidcMethod.");

            return new KratosUpdateRegistrationFlowWithOidcMethod(method.Value!, provider.Value!, csrfToken, idToken, idTokenNonce, traits, transientPayload, upstreamParameters);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateRegistrationFlowWithOidcMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateRegistrationFlowWithOidcMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateRegistrationFlowWithOidcMethod kratosUpdateRegistrationFlowWithOidcMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUpdateRegistrationFlowWithOidcMethod, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateRegistrationFlowWithOidcMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateRegistrationFlowWithOidcMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateRegistrationFlowWithOidcMethod kratosUpdateRegistrationFlowWithOidcMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUpdateRegistrationFlowWithOidcMethod.Method == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithOidcMethod.Method), "Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (kratosUpdateRegistrationFlowWithOidcMethod.Provider == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithOidcMethod.Provider), "Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (kratosUpdateRegistrationFlowWithOidcMethod.CsrfTokenOption.IsSet && kratosUpdateRegistrationFlowWithOidcMethod.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithOidcMethod.CsrfToken), "Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (kratosUpdateRegistrationFlowWithOidcMethod.IdTokenOption.IsSet && kratosUpdateRegistrationFlowWithOidcMethod.IdToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithOidcMethod.IdToken), "Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (kratosUpdateRegistrationFlowWithOidcMethod.IdTokenNonceOption.IsSet && kratosUpdateRegistrationFlowWithOidcMethod.IdTokenNonce == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithOidcMethod.IdTokenNonce), "Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (kratosUpdateRegistrationFlowWithOidcMethod.TraitsOption.IsSet && kratosUpdateRegistrationFlowWithOidcMethod.Traits == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithOidcMethod.Traits), "Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (kratosUpdateRegistrationFlowWithOidcMethod.TransientPayloadOption.IsSet && kratosUpdateRegistrationFlowWithOidcMethod.TransientPayload == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithOidcMethod.TransientPayload), "Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.");

            if (kratosUpdateRegistrationFlowWithOidcMethod.UpstreamParametersOption.IsSet && kratosUpdateRegistrationFlowWithOidcMethod.UpstreamParameters == null)
                throw new ArgumentNullException(nameof(kratosUpdateRegistrationFlowWithOidcMethod.UpstreamParameters), "Property is required for class KratosUpdateRegistrationFlowWithOidcMethod.");

            writer.WriteString("method", kratosUpdateRegistrationFlowWithOidcMethod.Method);

            writer.WriteString("provider", kratosUpdateRegistrationFlowWithOidcMethod.Provider);

            if (kratosUpdateRegistrationFlowWithOidcMethod.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosUpdateRegistrationFlowWithOidcMethod.CsrfToken);

            if (kratosUpdateRegistrationFlowWithOidcMethod.IdTokenOption.IsSet)
                writer.WriteString("id_token", kratosUpdateRegistrationFlowWithOidcMethod.IdToken);

            if (kratosUpdateRegistrationFlowWithOidcMethod.IdTokenNonceOption.IsSet)
                writer.WriteString("id_token_nonce", kratosUpdateRegistrationFlowWithOidcMethod.IdTokenNonce);

            if (kratosUpdateRegistrationFlowWithOidcMethod.TraitsOption.IsSet)
            {
                writer.WritePropertyName("traits");
                JsonSerializer.Serialize(writer, kratosUpdateRegistrationFlowWithOidcMethod.Traits, jsonSerializerOptions);
            }
            if (kratosUpdateRegistrationFlowWithOidcMethod.TransientPayloadOption.IsSet)
            {
                writer.WritePropertyName("transient_payload");
                JsonSerializer.Serialize(writer, kratosUpdateRegistrationFlowWithOidcMethod.TransientPayload, jsonSerializerOptions);
            }
            if (kratosUpdateRegistrationFlowWithOidcMethod.UpstreamParametersOption.IsSet)
            {
                writer.WritePropertyName("upstream_parameters");
                JsonSerializer.Serialize(writer, kratosUpdateRegistrationFlowWithOidcMethod.UpstreamParameters, jsonSerializerOptions);
            }
        }
    }
}
