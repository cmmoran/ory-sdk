/*
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6
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
import java.util.Arrays;

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
 * Update Settings Flow with OpenID Connect Method
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-02-25T14:03:25.789977467Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class UpdateSettingsFlowWithOidcMethod {
  public static final String SERIALIZED_NAME_FLOW = "flow";
  @SerializedName(SERIALIZED_NAME_FLOW)
  private String flow;

  public static final String SERIALIZED_NAME_LINK = "link";
  @SerializedName(SERIALIZED_NAME_LINK)
  private String link;

  public static final String SERIALIZED_NAME_METHOD = "method";
  @SerializedName(SERIALIZED_NAME_METHOD)
  private String method;

  public static final String SERIALIZED_NAME_TRAITS = "traits";
  @SerializedName(SERIALIZED_NAME_TRAITS)
  private Object traits;

  public static final String SERIALIZED_NAME_TRANSIENT_PAYLOAD = "transient_payload";
  @SerializedName(SERIALIZED_NAME_TRANSIENT_PAYLOAD)
  private Object transientPayload;

  public static final String SERIALIZED_NAME_UNLINK = "unlink";
  @SerializedName(SERIALIZED_NAME_UNLINK)
  private String unlink;

  public static final String SERIALIZED_NAME_UPSTREAM_PARAMETERS = "upstream_parameters";
  @SerializedName(SERIALIZED_NAME_UPSTREAM_PARAMETERS)
  private Object upstreamParameters;

  public UpdateSettingsFlowWithOidcMethod() {
  }

  public UpdateSettingsFlowWithOidcMethod flow(String flow) {
    this.flow = flow;
    return this;
  }

  /**
   * Flow ID is the flow&#39;s ID.  in: query
   * @return flow
   */
  @javax.annotation.Nullable
  public String getFlow() {
    return flow;
  }

  public void setFlow(String flow) {
    this.flow = flow;
  }


  public UpdateSettingsFlowWithOidcMethod link(String link) {
    this.link = link;
    return this;
  }

  /**
   * Link this provider  Either this or &#x60;unlink&#x60; must be set.  type: string in: body
   * @return link
   */
  @javax.annotation.Nullable
  public String getLink() {
    return link;
  }

  public void setLink(String link) {
    this.link = link;
  }


  public UpdateSettingsFlowWithOidcMethod method(String method) {
    this.method = method;
    return this;
  }

  /**
   * Method  Should be set to profile when trying to update a profile.
   * @return method
   */
  @javax.annotation.Nonnull
  public String getMethod() {
    return method;
  }

  public void setMethod(String method) {
    this.method = method;
  }


  public UpdateSettingsFlowWithOidcMethod traits(Object traits) {
    this.traits = traits;
    return this;
  }

  /**
   * The identity&#39;s traits  in: body
   * @return traits
   */
  @javax.annotation.Nullable
  public Object getTraits() {
    return traits;
  }

  public void setTraits(Object traits) {
    this.traits = traits;
  }


  public UpdateSettingsFlowWithOidcMethod transientPayload(Object transientPayload) {
    this.transientPayload = transientPayload;
    return this;
  }

  /**
   * Transient data to pass along to any webhooks
   * @return transientPayload
   */
  @javax.annotation.Nullable
  public Object getTransientPayload() {
    return transientPayload;
  }

  public void setTransientPayload(Object transientPayload) {
    this.transientPayload = transientPayload;
  }


  public UpdateSettingsFlowWithOidcMethod unlink(String unlink) {
    this.unlink = unlink;
    return this;
  }

  /**
   * Unlink this provider  Either this or &#x60;link&#x60; must be set.  type: string in: body
   * @return unlink
   */
  @javax.annotation.Nullable
  public String getUnlink() {
    return unlink;
  }

  public void setUnlink(String unlink) {
    this.unlink = unlink;
  }


  public UpdateSettingsFlowWithOidcMethod upstreamParameters(Object upstreamParameters) {
    this.upstreamParameters = upstreamParameters;
    return this;
  }

  /**
   * UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: &#x60;login_hint&#x60; (string): The &#x60;login_hint&#x60; parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. &#x60;hd&#x60; (string): The &#x60;hd&#x60; parameter limits the login/registration process to a Google Organization, e.g. &#x60;mycollege.edu&#x60;. &#x60;prompt&#x60; (string): The &#x60;prompt&#x60; specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. &#x60;select_account&#x60;.
   * @return upstreamParameters
   */
  @javax.annotation.Nullable
  public Object getUpstreamParameters() {
    return upstreamParameters;
  }

  public void setUpstreamParameters(Object upstreamParameters) {
    this.upstreamParameters = upstreamParameters;
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
   * @return the UpdateSettingsFlowWithOidcMethod instance itself
   */
  public UpdateSettingsFlowWithOidcMethod putAdditionalProperty(String key, Object value) {
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
    UpdateSettingsFlowWithOidcMethod updateSettingsFlowWithOidcMethod = (UpdateSettingsFlowWithOidcMethod) o;
    return Objects.equals(this.flow, updateSettingsFlowWithOidcMethod.flow) &&
        Objects.equals(this.link, updateSettingsFlowWithOidcMethod.link) &&
        Objects.equals(this.method, updateSettingsFlowWithOidcMethod.method) &&
        Objects.equals(this.traits, updateSettingsFlowWithOidcMethod.traits) &&
        Objects.equals(this.transientPayload, updateSettingsFlowWithOidcMethod.transientPayload) &&
        Objects.equals(this.unlink, updateSettingsFlowWithOidcMethod.unlink) &&
        Objects.equals(this.upstreamParameters, updateSettingsFlowWithOidcMethod.upstreamParameters)&&
        Objects.equals(this.additionalProperties, updateSettingsFlowWithOidcMethod.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(flow, link, method, traits, transientPayload, unlink, upstreamParameters, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UpdateSettingsFlowWithOidcMethod {\n");
    sb.append("    flow: ").append(toIndentedString(flow)).append("\n");
    sb.append("    link: ").append(toIndentedString(link)).append("\n");
    sb.append("    method: ").append(toIndentedString(method)).append("\n");
    sb.append("    traits: ").append(toIndentedString(traits)).append("\n");
    sb.append("    transientPayload: ").append(toIndentedString(transientPayload)).append("\n");
    sb.append("    unlink: ").append(toIndentedString(unlink)).append("\n");
    sb.append("    upstreamParameters: ").append(toIndentedString(upstreamParameters)).append("\n");
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
    openapiFields.add("flow");
    openapiFields.add("link");
    openapiFields.add("method");
    openapiFields.add("traits");
    openapiFields.add("transient_payload");
    openapiFields.add("unlink");
    openapiFields.add("upstream_parameters");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("method");
  }

  /**
   * Validates the JSON Element and throws an exception if issues found
   *
   * @param jsonElement JSON Element
   * @throws IOException if the JSON Element is invalid with respect to UpdateSettingsFlowWithOidcMethod
   */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!UpdateSettingsFlowWithOidcMethod.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in UpdateSettingsFlowWithOidcMethod is not found in the empty JSON string", UpdateSettingsFlowWithOidcMethod.openapiRequiredFields.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : UpdateSettingsFlowWithOidcMethod.openapiRequiredFields) {
        if (jsonElement.getAsJsonObject().get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if ((jsonObj.get("flow") != null && !jsonObj.get("flow").isJsonNull()) && !jsonObj.get("flow").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `flow` to be a primitive type in the JSON string but got `%s`", jsonObj.get("flow").toString()));
      }
      if ((jsonObj.get("link") != null && !jsonObj.get("link").isJsonNull()) && !jsonObj.get("link").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `link` to be a primitive type in the JSON string but got `%s`", jsonObj.get("link").toString()));
      }
      if (!jsonObj.get("method").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `method` to be a primitive type in the JSON string but got `%s`", jsonObj.get("method").toString()));
      }
      if ((jsonObj.get("unlink") != null && !jsonObj.get("unlink").isJsonNull()) && !jsonObj.get("unlink").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `unlink` to be a primitive type in the JSON string but got `%s`", jsonObj.get("unlink").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!UpdateSettingsFlowWithOidcMethod.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'UpdateSettingsFlowWithOidcMethod' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<UpdateSettingsFlowWithOidcMethod> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(UpdateSettingsFlowWithOidcMethod.class));

       return (TypeAdapter<T>) new TypeAdapter<UpdateSettingsFlowWithOidcMethod>() {
           @Override
           public void write(JsonWriter out, UpdateSettingsFlowWithOidcMethod value) throws IOException {
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
           public UpdateSettingsFlowWithOidcMethod read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             JsonObject jsonObj = jsonElement.getAsJsonObject();
             // store additional fields in the deserialized instance
             UpdateSettingsFlowWithOidcMethod instance = thisAdapter.fromJsonTree(jsonObj);
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
   * Create an instance of UpdateSettingsFlowWithOidcMethod given an JSON string
   *
   * @param jsonString JSON string
   * @return An instance of UpdateSettingsFlowWithOidcMethod
   * @throws IOException if the JSON string is invalid with respect to UpdateSettingsFlowWithOidcMethod
   */
  public static UpdateSettingsFlowWithOidcMethod fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, UpdateSettingsFlowWithOidcMethod.class);
  }

  /**
   * Convert an instance of UpdateSettingsFlowWithOidcMethod to an JSON string
   *
   * @return JSON string
   */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

