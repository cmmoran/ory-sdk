/*
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.4.0-alpha.0
 * Contact: office@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.kratos.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import sh.ory.kratos.model.SessionAuthenticationMethod;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.TypeAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

import sh.ory.kratos.JSON;

/**
 * Device corresponding to a Session
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-03-06T19:15:57.465639357Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class SessionDevice {
  public static final String SERIALIZED_NAME_AUTHENTICATION_METHODS = "authentication_methods";
  @SerializedName(SERIALIZED_NAME_AUTHENTICATION_METHODS)
  private List<SessionAuthenticationMethod> authenticationMethods = new ArrayList<>();

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_IP_ADDRESS = "ip_address";
  @SerializedName(SERIALIZED_NAME_IP_ADDRESS)
  private String ipAddress;

  public static final String SERIALIZED_NAME_LOCATION = "location";
  @SerializedName(SERIALIZED_NAME_LOCATION)
  private String location;

  public static final String SERIALIZED_NAME_TRUSTED = "trusted";
  @SerializedName(SERIALIZED_NAME_TRUSTED)
  private Boolean trusted;

  public static final String SERIALIZED_NAME_USER_AGENT = "user_agent";
  @SerializedName(SERIALIZED_NAME_USER_AGENT)
  private String userAgent;

  public SessionDevice() {
  }

  public SessionDevice authenticationMethods(List<SessionAuthenticationMethod> authenticationMethods) {
    this.authenticationMethods = authenticationMethods;
    return this;
  }

  public SessionDevice addAuthenticationMethodsItem(SessionAuthenticationMethod authenticationMethodsItem) {
    if (this.authenticationMethods == null) {
      this.authenticationMethods = new ArrayList<>();
    }
    this.authenticationMethods.add(authenticationMethodsItem);
    return this;
  }

  /**
   * A list of authenticators which were used to authenticate the session.
   * @return authenticationMethods
   */
  @javax.annotation.Nullable
  public List<SessionAuthenticationMethod> getAuthenticationMethods() {
    return authenticationMethods;
  }

  public void setAuthenticationMethods(List<SessionAuthenticationMethod> authenticationMethods) {
    this.authenticationMethods = authenticationMethods;
  }


  public SessionDevice id(String id) {
    this.id = id;
    return this;
  }

  /**
   * Device record ID
   * @return id
   */
  @javax.annotation.Nonnull
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }


  public SessionDevice ipAddress(String ipAddress) {
    this.ipAddress = ipAddress;
    return this;
  }

  /**
   * IPAddress of the client
   * @return ipAddress
   */
  @javax.annotation.Nullable
  public String getIpAddress() {
    return ipAddress;
  }

  public void setIpAddress(String ipAddress) {
    this.ipAddress = ipAddress;
  }


  public SessionDevice location(String location) {
    this.location = location;
    return this;
  }

  /**
   * Geo Location corresponding to the IP Address
   * @return location
   */
  @javax.annotation.Nullable
  public String getLocation() {
    return location;
  }

  public void setLocation(String location) {
    this.location = location;
  }


  public SessionDevice trusted(Boolean trusted) {
    this.trusted = trusted;
    return this;
  }

  /**
   * Is this device trusted? (only matters if this device submitted aal2+ credentials)
   * @return trusted
   */
  @javax.annotation.Nullable
  public Boolean getTrusted() {
    return trusted;
  }

  public void setTrusted(Boolean trusted) {
    this.trusted = trusted;
  }


  public SessionDevice userAgent(String userAgent) {
    this.userAgent = userAgent;
    return this;
  }

  /**
   * UserAgent of the client
   * @return userAgent
   */
  @javax.annotation.Nullable
  public String getUserAgent() {
    return userAgent;
  }

  public void setUserAgent(String userAgent) {
    this.userAgent = userAgent;
  }

  /**
   * A container for additional, undeclared properties.
   * This is a holder for any undeclared properties as specified with
   * the 'additionalProperties' keyword in the OAS document.
   */
  private Map<String, Object> additionalProperties;

  /**
   * Set the additional (undeclared) property with the specified name and value.
   * If the property does not already exist, create it otherwise replace it.
   *
   * @param key name of the property
   * @param value value of the property
   * @return the SessionDevice instance itself
   */
  public SessionDevice putAdditionalProperty(String key, Object value) {
    if (this.additionalProperties == null) {
        this.additionalProperties = new HashMap<String, Object>();
    }
    this.additionalProperties.put(key, value);
    return this;
  }

  /**
   * Return the additional (undeclared) property.
   *
   * @return a map of objects
   */
  public Map<String, Object> getAdditionalProperties() {
    return additionalProperties;
  }

  /**
   * Return the additional (undeclared) property with the specified name.
   *
   * @param key name of the property
   * @return an object
   */
  public Object getAdditionalProperty(String key) {
    if (this.additionalProperties == null) {
        return null;
    }
    return this.additionalProperties.get(key);
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SessionDevice sessionDevice = (SessionDevice) o;
    return Objects.equals(this.authenticationMethods, sessionDevice.authenticationMethods) &&
        Objects.equals(this.id, sessionDevice.id) &&
        Objects.equals(this.ipAddress, sessionDevice.ipAddress) &&
        Objects.equals(this.location, sessionDevice.location) &&
        Objects.equals(this.trusted, sessionDevice.trusted) &&
        Objects.equals(this.userAgent, sessionDevice.userAgent)&&
        Objects.equals(this.additionalProperties, sessionDevice.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(authenticationMethods, id, ipAddress, location, trusted, userAgent, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SessionDevice {\n");
    sb.append("    authenticationMethods: ").append(toIndentedString(authenticationMethods)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    ipAddress: ").append(toIndentedString(ipAddress)).append("\n");
    sb.append("    location: ").append(toIndentedString(location)).append("\n");
    sb.append("    trusted: ").append(toIndentedString(trusted)).append("\n");
    sb.append("    userAgent: ").append(toIndentedString(userAgent)).append("\n");
    sb.append("    additionalProperties: ").append(toIndentedString(additionalProperties)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("authentication_methods");
    openapiFields.add("id");
    openapiFields.add("ip_address");
    openapiFields.add("location");
    openapiFields.add("trusted");
    openapiFields.add("user_agent");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("id");
  }

  /**
   * Validates the JSON Element and throws an exception if issues found
   *
   * @param jsonElement JSON Element
   * @throws IOException if the JSON Element is invalid with respect to SessionDevice
   */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!SessionDevice.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in SessionDevice is not found in the empty JSON string", SessionDevice.openapiRequiredFields.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : SessionDevice.openapiRequiredFields) {
        if (jsonElement.getAsJsonObject().get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if (jsonObj.get("authentication_methods") != null && !jsonObj.get("authentication_methods").isJsonNull()) {
        JsonArray jsonArrayauthenticationMethods = jsonObj.getAsJsonArray("authentication_methods");
        if (jsonArrayauthenticationMethods != null) {
          // ensure the json data is an array
          if (!jsonObj.get("authentication_methods").isJsonArray()) {
            throw new IllegalArgumentException(String.format("Expected the field `authentication_methods` to be an array in the JSON string but got `%s`", jsonObj.get("authentication_methods").toString()));
          }

          // validate the optional field `authentication_methods` (array)
          for (int i = 0; i < jsonArrayauthenticationMethods.size(); i++) {
            SessionAuthenticationMethod.validateJsonElement(jsonArrayauthenticationMethods.get(i));
          };
        }
      }
      if (!jsonObj.get("id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("id").toString()));
      }
      if ((jsonObj.get("ip_address") != null && !jsonObj.get("ip_address").isJsonNull()) && !jsonObj.get("ip_address").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `ip_address` to be a primitive type in the JSON string but got `%s`", jsonObj.get("ip_address").toString()));
      }
      if ((jsonObj.get("location") != null && !jsonObj.get("location").isJsonNull()) && !jsonObj.get("location").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `location` to be a primitive type in the JSON string but got `%s`", jsonObj.get("location").toString()));
      }
      if ((jsonObj.get("user_agent") != null && !jsonObj.get("user_agent").isJsonNull()) && !jsonObj.get("user_agent").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `user_agent` to be a primitive type in the JSON string but got `%s`", jsonObj.get("user_agent").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!SessionDevice.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'SessionDevice' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<SessionDevice> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(SessionDevice.class));

       return (TypeAdapter<T>) new TypeAdapter<SessionDevice>() {
           @Override
           public void write(JsonWriter out, SessionDevice value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             obj.remove("additionalProperties");
             // serialize additional properties
             if (value.getAdditionalProperties() != null) {
               for (Map.Entry<String, Object> entry : value.getAdditionalProperties().entrySet()) {
                 if (entry.getValue() instanceof String)
                   obj.addProperty(entry.getKey(), (String) entry.getValue());
                 else if (entry.getValue() instanceof Number)
                   obj.addProperty(entry.getKey(), (Number) entry.getValue());
                 else if (entry.getValue() instanceof Boolean)
                   obj.addProperty(entry.getKey(), (Boolean) entry.getValue());
                 else if (entry.getValue() instanceof Character)
                   obj.addProperty(entry.getKey(), (Character) entry.getValue());
                 else {
                   JsonElement jsonElement = gson.toJsonTree(entry.getValue());
                   if (jsonElement.isJsonArray()) {
                     obj.add(entry.getKey(), jsonElement.getAsJsonArray());
                   } else {
                     obj.add(entry.getKey(), jsonElement.getAsJsonObject());
                   }
                 }
               }
             }
             elementAdapter.write(out, obj);
           }

           @Override
           public SessionDevice read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             JsonObject jsonObj = jsonElement.getAsJsonObject();
             // store additional fields in the deserialized instance
             SessionDevice instance = thisAdapter.fromJsonTree(jsonObj);
             for (Map.Entry<String, JsonElement> entry : jsonObj.entrySet()) {
               if (!openapiFields.contains(entry.getKey())) {
                 if (entry.getValue().isJsonPrimitive()) { // primitive type
                   if (entry.getValue().getAsJsonPrimitive().isString())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsString());
                   else if (entry.getValue().getAsJsonPrimitive().isNumber())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsNumber());
                   else if (entry.getValue().getAsJsonPrimitive().isBoolean())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsBoolean());
                   else
                     throw new IllegalArgumentException(String.format("The field `%s` has unknown primitive type. Value: %s", entry.getKey(), entry.getValue().toString()));
                 } else if (entry.getValue().isJsonArray()) {
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), List.class));
                 } else { // JSON object
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), HashMap.class));
                 }
               }
             }
             return instance;
           }

       }.nullSafe();
    }
  }

  /**
   * Create an instance of SessionDevice given an JSON string
   *
   * @param jsonString JSON string
   * @return An instance of SessionDevice
   * @throws IOException if the JSON string is invalid with respect to SessionDevice
   */
  public static SessionDevice fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, SessionDevice.class);
  }

  /**
   * Convert an instance of SessionDevice to an JSON string
   *
   * @return JSON string
   */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

