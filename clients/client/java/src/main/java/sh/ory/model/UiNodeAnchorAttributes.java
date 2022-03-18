/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.133
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
import sh.ory.model.UiText;

/**
 * UiNodeAnchorAttributes
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-03-18T14:07:53.269111298Z[Etc/UTC]")
public class UiNodeAnchorAttributes {
  public static final String SERIALIZED_NAME_HREF = "href";
  @SerializedName(SERIALIZED_NAME_HREF)
  private String href;

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_NODE_TYPE = "node_type";
  @SerializedName(SERIALIZED_NAME_NODE_TYPE)
  private String nodeType;

  public static final String SERIALIZED_NAME_TITLE = "title";
  @SerializedName(SERIALIZED_NAME_TITLE)
  private UiText title;

  public UiNodeAnchorAttributes() { 
  }

  public UiNodeAnchorAttributes href(String href) {
    
    this.href = href;
    return this;
  }

   /**
   * The link&#39;s href (destination) URL.  format: uri
   * @return href
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The link's href (destination) URL.  format: uri")

  public String getHref() {
    return href;
  }


  public void setHref(String href) {
    this.href = href;
  }


  public UiNodeAnchorAttributes id(String id) {
    
    this.id = id;
    return this;
  }

   /**
   * A unique identifier
   * @return id
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "A unique identifier")

  public String getId() {
    return id;
  }


  public void setId(String id) {
    this.id = id;
  }


  public UiNodeAnchorAttributes nodeType(String nodeType) {
    
    this.nodeType = nodeType;
    return this;
  }

   /**
   * Get nodeType
   * @return nodeType
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public String getNodeType() {
    return nodeType;
  }


  public void setNodeType(String nodeType) {
    this.nodeType = nodeType;
  }


  public UiNodeAnchorAttributes title(UiText title) {
    
    this.title = title;
    return this;
  }

   /**
   * Get title
   * @return title
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public UiText getTitle() {
    return title;
  }


  public void setTitle(UiText title) {
    this.title = title;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UiNodeAnchorAttributes uiNodeAnchorAttributes = (UiNodeAnchorAttributes) o;
    return Objects.equals(this.href, uiNodeAnchorAttributes.href) &&
        Objects.equals(this.id, uiNodeAnchorAttributes.id) &&
        Objects.equals(this.nodeType, uiNodeAnchorAttributes.nodeType) &&
        Objects.equals(this.title, uiNodeAnchorAttributes.title);
  }

  @Override
  public int hashCode() {
    return Objects.hash(href, id, nodeType, title);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UiNodeAnchorAttributes {\n");
    sb.append("    href: ").append(toIndentedString(href)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    nodeType: ").append(toIndentedString(nodeType)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
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

