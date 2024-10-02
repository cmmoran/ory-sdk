# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.15.5
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from datetime import datetime
from pydantic import BaseModel, ConfigDict, Field, StrictBool, StrictStr
from typing import Any, ClassVar, Dict, List, Optional
from ory_client.models.authenticator_assurance_level import AuthenticatorAssuranceLevel
from ory_client.models.identity import Identity
from ory_client.models.session_authentication_method import SessionAuthenticationMethod
from ory_client.models.session_device import SessionDevice
from typing import Optional, Set
from typing_extensions import Self

class Session(BaseModel):
    """
    A Session
    """ # noqa: E501
    active: Optional[StrictBool] = Field(default=None, description="Active state. If false the session is no longer active.")
    authenticated_at: Optional[datetime] = Field(default=None, description="The Session Authentication Timestamp  When this session was authenticated at. If multi-factor authentication was used this is the time when the last factor was authenticated (e.g. the TOTP code challenge was completed).")
    authentication_methods: Optional[List[SessionAuthenticationMethod]] = Field(default=None, description="A list of authenticators which were used to authenticate the session.")
    authenticator_assurance_level: Optional[AuthenticatorAssuranceLevel] = None
    devices: Optional[List[SessionDevice]] = Field(default=None, description="Devices has history of all endpoints where the session was used")
    expires_at: Optional[datetime] = Field(default=None, description="The Session Expiry  When this session expires at.")
    id: StrictStr = Field(description="Session ID")
    identity: Optional[Identity] = None
    issued_at: Optional[datetime] = Field(default=None, description="The Session Issuance Timestamp  When this session was issued at. Usually equal or close to `authenticated_at`.")
    tokenized: Optional[StrictStr] = Field(default=None, description="Tokenized is the tokenized (e.g. JWT) version of the session.  It is only set when the `tokenize` query parameter was set to a valid tokenize template during calls to `/session/whoami`.")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["active", "authenticated_at", "authentication_methods", "authenticator_assurance_level", "devices", "expires_at", "id", "identity", "issued_at", "tokenized"]

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
        """Create an instance of Session from a JSON string"""
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
        # override the default output from pydantic by calling `to_dict()` of each item in authentication_methods (list)
        _items = []
        if self.authentication_methods:
            for _item in self.authentication_methods:
                if _item:
                    _items.append(_item.to_dict())
            _dict['authentication_methods'] = _items
        # override the default output from pydantic by calling `to_dict()` of each item in devices (list)
        _items = []
        if self.devices:
            for _item in self.devices:
                if _item:
                    _items.append(_item.to_dict())
            _dict['devices'] = _items
        # override the default output from pydantic by calling `to_dict()` of identity
        if self.identity:
            _dict['identity'] = self.identity.to_dict()
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of Session from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "active": obj.get("active"),
            "authenticated_at": obj.get("authenticated_at"),
            "authentication_methods": [SessionAuthenticationMethod.from_dict(_item) for _item in obj["authentication_methods"]] if obj.get("authentication_methods") is not None else None,
            "authenticator_assurance_level": obj.get("authenticator_assurance_level"),
            "devices": [SessionDevice.from_dict(_item) for _item in obj["devices"]] if obj.get("devices") is not None else None,
            "expires_at": obj.get("expires_at"),
            "id": obj.get("id"),
            "identity": Identity.from_dict(obj["identity"]) if obj.get("identity") is not None else None,
            "issued_at": obj.get("issued_at"),
            "tokenized": obj.get("tokenized")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


