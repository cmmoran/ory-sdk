# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateVerificationFlowWithLinkMethod do
  @moduledoc """
  Update Verification Flow with Link Method
  """

  @derive Jason.Encoder
  defstruct [
    :csrf_token,
    :email,
    :method,
    :transient_payload
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :email => String.t,
    :method => String.t,
    :transient_payload => map() | nil
  }

  def decode(value) do
    value
  end
end

