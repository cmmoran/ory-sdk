# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.ConsistencyRequestParameters do
  @moduledoc """
  Control API consistency guarantees
  """

  @derive Jason.Encoder
  defstruct [
    :consistency
  ]

  @type t :: %__MODULE__{
    :consistency => String.t | nil
  }

  def decode(value) do
    value
  end
end

