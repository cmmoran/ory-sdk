# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateLoginFlowWithCodeMethod do
  @moduledoc """
  Update Login flow using the code method
  """

  @derive Jason.Encoder
  defstruct [
    :address,
    :code,
    :csrf_token,
    :identifier,
    :method,
    :resend,
    :transient_payload,
    :trust_device
  ]

  @type t :: %__MODULE__{
    :address => String.t | nil,
    :code => String.t | nil,
    :csrf_token => String.t,
    :identifier => String.t | nil,
    :method => String.t,
    :resend => String.t | nil,
    :transient_payload => map() | nil,
    :trust_device => boolean() | nil
  }

  def decode(value) do
    value
  end
end

