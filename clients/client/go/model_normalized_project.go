/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.16.1
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"time"
	"fmt"
)

// checks if the NormalizedProject type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &NormalizedProject{}

// NormalizedProject struct for NormalizedProject
type NormalizedProject struct {
	// The Project's Creation Date
	CreatedAt time.Time `json:"created_at"`
	CurrentRevision NormalizedProjectRevision `json:"current_revision"`
	// The environment of the project. prod Production stage Staging dev Development
	Environment string `json:"environment"`
	// The project's data home region. eu-central EUCentral asia-northeast AsiaNorthEast us-east USEast us-west USWest us US global Global
	HomeRegion string `json:"home_region"`
	Hosts []string `json:"hosts"`
	// The project's ID.
	Id string `json:"id"`
	// The project's slug
	Slug string `json:"slug"`
	// The state of the project. running Running halted Halted deleted Deleted
	State string `json:"state"`
	SubscriptionId NullableString `json:"subscription_id,omitempty"`
	SubscriptionPlan NullableString `json:"subscription_plan,omitempty"`
	// Last Time Project was Updated
	UpdatedAt time.Time `json:"updated_at"`
	Workspace *Workspace `json:"workspace,omitempty"`
	WorkspaceId NullableString `json:"workspace_id"`
	AdditionalProperties map[string]interface{}
}

type _NormalizedProject NormalizedProject

// NewNormalizedProject instantiates a new NormalizedProject object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewNormalizedProject(createdAt time.Time, currentRevision NormalizedProjectRevision, environment string, homeRegion string, hosts []string, id string, slug string, state string, updatedAt time.Time, workspaceId NullableString) *NormalizedProject {
	this := NormalizedProject{}
	this.CreatedAt = createdAt
	this.CurrentRevision = currentRevision
	this.Environment = environment
	this.HomeRegion = homeRegion
	this.Hosts = hosts
	this.Id = id
	this.Slug = slug
	this.State = state
	this.UpdatedAt = updatedAt
	this.WorkspaceId = workspaceId
	return &this
}

// NewNormalizedProjectWithDefaults instantiates a new NormalizedProject object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewNormalizedProjectWithDefaults() *NormalizedProject {
	this := NormalizedProject{}
	return &this
}

// GetCreatedAt returns the CreatedAt field value
func (o *NormalizedProject) GetCreatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.CreatedAt
}

// GetCreatedAtOk returns a tuple with the CreatedAt field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetCreatedAtOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.CreatedAt, true
}

// SetCreatedAt sets field value
func (o *NormalizedProject) SetCreatedAt(v time.Time) {
	o.CreatedAt = v
}

// GetCurrentRevision returns the CurrentRevision field value
func (o *NormalizedProject) GetCurrentRevision() NormalizedProjectRevision {
	if o == nil {
		var ret NormalizedProjectRevision
		return ret
	}

	return o.CurrentRevision
}

// GetCurrentRevisionOk returns a tuple with the CurrentRevision field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetCurrentRevisionOk() (*NormalizedProjectRevision, bool) {
	if o == nil {
		return nil, false
	}
	return &o.CurrentRevision, true
}

// SetCurrentRevision sets field value
func (o *NormalizedProject) SetCurrentRevision(v NormalizedProjectRevision) {
	o.CurrentRevision = v
}

// GetEnvironment returns the Environment field value
func (o *NormalizedProject) GetEnvironment() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Environment
}

// GetEnvironmentOk returns a tuple with the Environment field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetEnvironmentOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Environment, true
}

// SetEnvironment sets field value
func (o *NormalizedProject) SetEnvironment(v string) {
	o.Environment = v
}

// GetHomeRegion returns the HomeRegion field value
func (o *NormalizedProject) GetHomeRegion() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.HomeRegion
}

// GetHomeRegionOk returns a tuple with the HomeRegion field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetHomeRegionOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.HomeRegion, true
}

// SetHomeRegion sets field value
func (o *NormalizedProject) SetHomeRegion(v string) {
	o.HomeRegion = v
}

// GetHosts returns the Hosts field value
func (o *NormalizedProject) GetHosts() []string {
	if o == nil {
		var ret []string
		return ret
	}

	return o.Hosts
}

// GetHostsOk returns a tuple with the Hosts field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetHostsOk() ([]string, bool) {
	if o == nil {
		return nil, false
	}
	return o.Hosts, true
}

// SetHosts sets field value
func (o *NormalizedProject) SetHosts(v []string) {
	o.Hosts = v
}

// GetId returns the Id field value
func (o *NormalizedProject) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *NormalizedProject) SetId(v string) {
	o.Id = v
}

// GetSlug returns the Slug field value
func (o *NormalizedProject) GetSlug() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Slug
}

// GetSlugOk returns a tuple with the Slug field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetSlugOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Slug, true
}

// SetSlug sets field value
func (o *NormalizedProject) SetSlug(v string) {
	o.Slug = v
}

// GetState returns the State field value
func (o *NormalizedProject) GetState() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.State
}

// GetStateOk returns a tuple with the State field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetStateOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.State, true
}

// SetState sets field value
func (o *NormalizedProject) SetState(v string) {
	o.State = v
}

// GetSubscriptionId returns the SubscriptionId field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *NormalizedProject) GetSubscriptionId() string {
	if o == nil || IsNil(o.SubscriptionId.Get()) {
		var ret string
		return ret
	}
	return *o.SubscriptionId.Get()
}

// GetSubscriptionIdOk returns a tuple with the SubscriptionId field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *NormalizedProject) GetSubscriptionIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.SubscriptionId.Get(), o.SubscriptionId.IsSet()
}

// HasSubscriptionId returns a boolean if a field has been set.
func (o *NormalizedProject) HasSubscriptionId() bool {
	if o != nil && o.SubscriptionId.IsSet() {
		return true
	}

	return false
}

// SetSubscriptionId gets a reference to the given NullableString and assigns it to the SubscriptionId field.
func (o *NormalizedProject) SetSubscriptionId(v string) {
	o.SubscriptionId.Set(&v)
}
// SetSubscriptionIdNil sets the value for SubscriptionId to be an explicit nil
func (o *NormalizedProject) SetSubscriptionIdNil() {
	o.SubscriptionId.Set(nil)
}

// UnsetSubscriptionId ensures that no value is present for SubscriptionId, not even an explicit nil
func (o *NormalizedProject) UnsetSubscriptionId() {
	o.SubscriptionId.Unset()
}

// GetSubscriptionPlan returns the SubscriptionPlan field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *NormalizedProject) GetSubscriptionPlan() string {
	if o == nil || IsNil(o.SubscriptionPlan.Get()) {
		var ret string
		return ret
	}
	return *o.SubscriptionPlan.Get()
}

// GetSubscriptionPlanOk returns a tuple with the SubscriptionPlan field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *NormalizedProject) GetSubscriptionPlanOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.SubscriptionPlan.Get(), o.SubscriptionPlan.IsSet()
}

// HasSubscriptionPlan returns a boolean if a field has been set.
func (o *NormalizedProject) HasSubscriptionPlan() bool {
	if o != nil && o.SubscriptionPlan.IsSet() {
		return true
	}

	return false
}

// SetSubscriptionPlan gets a reference to the given NullableString and assigns it to the SubscriptionPlan field.
func (o *NormalizedProject) SetSubscriptionPlan(v string) {
	o.SubscriptionPlan.Set(&v)
}
// SetSubscriptionPlanNil sets the value for SubscriptionPlan to be an explicit nil
func (o *NormalizedProject) SetSubscriptionPlanNil() {
	o.SubscriptionPlan.Set(nil)
}

// UnsetSubscriptionPlan ensures that no value is present for SubscriptionPlan, not even an explicit nil
func (o *NormalizedProject) UnsetSubscriptionPlan() {
	o.SubscriptionPlan.Unset()
}

// GetUpdatedAt returns the UpdatedAt field value
func (o *NormalizedProject) GetUpdatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.UpdatedAt
}

// GetUpdatedAtOk returns a tuple with the UpdatedAt field value
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetUpdatedAtOk() (*time.Time, bool) {
	if o == nil {
		return nil, false
	}
	return &o.UpdatedAt, true
}

// SetUpdatedAt sets field value
func (o *NormalizedProject) SetUpdatedAt(v time.Time) {
	o.UpdatedAt = v
}

// GetWorkspace returns the Workspace field value if set, zero value otherwise.
func (o *NormalizedProject) GetWorkspace() Workspace {
	if o == nil || IsNil(o.Workspace) {
		var ret Workspace
		return ret
	}
	return *o.Workspace
}

// GetWorkspaceOk returns a tuple with the Workspace field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *NormalizedProject) GetWorkspaceOk() (*Workspace, bool) {
	if o == nil || IsNil(o.Workspace) {
		return nil, false
	}
	return o.Workspace, true
}

// HasWorkspace returns a boolean if a field has been set.
func (o *NormalizedProject) HasWorkspace() bool {
	if o != nil && !IsNil(o.Workspace) {
		return true
	}

	return false
}

// SetWorkspace gets a reference to the given Workspace and assigns it to the Workspace field.
func (o *NormalizedProject) SetWorkspace(v Workspace) {
	o.Workspace = &v
}

// GetWorkspaceId returns the WorkspaceId field value
// If the value is explicit nil, the zero value for string will be returned
func (o *NormalizedProject) GetWorkspaceId() string {
	if o == nil || o.WorkspaceId.Get() == nil {
		var ret string
		return ret
	}

	return *o.WorkspaceId.Get()
}

// GetWorkspaceIdOk returns a tuple with the WorkspaceId field value
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *NormalizedProject) GetWorkspaceIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return o.WorkspaceId.Get(), o.WorkspaceId.IsSet()
}

// SetWorkspaceId sets field value
func (o *NormalizedProject) SetWorkspaceId(v string) {
	o.WorkspaceId.Set(&v)
}

func (o NormalizedProject) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o NormalizedProject) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["created_at"] = o.CreatedAt
	toSerialize["current_revision"] = o.CurrentRevision
	toSerialize["environment"] = o.Environment
	toSerialize["home_region"] = o.HomeRegion
	toSerialize["hosts"] = o.Hosts
	toSerialize["id"] = o.Id
	toSerialize["slug"] = o.Slug
	toSerialize["state"] = o.State
	if o.SubscriptionId.IsSet() {
		toSerialize["subscription_id"] = o.SubscriptionId.Get()
	}
	if o.SubscriptionPlan.IsSet() {
		toSerialize["subscription_plan"] = o.SubscriptionPlan.Get()
	}
	toSerialize["updated_at"] = o.UpdatedAt
	if !IsNil(o.Workspace) {
		toSerialize["workspace"] = o.Workspace
	}
	toSerialize["workspace_id"] = o.WorkspaceId.Get()

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *NormalizedProject) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"created_at",
		"current_revision",
		"environment",
		"home_region",
		"hosts",
		"id",
		"slug",
		"state",
		"updated_at",
		"workspace_id",
	}

	allProperties := make(map[string]interface{})

	err = json.Unmarshal(data, &allProperties)

	if err != nil {
		return err;
	}

	for _, requiredProperty := range(requiredProperties) {
		if _, exists := allProperties[requiredProperty]; !exists {
			return fmt.Errorf("no value given for required property %v", requiredProperty)
		}
	}

	varNormalizedProject := _NormalizedProject{}

	err = json.Unmarshal(data, &varNormalizedProject)

	if err != nil {
		return err
	}

	*o = NormalizedProject(varNormalizedProject)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "created_at")
		delete(additionalProperties, "current_revision")
		delete(additionalProperties, "environment")
		delete(additionalProperties, "home_region")
		delete(additionalProperties, "hosts")
		delete(additionalProperties, "id")
		delete(additionalProperties, "slug")
		delete(additionalProperties, "state")
		delete(additionalProperties, "subscription_id")
		delete(additionalProperties, "subscription_plan")
		delete(additionalProperties, "updated_at")
		delete(additionalProperties, "workspace")
		delete(additionalProperties, "workspace_id")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableNormalizedProject struct {
	value *NormalizedProject
	isSet bool
}

func (v NullableNormalizedProject) Get() *NormalizedProject {
	return v.value
}

func (v *NullableNormalizedProject) Set(val *NormalizedProject) {
	v.value = val
	v.isSet = true
}

func (v NullableNormalizedProject) IsSet() bool {
	return v.isSet
}

func (v *NullableNormalizedProject) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableNormalizedProject(val *NormalizedProject) *NullableNormalizedProject {
	return &NullableNormalizedProject{value: val, isSet: true}
}

func (v NullableNormalizedProject) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableNormalizedProject) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


