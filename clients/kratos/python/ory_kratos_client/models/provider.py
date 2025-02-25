# coding: utf-8

"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

    The version of the OpenAPI document: v1.3.4
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

class Provider(BaseModel):
    """
    Provider
    """ # noqa: E501
    client_id: Optional[StrictStr] = Field(default=None, description="The RP's client identifier, issued by the IdP.")
    config_url: Optional[StrictStr] = Field(default=None, description="A full path of the IdP config file.")
    domain_hint: Optional[StrictStr] = Field(default=None, description="By specifying one of domain_hints values provided by the accounts endpoints, the FedCM dialog selectively shows the specified account.")
    fields: Optional[List[StrictStr]] = Field(default=None, description="Array of strings that specifies the user information (\"name\", \" email\", \"picture\") that RP needs IdP to share with them.  Note: Field API is supported by Chrome 132 and later.")
    login_hint: Optional[StrictStr] = Field(default=None, description="By specifying one of login_hints values provided by the accounts endpoints, the FedCM dialog selectively shows the specified account.")
    nonce: Optional[StrictStr] = Field(default=None, description="A random string to ensure the response is issued for this specific request. Prevents replay attacks.")
    parameters: Optional[Dict[str, StrictStr]] = Field(default=None, description="Custom object that allows to specify additional key-value parameters: scope: A string value containing additional permissions that RP needs to request, for example \" drive.readonly calendar.readonly\" nonce: A random string to ensure the response is issued for this specific request. Prevents replay attacks.  Other custom key-value parameters.  Note: parameters is supported from Chrome 132.")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["client_id", "config_url", "domain_hint", "fields", "login_hint", "nonce", "parameters"]

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
        """Create an instance of Provider from a JSON string"""
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
        """Create an instance of Provider from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "client_id": obj.get("client_id"),
            "config_url": obj.get("config_url"),
            "domain_hint": obj.get("domain_hint"),
            "fields": obj.get("fields"),
            "login_hint": obj.get("login_hint"),
            "nonce": obj.get("nonce"),
            "parameters": obj.get("parameters")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


