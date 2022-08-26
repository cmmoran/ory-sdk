/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.21
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientExpandTree
    /// </summary>
    [DataContract(Name = "expandTree")]
    public partial class ClientExpandTree : IEquatable<ClientExpandTree>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Union for value: union
            /// </summary>
            [EnumMember(Value = "union")]
            Union = 1,

            /// <summary>
            /// Enum Exclusion for value: exclusion
            /// </summary>
            [EnumMember(Value = "exclusion")]
            Exclusion = 2,

            /// <summary>
            /// Enum Intersection for value: intersection
            /// </summary>
            [EnumMember(Value = "intersection")]
            Intersection = 3,

            /// <summary>
            /// Enum Leaf for value: leaf
            /// </summary>
            [EnumMember(Value = "leaf")]
            Leaf = 4

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientExpandTree" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientExpandTree()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientExpandTree" /> class.
        /// </summary>
        /// <param name="children">children.</param>
        /// <param name="subjectId">subjectId.</param>
        /// <param name="subjectSet">subjectSet.</param>
        /// <param name="type">type (required).</param>
        public ClientExpandTree(List<ClientExpandTree> children = default(List<ClientExpandTree>), string subjectId = default(string), ClientSubjectSet subjectSet = default(ClientSubjectSet), TypeEnum type = default(TypeEnum))
        {
            this.Type = type;
            this.Children = children;
            this.SubjectId = subjectId;
            this.SubjectSet = subjectSet;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public List<ClientExpandTree> Children { get; set; }

        /// <summary>
        /// Gets or Sets SubjectId
        /// </summary>
        [DataMember(Name = "subject_id", EmitDefaultValue = false)]
        public string SubjectId { get; set; }

        /// <summary>
        /// Gets or Sets SubjectSet
        /// </summary>
        [DataMember(Name = "subject_set", EmitDefaultValue = false)]
        public ClientSubjectSet SubjectSet { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientExpandTree {\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  SubjectId: ").Append(SubjectId).Append("\n");
            sb.Append("  SubjectSet: ").Append(SubjectSet).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientExpandTree);
        }

        /// <summary>
        /// Returns true if ClientExpandTree instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientExpandTree to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientExpandTree input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.SubjectId == input.SubjectId ||
                    (this.SubjectId != null &&
                    this.SubjectId.Equals(input.SubjectId))
                ) && 
                (
                    this.SubjectSet == input.SubjectSet ||
                    (this.SubjectSet != null &&
                    this.SubjectSet.Equals(input.SubjectSet))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
                }
                if (this.SubjectId != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectId.GetHashCode();
                }
                if (this.SubjectSet != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectSet.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
