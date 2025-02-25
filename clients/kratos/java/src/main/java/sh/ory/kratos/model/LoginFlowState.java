/*
 * Ory Identities API
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.3.6-alpha.1
 * Contact: office@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.kratos.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.JsonElement;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * The experimental state represents the state of a login flow. This field is EXPERIMENTAL and subject to change!
 */
@JsonAdapter(LoginFlowState.Adapter.class)
public enum LoginFlowState {
  
  CHOOSE_METHOD("choose_method"),
  
  SENT_EMAIL("sent_email"),
  
  PASSED_CHALLENGE("passed_challenge");

  private String value;

  LoginFlowState(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static LoginFlowState fromValue(String value) {
    for (LoginFlowState b : LoginFlowState.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<LoginFlowState> {
    @Override
    public void write(final JsonWriter jsonWriter, final LoginFlowState enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public LoginFlowState read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return LoginFlowState.fromValue(value);
    }
  }

  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
    String value = jsonElement.getAsString();
    LoginFlowState.fromValue(value);
  }
}

