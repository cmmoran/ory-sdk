/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.16
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
    /// ClientHandledOAuth2ConsentRequest
    /// </summary>
    [DataContract(Name = "handledOAuth2ConsentRequest")]
    public partial class ClientHandledOAuth2ConsentRequest : IEquatable<ClientHandledOAuth2ConsentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientHandledOAuth2ConsentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientHandledOAuth2ConsentRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientHandledOAuth2ConsentRequest" /> class.
        /// </summary>
        /// <param name="redirectTo">Original request URL to which you should redirect the user if request was already handled. (required).</param>
        public ClientHandledOAuth2ConsentRequest(string redirectTo = default(string))
        {
            // to ensure "redirectTo" is required (not null)
            if (redirectTo == null) {
                throw new ArgumentNullException("redirectTo is a required property for ClientHandledOAuth2ConsentRequest and cannot be null");
            }
            this.RedirectTo = redirectTo;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Original request URL to which you should redirect the user if request was already handled.
        /// </summary>
        /// <value>Original request URL to which you should redirect the user if request was already handled.</value>
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
            sb.Append("class ClientHandledOAuth2ConsentRequest {\n");
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
            return this.Equals(input as ClientHandledOAuth2ConsentRequest);
        }

        /// <summary>
        /// Returns true if ClientHandledOAuth2ConsentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientHandledOAuth2ConsentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientHandledOAuth2ConsentRequest input)
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
