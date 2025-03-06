# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateSettingsFlowWithOidcMethod do
  @moduledoc """
  Update Settings Flow with OpenID Connect Method
  """

  @derive Jason.Encoder
  defstruct [
    :flow,
    :link,
    :method,
    :traits,
    :transient_payload,
    :unlink,
    :upstream_parameters
  ]

  @type t :: %__MODULE__{
    :flow => String.t | nil,
    :link => String.t | nil,
    :method => String.t,
    :traits => map() | nil,
    :transient_payload => map() | nil,
    :unlink => String.t | nil,
    :upstream_parameters => map() | nil
  }

  def decode(value) do
    value
  end
end

