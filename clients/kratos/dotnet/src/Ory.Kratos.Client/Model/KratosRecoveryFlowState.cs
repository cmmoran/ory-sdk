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
    /// The experimental state represents the state of a recovery flow. This field is EXPERIMENTAL and subject to change!
    /// </summary>
    /// <value>The experimental state represents the state of a recovery flow. This field is EXPERIMENTAL and subject to change!</value>
    public enum KratosRecoveryFlowState
    {
        /// <summary>
        /// Enum ChooseMethod for value: choose_method
        /// </summary>
        ChooseMethod = 1,

        /// <summary>
        /// Enum SentEmail for value: sent_email
        /// </summary>
        SentEmail = 2,

        /// <summary>
        /// Enum PassedChallenge for value: passed_challenge
        /// </summary>
        PassedChallenge = 3
    }

    /// <summary>
    /// Converts <see cref="KratosRecoveryFlowState"/> to and from the JSON value
    /// </summary>
    public static class KratosRecoveryFlowStateValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="KratosRecoveryFlowState"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KratosRecoveryFlowState FromString(string value)
        {
            if (value.Equals("choose_method"))
                return KratosRecoveryFlowState.ChooseMethod;

            if (value.Equals("sent_email"))
                return KratosRecoveryFlowState.SentEmail;

            if (value.Equals("passed_challenge"))
                return KratosRecoveryFlowState.PassedChallenge;

            throw new NotImplementedException($"Could not convert value to type KratosRecoveryFlowState: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="KratosRecoveryFlowState"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KratosRecoveryFlowState? FromStringOrDefault(string value)
        {
            if (value.Equals("choose_method"))
                return KratosRecoveryFlowState.ChooseMethod;

            if (value.Equals("sent_email"))
                return KratosRecoveryFlowState.SentEmail;

            if (value.Equals("passed_challenge"))
                return KratosRecoveryFlowState.PassedChallenge;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="KratosRecoveryFlowState"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(KratosRecoveryFlowState value)
        {
            if (value == KratosRecoveryFlowState.ChooseMethod)
                return "choose_method";

            if (value == KratosRecoveryFlowState.SentEmail)
                return "sent_email";

            if (value == KratosRecoveryFlowState.PassedChallenge)
                return "passed_challenge";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosRecoveryFlowState"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class KratosRecoveryFlowStateJsonConverter : JsonConverter<KratosRecoveryFlowState>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override KratosRecoveryFlowState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            KratosRecoveryFlowState? result = rawValue == null
                ? null
                : KratosRecoveryFlowStateValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the KratosRecoveryFlowState to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosRecoveryFlowState"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, KratosRecoveryFlowState kratosRecoveryFlowState, JsonSerializerOptions options)
        {
            writer.WriteStringValue(kratosRecoveryFlowState.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosRecoveryFlowState"/>
    /// </summary>
    public class KratosRecoveryFlowStateNullableJsonConverter : JsonConverter<KratosRecoveryFlowState?>
    {
        /// <summary>
        /// Returns a KratosRecoveryFlowState from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override KratosRecoveryFlowState? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            KratosRecoveryFlowState? result = rawValue == null
                ? null
                : KratosRecoveryFlowStateValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosRecoveryFlowState"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, KratosRecoveryFlowState? kratosRecoveryFlowState, JsonSerializerOptions options)
        {
            writer.WriteStringValue(kratosRecoveryFlowState?.ToString() ?? "null");
        }
    }
}
