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
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Ory.Kratos.Client.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Ory.Kratos.Client.Test")]

namespace Ory.Kratos.Client.Client
{
    /// <summary>
    /// Utility functions providing some benefit to API client consumers.
    /// </summary>
    public static partial class ClientUtils
    {

        /// <summary>
        /// A delegate for events.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public delegate void EventHandler<T>(object sender, T e) where T : EventArgs;

        /// <summary>
        /// An enum of headers
        /// </summary>
        public enum ApiKeyHeader
        {
            /// <summary>
            /// The Authorization header
            /// </summary>
            Authorization
        }

        /// <summary>
        /// Converte an ApiKeyHeader to a string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException"></exception>
        public static string ApiKeyHeaderToString(ApiKeyHeader value)
        {
            return value switch
            {
                ApiKeyHeader.Authorization => "Authorization",
                _ => throw new System.ComponentModel.InvalidEnumArgumentException(nameof(value), (int)value, typeof(ApiKeyHeader)),
            };
        }

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(string json, JsonSerializerOptions options, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T? result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(json, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(ref Utf8JsonReader reader, JsonSerializerOptions options, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T? result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(ref reader, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <param name="format">The DateTime serialization format.</param>
        /// <returns>Formatted string.</returns>
        public static string? ParameterToString(object? obj, string? format = ISO8601_DATETIME_FORMAT)
        {
            if (obj is DateTime dateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTime.ToString(format);
            if (obj is DateTimeOffset dateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTimeOffset.ToString(format);
            if (obj is DateOnly dateOnly)
                return dateOnly.ToString(format);
            if (obj is bool boolean)
                return boolean
                    ? "true"
                    : "false";
            if (obj is KratosAuthenticatorAssuranceLevel kratosAuthenticatorAssuranceLevel)
                return KratosAuthenticatorAssuranceLevelValueConverter.ToJsonValue(kratosAuthenticatorAssuranceLevel);
            if (obj is KratosConsistencyRequestParameters.ConsistencyEnum kratosConsistencyRequestParametersConsistencyEnum)
                return KratosConsistencyRequestParameters.ConsistencyEnumToJsonValue(kratosConsistencyRequestParametersConsistencyEnum);
            if (obj is KratosContinueWith.ActionEnum kratosContinueWithActionEnum)
                return KratosContinueWith.ActionEnumToJsonValue(kratosContinueWithActionEnum);
            if (obj is KratosContinueWithRecoveryUi.ActionEnum kratosContinueWithRecoveryUiActionEnum)
                return KratosContinueWithRecoveryUi.ActionEnumToJsonValue(kratosContinueWithRecoveryUiActionEnum);
            if (obj is KratosContinueWithRedirectBrowserTo.ActionEnum kratosContinueWithRedirectBrowserToActionEnum)
                return KratosContinueWithRedirectBrowserTo.ActionEnumToJsonValue(kratosContinueWithRedirectBrowserToActionEnum);
            if (obj is KratosContinueWithSetOrySessionToken.ActionEnum kratosContinueWithSetOrySessionTokenActionEnum)
                return KratosContinueWithSetOrySessionToken.ActionEnumToJsonValue(kratosContinueWithSetOrySessionTokenActionEnum);
            if (obj is KratosContinueWithSettingsUi.ActionEnum kratosContinueWithSettingsUiActionEnum)
                return KratosContinueWithSettingsUi.ActionEnumToJsonValue(kratosContinueWithSettingsUiActionEnum);
            if (obj is KratosContinueWithVerificationUi.ActionEnum kratosContinueWithVerificationUiActionEnum)
                return KratosContinueWithVerificationUi.ActionEnumToJsonValue(kratosContinueWithVerificationUiActionEnum);
            if (obj is KratosCourierMessageStatus kratosCourierMessageStatus)
                return KratosCourierMessageStatusValueConverter.ToJsonValue(kratosCourierMessageStatus);
            if (obj is KratosCourierMessageType kratosCourierMessageType)
                return KratosCourierMessageTypeValueConverter.ToJsonValue(kratosCourierMessageType);
            if (obj is KratosCreateIdentityBody.StateEnum kratosCreateIdentityBodyStateEnum)
                return KratosCreateIdentityBody.StateEnumToJsonValue(kratosCreateIdentityBodyStateEnum);
            if (obj is KratosIdentity.StateEnum kratosIdentityStateEnum)
                return KratosIdentity.StateEnumToJsonValue(kratosIdentityStateEnum);
            if (obj is KratosIdentityCredentials.TypeEnum kratosIdentityCredentialsTypeEnum)
                return KratosIdentityCredentials.TypeEnumToJsonValue(kratosIdentityCredentialsTypeEnum);
            if (obj is KratosIdentityPatchResponse.ActionEnum kratosIdentityPatchResponseActionEnum)
                return KratosIdentityPatchResponse.ActionEnumToJsonValue(kratosIdentityPatchResponseActionEnum);
            if (obj is KratosLoginFlow.ActiveEnum kratosLoginFlowActiveEnum)
                return KratosLoginFlow.ActiveEnumToJsonValue(kratosLoginFlowActiveEnum);
            if (obj is KratosLoginFlowState kratosLoginFlowState)
                return KratosLoginFlowStateValueConverter.ToJsonValue(kratosLoginFlowState);
            if (obj is KratosMessage.TemplateTypeEnum kratosMessageTemplateTypeEnum)
                return KratosMessage.TemplateTypeEnumToJsonValue(kratosMessageTemplateTypeEnum);
            if (obj is KratosMessageDispatch.StatusEnum kratosMessageDispatchStatusEnum)
                return KratosMessageDispatch.StatusEnumToJsonValue(kratosMessageDispatchStatusEnum);
            if (obj is KratosRecoveryFlowState kratosRecoveryFlowState)
                return KratosRecoveryFlowStateValueConverter.ToJsonValue(kratosRecoveryFlowState);
            if (obj is KratosRegistrationFlow.ActiveEnum kratosRegistrationFlowActiveEnum)
                return KratosRegistrationFlow.ActiveEnumToJsonValue(kratosRegistrationFlowActiveEnum);
            if (obj is KratosRegistrationFlowState kratosRegistrationFlowState)
                return KratosRegistrationFlowStateValueConverter.ToJsonValue(kratosRegistrationFlowState);
            if (obj is KratosSessionAuthenticationMethod.MethodEnum kratosSessionAuthenticationMethodMethodEnum)
                return KratosSessionAuthenticationMethod.MethodEnumToJsonValue(kratosSessionAuthenticationMethodMethodEnum);
            if (obj is KratosSettingsFlowState kratosSettingsFlowState)
                return KratosSettingsFlowStateValueConverter.ToJsonValue(kratosSettingsFlowState);
            if (obj is KratosUiNode.GroupEnum kratosUiNodeGroupEnum)
                return KratosUiNode.GroupEnumToJsonValue(kratosUiNodeGroupEnum);
            if (obj is KratosUiNode.TypeEnum kratosUiNodeTypeEnum)
                return KratosUiNode.TypeEnumToJsonValue(kratosUiNodeTypeEnum);
            if (obj is KratosUiNodeAnchorAttributes.NodeTypeEnum kratosUiNodeAnchorAttributesNodeTypeEnum)
                return KratosUiNodeAnchorAttributes.NodeTypeEnumToJsonValue(kratosUiNodeAnchorAttributesNodeTypeEnum);
            if (obj is KratosUiNodeAttributes.NodeTypeEnum kratosUiNodeAttributesNodeTypeEnum)
                return KratosUiNodeAttributes.NodeTypeEnumToJsonValue(kratosUiNodeAttributesNodeTypeEnum);
            if (obj is KratosUiNodeDivisionAttributes.NodeTypeEnum kratosUiNodeDivisionAttributesNodeTypeEnum)
                return KratosUiNodeDivisionAttributes.NodeTypeEnumToJsonValue(kratosUiNodeDivisionAttributesNodeTypeEnum);
            if (obj is KratosUiNodeImageAttributes.NodeTypeEnum kratosUiNodeImageAttributesNodeTypeEnum)
                return KratosUiNodeImageAttributes.NodeTypeEnumToJsonValue(kratosUiNodeImageAttributesNodeTypeEnum);
            if (obj is KratosUiNodeInputAttributes.NodeTypeEnum kratosUiNodeInputAttributesNodeTypeEnum)
                return KratosUiNodeInputAttributes.NodeTypeEnumToJsonValue(kratosUiNodeInputAttributesNodeTypeEnum);
            if (obj is KratosUiNodeInputAttributes.TypeEnum kratosUiNodeInputAttributesTypeEnum)
                return KratosUiNodeInputAttributes.TypeEnumToJsonValue(kratosUiNodeInputAttributesTypeEnum);
            if (obj is KratosUiNodeInputAttributes.AutocompleteEnum kratosUiNodeInputAttributesAutocompleteEnum)
                return KratosUiNodeInputAttributes.AutocompleteEnumToJsonValue(kratosUiNodeInputAttributesAutocompleteEnum);
            if (obj is KratosUiNodeInputAttributes.OnclickTriggerEnum kratosUiNodeInputAttributesOnclickTriggerEnum)
                return KratosUiNodeInputAttributes.OnclickTriggerEnumToJsonValue(kratosUiNodeInputAttributesOnclickTriggerEnum);
            if (obj is KratosUiNodeInputAttributes.OnloadTriggerEnum kratosUiNodeInputAttributesOnloadTriggerEnum)
                return KratosUiNodeInputAttributes.OnloadTriggerEnumToJsonValue(kratosUiNodeInputAttributesOnloadTriggerEnum);
            if (obj is KratosUiNodeScriptAttributes.NodeTypeEnum kratosUiNodeScriptAttributesNodeTypeEnum)
                return KratosUiNodeScriptAttributes.NodeTypeEnumToJsonValue(kratosUiNodeScriptAttributesNodeTypeEnum);
            if (obj is KratosUiNodeTextAttributes.NodeTypeEnum kratosUiNodeTextAttributesNodeTypeEnum)
                return KratosUiNodeTextAttributes.NodeTypeEnumToJsonValue(kratosUiNodeTextAttributesNodeTypeEnum);
            if (obj is KratosUiText.TypeEnum kratosUiTextTypeEnum)
                return KratosUiText.TypeEnumToJsonValue(kratosUiTextTypeEnum);
            if (obj is KratosUpdateIdentityBody.StateEnum kratosUpdateIdentityBodyStateEnum)
                return KratosUpdateIdentityBody.StateEnumToJsonValue(kratosUpdateIdentityBodyStateEnum);
            if (obj is KratosUpdateRecoveryFlowBody.MethodEnum kratosUpdateRecoveryFlowBodyMethodEnum)
                return KratosUpdateRecoveryFlowBody.MethodEnumToJsonValue(kratosUpdateRecoveryFlowBodyMethodEnum);
            if (obj is KratosUpdateRecoveryFlowWithCodeMethod.MethodEnum kratosUpdateRecoveryFlowWithCodeMethodMethodEnum)
                return KratosUpdateRecoveryFlowWithCodeMethod.MethodEnumToJsonValue(kratosUpdateRecoveryFlowWithCodeMethodMethodEnum);
            if (obj is KratosUpdateRecoveryFlowWithLinkMethod.MethodEnum kratosUpdateRecoveryFlowWithLinkMethodMethodEnum)
                return KratosUpdateRecoveryFlowWithLinkMethod.MethodEnumToJsonValue(kratosUpdateRecoveryFlowWithLinkMethodMethodEnum);
            if (obj is KratosUpdateRegistrationFlowWithProfileMethod.ScreenEnum kratosUpdateRegistrationFlowWithProfileMethodScreenEnum)
                return KratosUpdateRegistrationFlowWithProfileMethod.ScreenEnumToJsonValue(kratosUpdateRegistrationFlowWithProfileMethodScreenEnum);
            if (obj is KratosUpdateVerificationFlowBody.MethodEnum kratosUpdateVerificationFlowBodyMethodEnum)
                return KratosUpdateVerificationFlowBody.MethodEnumToJsonValue(kratosUpdateVerificationFlowBodyMethodEnum);
            if (obj is KratosUpdateVerificationFlowWithCodeMethod.MethodEnum kratosUpdateVerificationFlowWithCodeMethodMethodEnum)
                return KratosUpdateVerificationFlowWithCodeMethod.MethodEnumToJsonValue(kratosUpdateVerificationFlowWithCodeMethodMethodEnum);
            if (obj is KratosUpdateVerificationFlowWithLinkMethod.MethodEnum kratosUpdateVerificationFlowWithLinkMethodMethodEnum)
                return KratosUpdateVerificationFlowWithLinkMethod.MethodEnumToJsonValue(kratosUpdateVerificationFlowWithLinkMethodMethodEnum);
            if (obj is KratosVerifiableIdentityAddress.ViaEnum kratosVerifiableIdentityAddressViaEnum)
                return KratosVerifiableIdentityAddress.ViaEnumToJsonValue(kratosVerifiableIdentityAddressViaEnum);
            if (obj is KratosVerificationFlowState kratosVerificationFlowState)
                return KratosVerificationFlowStateValueConverter.ToJsonValue(kratosVerificationFlowState);
            if (obj is ICollection collection)
            {
                List<string?> entries = new();
                foreach (var entry in collection)
                    entries.Add(ParameterToString(entry));
                return string.Join(",", entries);
            }

            return Convert.ToString(obj, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">string to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(global::System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            using (var ms = new MemoryStream())
            {
                inputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public static string? SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public static string? SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Provides a case-insensitive check that a provided content type is a known JSON-like content type.
        /// </summary>
        [GeneratedRegex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$")]
        private static partial Regex JsonRegex();

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public static bool IsJsonMime(string mime)
        {
            if (string.IsNullOrWhiteSpace(mime)) return false;

            return JsonRegex().IsMatch(mime) || mime.Equals("application/json-patch+json");
        }

        /// <summary>
        /// Get the discriminator
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="discriminator"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public static string? GetDiscriminator(Utf8JsonReader utf8JsonReader, string discriminator)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

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

                    if (localVarJsonPropertyName != null && localVarJsonPropertyName.Equals(discriminator))
                        return utf8JsonReader.GetString();
                }
            }

            throw new JsonException("The specified discriminator was not found.");
        }

        /// <summary>
        /// The base path of the API
        /// </summary>
        public const string BASE_ADDRESS = "http://localhost";

        /// <summary>
        /// The scheme of the API
        /// </summary>
        public const string SCHEME = "http";

        /// <summary>
        /// The context path of the API
        /// </summary>
        public const string CONTEXT_PATH = "";

        /// <summary>
        /// The host of the API
        /// </summary>
        public const string HOST = "localhost";

        /// <summary>
        /// The format to use for DateTime serialization
        /// </summary>
        public const string ISO8601_DATETIME_FORMAT = "o";
    }
}
