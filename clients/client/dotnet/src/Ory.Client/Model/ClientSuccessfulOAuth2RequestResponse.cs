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
    /// ClientSuccessfulOAuth2RequestResponse
    /// </summary>
    [DataContract(Name = "successfulOAuth2RequestResponse")]
    public partial class ClientSuccessfulOAuth2RequestResponse : IEquatable<ClientSuccessfulOAuth2RequestResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSuccessfulOAuth2RequestResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSuccessfulOAuth2RequestResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSuccessfulOAuth2RequestResponse" /> class.
        /// </summary>
        /// <param name="redirectTo">RedirectURL is the URL which you should redirect the user to once the authentication process is completed. (required).</param>
        public ClientSuccessfulOAuth2RequestResponse(string redirectTo = default(string))
        {
            // to ensure "redirectTo" is required (not null)
            if (redirectTo == null) {
                throw new ArgumentNullException("redirectTo is a required property for ClientSuccessfulOAuth2RequestResponse and cannot be null");
            }
            this.RedirectTo = redirectTo;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// RedirectURL is the URL which you should redirect the user to once the authentication process is completed.
        /// </summary>
        /// <value>RedirectURL is the URL which you should redirect the user to once the authentication process is completed.</value>
        [DataMember(Name = "redirect_to", IsRequired = true, EmitDefaultValue = false)]
        public string RedirectTo { get; set; }

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
            sb.Append("class ClientSuccessfulOAuth2RequestResponse {\n");
            sb.Append("  RedirectTo: ").Append(RedirectTo).Append("\n");
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
            return this.Equals(input as ClientSuccessfulOAuth2RequestResponse);
        }

        /// <summary>
        /// Returns true if ClientSuccessfulOAuth2RequestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSuccessfulOAuth2RequestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSuccessfulOAuth2RequestResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RedirectTo == input.RedirectTo ||
                    (this.RedirectTo != null &&
                    this.RedirectTo.Equals(input.RedirectTo))
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
                if (this.RedirectTo != null)
                {
                    hashCode = (hashCode * 59) + this.RedirectTo.GetHashCode();
                }
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
