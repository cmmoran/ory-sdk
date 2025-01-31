/*
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.5
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

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

import sh.ory.JSON;

/**
 * OAuth2ConsentRequestOpenIDConnectContext
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-01-31T08:39:45.098075805Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class OAuth2ConsentRequestOpenIDConnectContext {
  public static final String SERIALIZED_NAME_ACR_VALUES = "acr_values";
  @SerializedName(SERIALIZED_NAME_ACR_VALUES)
  private List<String> acrValues = new ArrayList<>();

  public static final String SERIALIZED_NAME_DISPLAY = "display";
  @SerializedName(SERIALIZED_NAME_DISPLAY)
  private String display;

  public static final String SERIALIZED_NAME_ID_TOKEN_HINT_CLAIMS = "id_token_hint_claims";
  @SerializedName(SERIALIZED_NAME_ID_TOKEN_HINT_CLAIMS)
  private Map<String, Object> idTokenHintClaims = new HashMap<>();

  public static final String SERIALIZED_NAME_LOGIN_HINT = "login_hint";
  @SerializedName(SERIALIZED_NAME_LOGIN_HINT)
  private String loginHint;

  public static final String SERIALIZED_NAME_UI_LOCALES = "ui_locales";
  @SerializedName(SERIALIZED_NAME_UI_LOCALES)
  private List<String> uiLocales = new ArrayList<>();

  public OAuth2ConsentRequestOpenIDConnectContext() {
  }

  public OAuth2ConsentRequestOpenIDConnectContext acrValues(List<String> acrValues) {
    this.acrValues = acrValues;
    return this;
  }

  public OAuth2ConsentRequestOpenIDConnectContext addAcrValuesItem(String acrValuesItem) {
    if (this.acrValues == null) {
      this.acrValues = new ArrayList<>();
    }
    this.acrValues.add(acrValuesItem);
    return this;
  }

  /**
   * ACRValues is the Authentication AuthorizationContext Class Reference requested in the OAuth 2.0 Authorization request. It is a parameter defined by OpenID Connect and expresses which level of authentication (e.g. 2FA) is required.  OpenID Connect defines it as follows: &gt; Requested Authentication AuthorizationContext Class Reference values. Space-separated string that specifies the acr values that the Authorization Server is being requested to use for processing this Authentication Request, with the values appearing in order of preference. The Authentication AuthorizationContext Class satisfied by the authentication performed is returned as the acr Claim Value, as specified in Section 2. The acr Claim is requested as a Voluntary Claim by this parameter.
   * @return acrValues
   */
  @javax.annotation.Nullable
  public List<String> getAcrValues() {
    return acrValues;
  }

  public void setAcrValues(List<String> acrValues) {
    this.acrValues = acrValues;
  }


  public OAuth2ConsentRequestOpenIDConnectContext display(String display) {
    this.display = display;
    return this;
  }

  /**
   * Display is a string value that specifies how the Authorization Server displays the authentication and consent user interface pages to the End-User. The defined values are: page: The Authorization Server SHOULD display the authentication and consent UI consistent with a full User Agent page view. If the display parameter is not specified, this is the default display mode. popup: The Authorization Server SHOULD display the authentication and consent UI consistent with a popup User Agent window. The popup User Agent window should be of an appropriate size for a login-focused dialog and should not obscure the entire window that it is popping up over. touch: The Authorization Server SHOULD display the authentication and consent UI consistent with a device that leverages a touch interface. wap: The Authorization Server SHOULD display the authentication and consent UI consistent with a \&quot;feature phone\&quot; type display.  The Authorization Server MAY also attempt to detect the capabilities of the User Agent and present an appropriate display.
   * @return display
   */
  @javax.annotation.Nullable
  public String getDisplay() {
    return display;
  }

  public void setDisplay(String display) {
    this.display = display;
  }


  public OAuth2ConsentRequestOpenIDConnectContext idTokenHintClaims(Map<String, Object> idTokenHintClaims) {
    this.idTokenHintClaims = idTokenHintClaims;
    return this;
  }

  public OAuth2ConsentRequestOpenIDConnectContext putIdTokenHintClaimsItem(String key, Object idTokenHintClaimsItem) {
    if (this.idTokenHintClaims == null) {
      this.idTokenHintClaims = new HashMap<>();
    }
    this.idTokenHintClaims.put(key, idTokenHintClaimsItem);
    return this;
  }

  /**
   * IDTokenHintClaims are the claims of the ID Token previously issued by the Authorization Server being passed as a hint about the End-User&#39;s current or past authenticated session with the Client.
   * @return idTokenHintClaims
   */
  @javax.annotation.Nullable
  public Map<String, Object> getIdTokenHintClaims() {
    return idTokenHintClaims;
  }

  public void setIdTokenHintClaims(Map<String, Object> idTokenHintClaims) {
    this.idTokenHintClaims = idTokenHintClaims;
  }


  public OAuth2ConsentRequestOpenIDConnectContext loginHint(String loginHint) {
    this.loginHint = loginHint;
    return this;
  }

  /**
   * LoginHint hints about the login identifier the End-User might use to log in (if necessary). This hint can be used by an RP if it first asks the End-User for their e-mail address (or other identifier) and then wants to pass that value as a hint to the discovered authorization service. This value MAY also be a phone number in the format specified for the phone_number Claim. The use of this parameter is optional.
   * @return loginHint
   */
  @javax.annotation.Nullable
  public String getLoginHint() {
    return loginHint;
  }

  public void setLoginHint(String loginHint) {
    this.loginHint = loginHint;
  }


  public OAuth2ConsentRequestOpenIDConnectContext uiLocales(List<String> uiLocales) {
    this.uiLocales = uiLocales;
    return this;
  }

  public OAuth2ConsentRequestOpenIDConnectContext addUiLocalesItem(String uiLocalesItem) {
    if (this.uiLocales == null) {
      this.uiLocales = new ArrayList<>();
    }
    this.uiLocales.add(uiLocalesItem);
    return this;
  }

  /**
   * UILocales is the End-User&#39;id preferred languages and scripts for the user interface, represented as a space-separated list of BCP47 [RFC5646] language tag values, ordered by preference. For instance, the value \&quot;fr-CA fr en\&quot; represents a preference for French as spoken in Canada, then French (without a region designation), followed by English (without a region designation). An error SHOULD NOT result if some or all of the requested locales are not supported by the OpenID Provider.
   * @return uiLocales
   */
  @javax.annotation.Nullable
  public List<String> getUiLocales() {
    return uiLocales;
  }

  public void setUiLocales(List<String> uiLocales) {
    this.uiLocales = uiLocales;
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
   * @return the OAuth2ConsentRequestOpenIDConnectContext instance itself
   */
  public OAuth2ConsentRequestOpenIDConnectContext putAdditionalProperty(String key, Object value) {
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
    OAuth2ConsentRequestOpenIDConnectContext oAuth2ConsentRequestOpenIDConnectContext = (OAuth2ConsentRequestOpenIDConnectContext) o;
    return Objects.equals(this.acrValues, oAuth2ConsentRequestOpenIDConnectContext.acrValues) &&
        Objects.equals(this.display, oAuth2ConsentRequestOpenIDConnectContext.display) &&
        Objects.equals(this.idTokenHintClaims, oAuth2ConsentRequestOpenIDConnectContext.idTokenHintClaims) &&
        Objects.equals(this.loginHint, oAuth2ConsentRequestOpenIDConnectContext.loginHint) &&
        Objects.equals(this.uiLocales, oAuth2ConsentRequestOpenIDConnectContext.uiLocales)&&
        Objects.equals(this.additionalProperties, oAuth2ConsentRequestOpenIDConnectContext.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(acrValues, display, idTokenHintClaims, loginHint, uiLocales, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OAuth2ConsentRequestOpenIDConnectContext {\n");
    sb.append("    acrValues: ").append(toIndentedString(acrValues)).append("\n");
    sb.append("    display: ").append(toIndentedString(display)).append("\n");
    sb.append("    idTokenHintClaims: ").append(toIndentedString(idTokenHintClaims)).append("\n");
    sb.append("    loginHint: ").append(toIndentedString(loginHint)).append("\n");
    sb.append("    uiLocales: ").append(toIndentedString(uiLocales)).append("\n");
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
    openapiFields.add("acr_values");
    openapiFields.add("display");
    openapiFields.add("id_token_hint_claims");
    openapiFields.add("login_hint");
    openapiFields.add("ui_locales");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

  /**
   * Validates the JSON Element and throws an exception if issues found
   *
   * @param jsonElement JSON Element
   * @throws IOException if the JSON Element is invalid with respect to OAuth2ConsentRequestOpenIDConnectContext
   */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!OAuth2ConsentRequestOpenIDConnectContext.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in OAuth2ConsentRequestOpenIDConnectContext is not found in the empty JSON string", OAuth2ConsentRequestOpenIDConnectContext.openapiRequiredFields.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      // ensure the optional json data is an array if present
      if (jsonObj.get("acr_values") != null && !jsonObj.get("acr_values").isJsonNull() && !jsonObj.get("acr_values").isJsonArray()) {
        throw new IllegalArgumentException(String.format("Expected the field `acr_values` to be an array in the JSON string but got `%s`", jsonObj.get("acr_values").toString()));
      }
      if ((jsonObj.get("display") != null && !jsonObj.get("display").isJsonNull()) && !jsonObj.get("display").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `display` to be a primitive type in the JSON string but got `%s`", jsonObj.get("display").toString()));
      }
      if ((jsonObj.get("login_hint") != null && !jsonObj.get("login_hint").isJsonNull()) && !jsonObj.get("login_hint").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `login_hint` to be a primitive type in the JSON string but got `%s`", jsonObj.get("login_hint").toString()));
      }
      // ensure the optional json data is an array if present
      if (jsonObj.get("ui_locales") != null && !jsonObj.get("ui_locales").isJsonNull() && !jsonObj.get("ui_locales").isJsonArray()) {
        throw new IllegalArgumentException(String.format("Expected the field `ui_locales` to be an array in the JSON string but got `%s`", jsonObj.get("ui_locales").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!OAuth2ConsentRequestOpenIDConnectContext.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'OAuth2ConsentRequestOpenIDConnectContext' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<OAuth2ConsentRequestOpenIDConnectContext> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(OAuth2ConsentRequestOpenIDConnectContext.class));

       return (TypeAdapter<T>) new TypeAdapter<OAuth2ConsentRequestOpenIDConnectContext>() {
           @Override
           public void write(JsonWriter out, OAuth2ConsentRequestOpenIDConnectContext value) throws IOException {
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
           public OAuth2ConsentRequestOpenIDConnectContext read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             JsonObject jsonObj = jsonElement.getAsJsonObject();
             // store additional fields in the deserialized instance
             OAuth2ConsentRequestOpenIDConnectContext instance = thisAdapter.fromJsonTree(jsonObj);
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
   * Create an instance of OAuth2ConsentRequestOpenIDConnectContext given an JSON string
   *
   * @param jsonString JSON string
   * @return An instance of OAuth2ConsentRequestOpenIDConnectContext
   * @throws IOException if the JSON string is invalid with respect to OAuth2ConsentRequestOpenIDConnectContext
   */
  public static OAuth2ConsentRequestOpenIDConnectContext fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, OAuth2ConsentRequestOpenIDConnectContext.class);
  }

  /**
   * Convert an instance of OAuth2ConsentRequestOpenIDConnectContext to an JSON string
   *
   * @return JSON string
   */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

