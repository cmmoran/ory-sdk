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

from pydantic import BaseModel, ConfigDict, Field, StrictStr
from typing import Any, ClassVar, Dict, List, Optional
from typing import Optional, Set
from typing_extensions import Self

class UpdateSettingsFlowWithWebAuthnMethod(BaseModel):
    """
    Update Settings Flow with WebAuthn Method
    """ # noqa: E501
    csrf_token: Optional[StrictStr] = Field(default=None, description="CSRFToken is the anti-CSRF token")
    method: StrictStr = Field(description="Method  Should be set to \"webauthn\" when trying to add, update, or remove a webAuthn pairing.")
    transient_payload: Optional[Dict[str, Any]] = Field(default=None, description="Transient data to pass along to any webhooks")
    webauthn_register: Optional[StrictStr] = Field(default=None, description="Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.")
    webauthn_register_displayname: Optional[StrictStr] = Field(default=None, description="Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.")
    webauthn_remove: Optional[StrictStr] = Field(default=None, description="Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["csrf_token", "method", "transient_payload", "webauthn_register", "webauthn_register_displayname", "webauthn_remove"]

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
        """Create an instance of UpdateSettingsFlowWithWebAuthnMethod from a JSON string"""
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
        """Create an instance of UpdateSettingsFlowWithWebAuthnMethod from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "csrf_token": obj.get("csrf_token"),
            "method": obj.get("method"),
            "transient_payload": obj.get("transient_payload"),
            "webauthn_register": obj.get("webauthn_register"),
            "webauthn_register_displayname": obj.get("webauthn_register_displayname"),
            "webauthn_remove": obj.get("webauthn_remove")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


