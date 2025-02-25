/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.4
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// Update Registration Request Body
    /// </summary>
    [JsonConverter(typeof(KratosUpdateRegistrationFlowBodyJsonConverter))]
    [DataContract(Name = "updateRegistrationFlowBody")]
    public partial class KratosUpdateRegistrationFlowBody : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class
        /// with the <see cref="KratosUpdateRegistrationFlowWithPasswordMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateRegistrationFlowWithPasswordMethod.</param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithPasswordMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class
        /// with the <see cref="KratosUpdateRegistrationFlowWithOidcMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateRegistrationFlowWithOidcMethod.</param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithOidcMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class
        /// with the <see cref="KratosUpdateRegistrationFlowWithWebAuthnMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateRegistrationFlowWithWebAuthnMethod.</param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithWebAuthnMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class
        /// with the <see cref="KratosUpdateRegistrationFlowWithCodeMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateRegistrationFlowWithCodeMethod.</param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithCodeMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class
        /// with the <see cref="KratosUpdateRegistrationFlowWithPasskeyMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateRegistrationFlowWithPasskeyMethod.</param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithPasskeyMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateRegistrationFlowBody" /> class
        /// with the <see cref="KratosUpdateRegistrationFlowWithProfileMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateRegistrationFlowWithProfileMethod.</param>
        public KratosUpdateRegistrationFlowBody(KratosUpdateRegistrationFlowWithProfileMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(KratosUpdateRegistrationFlowWithCodeMethod) || value is KratosUpdateRegistrationFlowWithCodeMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateRegistrationFlowWithOidcMethod) || value is KratosUpdateRegistrationFlowWithOidcMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateRegistrationFlowWithPasskeyMethod) || value is KratosUpdateRegistrationFlowWithPasskeyMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateRegistrationFlowWithPasswordMethod) || value is KratosUpdateRegistrationFlowWithPasswordMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateRegistrationFlowWithProfileMethod) || value is KratosUpdateRegistrationFlowWithProfileMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateRegistrationFlowWithWebAuthnMethod) || value is KratosUpdateRegistrationFlowWithWebAuthnMethod)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: KratosUpdateRegistrationFlowWithCodeMethod, KratosUpdateRegistrationFlowWithOidcMethod, KratosUpdateRegistrationFlowWithPasskeyMethod, KratosUpdateRegistrationFlowWithPasswordMethod, KratosUpdateRegistrationFlowWithProfileMethod, KratosUpdateRegistrationFlowWithWebAuthnMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateRegistrationFlowWithPasswordMethod`. If the actual instance is not `KratosUpdateRegistrationFlowWithPasswordMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateRegistrationFlowWithPasswordMethod</returns>
        public KratosUpdateRegistrationFlowWithPasswordMethod GetKratosUpdateRegistrationFlowWithPasswordMethod()
        {
            return (KratosUpdateRegistrationFlowWithPasswordMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateRegistrationFlowWithOidcMethod`. If the actual instance is not `KratosUpdateRegistrationFlowWithOidcMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateRegistrationFlowWithOidcMethod</returns>
        public KratosUpdateRegistrationFlowWithOidcMethod GetKratosUpdateRegistrationFlowWithOidcMethod()
        {
            return (KratosUpdateRegistrationFlowWithOidcMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateRegistrationFlowWithWebAuthnMethod`. If the actual instance is not `KratosUpdateRegistrationFlowWithWebAuthnMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateRegistrationFlowWithWebAuthnMethod</returns>
        public KratosUpdateRegistrationFlowWithWebAuthnMethod GetKratosUpdateRegistrationFlowWithWebAuthnMethod()
        {
            return (KratosUpdateRegistrationFlowWithWebAuthnMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateRegistrationFlowWithCodeMethod`. If the actual instance is not `KratosUpdateRegistrationFlowWithCodeMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateRegistrationFlowWithCodeMethod</returns>
        public KratosUpdateRegistrationFlowWithCodeMethod GetKratosUpdateRegistrationFlowWithCodeMethod()
        {
            return (KratosUpdateRegistrationFlowWithCodeMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateRegistrationFlowWithPasskeyMethod`. If the actual instance is not `KratosUpdateRegistrationFlowWithPasskeyMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateRegistrationFlowWithPasskeyMethod</returns>
        public KratosUpdateRegistrationFlowWithPasskeyMethod GetKratosUpdateRegistrationFlowWithPasskeyMethod()
        {
            return (KratosUpdateRegistrationFlowWithPasskeyMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateRegistrationFlowWithProfileMethod`. If the actual instance is not `KratosUpdateRegistrationFlowWithProfileMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateRegistrationFlowWithProfileMethod</returns>
        public KratosUpdateRegistrationFlowWithProfileMethod GetKratosUpdateRegistrationFlowWithProfileMethod()
        {
            return (KratosUpdateRegistrationFlowWithProfileMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosUpdateRegistrationFlowBody {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, KratosUpdateRegistrationFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KratosUpdateRegistrationFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KratosUpdateRegistrationFlowBody</returns>
        public static KratosUpdateRegistrationFlowBody FromJson(string jsonString)
        {
            KratosUpdateRegistrationFlowBody newKratosUpdateRegistrationFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newKratosUpdateRegistrationFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateRegistrationFlowWithCodeMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithCodeMethod>(jsonString, KratosUpdateRegistrationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithCodeMethod>(jsonString, KratosUpdateRegistrationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateRegistrationFlowWithCodeMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateRegistrationFlowWithCodeMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateRegistrationFlowWithOidcMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithOidcMethod>(jsonString, KratosUpdateRegistrationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithOidcMethod>(jsonString, KratosUpdateRegistrationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateRegistrationFlowWithOidcMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateRegistrationFlowWithOidcMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateRegistrationFlowWithPasskeyMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithPasskeyMethod>(jsonString, KratosUpdateRegistrationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithPasskeyMethod>(jsonString, KratosUpdateRegistrationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateRegistrationFlowWithPasskeyMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateRegistrationFlowWithPasskeyMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateRegistrationFlowWithPasswordMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithPasswordMethod>(jsonString, KratosUpdateRegistrationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithPasswordMethod>(jsonString, KratosUpdateRegistrationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateRegistrationFlowWithPasswordMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateRegistrationFlowWithPasswordMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateRegistrationFlowWithProfileMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithProfileMethod>(jsonString, KratosUpdateRegistrationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithProfileMethod>(jsonString, KratosUpdateRegistrationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateRegistrationFlowWithProfileMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateRegistrationFlowWithProfileMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateRegistrationFlowWithWebAuthnMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithWebAuthnMethod>(jsonString, KratosUpdateRegistrationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateRegistrationFlowBody = new KratosUpdateRegistrationFlowBody(JsonConvert.DeserializeObject<KratosUpdateRegistrationFlowWithWebAuthnMethod>(jsonString, KratosUpdateRegistrationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateRegistrationFlowWithWebAuthnMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateRegistrationFlowWithWebAuthnMethod: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newKratosUpdateRegistrationFlowBody;
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

    /// <summary>
    /// Custom JSON converter for KratosUpdateRegistrationFlowBody
    /// </summary>
    public class KratosUpdateRegistrationFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(KratosUpdateRegistrationFlowBody).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return KratosUpdateRegistrationFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return KratosUpdateRegistrationFlowBody.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
