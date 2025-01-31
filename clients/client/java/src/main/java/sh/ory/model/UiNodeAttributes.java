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
import java.util.Arrays;
import org.openapitools.jackson.nullable.JsonNullable;
import sh.ory.model.UiNodeAnchorAttributes;
import sh.ory.model.UiNodeImageAttributes;
import sh.ory.model.UiNodeInputAttributes;
import sh.ory.model.UiNodeScriptAttributes;
import sh.ory.model.UiNodeTextAttributes;
import sh.ory.model.UiText;



import java.io.IOException;
import java.lang.reflect.Type;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapter;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.JsonPrimitive;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonSerializationContext;
import com.google.gson.JsonSerializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonArray;
import com.google.gson.JsonParseException;

import sh.ory.JSON;

@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2025-01-31T08:39:45.098075805Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class UiNodeAttributes extends AbstractOpenApiSchema {
    private static final Logger log = Logger.getLogger(UiNodeAttributes.class.getName());

    public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
        @SuppressWarnings("unchecked")
        @Override
        public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
            if (!UiNodeAttributes.class.isAssignableFrom(type.getRawType())) {
                return null; // this class only serializes 'UiNodeAttributes' and its subtypes
            }
            final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
            final TypeAdapter<UiNodeInputAttributes> adapterUiNodeInputAttributes = gson.getDelegateAdapter(this, TypeToken.get(UiNodeInputAttributes.class));
            final TypeAdapter<UiNodeTextAttributes> adapterUiNodeTextAttributes = gson.getDelegateAdapter(this, TypeToken.get(UiNodeTextAttributes.class));
            final TypeAdapter<UiNodeImageAttributes> adapterUiNodeImageAttributes = gson.getDelegateAdapter(this, TypeToken.get(UiNodeImageAttributes.class));
            final TypeAdapter<UiNodeAnchorAttributes> adapterUiNodeAnchorAttributes = gson.getDelegateAdapter(this, TypeToken.get(UiNodeAnchorAttributes.class));
            final TypeAdapter<UiNodeScriptAttributes> adapterUiNodeScriptAttributes = gson.getDelegateAdapter(this, TypeToken.get(UiNodeScriptAttributes.class));

            return (TypeAdapter<T>) new TypeAdapter<UiNodeAttributes>() {
                @Override
                public void write(JsonWriter out, UiNodeAttributes value) throws IOException {
                    if (value == null || value.getActualInstance() == null) {
                        elementAdapter.write(out, null);
                        return;
                    }

                    // check if the actual instance is of the type `UiNodeInputAttributes`
                    if (value.getActualInstance() instanceof UiNodeInputAttributes) {
                        JsonElement element = adapterUiNodeInputAttributes.toJsonTree((UiNodeInputAttributes)value.getActualInstance());
                        elementAdapter.write(out, element);
                        return;
                    }
                    // check if the actual instance is of the type `UiNodeTextAttributes`
                    if (value.getActualInstance() instanceof UiNodeTextAttributes) {
                        JsonElement element = adapterUiNodeTextAttributes.toJsonTree((UiNodeTextAttributes)value.getActualInstance());
                        elementAdapter.write(out, element);
                        return;
                    }
                    // check if the actual instance is of the type `UiNodeImageAttributes`
                    if (value.getActualInstance() instanceof UiNodeImageAttributes) {
                        JsonElement element = adapterUiNodeImageAttributes.toJsonTree((UiNodeImageAttributes)value.getActualInstance());
                        elementAdapter.write(out, element);
                        return;
                    }
                    // check if the actual instance is of the type `UiNodeAnchorAttributes`
                    if (value.getActualInstance() instanceof UiNodeAnchorAttributes) {
                        JsonElement element = adapterUiNodeAnchorAttributes.toJsonTree((UiNodeAnchorAttributes)value.getActualInstance());
                        elementAdapter.write(out, element);
                        return;
                    }
                    // check if the actual instance is of the type `UiNodeScriptAttributes`
                    if (value.getActualInstance() instanceof UiNodeScriptAttributes) {
                        JsonElement element = adapterUiNodeScriptAttributes.toJsonTree((UiNodeScriptAttributes)value.getActualInstance());
                        elementAdapter.write(out, element);
                        return;
                    }
                    throw new IOException("Failed to serialize as the type doesn't match oneOf schemas: UiNodeAnchorAttributes, UiNodeImageAttributes, UiNodeInputAttributes, UiNodeScriptAttributes, UiNodeTextAttributes");
                }

                @Override
                public UiNodeAttributes read(JsonReader in) throws IOException {
                    Object deserialized = null;
                    JsonElement jsonElement = elementAdapter.read(in);

                    JsonObject jsonObject = jsonElement.getAsJsonObject();

                    // use discriminator value for faster oneOf lookup
                    UiNodeAttributes newUiNodeAttributes = new UiNodeAttributes();
                    if (jsonObject.get("node_type") == null) {
                        log.log(Level.WARNING, "Failed to lookup discriminator value for UiNodeAttributes as `node_type` was not found in the payload or the payload is empty.");
                    } else  {
                        // look up the discriminator value in the field `node_type`
                        switch (jsonObject.get("node_type").getAsString()) {
                            case "a":
                                deserialized = adapterUiNodeAnchorAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "img":
                                deserialized = adapterUiNodeImageAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "input":
                                deserialized = adapterUiNodeInputAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "script":
                                deserialized = adapterUiNodeScriptAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "text":
                                deserialized = adapterUiNodeTextAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "uiNodeAnchorAttributes":
                                deserialized = adapterUiNodeAnchorAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "uiNodeImageAttributes":
                                deserialized = adapterUiNodeImageAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "uiNodeInputAttributes":
                                deserialized = adapterUiNodeInputAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "uiNodeScriptAttributes":
                                deserialized = adapterUiNodeScriptAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            case "uiNodeTextAttributes":
                                deserialized = adapterUiNodeTextAttributes.fromJsonTree(jsonObject);
                                newUiNodeAttributes.setActualInstance(deserialized);
                                return newUiNodeAttributes;
                            default:
                                log.log(Level.WARNING, String.format("Failed to lookup discriminator value `%s` for UiNodeAttributes. Possible values: a img input script text uiNodeAnchorAttributes uiNodeImageAttributes uiNodeInputAttributes uiNodeScriptAttributes uiNodeTextAttributes", jsonObject.get("node_type").getAsString()));
                        }
                    }

                    int match = 0;
                    ArrayList<String> errorMessages = new ArrayList<>();
                    TypeAdapter actualAdapter = elementAdapter;

                    // deserialize UiNodeInputAttributes
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UiNodeInputAttributes.validateJsonElement(jsonElement);
                        actualAdapter = adapterUiNodeInputAttributes;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UiNodeInputAttributes'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UiNodeInputAttributes failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UiNodeInputAttributes'", e);
                    }
                    // deserialize UiNodeTextAttributes
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UiNodeTextAttributes.validateJsonElement(jsonElement);
                        actualAdapter = adapterUiNodeTextAttributes;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UiNodeTextAttributes'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UiNodeTextAttributes failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UiNodeTextAttributes'", e);
                    }
                    // deserialize UiNodeImageAttributes
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UiNodeImageAttributes.validateJsonElement(jsonElement);
                        actualAdapter = adapterUiNodeImageAttributes;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UiNodeImageAttributes'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UiNodeImageAttributes failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UiNodeImageAttributes'", e);
                    }
                    // deserialize UiNodeAnchorAttributes
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UiNodeAnchorAttributes.validateJsonElement(jsonElement);
                        actualAdapter = adapterUiNodeAnchorAttributes;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UiNodeAnchorAttributes'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UiNodeAnchorAttributes failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UiNodeAnchorAttributes'", e);
                    }
                    // deserialize UiNodeScriptAttributes
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UiNodeScriptAttributes.validateJsonElement(jsonElement);
                        actualAdapter = adapterUiNodeScriptAttributes;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UiNodeScriptAttributes'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UiNodeScriptAttributes failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UiNodeScriptAttributes'", e);
                    }

                    if (match == 1) {
                        UiNodeAttributes ret = new UiNodeAttributes();
                        ret.setActualInstance(actualAdapter.fromJsonTree(jsonElement));
                        return ret;
                    }

                    throw new IOException(String.format("Failed deserialization for UiNodeAttributes: %d classes match result, expected 1. Detailed failure message for oneOf schemas: %s. JSON: %s", match, errorMessages, jsonElement.toString()));
                }
            }.nullSafe();
        }
    }

    // store a list of schema names defined in oneOf
    public static final Map<String, Class<?>> schemas = new HashMap<String, Class<?>>();

    public UiNodeAttributes() {
        super("oneOf", Boolean.FALSE);
    }

    public UiNodeAttributes(Object o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    static {
        schemas.put("UiNodeInputAttributes", UiNodeInputAttributes.class);
        schemas.put("UiNodeTextAttributes", UiNodeTextAttributes.class);
        schemas.put("UiNodeImageAttributes", UiNodeImageAttributes.class);
        schemas.put("UiNodeAnchorAttributes", UiNodeAnchorAttributes.class);
        schemas.put("UiNodeScriptAttributes", UiNodeScriptAttributes.class);
    }

    @Override
    public Map<String, Class<?>> getSchemas() {
        return UiNodeAttributes.schemas;
    }

    /**
     * Set the instance that matches the oneOf child schema, check
     * the instance parameter is valid against the oneOf child schemas:
     * UiNodeAnchorAttributes, UiNodeImageAttributes, UiNodeInputAttributes, UiNodeScriptAttributes, UiNodeTextAttributes
     *
     * It could be an instance of the 'oneOf' schemas.
     */
    @Override
    public void setActualInstance(Object instance) {
        if (instance instanceof UiNodeInputAttributes) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof UiNodeTextAttributes) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof UiNodeImageAttributes) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof UiNodeAnchorAttributes) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof UiNodeScriptAttributes) {
            super.setActualInstance(instance);
            return;
        }

        throw new RuntimeException("Invalid instance type. Must be UiNodeAnchorAttributes, UiNodeImageAttributes, UiNodeInputAttributes, UiNodeScriptAttributes, UiNodeTextAttributes");
    }

    /**
     * Get the actual instance, which can be the following:
     * UiNodeAnchorAttributes, UiNodeImageAttributes, UiNodeInputAttributes, UiNodeScriptAttributes, UiNodeTextAttributes
     *
     * @return The actual instance (UiNodeAnchorAttributes, UiNodeImageAttributes, UiNodeInputAttributes, UiNodeScriptAttributes, UiNodeTextAttributes)
     */
    @SuppressWarnings("unchecked")
    @Override
    public Object getActualInstance() {
        return super.getActualInstance();
    }

    /**
     * Get the actual instance of `UiNodeInputAttributes`. If the actual instance is not `UiNodeInputAttributes`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UiNodeInputAttributes`
     * @throws ClassCastException if the instance is not `UiNodeInputAttributes`
     */
    public UiNodeInputAttributes getUiNodeInputAttributes() throws ClassCastException {
        return (UiNodeInputAttributes)super.getActualInstance();
    }
    /**
     * Get the actual instance of `UiNodeTextAttributes`. If the actual instance is not `UiNodeTextAttributes`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UiNodeTextAttributes`
     * @throws ClassCastException if the instance is not `UiNodeTextAttributes`
     */
    public UiNodeTextAttributes getUiNodeTextAttributes() throws ClassCastException {
        return (UiNodeTextAttributes)super.getActualInstance();
    }
    /**
     * Get the actual instance of `UiNodeImageAttributes`. If the actual instance is not `UiNodeImageAttributes`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UiNodeImageAttributes`
     * @throws ClassCastException if the instance is not `UiNodeImageAttributes`
     */
    public UiNodeImageAttributes getUiNodeImageAttributes() throws ClassCastException {
        return (UiNodeImageAttributes)super.getActualInstance();
    }
    /**
     * Get the actual instance of `UiNodeAnchorAttributes`. If the actual instance is not `UiNodeAnchorAttributes`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UiNodeAnchorAttributes`
     * @throws ClassCastException if the instance is not `UiNodeAnchorAttributes`
     */
    public UiNodeAnchorAttributes getUiNodeAnchorAttributes() throws ClassCastException {
        return (UiNodeAnchorAttributes)super.getActualInstance();
    }
    /**
     * Get the actual instance of `UiNodeScriptAttributes`. If the actual instance is not `UiNodeScriptAttributes`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UiNodeScriptAttributes`
     * @throws ClassCastException if the instance is not `UiNodeScriptAttributes`
     */
    public UiNodeScriptAttributes getUiNodeScriptAttributes() throws ClassCastException {
        return (UiNodeScriptAttributes)super.getActualInstance();
    }

    /**
     * Validates the JSON Element and throws an exception if issues found
     *
     * @param jsonElement JSON Element
     * @throws IOException if the JSON Element is invalid with respect to UiNodeAttributes
     */
    public static void validateJsonElement(JsonElement jsonElement) throws IOException {
        // validate oneOf schemas one by one
        int validCount = 0;
        ArrayList<String> errorMessages = new ArrayList<>();
        // validate the json string with UiNodeInputAttributes
        try {
            UiNodeInputAttributes.validateJsonElement(jsonElement);
            validCount++;
        } catch (Exception e) {
            errorMessages.add(String.format("Deserialization for UiNodeInputAttributes failed with `%s`.", e.getMessage()));
            // continue to the next one
        }
        // validate the json string with UiNodeTextAttributes
        try {
            UiNodeTextAttributes.validateJsonElement(jsonElement);
            validCount++;
        } catch (Exception e) {
            errorMessages.add(String.format("Deserialization for UiNodeTextAttributes failed with `%s`.", e.getMessage()));
            // continue to the next one
        }
        // validate the json string with UiNodeImageAttributes
        try {
            UiNodeImageAttributes.validateJsonElement(jsonElement);
            validCount++;
        } catch (Exception e) {
            errorMessages.add(String.format("Deserialization for UiNodeImageAttributes failed with `%s`.", e.getMessage()));
            // continue to the next one
        }
        // validate the json string with UiNodeAnchorAttributes
        try {
            UiNodeAnchorAttributes.validateJsonElement(jsonElement);
            validCount++;
        } catch (Exception e) {
            errorMessages.add(String.format("Deserialization for UiNodeAnchorAttributes failed with `%s`.", e.getMessage()));
            // continue to the next one
        }
        // validate the json string with UiNodeScriptAttributes
        try {
            UiNodeScriptAttributes.validateJsonElement(jsonElement);
            validCount++;
        } catch (Exception e) {
            errorMessages.add(String.format("Deserialization for UiNodeScriptAttributes failed with `%s`.", e.getMessage()));
            // continue to the next one
        }
        if (validCount != 1) {
            throw new IOException(String.format("The JSON string is invalid for UiNodeAttributes with oneOf schemas: UiNodeAnchorAttributes, UiNodeImageAttributes, UiNodeInputAttributes, UiNodeScriptAttributes, UiNodeTextAttributes. %d class(es) match the result, expected 1. Detailed failure message for oneOf schemas: %s. JSON: %s", validCount, errorMessages, jsonElement.toString()));
        }
    }

    /**
     * Create an instance of UiNodeAttributes given an JSON string
     *
     * @param jsonString JSON string
     * @return An instance of UiNodeAttributes
     * @throws IOException if the JSON string is invalid with respect to UiNodeAttributes
     */
    public static UiNodeAttributes fromJson(String jsonString) throws IOException {
        return JSON.getGson().fromJson(jsonString, UiNodeAttributes.class);
    }

    /**
     * Convert an instance of UiNodeAttributes to an JSON string
     *
     * @return JSON string
     */
    public String toJson() {
        return JSON.getGson().toJson(this);
    }
}

