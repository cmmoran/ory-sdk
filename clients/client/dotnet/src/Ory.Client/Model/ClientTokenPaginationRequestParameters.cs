/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.2
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
    /// The &#x60;Link&#x60; HTTP header contains multiple links (&#x60;first&#x60;, &#x60;next&#x60;, &#x60;last&#x60;, &#x60;previous&#x60;) formatted as: &#x60;&lt;https://{project-slug}.projects.oryapis.com/admin/clients?page_size&#x3D;{limit}&amp;page_token&#x3D;{offset}&gt;; rel&#x3D;\&quot;{page}\&quot;&#x60;  For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
    /// </summary>
    [DataContract(Name = "tokenPaginationRequestParameters")]
    public partial class ClientTokenPaginationRequestParameters : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientTokenPaginationRequestParameters" /> class.
        /// </summary>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (default to 250).</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (default to &quot;1&quot;).</param>
        public ClientTokenPaginationRequestParameters(long pageSize = 250, string pageToken = @"1")
        {
            this.PageSize = pageSize;
            // use default value if no "pageToken" provided
            this.PageToken = pageToken ?? @"1";
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
        /// </summary>
        /// <value>Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public long PageSize { get; set; }

        /// <summary>
        /// Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
        /// </summary>
        /// <value>Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).</value>
        [DataMember(Name = "page_token", EmitDefaultValue = false)]
        public string PageToken { get; set; }

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
            sb.Append("class ClientTokenPaginationRequestParameters {\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PageSize (long) maximum
            if (this.PageSize > (long)500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageSize, must be a value less than or equal to 500.", new [] { "PageSize" });
            }

            // PageSize (long) minimum
            if (this.PageSize < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageSize, must be a value greater than or equal to 1.", new [] { "PageSize" });
            }

            yield break;
        }
    }

}
