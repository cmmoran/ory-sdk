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
    /// KratosUiNodeAnchorAttributes
    /// </summary>
    public partial class KratosUiNodeAnchorAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeAnchorAttributes" /> class.
        /// </summary>
        /// <param name="href">The link&#39;s href (destination) URL.  format: uri</param>
        /// <param name="id">A unique identifier</param>
        /// <param name="nodeType">NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script div Division</param>
        /// <param name="title">title</param>
        [JsonConstructor]
        public KratosUiNodeAnchorAttributes(string href, string id, NodeTypeEnum nodeType, KratosUiText title)
        {
            Href = href;
            Id = id;
            NodeType = nodeType;
            Title = title;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script div Division</value>
        public enum NodeTypeEnum
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
        /// Returns a <see cref="NodeTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static NodeTypeEnum NodeTypeEnumFromString(string value)
        {
            if (value.Equals("text"))
                return NodeTypeEnum.Text;

            if (value.Equals("input"))
                return NodeTypeEnum.Input;

            if (value.Equals("img"))
                return NodeTypeEnum.Img;

            if (value.Equals("a"))
                return NodeTypeEnum.A;

            if (value.Equals("script"))
                return NodeTypeEnum.Script;

            if (value.Equals("div"))
                return NodeTypeEnum.Div;

            throw new NotImplementedException($"Could not convert value to type NodeTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="NodeTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static NodeTypeEnum? NodeTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("text"))
                return NodeTypeEnum.Text;

            if (value.Equals("input"))
                return NodeTypeEnum.Input;

            if (value.Equals("img"))
                return NodeTypeEnum.Img;

            if (value.Equals("a"))
                return NodeTypeEnum.A;

            if (value.Equals("script"))
                return NodeTypeEnum.Script;

            if (value.Equals("div"))
                return NodeTypeEnum.Div;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="NodeTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string NodeTypeEnumToJsonValue(NodeTypeEnum value)
        {
            if (value == NodeTypeEnum.Text)
                return "text";

            if (value == NodeTypeEnum.Input)
                return "input";

            if (value == NodeTypeEnum.Img)
                return "img";

            if (value == NodeTypeEnum.A)
                return "a";

            if (value == NodeTypeEnum.Script)
                return "script";

            if (value == NodeTypeEnum.Div)
                return "div";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. text Text input Input img Image a Anchor script Script div Division</value>
        [JsonPropertyName("node_type")]
        public NodeTypeEnum NodeType { get; set; }

        /// <summary>
        /// The link&#39;s href (destination) URL.  format: uri
        /// </summary>
        /// <value>The link&#39;s href (destination) URL.  format: uri</value>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// A unique identifier
        /// </summary>
        /// <value>A unique identifier</value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public KratosUiText Title { get; set; }

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
            sb.Append("class KratosUiNodeAnchorAttributes {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
    /// A Json converter for type <see cref="KratosUiNodeAnchorAttributes" />
    /// </summary>
    public class KratosUiNodeAnchorAttributesJsonConverter : JsonConverter<KratosUiNodeAnchorAttributes>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUiNodeAnchorAttributes" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUiNodeAnchorAttributes Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> href = default;
            Option<string?> id = default;
            Option<KratosUiNodeAnchorAttributes.NodeTypeEnum?> nodeType = default;
            Option<KratosUiText?> title = default;

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
                        case "href":
                            href = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "node_type":
                            string? nodeTypeRawValue = utf8JsonReader.GetString();
                            if (nodeTypeRawValue != null)
                                nodeType = new Option<KratosUiNodeAnchorAttributes.NodeTypeEnum?>(KratosUiNodeAnchorAttributes.NodeTypeEnumFromStringOrDefault(nodeTypeRawValue));
                            break;
                        case "title":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                title = new Option<KratosUiText?>(JsonSerializer.Deserialize<KratosUiText>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!href.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeAnchorAttributes.", nameof(href));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeAnchorAttributes.", nameof(id));

            if (!nodeType.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeAnchorAttributes.", nameof(nodeType));

            if (!title.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeAnchorAttributes.", nameof(title));

            if (href.IsSet && href.Value == null)
                throw new ArgumentNullException(nameof(href), "Property is not nullable for class KratosUiNodeAnchorAttributes.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class KratosUiNodeAnchorAttributes.");

            if (nodeType.IsSet && nodeType.Value == null)
                throw new ArgumentNullException(nameof(nodeType), "Property is not nullable for class KratosUiNodeAnchorAttributes.");

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class KratosUiNodeAnchorAttributes.");

            return new KratosUiNodeAnchorAttributes(href.Value!, id.Value!, nodeType.Value!.Value!, title.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUiNodeAnchorAttributes" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNodeAnchorAttributes"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUiNodeAnchorAttributes kratosUiNodeAnchorAttributes, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUiNodeAnchorAttributes, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUiNodeAnchorAttributes" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNodeAnchorAttributes"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUiNodeAnchorAttributes kratosUiNodeAnchorAttributes, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUiNodeAnchorAttributes.Href == null)
                throw new ArgumentNullException(nameof(kratosUiNodeAnchorAttributes.Href), "Property is required for class KratosUiNodeAnchorAttributes.");

            if (kratosUiNodeAnchorAttributes.Id == null)
                throw new ArgumentNullException(nameof(kratosUiNodeAnchorAttributes.Id), "Property is required for class KratosUiNodeAnchorAttributes.");

            if (kratosUiNodeAnchorAttributes.Title == null)
                throw new ArgumentNullException(nameof(kratosUiNodeAnchorAttributes.Title), "Property is required for class KratosUiNodeAnchorAttributes.");

            writer.WriteString("href", kratosUiNodeAnchorAttributes.Href);

            writer.WriteString("id", kratosUiNodeAnchorAttributes.Id);

            var nodeTypeRawValue = KratosUiNodeAnchorAttributes.NodeTypeEnumToJsonValue(kratosUiNodeAnchorAttributes.NodeType);
            writer.WriteString("node_type", nodeTypeRawValue);
            writer.WritePropertyName("title");
            JsonSerializer.Serialize(writer, kratosUiNodeAnchorAttributes.Title, jsonSerializerOptions);
        }
    }
}
