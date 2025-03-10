# SessionAuthenticationMethod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aal** | Pointer to [**AuthenticatorAssuranceLevel**](AuthenticatorAssuranceLevel.md) |  | [optional] 
**CompletedAt** | Pointer to **time.Time** | When the authentication challenge was completed. | [optional] 
**DeviceTrustBased** | Pointer to **bool** | DeviceTrustBased indicates that this authentication method was added due to device trust | [optional] 
**Method** | Pointer to **string** |  | [optional] 
**Organization** | Pointer to **string** | The Organization id used for authentication | [optional] 
**Provider** | Pointer to **string** | OIDC or SAML provider id used for authentication | [optional] 

## Methods

### NewSessionAuthenticationMethod

`func NewSessionAuthenticationMethod() *SessionAuthenticationMethod`

NewSessionAuthenticationMethod instantiates a new SessionAuthenticationMethod object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSessionAuthenticationMethodWithDefaults

`func NewSessionAuthenticationMethodWithDefaults() *SessionAuthenticationMethod`

NewSessionAuthenticationMethodWithDefaults instantiates a new SessionAuthenticationMethod object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetAal

`func (o *SessionAuthenticationMethod) GetAal() AuthenticatorAssuranceLevel`

GetAal returns the Aal field if non-nil, zero value otherwise.

### GetAalOk

`func (o *SessionAuthenticationMethod) GetAalOk() (*AuthenticatorAssuranceLevel, bool)`

GetAalOk returns a tuple with the Aal field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetAal

`func (o *SessionAuthenticationMethod) SetAal(v AuthenticatorAssuranceLevel)`

SetAal sets Aal field to given value.

### HasAal

`func (o *SessionAuthenticationMethod) HasAal() bool`

HasAal returns a boolean if a field has been set.

### GetCompletedAt

`func (o *SessionAuthenticationMethod) GetCompletedAt() time.Time`

GetCompletedAt returns the CompletedAt field if non-nil, zero value otherwise.

### GetCompletedAtOk

`func (o *SessionAuthenticationMethod) GetCompletedAtOk() (*time.Time, bool)`

GetCompletedAtOk returns a tuple with the CompletedAt field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCompletedAt

`func (o *SessionAuthenticationMethod) SetCompletedAt(v time.Time)`

SetCompletedAt sets CompletedAt field to given value.

### HasCompletedAt

`func (o *SessionAuthenticationMethod) HasCompletedAt() bool`

HasCompletedAt returns a boolean if a field has been set.

### GetDeviceTrustBased

`func (o *SessionAuthenticationMethod) GetDeviceTrustBased() bool`

GetDeviceTrustBased returns the DeviceTrustBased field if non-nil, zero value otherwise.

### GetDeviceTrustBasedOk

`func (o *SessionAuthenticationMethod) GetDeviceTrustBasedOk() (*bool, bool)`

GetDeviceTrustBasedOk returns a tuple with the DeviceTrustBased field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDeviceTrustBased

`func (o *SessionAuthenticationMethod) SetDeviceTrustBased(v bool)`

SetDeviceTrustBased sets DeviceTrustBased field to given value.

### HasDeviceTrustBased

`func (o *SessionAuthenticationMethod) HasDeviceTrustBased() bool`

HasDeviceTrustBased returns a boolean if a field has been set.

### GetMethod

`func (o *SessionAuthenticationMethod) GetMethod() string`

GetMethod returns the Method field if non-nil, zero value otherwise.

### GetMethodOk

`func (o *SessionAuthenticationMethod) GetMethodOk() (*string, bool)`

GetMethodOk returns a tuple with the Method field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMethod

`func (o *SessionAuthenticationMethod) SetMethod(v string)`

SetMethod sets Method field to given value.

### HasMethod

`func (o *SessionAuthenticationMethod) HasMethod() bool`

HasMethod returns a boolean if a field has been set.

### GetOrganization

`func (o *SessionAuthenticationMethod) GetOrganization() string`

GetOrganization returns the Organization field if non-nil, zero value otherwise.

### GetOrganizationOk

`func (o *SessionAuthenticationMethod) GetOrganizationOk() (*string, bool)`

GetOrganizationOk returns a tuple with the Organization field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetOrganization

`func (o *SessionAuthenticationMethod) SetOrganization(v string)`

SetOrganization sets Organization field to given value.

### HasOrganization

`func (o *SessionAuthenticationMethod) HasOrganization() bool`

HasOrganization returns a boolean if a field has been set.

### GetProvider

`func (o *SessionAuthenticationMethod) GetProvider() string`

GetProvider returns the Provider field if non-nil, zero value otherwise.

### GetProviderOk

`func (o *SessionAuthenticationMethod) GetProviderOk() (*string, bool)`

GetProviderOk returns a tuple with the Provider field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetProvider

`func (o *SessionAuthenticationMethod) SetProvider(v string)`

SetProvider sets Provider field to given value.

### HasProvider

`func (o *SessionAuthenticationMethod) HasProvider() bool`

HasProvider returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


