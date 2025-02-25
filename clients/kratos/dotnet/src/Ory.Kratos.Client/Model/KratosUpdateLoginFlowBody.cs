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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosUpdateLoginFlowBody
    /// </summary>
    [JsonConverter(typeof(KratosUpdateLoginFlowBodyJsonConverter))]
    [DataContract(Name = "updateLoginFlowBody")]
    public partial class KratosUpdateLoginFlowBody : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowBody" /> class
        /// with the <see cref="KratosUpdateLoginFlowWithPasswordMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateLoginFlowWithPasswordMethod.</param>
        public KratosUpdateLoginFlowBody(KratosUpdateLoginFlowWithPasswordMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowBody" /> class
        /// with the <see cref="KratosUpdateLoginFlowWithOidcMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateLoginFlowWithOidcMethod.</param>
        public KratosUpdateLoginFlowBody(KratosUpdateLoginFlowWithOidcMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowBody" /> class
        /// with the <see cref="KratosUpdateLoginFlowWithTotpMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateLoginFlowWithTotpMethod.</param>
        public KratosUpdateLoginFlowBody(KratosUpdateLoginFlowWithTotpMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowBody" /> class
        /// with the <see cref="KratosUpdateLoginFlowWithWebAuthnMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateLoginFlowWithWebAuthnMethod.</param>
        public KratosUpdateLoginFlowBody(KratosUpdateLoginFlowWithWebAuthnMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowBody" /> class
        /// with the <see cref="KratosUpdateLoginFlowWithLookupSecretMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateLoginFlowWithLookupSecretMethod.</param>
        public KratosUpdateLoginFlowBody(KratosUpdateLoginFlowWithLookupSecretMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowBody" /> class
        /// with the <see cref="KratosUpdateLoginFlowWithCodeMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateLoginFlowWithCodeMethod.</param>
        public KratosUpdateLoginFlowBody(KratosUpdateLoginFlowWithCodeMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowBody" /> class
        /// with the <see cref="KratosUpdateLoginFlowWithPasskeyMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateLoginFlowWithPasskeyMethod.</param>
        public KratosUpdateLoginFlowBody(KratosUpdateLoginFlowWithPasskeyMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowBody" /> class
        /// with the <see cref="KratosUpdateLoginFlowWithIdentifierFirstMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateLoginFlowWithIdentifierFirstMethod.</param>
        public KratosUpdateLoginFlowBody(KratosUpdateLoginFlowWithIdentifierFirstMethod actualInstance)
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
                if (value.GetType() == typeof(KratosUpdateLoginFlowWithCodeMethod) || value is KratosUpdateLoginFlowWithCodeMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateLoginFlowWithIdentifierFirstMethod) || value is KratosUpdateLoginFlowWithIdentifierFirstMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateLoginFlowWithLookupSecretMethod) || value is KratosUpdateLoginFlowWithLookupSecretMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateLoginFlowWithOidcMethod) || value is KratosUpdateLoginFlowWithOidcMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateLoginFlowWithPasskeyMethod) || value is KratosUpdateLoginFlowWithPasskeyMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateLoginFlowWithPasswordMethod) || value is KratosUpdateLoginFlowWithPasswordMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateLoginFlowWithTotpMethod) || value is KratosUpdateLoginFlowWithTotpMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateLoginFlowWithWebAuthnMethod) || value is KratosUpdateLoginFlowWithWebAuthnMethod)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: KratosUpdateLoginFlowWithCodeMethod, KratosUpdateLoginFlowWithIdentifierFirstMethod, KratosUpdateLoginFlowWithLookupSecretMethod, KratosUpdateLoginFlowWithOidcMethod, KratosUpdateLoginFlowWithPasskeyMethod, KratosUpdateLoginFlowWithPasswordMethod, KratosUpdateLoginFlowWithTotpMethod, KratosUpdateLoginFlowWithWebAuthnMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateLoginFlowWithPasswordMethod`. If the actual instance is not `KratosUpdateLoginFlowWithPasswordMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateLoginFlowWithPasswordMethod</returns>
        public KratosUpdateLoginFlowWithPasswordMethod GetKratosUpdateLoginFlowWithPasswordMethod()
        {
            return (KratosUpdateLoginFlowWithPasswordMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateLoginFlowWithOidcMethod`. If the actual instance is not `KratosUpdateLoginFlowWithOidcMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateLoginFlowWithOidcMethod</returns>
        public KratosUpdateLoginFlowWithOidcMethod GetKratosUpdateLoginFlowWithOidcMethod()
        {
            return (KratosUpdateLoginFlowWithOidcMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateLoginFlowWithTotpMethod`. If the actual instance is not `KratosUpdateLoginFlowWithTotpMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateLoginFlowWithTotpMethod</returns>
        public KratosUpdateLoginFlowWithTotpMethod GetKratosUpdateLoginFlowWithTotpMethod()
        {
            return (KratosUpdateLoginFlowWithTotpMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateLoginFlowWithWebAuthnMethod`. If the actual instance is not `KratosUpdateLoginFlowWithWebAuthnMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateLoginFlowWithWebAuthnMethod</returns>
        public KratosUpdateLoginFlowWithWebAuthnMethod GetKratosUpdateLoginFlowWithWebAuthnMethod()
        {
            return (KratosUpdateLoginFlowWithWebAuthnMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateLoginFlowWithLookupSecretMethod`. If the actual instance is not `KratosUpdateLoginFlowWithLookupSecretMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateLoginFlowWithLookupSecretMethod</returns>
        public KratosUpdateLoginFlowWithLookupSecretMethod GetKratosUpdateLoginFlowWithLookupSecretMethod()
        {
            return (KratosUpdateLoginFlowWithLookupSecretMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateLoginFlowWithCodeMethod`. If the actual instance is not `KratosUpdateLoginFlowWithCodeMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateLoginFlowWithCodeMethod</returns>
        public KratosUpdateLoginFlowWithCodeMethod GetKratosUpdateLoginFlowWithCodeMethod()
        {
            return (KratosUpdateLoginFlowWithCodeMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateLoginFlowWithPasskeyMethod`. If the actual instance is not `KratosUpdateLoginFlowWithPasskeyMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateLoginFlowWithPasskeyMethod</returns>
        public KratosUpdateLoginFlowWithPasskeyMethod GetKratosUpdateLoginFlowWithPasskeyMethod()
        {
            return (KratosUpdateLoginFlowWithPasskeyMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateLoginFlowWithIdentifierFirstMethod`. If the actual instance is not `KratosUpdateLoginFlowWithIdentifierFirstMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateLoginFlowWithIdentifierFirstMethod</returns>
        public KratosUpdateLoginFlowWithIdentifierFirstMethod GetKratosUpdateLoginFlowWithIdentifierFirstMethod()
        {
            return (KratosUpdateLoginFlowWithIdentifierFirstMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosUpdateLoginFlowBody {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, KratosUpdateLoginFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KratosUpdateLoginFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KratosUpdateLoginFlowBody</returns>
        public static KratosUpdateLoginFlowBody FromJson(string jsonString)
        {
            KratosUpdateLoginFlowBody newKratosUpdateLoginFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newKratosUpdateLoginFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateLoginFlowWithCodeMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithCodeMethod>(jsonString, KratosUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithCodeMethod>(jsonString, KratosUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateLoginFlowWithCodeMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateLoginFlowWithCodeMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateLoginFlowWithIdentifierFirstMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithIdentifierFirstMethod>(jsonString, KratosUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithIdentifierFirstMethod>(jsonString, KratosUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateLoginFlowWithIdentifierFirstMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateLoginFlowWithIdentifierFirstMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateLoginFlowWithLookupSecretMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithLookupSecretMethod>(jsonString, KratosUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithLookupSecretMethod>(jsonString, KratosUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateLoginFlowWithLookupSecretMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateLoginFlowWithLookupSecretMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateLoginFlowWithOidcMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithOidcMethod>(jsonString, KratosUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithOidcMethod>(jsonString, KratosUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateLoginFlowWithOidcMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateLoginFlowWithOidcMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateLoginFlowWithPasskeyMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithPasskeyMethod>(jsonString, KratosUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithPasskeyMethod>(jsonString, KratosUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateLoginFlowWithPasskeyMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateLoginFlowWithPasskeyMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateLoginFlowWithPasswordMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithPasswordMethod>(jsonString, KratosUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithPasswordMethod>(jsonString, KratosUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateLoginFlowWithPasswordMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateLoginFlowWithPasswordMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateLoginFlowWithTotpMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithTotpMethod>(jsonString, KratosUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithTotpMethod>(jsonString, KratosUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateLoginFlowWithTotpMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateLoginFlowWithTotpMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateLoginFlowWithWebAuthnMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithWebAuthnMethod>(jsonString, KratosUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateLoginFlowBody = new KratosUpdateLoginFlowBody(JsonConvert.DeserializeObject<KratosUpdateLoginFlowWithWebAuthnMethod>(jsonString, KratosUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateLoginFlowWithWebAuthnMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateLoginFlowWithWebAuthnMethod: {1}", jsonString, exception.ToString()));
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
            return newKratosUpdateLoginFlowBody;
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
    /// Custom JSON converter for KratosUpdateLoginFlowBody
    /// </summary>
    public class KratosUpdateLoginFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(KratosUpdateLoginFlowBody).GetMethod("ToJson").Invoke(value, null)));
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
                    return KratosUpdateLoginFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return KratosUpdateLoginFlowBody.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
