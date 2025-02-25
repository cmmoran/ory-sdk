/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.7
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
    /// Create Identity and Import Credentials
    /// </summary>
    [DataContract(Name = "identityWithCredentials")]
    public partial class KratosIdentityWithCredentials : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityWithCredentials" /> class.
        /// </summary>
        /// <param name="oidc">oidc.</param>
        /// <param name="password">password.</param>
        public KratosIdentityWithCredentials(KratosIdentityWithCredentialsOidc oidc = default(KratosIdentityWithCredentialsOidc), KratosIdentityWithCredentialsPassword password = default(KratosIdentityWithCredentialsPassword))
        {
            this.Oidc = oidc;
            this.Password = password;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Oidc
        /// </summary>
        [DataMember(Name = "oidc", EmitDefaultValue = false)]
        public KratosIdentityWithCredentialsOidc Oidc { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public KratosIdentityWithCredentialsPassword Password { get; set; }

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
            sb.Append("class KratosIdentityWithCredentials {\n");
            sb.Append("  Oidc: ").Append(Oidc).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
