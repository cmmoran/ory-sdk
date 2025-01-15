/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.1
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
    /// ClientPlanDetails
    /// </summary>
    [DataContract(Name = "PlanDetails")]
    public partial class ClientPlanDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPlanDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientPlanDetails()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPlanDetails" /> class.
        /// </summary>
        /// <param name="baseFeeMonthly">BaseFeeMonthly is the monthly base fee for the plan. (required).</param>
        /// <param name="baseFeeYearly">BaseFeeYearly is the yearly base fee for the plan. (required).</param>
        /// <param name="custom">Custom is true if the plan is custom. This means it will be hidden from the pricing page. (required).</param>
        /// <param name="description">Description is the description of the plan. (required).</param>
        /// <param name="features">features (required).</param>
        /// <param name="latest">Latest is true if the plan is the latest version of a plan and should be available for self-service usage..</param>
        /// <param name="name">Name is the name of the plan. (required).</param>
        /// <param name="varVersion">Version is the version of the plan. The combination of &#x60;name@version&#x60; must be unique. (required).</param>
        public ClientPlanDetails(long baseFeeMonthly = default(long), long baseFeeYearly = default(long), bool custom = default(bool), string description = default(string), Dictionary<string, ClientGenericUsage> features = default(Dictionary<string, ClientGenericUsage>), bool latest = default(bool), string name = default(string), long varVersion = default(long))
        {
            this.BaseFeeMonthly = baseFeeMonthly;
            this.BaseFeeYearly = baseFeeYearly;
            this.Custom = custom;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ClientPlanDetails and cannot be null");
            }
            this.Description = description;
            // to ensure "features" is required (not null)
            if (features == null)
            {
                throw new ArgumentNullException("features is a required property for ClientPlanDetails and cannot be null");
            }
            this.Features = features;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ClientPlanDetails and cannot be null");
            }
            this.Name = name;
            this.VarVersion = varVersion;
            this.Latest = latest;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// BaseFeeMonthly is the monthly base fee for the plan.
        /// </summary>
        /// <value>BaseFeeMonthly is the monthly base fee for the plan.</value>
        [DataMember(Name = "base_fee_monthly", IsRequired = true, EmitDefaultValue = true)]
        public long BaseFeeMonthly { get; set; }

        /// <summary>
        /// BaseFeeYearly is the yearly base fee for the plan.
        /// </summary>
        /// <value>BaseFeeYearly is the yearly base fee for the plan.</value>
        [DataMember(Name = "base_fee_yearly", IsRequired = true, EmitDefaultValue = true)]
        public long BaseFeeYearly { get; set; }

        /// <summary>
        /// Custom is true if the plan is custom. This means it will be hidden from the pricing page.
        /// </summary>
        /// <value>Custom is true if the plan is custom. This means it will be hidden from the pricing page.</value>
        [DataMember(Name = "custom", IsRequired = true, EmitDefaultValue = true)]
        public bool Custom { get; set; }

        /// <summary>
        /// Description is the description of the plan.
        /// </summary>
        /// <value>Description is the description of the plan.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, ClientGenericUsage> Features { get; set; }

        /// <summary>
        /// Latest is true if the plan is the latest version of a plan and should be available for self-service usage.
        /// </summary>
        /// <value>Latest is true if the plan is the latest version of a plan and should be available for self-service usage.</value>
        [DataMember(Name = "latest", EmitDefaultValue = true)]
        public bool Latest { get; set; }

        /// <summary>
        /// Name is the name of the plan.
        /// </summary>
        /// <value>Name is the name of the plan.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Version is the version of the plan. The combination of &#x60;name@version&#x60; must be unique.
        /// </summary>
        /// <value>Version is the version of the plan. The combination of &#x60;name@version&#x60; must be unique.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public long VarVersion { get; set; }

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
            sb.Append("class ClientPlanDetails {\n");
            sb.Append("  BaseFeeMonthly: ").Append(BaseFeeMonthly).Append("\n");
            sb.Append("  BaseFeeYearly: ").Append(BaseFeeYearly).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
