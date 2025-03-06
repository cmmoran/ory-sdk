// <auto-generated>
/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.4.0-alpha.0
 * Contact: office@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Ory.Kratos.Client.Client;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// It can either be &#x60;email&#x60; or &#x60;phone&#x60;
    /// </summary>
    /// <value>It can either be &#x60;email&#x60; or &#x60;phone&#x60;</value>
    public enum KratosCourierMessageType
    {
        /// <summary>
        /// Enum Email for value: email
        /// </summary>
        Email = 1,

        /// <summary>
        /// Enum Phone for value: phone
        /// </summary>
        Phone = 2
    }

    /// <summary>
    /// Converts <see cref="KratosCourierMessageType"/> to and from the JSON value
    /// </summary>
    public static class KratosCourierMessageTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="KratosCourierMessageType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KratosCourierMessageType FromString(string value)
        {
            if (value.Equals("email"))
                return KratosCourierMessageType.Email;

            if (value.Equals("phone"))
                return KratosCourierMessageType.Phone;

            throw new NotImplementedException($"Could not convert value to type KratosCourierMessageType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="KratosCourierMessageType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KratosCourierMessageType? FromStringOrDefault(string value)
        {
            if (value.Equals("email"))
                return KratosCourierMessageType.Email;

            if (value.Equals("phone"))
                return KratosCourierMessageType.Phone;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="KratosCourierMessageType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(KratosCourierMessageType value)
        {
            if (value == KratosCourierMessageType.Email)
                return "email";

            if (value == KratosCourierMessageType.Phone)
                return "phone";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosCourierMessageType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class KratosCourierMessageTypeJsonConverter : JsonConverter<KratosCourierMessageType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override KratosCourierMessageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            KratosCourierMessageType? result = rawValue == null
                ? null
                : KratosCourierMessageTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the KratosCourierMessageType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCourierMessageType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, KratosCourierMessageType kratosCourierMessageType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(kratosCourierMessageType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosCourierMessageType"/>
    /// </summary>
    public class KratosCourierMessageTypeNullableJsonConverter : JsonConverter<KratosCourierMessageType?>
    {
        /// <summary>
        /// Returns a KratosCourierMessageType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override KratosCourierMessageType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            KratosCourierMessageType? result = rawValue == null
                ? null
                : KratosCourierMessageTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCourierMessageType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, KratosCourierMessageType? kratosCourierMessageType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(kratosCourierMessageType?.ToString() ?? "null");
        }
    }
}
