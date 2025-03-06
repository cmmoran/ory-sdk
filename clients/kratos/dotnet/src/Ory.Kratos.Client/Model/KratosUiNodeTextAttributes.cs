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
    /// KratosUiNodeTextAttributes
    /// </summary>
    public partial class KratosUiNodeTextAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeTextAttributes" /> class.
        /// </summary>
        /// <param name="id">A unique identifier</param>
        /// <param name="nodeType">NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;text\&quot;. text Text input Input img Image a Anchor script Script div Division</param>
        /// <param name="text">text</param>
        [JsonConstructor]
        public KratosUiNodeTextAttributes(string id, NodeTypeEnum nodeType, KratosUiText text)
        {
            Id = id;
            NodeType = nodeType;
            Text = text;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;text\&quot;. text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;text\&quot;. text Text input Input img Image a Anchor script Script div Division</value>
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
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;text\&quot;. text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;text\&quot;. text Text input Input img Image a Anchor script Script div Division</value>
        [JsonPropertyName("node_type")]
        public NodeTypeEnum NodeType { get; set; }

        /// <summary>
        /// A unique identifier
        /// </summary>
        /// <value>A unique identifier</value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [JsonPropertyName("text")]
        public KratosUiText Text { get; set; }

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
            sb.Append("class KratosUiNodeTextAttributes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
    /// A Json converter for type <see cref="KratosUiNodeTextAttributes" />
    /// </summary>
    public class KratosUiNodeTextAttributesJsonConverter : JsonConverter<KratosUiNodeTextAttributes>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUiNodeTextAttributes" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUiNodeTextAttributes Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<KratosUiNodeTextAttributes.NodeTypeEnum?> nodeType = default;
            Option<KratosUiText?> text = default;

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
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "node_type":
                            string? nodeTypeRawValue = utf8JsonReader.GetString();
                            if (nodeTypeRawValue != null)
                                nodeType = new Option<KratosUiNodeTextAttributes.NodeTypeEnum?>(KratosUiNodeTextAttributes.NodeTypeEnumFromStringOrDefault(nodeTypeRawValue));
                            break;
                        case "text":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                text = new Option<KratosUiText?>(JsonSerializer.Deserialize<KratosUiText>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeTextAttributes.", nameof(id));

            if (!nodeType.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeTextAttributes.", nameof(nodeType));

            if (!text.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeTextAttributes.", nameof(text));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class KratosUiNodeTextAttributes.");

            if (nodeType.IsSet && nodeType.Value == null)
                throw new ArgumentNullException(nameof(nodeType), "Property is not nullable for class KratosUiNodeTextAttributes.");

            if (text.IsSet && text.Value == null)
                throw new ArgumentNullException(nameof(text), "Property is not nullable for class KratosUiNodeTextAttributes.");

            return new KratosUiNodeTextAttributes(id.Value!, nodeType.Value!.Value!, text.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUiNodeTextAttributes" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNodeTextAttributes"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUiNodeTextAttributes kratosUiNodeTextAttributes, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUiNodeTextAttributes, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUiNodeTextAttributes" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNodeTextAttributes"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUiNodeTextAttributes kratosUiNodeTextAttributes, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUiNodeTextAttributes.Id == null)
                throw new ArgumentNullException(nameof(kratosUiNodeTextAttributes.Id), "Property is required for class KratosUiNodeTextAttributes.");

            if (kratosUiNodeTextAttributes.Text == null)
                throw new ArgumentNullException(nameof(kratosUiNodeTextAttributes.Text), "Property is required for class KratosUiNodeTextAttributes.");

            writer.WriteString("id", kratosUiNodeTextAttributes.Id);

            var nodeTypeRawValue = KratosUiNodeTextAttributes.NodeTypeEnumToJsonValue(kratosUiNodeTextAttributes.NodeType);
            writer.WriteString("node_type", nodeTypeRawValue);
            writer.WritePropertyName("text");
            JsonSerializer.Serialize(writer, kratosUiNodeTextAttributes.Text, jsonSerializerOptions);
        }
    }
}
