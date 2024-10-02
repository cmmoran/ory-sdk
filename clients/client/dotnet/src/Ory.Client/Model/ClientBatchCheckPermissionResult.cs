/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.5
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
    /// Batch Check Permission Result
    /// </summary>
    [DataContract(Name = "batchCheckPermissionResult")]
    public partial class ClientBatchCheckPermissionResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBatchCheckPermissionResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientBatchCheckPermissionResult()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBatchCheckPermissionResult" /> class.
        /// </summary>
        /// <param name="results">An array of check results. The order aligns with the input order. (required).</param>
        public ClientBatchCheckPermissionResult(List<ClientCheckPermissionResultWithError> results = default(List<ClientCheckPermissionResultWithError>))
        {
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for ClientBatchCheckPermissionResult and cannot be null");
            }
            this.Results = results;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// An array of check results. The order aligns with the input order.
        /// </summary>
        /// <value>An array of check results. The order aligns with the input order.</value>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<ClientCheckPermissionResultWithError> Results { get; set; }

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
            sb.Append("class ClientBatchCheckPermissionResult {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
