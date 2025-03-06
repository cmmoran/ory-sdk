# NOTE: This file is auto generated by OpenAPI Generator 7.12.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UiNodeInputAttributes do
  @moduledoc """
  InputAttributes represents the attributes of an input node
  """

  @derive Jason.Encoder
  defstruct [
    :autocomplete,
    :disabled,
    :label,
    :maxlength,
    :name,
    :node_type,
    :onclick,
    :onclickTrigger,
    :onload,
    :onloadTrigger,
    :pattern,
    :required,
    :type,
    :value
  ]

  @type t :: %__MODULE__{
    :autocomplete => String.t | nil,
    :disabled => boolean(),
    :label => Ory.Model.UiText.t | nil,
    :maxlength => integer() | nil,
    :name => String.t,
    :node_type => String.t,
    :onclick => String.t | nil,
    :onclickTrigger => String.t | nil,
    :onload => String.t | nil,
    :onloadTrigger => String.t | nil,
    :pattern => String.t | nil,
    :required => boolean() | nil,
    :type => String.t,
    :value => any() | nil
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:label, :struct, Ory.Model.UiText)
  end
end

