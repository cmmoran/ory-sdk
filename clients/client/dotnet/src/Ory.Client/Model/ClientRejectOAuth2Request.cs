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
    /// ClientRejectOAuth2Request
    /// </summary>
    [DataContract(Name = "rejectOAuth2Request")]
    public partial class ClientRejectOAuth2Request : IEquatable<ClientRejectOAuth2Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRejectOAuth2Request" /> class.
        /// </summary>
        /// <param name="error">The error should follow the OAuth2 error format (e.g. &#x60;invalid_request&#x60;, &#x60;login_required&#x60;).  Defaults to &#x60;request_denied&#x60;..</param>
        /// <param name="errorDebug">Debug contains information to help resolve the problem as a developer. Usually not exposed to the public but only in the server logs..</param>
        /// <param name="errorDescription">Description of the error in a human readable format..</param>
        /// <param name="errorHint">Hint to help resolve the error..</param>
        /// <param name="statusCode">Represents the HTTP status code of the error (e.g. 401 or 403)  Defaults to 400.</param>
        public ClientRejectOAuth2Request(string error = default(string), string errorDebug = default(string), string errorDescription = default(string), string errorHint = default(string), long statusCode = default(long))
        {
            this.Error = error;
            this.ErrorDebug = errorDebug;
            this.ErrorDescription = errorDescription;
            this.ErrorHint = errorHint;
            this.StatusCode = statusCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The error should follow the OAuth2 error format (e.g. &#x60;invalid_request&#x60;, &#x60;login_required&#x60;).  Defaults to &#x60;request_denied&#x60;.
        /// </summary>
        /// <value>The error should follow the OAuth2 error format (e.g. &#x60;invalid_request&#x60;, &#x60;login_required&#x60;).  Defaults to &#x60;request_denied&#x60;.</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Debug contains information to help resolve the problem as a developer. Usually not exposed to the public but only in the server logs.
        /// </summary>
        /// <value>Debug contains information to help resolve the problem as a developer. Usually not exposed to the public but only in the server logs.</value>
        [DataMember(Name = "error_debug", EmitDefaultValue = false)]
        public string ErrorDebug { get; set; }

        /// <summary>
        /// Description of the error in a human readable format.
        /// </summary>
        /// <value>Description of the error in a human readable format.</value>
        [DataMember(Name = "error_description", EmitDefaultValue = false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Hint to help resolve the error.
        /// </summary>
        /// <value>Hint to help resolve the error.</value>
        [DataMember(Name = "error_hint", EmitDefaultValue = false)]
        public string ErrorHint { get; set; }

        /// <summary>
        /// Represents the HTTP status code of the error (e.g. 401 or 403)  Defaults to 400
        /// </summary>
        /// <value>Represents the HTTP status code of the error (e.g. 401 or 403)  Defaults to 400</value>
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
            sb.Append("class ClientRejectOAuth2Request {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDebug: ").Append(ErrorDebug).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  ErrorHint: ").Append(ErrorHint).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientRejectOAuth2Request);
        }

        /// <summary>
        /// Returns true if ClientRejectOAuth2Request instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientRejectOAuth2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientRejectOAuth2Request input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ErrorDebug == input.ErrorDebug ||
                    (this.ErrorDebug != null &&
                    this.ErrorDebug.Equals(input.ErrorDebug))
                ) && 
                (
                    this.ErrorDescription == input.ErrorDescription ||
                    (this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(input.ErrorDescription))
                ) && 
                (
                    this.ErrorHint == input.ErrorHint ||
                    (this.ErrorHint != null &&
                    this.ErrorHint.Equals(input.ErrorHint))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
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
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.ErrorDebug != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorDebug.GetHashCode();
                }
                if (this.ErrorDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorDescription.GetHashCode();
                }
                if (this.ErrorHint != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorHint.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
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
