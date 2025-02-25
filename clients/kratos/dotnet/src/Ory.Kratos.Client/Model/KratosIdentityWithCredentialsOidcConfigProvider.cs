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
    /// Create Identity and Import Social Sign In Credentials Configuration
    /// </summary>
    [DataContract(Name = "identityWithCredentialsOidcConfigProvider")]
    public partial class KratosIdentityWithCredentialsOidcConfigProvider : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityWithCredentialsOidcConfigProvider" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosIdentityWithCredentialsOidcConfigProvider()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityWithCredentialsOidcConfigProvider" /> class.
        /// </summary>
        /// <param name="provider">The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;. (required).</param>
        /// <param name="subject">The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token. (required).</param>
        /// <param name="useAutoLink">If set, this credential allows the user to sign in using the OpenID Connect provider without setting the subject first..</param>
        public KratosIdentityWithCredentialsOidcConfigProvider(string provider = default(string), string subject = default(string), bool useAutoLink = default(bool))
        {
            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new ArgumentNullException("provider is a required property for KratosIdentityWithCredentialsOidcConfigProvider and cannot be null");
            }
            this.Provider = provider;
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for KratosIdentityWithCredentialsOidcConfigProvider and cannot be null");
            }
            this.Subject = subject;
            this.UseAutoLink = useAutoLink;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;.
        /// </summary>
        /// <value>The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;.</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token.
        /// </summary>
        /// <value>The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token.</value>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// If set, this credential allows the user to sign in using the OpenID Connect provider without setting the subject first.
        /// </summary>
        /// <value>If set, this credential allows the user to sign in using the OpenID Connect provider without setting the subject first.</value>
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
            sb.Append("class KratosIdentityWithCredentialsOidcConfigProvider {\n");
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
