# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateLoginFlowWithWebAuthnMethod do
  @moduledoc """
  Update Login Flow with WebAuthn Method
  """

  @derive Jason.Encoder
  defstruct [
    :csrf_token,
    :identifier,
    :method,
    :transient_payload,
    :webauthn_login
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :identifier => String.t,
    :method => String.t,
    :transient_payload => map() | nil,
    :webauthn_login => String.t | nil
  }

  def decode(value) do
    value
  end
end

