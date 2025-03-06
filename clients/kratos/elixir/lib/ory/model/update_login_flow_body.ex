# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateLoginFlowBody do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :csrf_token,
    :identifier,
    :method,
    :password,
    :password_identifier,
    :transient_payload,
    :id_token,
    :id_token_nonce,
    :provider,
    :traits,
    :upstream_parameters,
    :totp_code,
    :trust_device,
    :webauthn_login,
    :lookup_secret,
    :address,
    :code,
    :resend,
    :passkey_login
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t,
    :identifier => String.t,
    :method => String.t,
    :password => String.t,
    :password_identifier => String.t | nil,
    :transient_payload => map() | nil,
    :id_token => String.t | nil,
    :id_token_nonce => String.t | nil,
    :provider => String.t,
    :traits => map() | nil,
    :upstream_parameters => map() | nil,
    :totp_code => String.t,
    :trust_device => boolean() | nil,
    :webauthn_login => String.t | nil,
    :lookup_secret => String.t,
    :address => String.t | nil,
    :code => String.t | nil,
    :resend => String.t | nil,
    :passkey_login => String.t | nil
  }

  def decode(value) do
    value
  end
end

