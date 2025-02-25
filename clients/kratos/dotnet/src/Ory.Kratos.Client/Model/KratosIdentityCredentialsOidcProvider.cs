/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6-alpha.2
 * Contact: office@ory.sh
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
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosIdentityCredentialsOidcProvider
    /// </summary>
    [DataContract(Name = "identityCredentialsOidcProvider")]
    public partial class KratosIdentityCredentialsOidcProvider : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityCredentialsOidcProvider" /> class.
        /// </summary>
        /// <param name="initialAccessToken">initialAccessToken.</param>
        /// <param name="initialIdToken">initialIdToken.</param>
        /// <param name="initialRefreshToken">initialRefreshToken.</param>
        /// <param name="organization">organization.</param>
        /// <param name="provider">provider.</param>
        /// <param name="subject">subject.</param>
        /// <param name="useAutoLink">useAutoLink.</param>
        public KratosIdentityCredentialsOidcProvider(string initialAccessToken = default(string), string initialIdToken = default(string), string initialRefreshToken = default(string), string organization = default(string), string provider = default(string), string subject = default(string), bool useAutoLink = default(bool))
        {
            this.InitialAccessToken = initialAccessToken;
            this.InitialIdToken = initialIdToken;
            this.InitialRefreshToken = initialRefreshToken;
            this.Organization = organization;
            this.Provider = provider;
            this.Subject = subject;
            this.UseAutoLink = useAutoLink;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets InitialAccessToken
        /// </summary>
        [DataMember(Name = "initial_access_token", EmitDefaultValue = false)]
        public string InitialAccessToken { get; set; }

        /// <summary>
        /// Gets or Sets InitialIdToken
        /// </summary>
        [DataMember(Name = "initial_id_token", EmitDefaultValue = false)]
        public string InitialIdToken { get; set; }

        /// <summary>
        /// Gets or Sets InitialRefreshToken
        /// </summary>
        [DataMember(Name = "initial_refresh_token", EmitDefaultValue = false)]
        public string InitialRefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets UseAutoLink
        /// </summary>
        [DataMember(Name = "use_auto_link", EmitDefaultValue = true)]
        public bool UseAutoLink { get; set; }

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
            sb.Append("class KratosIdentityCredentialsOidcProvider {\n");
            sb.Append("  InitialAccessToken: ").Append(InitialAccessToken).Append("\n");
            sb.Append("  InitialIdToken: ").Append(InitialIdToken).Append("\n");
            sb.Append("  InitialRefreshToken: ").Append(InitialRefreshToken).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  UseAutoLink: ").Append(UseAutoLink).Append("\n");
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
