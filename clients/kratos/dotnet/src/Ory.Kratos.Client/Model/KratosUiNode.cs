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
    /// Nodes are represented as HTML elements or their native UI equivalents. For example, a node can be an &#x60;&lt;img&gt;&#x60; tag, or an &#x60;&lt;input element&gt;&#x60; but also &#x60;some plain text&#x60;.
    /// </summary>
    public partial class KratosUiNode : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNode" /> class.
        /// </summary>
        /// <param name="attributes">attributes</param>
        /// <param name="group">Group specifies which group (e.g. password authenticator) this node belongs to. default DefaultGroup password PasswordGroup oidc OpenIDConnectGroup profile ProfileGroup link LinkGroup code CodeGroup totp TOTPGroup lookup_secret LookupGroup webauthn WebAuthnGroup passkey PasskeyGroup identifier_first IdentifierFirstGroup captcha CaptchaGroup saml SAMLGroup</param>
        /// <param name="messages">messages</param>
        /// <param name="meta">meta</param>
        /// <param name="type">The node&#39;s type text Text input Input img Image a Anchor script Script div Division</param>
        [JsonConstructor]
        public KratosUiNode(KratosUiNodeAttributes attributes, GroupEnum group, List<KratosUiText> messages, KratosUiNodeMeta meta, TypeEnum type)
        {
            Attributes = attributes;
            Group = group;
            Messages = messages;
            Meta = meta;
            Type = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Group specifies which group (e.g. password authenticator) this node belongs to. default DefaultGroup password PasswordGroup oidc OpenIDConnectGroup profile ProfileGroup link LinkGroup code CodeGroup totp TOTPGroup lookup_secret LookupGroup webauthn WebAuthnGroup passkey PasskeyGroup identifier_first IdentifierFirstGroup captcha CaptchaGroup saml SAMLGroup
        /// </summary>
        /// <value>Group specifies which group (e.g. password authenticator) this node belongs to. default DefaultGroup password PasswordGroup oidc OpenIDConnectGroup profile ProfileGroup link LinkGroup code CodeGroup totp TOTPGroup lookup_secret LookupGroup webauthn WebAuthnGroup passkey PasskeyGroup identifier_first IdentifierFirstGroup captcha CaptchaGroup saml SAMLGroup</value>
        public enum GroupEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            Default = 1,

            /// <summary>
            /// Enum Password for value: password
            /// </summary>
            Password = 2,

            /// <summary>
            /// Enum Oidc for value: oidc
            /// </summary>
            Oidc = 3,

            /// <summary>
            /// Enum Profile for value: profile
            /// </summary>
            Profile = 4,

            /// <summary>
            /// Enum Link for value: link
            /// </summary>
            Link = 5,

            /// <summary>
            /// Enum Code for value: code
            /// </summary>
            Code = 6,

            /// <summary>
            /// Enum Totp for value: totp
            /// </summary>
            Totp = 7,

            /// <summary>
            /// Enum LookupSecret for value: lookup_secret
            /// </summary>
            LookupSecret = 8,

            /// <summary>
            /// Enum Webauthn for value: webauthn
            /// </summary>
            Webauthn = 9,

            /// <summary>
            /// Enum Passkey for value: passkey
            /// </summary>
            Passkey = 10,

            /// <summary>
            /// Enum IdentifierFirst for value: identifier_first
            /// </summary>
            IdentifierFirst = 11,

            /// <summary>
            /// Enum Captcha for value: captcha
            /// </summary>
            Captcha = 12,

            /// <summary>
            /// Enum Saml for value: saml
            /// </summary>
            Saml = 13
        }

        /// <summary>
        /// Returns a <see cref="GroupEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static GroupEnum GroupEnumFromString(string value)
        {
            if (value.Equals("default"))
                return GroupEnum.Default;

            if (value.Equals("password"))
                return GroupEnum.Password;

            if (value.Equals("oidc"))
                return GroupEnum.Oidc;

            if (value.Equals("profile"))
                return GroupEnum.Profile;

            if (value.Equals("link"))
                return GroupEnum.Link;

            if (value.Equals("code"))
                return GroupEnum.Code;

            if (value.Equals("totp"))
                return GroupEnum.Totp;

            if (value.Equals("lookup_secret"))
                return GroupEnum.LookupSecret;

            if (value.Equals("webauthn"))
                return GroupEnum.Webauthn;

            if (value.Equals("passkey"))
                return GroupEnum.Passkey;

            if (value.Equals("identifier_first"))
                return GroupEnum.IdentifierFirst;

            if (value.Equals("captcha"))
                return GroupEnum.Captcha;

            if (value.Equals("saml"))
                return GroupEnum.Saml;

            throw new NotImplementedException($"Could not convert value to type GroupEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="GroupEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GroupEnum? GroupEnumFromStringOrDefault(string value)
        {
            if (value.Equals("default"))
                return GroupEnum.Default;

            if (value.Equals("password"))
                return GroupEnum.Password;

            if (value.Equals("oidc"))
                return GroupEnum.Oidc;

            if (value.Equals("profile"))
                return GroupEnum.Profile;

            if (value.Equals("link"))
                return GroupEnum.Link;

            if (value.Equals("code"))
                return GroupEnum.Code;

            if (value.Equals("totp"))
                return GroupEnum.Totp;

            if (value.Equals("lookup_secret"))
                return GroupEnum.LookupSecret;

            if (value.Equals("webauthn"))
                return GroupEnum.Webauthn;

            if (value.Equals("passkey"))
                return GroupEnum.Passkey;

            if (value.Equals("identifier_first"))
                return GroupEnum.IdentifierFirst;

            if (value.Equals("captcha"))
                return GroupEnum.Captcha;

            if (value.Equals("saml"))
                return GroupEnum.Saml;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="GroupEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string GroupEnumToJsonValue(GroupEnum value)
        {
            if (value == GroupEnum.Default)
                return "default";

            if (value == GroupEnum.Password)
                return "password";

            if (value == GroupEnum.Oidc)
                return "oidc";

            if (value == GroupEnum.Profile)
                return "profile";

            if (value == GroupEnum.Link)
                return "link";

            if (value == GroupEnum.Code)
                return "code";

            if (value == GroupEnum.Totp)
                return "totp";

            if (value == GroupEnum.LookupSecret)
                return "lookup_secret";

            if (value == GroupEnum.Webauthn)
                return "webauthn";

            if (value == GroupEnum.Passkey)
                return "passkey";

            if (value == GroupEnum.IdentifierFirst)
                return "identifier_first";

            if (value == GroupEnum.Captcha)
                return "captcha";

            if (value == GroupEnum.Saml)
                return "saml";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Group specifies which group (e.g. password authenticator) this node belongs to. default DefaultGroup password PasswordGroup oidc OpenIDConnectGroup profile ProfileGroup link LinkGroup code CodeGroup totp TOTPGroup lookup_secret LookupGroup webauthn WebAuthnGroup passkey PasskeyGroup identifier_first IdentifierFirstGroup captcha CaptchaGroup saml SAMLGroup
        /// </summary>
        /// <value>Group specifies which group (e.g. password authenticator) this node belongs to. default DefaultGroup password PasswordGroup oidc OpenIDConnectGroup profile ProfileGroup link LinkGroup code CodeGroup totp TOTPGroup lookup_secret LookupGroup webauthn WebAuthnGroup passkey PasskeyGroup identifier_first IdentifierFirstGroup captcha CaptchaGroup saml SAMLGroup</value>
        [JsonPropertyName("group")]
        public GroupEnum Group { get; set; }

        /// <summary>
        /// The node&#39;s type text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>The node&#39;s type text Text input Input img Image a Anchor script Script div Division</value>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            Text = 1,

            /// <summary>
            /// Enum Input for value: input
            /// </summary>
            Input = 2,

            /// <summary>
            /// Enum Img for value: img
            /// </summary>
            Img = 3,

            /// <summary>
            /// Enum A for value: a
            /// </summary>
            A = 4,

            /// <summary>
            /// Enum Script for value: script
            /// </summary>
            Script = 5,

            /// <summary>
            /// Enum Div for value: div
            /// </summary>
            Div = 6
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("text"))
                return TypeEnum.Text;

            if (value.Equals("input"))
                return TypeEnum.Input;

            if (value.Equals("img"))
                return TypeEnum.Img;

            if (value.Equals("a"))
                return TypeEnum.A;

            if (value.Equals("script"))
                return TypeEnum.Script;

            if (value.Equals("div"))
                return TypeEnum.Div;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("text"))
                return TypeEnum.Text;

            if (value.Equals("input"))
                return TypeEnum.Input;

            if (value.Equals("img"))
                return TypeEnum.Img;

            if (value.Equals("a"))
                return TypeEnum.A;

            if (value.Equals("script"))
                return TypeEnum.Script;

            if (value.Equals("div"))
                return TypeEnum.Div;

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
            if (value == TypeEnum.Text)
                return "text";

            if (value == TypeEnum.Input)
                return "input";

            if (value == TypeEnum.Img)
                return "img";

            if (value == TypeEnum.A)
                return "a";

            if (value == TypeEnum.Script)
                return "script";

            if (value == TypeEnum.Div)
                return "div";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// The node&#39;s type text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>The node&#39;s type text Text input Input img Image a Anchor script Script div Division</value>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public KratosUiNodeAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [JsonPropertyName("messages")]
        public List<KratosUiText> Messages { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [JsonPropertyName("meta")]
        public KratosUiNodeMeta Meta { get; set; }

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
            sb.Append("class KratosUiNode {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="KratosUiNode" />
    /// </summary>
    public class KratosUiNodeJsonConverter : JsonConverter<KratosUiNode>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUiNode" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUiNode Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<KratosUiNodeAttributes?> attributes = default;
            Option<KratosUiNode.GroupEnum?> group = default;
            Option<List<KratosUiText>?> messages = default;
            Option<KratosUiNodeMeta?> meta = default;
            Option<KratosUiNode.TypeEnum?> type = default;

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
                        case "attributes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attributes = new Option<KratosUiNodeAttributes?>(JsonSerializer.Deserialize<KratosUiNodeAttributes>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "group":
                            string? groupRawValue = utf8JsonReader.GetString();
                            if (groupRawValue != null)
                                group = new Option<KratosUiNode.GroupEnum?>(KratosUiNode.GroupEnumFromStringOrDefault(groupRawValue));
                            break;
                        case "messages":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                messages = new Option<List<KratosUiText>?>(JsonSerializer.Deserialize<List<KratosUiText>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "meta":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                meta = new Option<KratosUiNodeMeta?>(JsonSerializer.Deserialize<KratosUiNodeMeta>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<KratosUiNode.TypeEnum?>(KratosUiNode.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!attributes.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNode.", nameof(attributes));

            if (!group.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNode.", nameof(group));

            if (!messages.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNode.", nameof(messages));

            if (!meta.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNode.", nameof(meta));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNode.", nameof(type));

            if (attributes.IsSet && attributes.Value == null)
                throw new ArgumentNullException(nameof(attributes), "Property is not nullable for class KratosUiNode.");

            if (group.IsSet && group.Value == null)
                throw new ArgumentNullException(nameof(group), "Property is not nullable for class KratosUiNode.");

            if (messages.IsSet && messages.Value == null)
                throw new ArgumentNullException(nameof(messages), "Property is not nullable for class KratosUiNode.");

            if (meta.IsSet && meta.Value == null)
                throw new ArgumentNullException(nameof(meta), "Property is not nullable for class KratosUiNode.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class KratosUiNode.");

            return new KratosUiNode(attributes.Value!, group.Value!.Value!, messages.Value!, meta.Value!, type.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUiNode" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNode"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUiNode kratosUiNode, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUiNode, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUiNode" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNode"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUiNode kratosUiNode, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUiNode.Attributes == null)
                throw new ArgumentNullException(nameof(kratosUiNode.Attributes), "Property is required for class KratosUiNode.");

            if (kratosUiNode.Messages == null)
                throw new ArgumentNullException(nameof(kratosUiNode.Messages), "Property is required for class KratosUiNode.");

            if (kratosUiNode.Meta == null)
                throw new ArgumentNullException(nameof(kratosUiNode.Meta), "Property is required for class KratosUiNode.");

            writer.WritePropertyName("attributes");
            JsonSerializer.Serialize(writer, kratosUiNode.Attributes, jsonSerializerOptions);
            var groupRawValue = KratosUiNode.GroupEnumToJsonValue(kratosUiNode.Group);
            writer.WriteString("group", groupRawValue);
            writer.WritePropertyName("messages");
            JsonSerializer.Serialize(writer, kratosUiNode.Messages, jsonSerializerOptions);
            writer.WritePropertyName("meta");
            JsonSerializer.Serialize(writer, kratosUiNode.Meta, jsonSerializerOptions);
            var typeRawValue = KratosUiNode.TypeEnumToJsonValue(kratosUiNode.Type);
            writer.WriteString("type", typeRawValue);
        }
    }
}
