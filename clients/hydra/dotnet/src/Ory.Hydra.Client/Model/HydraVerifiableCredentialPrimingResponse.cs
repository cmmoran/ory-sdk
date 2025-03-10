/*
 * Ory Hydra API
 *
 * Documentation for all of Ory Hydra's APIs. 
 *
 * The version of the OpenAPI document: v2.4.0-alpha.1
 * Contact: hi@ory.sh
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
using OpenAPIDateConverter = Ory.Hydra.Client.Client.OpenAPIDateConverter;

namespace Ory.Hydra.Client.Model
{
    /// <summary>
    /// HydraVerifiableCredentialPrimingResponse
    /// </summary>
    [DataContract(Name = "verifiableCredentialPrimingResponse")]
    public partial class HydraVerifiableCredentialPrimingResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraVerifiableCredentialPrimingResponse" /> class.
        /// </summary>
        /// <param name="cNonce">cNonce.</param>
        /// <param name="cNonceExpiresIn">cNonceExpiresIn.</param>
        /// <param name="error">error.</param>
        /// <param name="errorDebug">errorDebug.</param>
        /// <param name="errorDescription">errorDescription.</param>
        /// <param name="errorHint">errorHint.</param>
        /// <param name="format">format.</param>
        /// <param name="statusCode">statusCode.</param>
        public HydraVerifiableCredentialPrimingResponse(string cNonce = default(string), long cNonceExpiresIn = default(long), string error = default(string), string errorDebug = default(string), string errorDescription = default(string), string errorHint = default(string), string format = default(string), long statusCode = default(long))
        {
            this.CNonce = cNonce;
            this.CNonceExpiresIn = cNonceExpiresIn;
            this.Error = error;
            this.ErrorDebug = errorDebug;
            this.ErrorDescription = errorDescription;
            this.ErrorHint = errorHint;
            this.Format = format;
            this.StatusCode = statusCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets CNonce
        /// </summary>
        [DataMember(Name = "c_nonce", EmitDefaultValue = false)]
        public string CNonce { get; set; }

        /// <summary>
        /// Gets or Sets CNonceExpiresIn
        /// </summary>
        [DataMember(Name = "c_nonce_expires_in", EmitDefaultValue = false)]
        public long CNonceExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDebug
        /// </summary>
        [DataMember(Name = "error_debug", EmitDefaultValue = false)]
        public string ErrorDebug { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDescription
        /// </summary>
        [DataMember(Name = "error_description", EmitDefaultValue = false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or Sets ErrorHint
        /// </summary>
        [DataMember(Name = "error_hint", EmitDefaultValue = false)]
        public string ErrorHint { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        public long StatusCode { get; set; }

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
            sb.Append("class HydraVerifiableCredentialPrimingResponse {\n");
            sb.Append("  CNonce: ").Append(CNonce).Append("\n");
            sb.Append("  CNonceExpiresIn: ").Append(CNonceExpiresIn).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDebug: ").Append(ErrorDebug).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  ErrorHint: ").Append(ErrorHint).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
