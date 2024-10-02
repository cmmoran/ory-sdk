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
    /// ClientBillingPeriodBucket
    /// </summary>
    [DataContract(Name = "BillingPeriodBucket")]
    public partial class ClientBillingPeriodBucket : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientBillingPeriodBucket" /> class.
        /// </summary>
        /// <param name="baseInvoices">baseInvoices.</param>
        /// <param name="billingPeriod">billingPeriod.</param>
        /// <param name="usageInvoice">usageInvoice.</param>
        public ClientBillingPeriodBucket(List<ClientInvoice> baseInvoices = default(List<ClientInvoice>), ClientTimeInterval billingPeriod = default(ClientTimeInterval), ClientInvoice usageInvoice = default(ClientInvoice))
        {
            this.BaseInvoices = baseInvoices;
            this.BillingPeriod = billingPeriod;
            this.UsageInvoice = usageInvoice;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets BaseInvoices
        /// </summary>
        [DataMember(Name = "base_invoices", EmitDefaultValue = false)]
        public List<ClientInvoice> BaseInvoices { get; set; }

        /// <summary>
        /// Gets or Sets BillingPeriod
        /// </summary>
        [DataMember(Name = "billing_period", EmitDefaultValue = false)]
        public ClientTimeInterval BillingPeriod { get; set; }

        /// <summary>
        /// Gets or Sets UsageInvoice
        /// </summary>
        [DataMember(Name = "usage_invoice", EmitDefaultValue = false)]
        public ClientInvoice UsageInvoice { get; set; }

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
            sb.Append("class ClientBillingPeriodBucket {\n");
            sb.Append("  BaseInvoices: ").Append(BaseInvoices).Append("\n");
            sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
            sb.Append("  UsageInvoice: ").Append(UsageInvoice).Append("\n");
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
