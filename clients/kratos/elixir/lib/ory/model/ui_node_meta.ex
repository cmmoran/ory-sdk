# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UiNodeMeta do
  @moduledoc """
  This might include a label and other information that can optionally be used to render UIs.
  """

  @derive Jason.Encoder
  defstruct [
    :label
  ]

  @type t :: %__MODULE__{
    :label => Ory.Model.UiText.t | nil
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:label, :struct, Ory.Model.UiText)
  end
end

