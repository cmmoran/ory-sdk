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
    /// ClientCreateCustomHostnameBody
    /// </summary>
    [DataContract(Name = "createCustomHostnameBody")]
    public partial class ClientCreateCustomHostnameBody : IEquatable<ClientCreateCustomHostnameBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateCustomHostnameBody" /> class.
        /// </summary>
        /// <param name="cookieDomain">The domain where cookies will be set. Has to be a parent domain of the custom hostname to work..</param>
        /// <param name="corsAllowedOrigins">CORS Allowed origins for the custom hostname..</param>
        /// <param name="corsEnabled">CORS Enabled for the custom hostname..</param>
        /// <param name="hostname">The custom hostname where the API will be exposed..</param>
        public ClientCreateCustomHostnameBody(string cookieDomain = default(string), List<string> corsAllowedOrigins = default(List<string>), bool corsEnabled = default(bool), string hostname = default(string))
        {
            this.CookieDomain = cookieDomain;
            this.CorsAllowedOrigins = corsAllowedOrigins;
            this.CorsEnabled = corsEnabled;
            this.Hostname = hostname;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The domain where cookies will be set. Has to be a parent domain of the custom hostname to work.
        /// </summary>
        /// <value>The domain where cookies will be set. Has to be a parent domain of the custom hostname to work.</value>
        [DataMember(Name = "cookie_domain", EmitDefaultValue = false)]
        public string CookieDomain { get; set; }

        /// <summary>
        /// CORS Allowed origins for the custom hostname.
        /// </summary>
        /// <value>CORS Allowed origins for the custom hostname.</value>
        [DataMember(Name = "cors_allowed_origins", EmitDefaultValue = false)]
        public List<string> CorsAllowedOrigins { get; set; }

        /// <summary>
        /// CORS Enabled for the custom hostname.
        /// </summary>
        /// <value>CORS Enabled for the custom hostname.</value>
        [DataMember(Name = "cors_enabled", EmitDefaultValue = true)]
        public bool CorsEnabled { get; set; }

        /// <summary>
        /// The custom hostname where the API will be exposed.
        /// </summary>
        /// <value>The custom hostname where the API will be exposed.</value>
        [DataMember(Name = "hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

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
            sb.Append("class ClientCreateCustomHostnameBody {\n");
            sb.Append("  CookieDomain: ").Append(CookieDomain).Append("\n");
            sb.Append("  CorsAllowedOrigins: ").Append(CorsAllowedOrigins).Append("\n");
            sb.Append("  CorsEnabled: ").Append(CorsEnabled).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
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
            return this.Equals(input as ClientCreateCustomHostnameBody);
        }

        /// <summary>
        /// Returns true if ClientCreateCustomHostnameBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCreateCustomHostnameBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCreateCustomHostnameBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CookieDomain == input.CookieDomain ||
                    (this.CookieDomain != null &&
                    this.CookieDomain.Equals(input.CookieDomain))
                ) && 
                (
                    this.CorsAllowedOrigins == input.CorsAllowedOrigins ||
                    this.CorsAllowedOrigins != null &&
                    input.CorsAllowedOrigins != null &&
                    this.CorsAllowedOrigins.SequenceEqual(input.CorsAllowedOrigins)
                ) && 
                (
                    this.CorsEnabled == input.CorsEnabled ||
                    this.CorsEnabled.Equals(input.CorsEnabled)
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
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
                if (this.CookieDomain != null)
                {
                    hashCode = (hashCode * 59) + this.CookieDomain.GetHashCode();
                }
                if (this.CorsAllowedOrigins != null)
                {
                    hashCode = (hashCode * 59) + this.CorsAllowedOrigins.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CorsEnabled.GetHashCode();
                if (this.Hostname != null)
                {
                    hashCode = (hashCode * 59) + this.Hostname.GetHashCode();
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
