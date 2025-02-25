# coding: utf-8

"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

    The version of the OpenAPI document: v1.3.6-alpha.2
    Contact: office@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from pydantic import BaseModel, ConfigDict, Field, StrictStr
from typing import Any, ClassVar, Dict, List, Optional
from typing import Optional, Set
from typing_extensions import Self

class UpdateSettingsFlowWithOidcMethod(BaseModel):
    """
    Update Settings Flow with OpenID Connect Method
    """ # noqa: E501
    flow: Optional[StrictStr] = Field(default=None, description="Flow ID is the flow's ID.  in: query")
    link: Optional[StrictStr] = Field(default=None, description="Link this provider  Either this or `unlink` must be set.  type: string in: body")
    method: StrictStr = Field(description="Method  Should be set to profile when trying to update a profile.")
    traits: Optional[Dict[str, Any]] = Field(default=None, description="The identity's traits  in: body")
    transient_payload: Optional[Dict[str, Any]] = Field(default=None, description="Transient data to pass along to any webhooks")
    unlink: Optional[StrictStr] = Field(default=None, description="Unlink this provider  Either this or `link` must be set.  type: string in: body")
    upstream_parameters: Optional[Dict[str, Any]] = Field(default=None, description="UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: `login_hint` (string): The `login_hint` parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. `hd` (string): The `hd` parameter limits the login/registration process to a Google Organization, e.g. `mycollege.edu`. `prompt` (string): The `prompt` specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. `select_account`.")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["flow", "link", "method", "traits", "transient_payload", "unlink", "upstream_parameters"]

    model_config = ConfigDict(
        populate_by_name=True,
        validate_assignment=True,
        protected_namespaces=(),
    )


    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True, exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Optional[Self]:
        """Create an instance of UpdateSettingsFlowWithOidcMethod from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        * Fields in `self.additional_properties` are added to the output dict.
        """
        excluded_fields: Set[str] = set([
            "additional_properties",
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of UpdateSettingsFlowWithOidcMethod from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "flow": obj.get("flow"),
            "link": obj.get("link"),
            "method": obj.get("method"),
            "traits": obj.get("traits"),
            "transient_payload": obj.get("transient_payload"),
            "unlink": obj.get("unlink"),
            "upstream_parameters": obj.get("upstream_parameters")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


