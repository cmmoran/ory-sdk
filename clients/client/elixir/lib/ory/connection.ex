# NOTE: This file is auto generated by OpenAPI Generator 7.7.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Connection do
  @moduledoc """
  Handle Tesla connections for Ory.

  Additional middleware can be set in the compile-time or runtime configuration:

      config :tesla, Ory.Connection,
        base_url: "https://playground.projects.oryapis.com",
        adapter: Tesla.Adapter.Hackney

  The default base URL can also be set as:

      config :ory_client,
        :base_url, "https://playground.projects.oryapis.com"
  """

  @default_base_url Application.compile_env(
                      :ory_client,
                      :base_url,
                      "https://playground.projects.oryapis.com"
                    )

  @default_scopes [
    # A scope required when requesting refresh tokens (alias for &#x60;offline_access&#x60;)
    "offline",
    # A scope required when requesting refresh tokens
    "offline_access",
    # Request an OpenID Connect ID Token
    "openid"
  ]

  @typedoc """
  An arity-1 function or module/function tuple specification which, given
  a list of scopes, obtains an OAuth2 token.
  """
  @type token_fetcher :: (scopes :: list(String.t()) -> String.t()) | {module(), atom()}

  @typedoc """
  The list of options that can be passed to new/1.

  - `base_url`: Overrides the base URL on a per-client basis.
  - `user_agent`: Overrides the User-Agent header.
  - `token`: An OAuth2 token or a token fetcher function.
  - `token_scopes`: A list of OAuth2 scope strings for use with a token
    fetcher function.
  - `username`: A username for basic authentication.
  - `password`: A password for basic authentication.
  """
  @type options :: [
          {:base_url, String.t()},
          {:user_agent, String.t()},
          {:token, String.t() | token_fetcher},
          {:token_scopes, list(String.t())},
          {:username, String.t() | nil},
          {:password, String.t() | nil},
        ]

  @doc "Forward requests to Tesla."
  @spec request(Tesla.Client.t(), [Tesla.option()]) :: Tesla.Env.result()
  defdelegate request(client, options), to: Tesla

  @doc """
  Configure a client with no authentication.

  ### Returns

  Tesla.Env.client
  """
  @spec new() :: Tesla.Env.client()
  def new do
    Tesla.client(middleware(), adapter())
  end

  @doc """
  Configure a client that may have authentication.

  ### Parameters

  The first parameter *may* be a `token` (a string, a token fetcher class,
  or a module/function tuple) or a keyword list of `options`. They are
  documented separately, but only *one* of them will be passed.

  - `token`: a String or a function of arity one. This value, or the result
    of the function call, will be set as a bearer token in the
    `authorization` header.
  - `options`: a keyword list of OpenAPIPetstore.Connection.options.

  ### Returns

  Tesla.Env.client
  """
  @spec new(String.t() | token_fetcher | options) :: Tesla.Env.client()
  def new(token) when is_binary(token) or is_function(token, 1) or is_tuple(token) do
    new(token: token)
  end

  def new(options) when is_list(options) do
    options
    |> middleware()
    |> Tesla.client(adapter())
  end

  @doc """
  Configure a client using bearer authentication with scopes, or with
  username and password for basic authentication.

  ### Parameters

  - `token_or_username`: a String representing a bearer token or a username,
    depending on the type of the next parameter, or a function arity one
    that returns a bearer token.
  - `scopes_or_password`: a list of Strings represenging OAuth2 scopes, or
    a single string that is the password for the username provided.
  - `options`: a keyword list of OpenAPIPetstore.Connection.options.

  ### Returns

  Tesla.Env.client
  """
  @spec new(
          token_or_username :: String.t() | token_fetcher,
          scopes_or_password :: list(String.t()) | String.t(),
          options
        ) :: Tesla.Env.client()

  def new(token_or_username, scopes_or_password, options \\ [])

  def new(token, scopes, options)
      when (is_binary(token) or is_function(token, 1) or is_tuple(token)) and is_list(scopes) do
    options
    |> Keyword.merge(token: token, token_scopes: scopes)
    |> new()
  end

  def new(username, password, options) when is_binary(username) and is_binary(password) do
    options
    |> Keyword.merge(username: username, password: password)
    |> new()
  end

  @doc """
  Returns fully configured middleware for passing to Tesla.client/2.
  """
  @spec middleware(options) :: [Tesla.Client.middleware()]
  def middleware(options \\ []) do
    base_url =
      Keyword.get(
        options,
        :base_url,
        Application.get_env(:ory_client, :base_url, @default_base_url)
      )

    tesla_options = Application.get_env(:tesla, __MODULE__, [])
    middleware = Keyword.get(tesla_options, :middleware, [])
    json_engine = Keyword.get(tesla_options, :json, Jason)

    user_agent =
      Keyword.get(
        options,
        :user_agent,
        Keyword.get(
          tesla_options,
          :user_agent,
          "openapi-generator - Ory v1.16.8 - elixir"
        )
      )

    username = Keyword.get(options, :username)
    password = Keyword.get(options, :password)
    middleware =
      if username || password do
        [{Tesla.Middleware.BasicAuth, %{username: username, password: password}} | middleware]
      else
        middleware
      end

    middleware =
      if token = Keyword.get(options, :token) do
        scopes = Keyword.get(options, :token_scopes, @default_scopes)
        [authorization(token, scopes) | middleware]
      else
        middleware
      end

    [
      {Tesla.Middleware.BaseUrl, base_url},
      {Tesla.Middleware.Headers, [{"user-agent", user_agent}]},
      {Tesla.Middleware.EncodeJson, engine: json_engine}
      | middleware
    ]
  end

  @doc """
  Returns an authentication middleware tuple for a Tesla client that sets
  the `authorization` header to the value of the provided bearer token. If
  the token is provided as a function of arity one, it will be called with
  a list of requested scopes that will obtain an OAuth2 token.

  ### Parameters

  - `token`: a String or a function of arity one. This value, or the result
    of the function call, will be set as a bearer token in the
    `authorization` header.

  - `scopes`: an optional list of scopes for use with the token fetcher
    function. Ignored when `token` is provided as a String. Defaults to
    `#{inspect(@default_scopes)}`.

  ### Returns

  `{Tesla.Middleware.Headers, [{"authorization", TOKEN}]}`
  """
  @spec authorization(String.t() | token_fetcher, list(String.t())) ::
          Tesla.Client.middleware()
  def authorization(token, scopes \\ @default_scopes)

  def authorization(token, _scopes) when is_binary(token) do
    {Tesla.Middleware.Headers, [{"authorization", token}]}
  end

  def authorization({module, function}, scopes) when is_atom(module) and is_atom(function) do
    apply(module, function, [scopes])
  end

  def authorization(token_fetcher, scopes) when is_function(token_fetcher, 1) do
    authorization(token_fetcher.(scopes))
  end

  @doc """
  Returns the default adapter for this API.
  """
  def adapter do
    :tesla
    |> Application.get_env(__MODULE__, [])
    |> Keyword.get(:adapter, nil)
  end
end
