# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.DeleteMySessionsCount do
  @moduledoc """
  Deleted Session Count
  """

  @derive Jason.Encoder
  defstruct [
    :count
  ]

  @type t :: %__MODULE__{
    :count => integer() | nil
  }

  def decode(value) do
    value
  end
end

