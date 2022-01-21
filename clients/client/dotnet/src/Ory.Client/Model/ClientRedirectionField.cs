/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.57
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
    /// ClientRedirectionField
    /// </summary>
    [DataContract(Name = "RedirectionField")]
    public partial class ClientRedirectionField : IEquatable<ClientRedirectionField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRedirectionField" /> class.
        /// </summary>
        /// <param name="main">main.</param>
        /// <param name="oidc">oidc.</param>
        /// <param name="password">password.</param>
        /// <param name="profile">profile.</param>
        public ClientRedirectionField(string main = default(string), string oidc = default(string), string password = default(string), string profile = default(string))
        {
            this.Main = main;
            this.Oidc = oidc;
            this.Password = password;
            this.Profile = profile;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Main
        /// </summary>
        [DataMember(Name = "main", EmitDefaultValue = false)]
        public string Main { get; set; }

        /// <summary>
        /// Gets or Sets Oidc
        /// </summary>
        [DataMember(Name = "oidc", EmitDefaultValue = false)]
        public string Oidc { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public string Profile { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class ClientRedirectionField {\n");
            sb.Append("  Main: ").Append(Main).Append("\n");
            sb.Append("  Oidc: ").Append(Oidc).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(input as ClientRedirectionField);
        }

        /// <summary>
        /// Returns true if ClientRedirectionField instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientRedirectionField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientRedirectionField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Main == input.Main ||
                    (this.Main != null &&
                    this.Main.Equals(input.Main))
                ) && 
                (
                    this.Oidc == input.Oidc ||
                    (this.Oidc != null &&
                    this.Oidc.Equals(input.Oidc))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
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
                if (this.Main != null)
                    hashCode = hashCode * 59 + this.Main.GetHashCode();
                if (this.Oidc != null)
                    hashCode = hashCode * 59 + this.Oidc.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
