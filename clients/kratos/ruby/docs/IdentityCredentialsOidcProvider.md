# OryKratosClient::IdentityCredentialsOidcProvider

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **initial_access_token** | **String** |  | [optional] |
| **initial_id_token** | **String** |  | [optional] |
| **initial_refresh_token** | **String** |  | [optional] |
| **organization** | **String** |  | [optional] |
| **provider** | **String** |  | [optional] |
| **subject** | **String** |  | [optional] |
| **use_auto_link** | **Boolean** |  | [optional] |

## Example

```ruby
require 'ory-kratos-client'

instance = OryKratosClient::IdentityCredentialsOidcProvider.new(
  initial_access_token: null,
  initial_id_token: null,
  initial_refresh_token: null,
  organization: null,
  provider: null,
  subject: null,
  use_auto_link: null
)
```

