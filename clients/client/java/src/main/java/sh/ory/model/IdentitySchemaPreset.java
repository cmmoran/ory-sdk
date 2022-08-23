/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.16
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * IdentitySchemaPreset
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-08-23T16:56:02.881567578Z[Etc/UTC]")
public class IdentitySchemaPreset {
  public static final String SERIALIZED_NAME_SCHEMA = "schema";
  @SerializedName(SERIALIZED_NAME_SCHEMA)
  private Object schema;

  public static final String SERIALIZED_NAME_URL = "url";
  @SerializedName(SERIALIZED_NAME_URL)
  private String url;

  public IdentitySchemaPreset() { 
  }

  public IdentitySchemaPreset schema(Object schema) {
    
    this.schema = schema;
    return this;
  }

   /**
   * Schema is the Identity JSON Schema
   * @return schema
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Schema is the Identity JSON Schema")

  public Object getSchema() {
    return schema;
  }


  public void setSchema(Object schema) {
    this.schema = schema;
  }


  public IdentitySchemaPreset url(String url) {
    
    this.url = url;
    return this;
  }

   /**
   * URL is the preset identifier
   * @return url
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "URL is the preset identifier")

  public String getUrl() {
    return url;
  }


  public void setUrl(String url) {
    this.url = url;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    IdentitySchemaPreset identitySchemaPreset = (IdentitySchemaPreset) o;
    return Objects.equals(this.schema, identitySchemaPreset.schema) &&
        Objects.equals(this.url, identitySchemaPreset.url);
  }

  @Override
  public int hashCode() {
    return Objects.hash(schema, url);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class IdentitySchemaPreset {\n");
    sb.append("    schema: ").append(toIndentedString(schema)).append("\n");
    sb.append("    url: ").append(toIndentedString(url)).append("\n");
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

}

