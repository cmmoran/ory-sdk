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
    /// Division sections are used for interactive widgets that require a hook in the DOM / view.
    /// </summary>
    public partial class KratosUiNodeDivisionAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeDivisionAttributes" /> class.
        /// </summary>
        /// <param name="id">A unique identifier</param>
        /// <param name="nodeType">NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0. In this struct it technically always is \&quot;script\&quot;. text Text input Input img Image a Anchor script Script div Division</param>
        /// <param name="class">The script MIME type</param>
        /// <param name="data">Data is a map of key-value pairs that are passed to the division.  They may be used for &#x60;data-...&#x60; attributes.</param>
        [JsonConstructor]
        public KratosUiNodeDivisionAttributes(string id, NodeTypeEnum nodeType, Option<string?> @class = default, Option<Dictionary<string, string>?> data = default)
        {
            Id = id;
            NodeType = nodeType;
            ClassOption = @class;
            DataOption = data;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0. In this struct it technically always is \&quot;script\&quot;. text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0. In this struct it technically always is \&quot;script\&quot;. text Text input Input img Image a Anchor script Script div Division</value>
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
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0. In this struct it technically always is \&quot;script\&quot;. text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0. In this struct it technically always is \&quot;script\&quot;. text Text input Input img Image a Anchor script Script div Division</value>
        [JsonPropertyName("node_type")]
        public NodeTypeEnum NodeType { get; set; }

        /// <summary>
        /// A unique identifier
        /// </summary>
        /// <value>A unique identifier</value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Used to track the state of Class
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ClassOption { get; private set; }

        /// <summary>
        /// The script MIME type
        /// </summary>
        /// <value>The script MIME type</value>
        [JsonPropertyName("class")]
        public string? Class { get { return this.ClassOption; } set { this.ClassOption = new(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, string>?> DataOption { get; private set; }

        /// <summary>
        /// Data is a map of key-value pairs that are passed to the division.  They may be used for &#x60;data-...&#x60; attributes.
        /// </summary>
        /// <value>Data is a map of key-value pairs that are passed to the division.  They may be used for &#x60;data-...&#x60; attributes.</value>
        [JsonPropertyName("data")]
        public Dictionary<string, string>? Data { get { return this.DataOption; } set { this.DataOption = new(value); } }

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
            sb.Append("class KratosUiNodeDivisionAttributes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
    /// A Json converter for type <see cref="KratosUiNodeDivisionAttributes" />
    /// </summary>
    public class KratosUiNodeDivisionAttributesJsonConverter : JsonConverter<KratosUiNodeDivisionAttributes>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUiNodeDivisionAttributes" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUiNodeDivisionAttributes Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<KratosUiNodeDivisionAttributes.NodeTypeEnum?> nodeType = default;
            Option<string?> varClass = default;
            Option<Dictionary<string, string>?> data = default;

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
                                nodeType = new Option<KratosUiNodeDivisionAttributes.NodeTypeEnum?>(KratosUiNodeDivisionAttributes.NodeTypeEnumFromStringOrDefault(nodeTypeRawValue));
                            break;
                        case "class":
                            varClass = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<Dictionary<string, string>?>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeDivisionAttributes.", nameof(id));

            if (!nodeType.IsSet)
                throw new ArgumentException("Property is required for class KratosUiNodeDivisionAttributes.", nameof(nodeType));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class KratosUiNodeDivisionAttributes.");

            if (nodeType.IsSet && nodeType.Value == null)
                throw new ArgumentNullException(nameof(nodeType), "Property is not nullable for class KratosUiNodeDivisionAttributes.");

            if (varClass.IsSet && varClass.Value == null)
                throw new ArgumentNullException(nameof(varClass), "Property is not nullable for class KratosUiNodeDivisionAttributes.");

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class KratosUiNodeDivisionAttributes.");

            return new KratosUiNodeDivisionAttributes(id.Value!, nodeType.Value!.Value!, varClass, data);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUiNodeDivisionAttributes" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNodeDivisionAttributes"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUiNodeDivisionAttributes kratosUiNodeDivisionAttributes, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUiNodeDivisionAttributes, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUiNodeDivisionAttributes" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiNodeDivisionAttributes"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUiNodeDivisionAttributes kratosUiNodeDivisionAttributes, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUiNodeDivisionAttributes.Id == null)
                throw new ArgumentNullException(nameof(kratosUiNodeDivisionAttributes.Id), "Property is required for class KratosUiNodeDivisionAttributes.");

            if (kratosUiNodeDivisionAttributes.ClassOption.IsSet && kratosUiNodeDivisionAttributes.Class == null)
                throw new ArgumentNullException(nameof(kratosUiNodeDivisionAttributes.Class), "Property is required for class KratosUiNodeDivisionAttributes.");

            if (kratosUiNodeDivisionAttributes.DataOption.IsSet && kratosUiNodeDivisionAttributes.Data == null)
                throw new ArgumentNullException(nameof(kratosUiNodeDivisionAttributes.Data), "Property is required for class KratosUiNodeDivisionAttributes.");

            writer.WriteString("id", kratosUiNodeDivisionAttributes.Id);

            var nodeTypeRawValue = KratosUiNodeDivisionAttributes.NodeTypeEnumToJsonValue(kratosUiNodeDivisionAttributes.NodeType);
            writer.WriteString("node_type", nodeTypeRawValue);
            if (kratosUiNodeDivisionAttributes.ClassOption.IsSet)
                writer.WriteString("class", kratosUiNodeDivisionAttributes.Class);

            if (kratosUiNodeDivisionAttributes.DataOption.IsSet)
            {
                writer.WritePropertyName("data");
                JsonSerializer.Serialize(writer, kratosUiNodeDivisionAttributes.Data, jsonSerializerOptions);
            }
        }
    }
}
