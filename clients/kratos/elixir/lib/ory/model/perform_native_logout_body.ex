# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.PerformNativeLogoutBody do
  @moduledoc """
  Perform Native Logout Request Body
  """

  @derive Jason.Encoder
  defstruct [
    :session_token
  ]

  @type t :: %__MODULE__{
    :session_token => String.t
  }

  def decode(value) do
    value
  end
end

