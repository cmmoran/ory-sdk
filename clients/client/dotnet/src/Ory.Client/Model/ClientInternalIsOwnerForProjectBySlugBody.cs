/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.5
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
    /// Is Owner For Project By Slug Request Body
    /// </summary>
    [DataContract(Name = "internalIsOwnerForProjectBySlugBody")]
    public partial class ClientInternalIsOwnerForProjectBySlugBody : IValidatableObject
    {
        /// <summary>
        /// Namespace is the namespace of the subject.
        /// </summary>
        /// <value>Namespace is the namespace of the subject.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NamespaceEnum
        {
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,

            /// <summary>
            /// Enum ApiKey for value:  ApiKey
            /// </summary>
            [EnumMember(Value = " ApiKey")]
            ApiKey = 2
        }


        /// <summary>
        /// Namespace is the namespace of the subject.
        /// </summary>
        /// <value>Namespace is the namespace of the subject.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = true)]
        public NamespaceEnum Namespace { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInternalIsOwnerForProjectBySlugBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientInternalIsOwnerForProjectBySlugBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInternalIsOwnerForProjectBySlugBody" /> class.
        /// </summary>
        /// <param name="varNamespace">Namespace is the namespace of the subject. (required).</param>
        /// <param name="projectScope">ProjectScope is the project_id resolved from the API key..</param>
        /// <param name="projectSlug">ProjectSlug is the project&#39;s slug. (required).</param>
        /// <param name="subject">Subject is the subject acting (user or API key). (required).</param>
        public ClientInternalIsOwnerForProjectBySlugBody(NamespaceEnum varNamespace = default(NamespaceEnum), string projectScope = default(string), string projectSlug = default(string), string subject = default(string))
        {
            this.Namespace = varNamespace;
            // to ensure "projectSlug" is required (not null)
            if (projectSlug == null)
            {
                throw new ArgumentNullException("projectSlug is a required property for ClientInternalIsOwnerForProjectBySlugBody and cannot be null");
            }
            this.ProjectSlug = projectSlug;
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for ClientInternalIsOwnerForProjectBySlugBody and cannot be null");
            }
            this.Subject = subject;
            this.ProjectScope = projectScope;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// ProjectScope is the project_id resolved from the API key.
        /// </summary>
        /// <value>ProjectScope is the project_id resolved from the API key.</value>
        [DataMember(Name = "project_scope", EmitDefaultValue = false)]
        public string ProjectScope { get; set; }

        /// <summary>
        /// ProjectSlug is the project&#39;s slug.
        /// </summary>
        /// <value>ProjectSlug is the project&#39;s slug.</value>
        [DataMember(Name = "project_slug", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectSlug { get; set; }

        /// <summary>
        /// Subject is the subject acting (user or API key).
        /// </summary>
        /// <value>Subject is the subject acting (user or API key).</value>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = true)]
        public string Subject { get; set; }

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
            sb.Append("class ClientInternalIsOwnerForProjectBySlugBody {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ProjectScope: ").Append(ProjectScope).Append("\n");
            sb.Append("  ProjectSlug: ").Append(ProjectSlug).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
