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
import java.time.OffsetDateTime;
import java.util.UUID;
import sh.ory.model.SelfServiceVerificationFlowState;
import sh.ory.model.UiContainer;

/**
 * Used to verify an out-of-band communication channel such as an email address or a phone number.  For more information head over to: https://www.ory.sh/docs/kratos/selfservice/flows/verify-email-account-activation
 */
@ApiModel(description = "Used to verify an out-of-band communication channel such as an email address or a phone number.  For more information head over to: https://www.ory.sh/docs/kratos/selfservice/flows/verify-email-account-activation")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-03-18T14:07:53.269111298Z[Etc/UTC]")
public class SelfServiceVerificationFlow {
  public static final String SERIALIZED_NAME_ACTIVE = "active";
  @SerializedName(SERIALIZED_NAME_ACTIVE)
  private String active;

  public static final String SERIALIZED_NAME_EXPIRES_AT = "expires_at";
  @SerializedName(SERIALIZED_NAME_EXPIRES_AT)
  private OffsetDateTime expiresAt;

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private UUID id;

  public static final String SERIALIZED_NAME_ISSUED_AT = "issued_at";
  @SerializedName(SERIALIZED_NAME_ISSUED_AT)
  private OffsetDateTime issuedAt;

  public static final String SERIALIZED_NAME_REQUEST_URL = "request_url";
  @SerializedName(SERIALIZED_NAME_REQUEST_URL)
  private String requestUrl;

  public static final String SERIALIZED_NAME_RETURN_TO = "return_to";
  @SerializedName(SERIALIZED_NAME_RETURN_TO)
  private String returnTo;

  public static final String SERIALIZED_NAME_STATE = "state";
  @SerializedName(SERIALIZED_NAME_STATE)
  private SelfServiceVerificationFlowState state;

  public static final String SERIALIZED_NAME_TYPE = "type";
  @SerializedName(SERIALIZED_NAME_TYPE)
  private String type;

  public static final String SERIALIZED_NAME_UI = "ui";
  @SerializedName(SERIALIZED_NAME_UI)
  private UiContainer ui;

  public SelfServiceVerificationFlow() { 
  }

  public SelfServiceVerificationFlow active(String active) {
    
    this.active = active;
    return this;
  }

   /**
   * Active, if set, contains the registration method that is being used. It is initially not set.
   * @return active
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Active, if set, contains the registration method that is being used. It is initially not set.")

  public String getActive() {
    return active;
  }


  public void setActive(String active) {
    this.active = active;
  }


  public SelfServiceVerificationFlow expiresAt(OffsetDateTime expiresAt) {
    
    this.expiresAt = expiresAt;
    return this;
  }

   /**
   * ExpiresAt is the time (UTC) when the request expires. If the user still wishes to verify the address, a new request has to be initiated.
   * @return expiresAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "ExpiresAt is the time (UTC) when the request expires. If the user still wishes to verify the address, a new request has to be initiated.")

  public OffsetDateTime getExpiresAt() {
    return expiresAt;
  }


  public void setExpiresAt(OffsetDateTime expiresAt) {
    this.expiresAt = expiresAt;
  }


  public SelfServiceVerificationFlow id(UUID id) {
    
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public UUID getId() {
    return id;
  }


  public void setId(UUID id) {
    this.id = id;
  }


  public SelfServiceVerificationFlow issuedAt(OffsetDateTime issuedAt) {
    
    this.issuedAt = issuedAt;
    return this;
  }

   /**
   * IssuedAt is the time (UTC) when the request occurred.
   * @return issuedAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "IssuedAt is the time (UTC) when the request occurred.")

  public OffsetDateTime getIssuedAt() {
    return issuedAt;
  }


  public void setIssuedAt(OffsetDateTime issuedAt) {
    this.issuedAt = issuedAt;
  }


  public SelfServiceVerificationFlow requestUrl(String requestUrl) {
    
    this.requestUrl = requestUrl;
    return this;
  }

   /**
   * RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.
   * @return requestUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL's path or query for example.")

  public String getRequestUrl() {
    return requestUrl;
  }


  public void setRequestUrl(String requestUrl) {
    this.requestUrl = requestUrl;
  }


  public SelfServiceVerificationFlow returnTo(String returnTo) {
    
    this.returnTo = returnTo;
    return this;
  }

   /**
   * ReturnTo contains the requested return_to URL.
   * @return returnTo
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "ReturnTo contains the requested return_to URL.")

  public String getReturnTo() {
    return returnTo;
  }


  public void setReturnTo(String returnTo) {
    this.returnTo = returnTo;
  }


  public SelfServiceVerificationFlow state(SelfServiceVerificationFlowState state) {
    
    this.state = state;
    return this;
  }

   /**
   * Get state
   * @return state
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public SelfServiceVerificationFlowState getState() {
    return state;
  }


  public void setState(SelfServiceVerificationFlowState state) {
    this.state = state;
  }


  public SelfServiceVerificationFlow type(String type) {
    
    this.type = type;
    return this;
  }

   /**
   * The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.
   * @return type
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The flow type can either be `api` or `browser`.")

  public String getType() {
    return type;
  }


  public void setType(String type) {
    this.type = type;
  }


  public SelfServiceVerificationFlow ui(UiContainer ui) {
    
    this.ui = ui;
    return this;
  }

   /**
   * Get ui
   * @return ui
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public UiContainer getUi() {
    return ui;
  }


  public void setUi(UiContainer ui) {
    this.ui = ui;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SelfServiceVerificationFlow selfServiceVerificationFlow = (SelfServiceVerificationFlow) o;
    return Objects.equals(this.active, selfServiceVerificationFlow.active) &&
        Objects.equals(this.expiresAt, selfServiceVerificationFlow.expiresAt) &&
        Objects.equals(this.id, selfServiceVerificationFlow.id) &&
        Objects.equals(this.issuedAt, selfServiceVerificationFlow.issuedAt) &&
        Objects.equals(this.requestUrl, selfServiceVerificationFlow.requestUrl) &&
        Objects.equals(this.returnTo, selfServiceVerificationFlow.returnTo) &&
        Objects.equals(this.state, selfServiceVerificationFlow.state) &&
        Objects.equals(this.type, selfServiceVerificationFlow.type) &&
        Objects.equals(this.ui, selfServiceVerificationFlow.ui);
  }

  @Override
  public int hashCode() {
    return Objects.hash(active, expiresAt, id, issuedAt, requestUrl, returnTo, state, type, ui);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SelfServiceVerificationFlow {\n");
    sb.append("    active: ").append(toIndentedString(active)).append("\n");
    sb.append("    expiresAt: ").append(toIndentedString(expiresAt)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    issuedAt: ").append(toIndentedString(issuedAt)).append("\n");
    sb.append("    requestUrl: ").append(toIndentedString(requestUrl)).append("\n");
    sb.append("    returnTo: ").append(toIndentedString(returnTo)).append("\n");
    sb.append("    state: ").append(toIndentedString(state)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    ui: ").append(toIndentedString(ui)).append("\n");
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

