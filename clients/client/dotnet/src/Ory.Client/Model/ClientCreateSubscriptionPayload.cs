/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.116
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
    /// ClientCreateSubscriptionPayload
    /// </summary>
    [DataContract(Name = "CreateSubscriptionPayload")]
    public partial class ClientCreateSubscriptionPayload : IEquatable<ClientCreateSubscriptionPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateSubscriptionPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientCreateSubscriptionPayload()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateSubscriptionPayload" /> class.
        /// </summary>
        /// <param name="planOrPrice">planOrPrice (required).</param>
        /// <param name="provisionFirstProject">provisionFirstProject (required).</param>
        /// <param name="returnTo">returnTo.</param>
        public ClientCreateSubscriptionPayload(string planOrPrice = default(string), string provisionFirstProject = default(string), string returnTo = default(string))
        {
            // to ensure "planOrPrice" is required (not null)
            if (planOrPrice == null) {
                throw new ArgumentNullException("planOrPrice is a required property for ClientCreateSubscriptionPayload and cannot be null");
            }
            this.PlanOrPrice = planOrPrice;
            // to ensure "provisionFirstProject" is required (not null)
            if (provisionFirstProject == null) {
                throw new ArgumentNullException("provisionFirstProject is a required property for ClientCreateSubscriptionPayload and cannot be null");
            }
            this.ProvisionFirstProject = provisionFirstProject;
            this.ReturnTo = returnTo;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets PlanOrPrice
        /// </summary>
        [DataMember(Name = "plan_or_price", IsRequired = true, EmitDefaultValue = false)]
        public string PlanOrPrice { get; set; }

        /// <summary>
        /// Gets or Sets ProvisionFirstProject
        /// </summary>
        [DataMember(Name = "provision_first_project", IsRequired = true, EmitDefaultValue = false)]
        public string ProvisionFirstProject { get; set; }

        /// <summary>
        /// Gets or Sets ReturnTo
        /// </summary>
        [DataMember(Name = "return_to", EmitDefaultValue = false)]
        public string ReturnTo { get; set; }

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
            sb.Append("class ClientCreateSubscriptionPayload {\n");
            sb.Append("  PlanOrPrice: ").Append(PlanOrPrice).Append("\n");
            sb.Append("  ProvisionFirstProject: ").Append(ProvisionFirstProject).Append("\n");
            sb.Append("  ReturnTo: ").Append(ReturnTo).Append("\n");
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
            return this.Equals(input as ClientCreateSubscriptionPayload);
        }

        /// <summary>
        /// Returns true if ClientCreateSubscriptionPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCreateSubscriptionPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCreateSubscriptionPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PlanOrPrice == input.PlanOrPrice ||
                    (this.PlanOrPrice != null &&
                    this.PlanOrPrice.Equals(input.PlanOrPrice))
                ) && 
                (
                    this.ProvisionFirstProject == input.ProvisionFirstProject ||
                    (this.ProvisionFirstProject != null &&
                    this.ProvisionFirstProject.Equals(input.ProvisionFirstProject))
                ) && 
                (
                    this.ReturnTo == input.ReturnTo ||
                    (this.ReturnTo != null &&
                    this.ReturnTo.Equals(input.ReturnTo))
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
                if (this.PlanOrPrice != null)
                {
                    hashCode = (hashCode * 59) + this.PlanOrPrice.GetHashCode();
                }
                if (this.ProvisionFirstProject != null)
                {
                    hashCode = (hashCode * 59) + this.ProvisionFirstProject.GetHashCode();
                }
                if (this.ReturnTo != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnTo.GetHashCode();
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
