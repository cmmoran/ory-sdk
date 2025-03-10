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
    /// Container represents a HTML Form. The container can work with both HTTP Form and JSON requests
    /// </summary>
    public partial class KratosUiContainer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiContainer" /> class.
        /// </summary>
        /// <param name="action">Action should be used as the form action URL &#x60;&lt;form action&#x3D;\&quot;{{ .Action }}\&quot; method&#x3D;\&quot;post\&quot;&gt;&#x60;.</param>
        /// <param name="method">Method is the form method (e.g. POST)</param>
        /// <param name="nodes">nodes</param>
        /// <param name="messages">messages</param>
        [JsonConstructor]
        public KratosUiContainer(string action, string method, List<KratosUiNode> nodes, Option<List<KratosUiText>?> messages = default)
        {
            Action = action;
            Method = method;
            Nodes = nodes;
            MessagesOption = messages;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Action should be used as the form action URL &#x60;&lt;form action&#x3D;\&quot;{{ .Action }}\&quot; method&#x3D;\&quot;post\&quot;&gt;&#x60;.
        /// </summary>
        /// <value>Action should be used as the form action URL &#x60;&lt;form action&#x3D;\&quot;{{ .Action }}\&quot; method&#x3D;\&quot;post\&quot;&gt;&#x60;.</value>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Method is the form method (e.g. POST)
        /// </summary>
        /// <value>Method is the form method (e.g. POST)</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Nodes
        /// </summary>
        [JsonPropertyName("nodes")]
        public List<KratosUiNode> Nodes { get; set; }

        /// <summary>
        /// Used to track the state of Messages
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<KratosUiText>?> MessagesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [JsonPropertyName("messages")]
        public List<KratosUiText>? Messages { get { return this.MessagesOption; } set { this.MessagesOption = new(value); } }

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
            sb.Append("class KratosUiContainer {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
    /// A Json converter for type <see cref="KratosUiContainer" />
    /// </summary>
    public class KratosUiContainerJsonConverter : JsonConverter<KratosUiContainer>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUiContainer" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUiContainer Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> action = default;
            Option<string?> method = default;
            Option<List<KratosUiNode>?> nodes = default;
            Option<List<KratosUiText>?> messages = default;

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
                        case "action":
                            action = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "method":
                            method = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "nodes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                nodes = new Option<List<KratosUiNode>?>(JsonSerializer.Deserialize<List<KratosUiNode>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "messages":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                messages = new Option<List<KratosUiText>?>(JsonSerializer.Deserialize<List<KratosUiText>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!action.IsSet)
                throw new ArgumentException("Property is required for class KratosUiContainer.", nameof(action));

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUiContainer.", nameof(method));

            if (!nodes.IsSet)
                throw new ArgumentException("Property is required for class KratosUiContainer.", nameof(nodes));

            if (action.IsSet && action.Value == null)
                throw new ArgumentNullException(nameof(action), "Property is not nullable for class KratosUiContainer.");

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUiContainer.");

            if (nodes.IsSet && nodes.Value == null)
                throw new ArgumentNullException(nameof(nodes), "Property is not nullable for class KratosUiContainer.");

            if (messages.IsSet && messages.Value == null)
                throw new ArgumentNullException(nameof(messages), "Property is not nullable for class KratosUiContainer.");

            return new KratosUiContainer(action.Value!, method.Value!, nodes.Value!, messages);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUiContainer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiContainer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUiContainer kratosUiContainer, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUiContainer, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUiContainer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUiContainer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUiContainer kratosUiContainer, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUiContainer.Action == null)
                throw new ArgumentNullException(nameof(kratosUiContainer.Action), "Property is required for class KratosUiContainer.");

            if (kratosUiContainer.Method == null)
                throw new ArgumentNullException(nameof(kratosUiContainer.Method), "Property is required for class KratosUiContainer.");

            if (kratosUiContainer.Nodes == null)
                throw new ArgumentNullException(nameof(kratosUiContainer.Nodes), "Property is required for class KratosUiContainer.");

            if (kratosUiContainer.MessagesOption.IsSet && kratosUiContainer.Messages == null)
                throw new ArgumentNullException(nameof(kratosUiContainer.Messages), "Property is required for class KratosUiContainer.");

            writer.WriteString("action", kratosUiContainer.Action);

            writer.WriteString("method", kratosUiContainer.Method);

            writer.WritePropertyName("nodes");
            JsonSerializer.Serialize(writer, kratosUiContainer.Nodes, jsonSerializerOptions);
            if (kratosUiContainer.MessagesOption.IsSet)
            {
                writer.WritePropertyName("messages");
                JsonSerializer.Serialize(writer, kratosUiContainer.Messages, jsonSerializerOptions);
            }
        }
    }
}
