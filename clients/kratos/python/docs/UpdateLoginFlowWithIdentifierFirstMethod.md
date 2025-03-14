# UpdateLoginFlowWithIdentifierFirstMethod

Update Login Flow with Multi-Step Method

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**csrf_token** | **str** | Sending the anti-csrf token is only required for browser login flows. | [optional] 
**identifier** | **str** | Identifier is the email or username of the user trying to log in. | 
**method** | **str** | Method should be set to \&quot;password\&quot; when logging in using the identifier and password strategy. | 
**transient_payload** | **object** | Transient data to pass along to any webhooks | [optional] 

## Example

```python
from ory_kratos_client.models.update_login_flow_with_identifier_first_method import UpdateLoginFlowWithIdentifierFirstMethod

# TODO update the JSON string below
json = "{}"
# create an instance of UpdateLoginFlowWithIdentifierFirstMethod from a JSON string
update_login_flow_with_identifier_first_method_instance = UpdateLoginFlowWithIdentifierFirstMethod.from_json(json)
# print the JSON string representation of the object
print(UpdateLoginFlowWithIdentifierFirstMethod.to_json())

# convert the object into a dict
update_login_flow_with_identifier_first_method_dict = update_login_flow_with_identifier_first_method_instance.to_dict()
# create an instance of UpdateLoginFlowWithIdentifierFirstMethod from a dict
update_login_flow_with_identifier_first_method_from_dict = UpdateLoginFlowWithIdentifierFirstMethod.from_dict(update_login_flow_with_identifier_first_method_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


