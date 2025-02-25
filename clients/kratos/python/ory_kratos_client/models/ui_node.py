# coding: utf-8

"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

    The version of the OpenAPI document: v1.3.6-alpha.1
    Contact: office@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from pydantic import BaseModel, ConfigDict, Field, StrictStr, field_validator
from typing import Any, ClassVar, Dict, List
from ory_kratos_client.models.ui_node_attributes import UiNodeAttributes
from ory_kratos_client.models.ui_node_meta import UiNodeMeta
from ory_kratos_client.models.ui_text import UiText
from typing import Optional, Set
from typing_extensions import Self

class UiNode(BaseModel):
    """
    Nodes are represented as HTML elements or their native UI equivalents. For example, a node can be an `<img>` tag, or an `<input element>` but also `some plain text`.
    """ # noqa: E501
    attributes: UiNodeAttributes
    group: StrictStr = Field(description="Group specifies which group (e.g. password authenticator) this node belongs to. default DefaultGroup password PasswordGroup oidc OpenIDConnectGroup profile ProfileGroup link LinkGroup code CodeGroup totp TOTPGroup lookup_secret LookupGroup webauthn WebAuthnGroup passkey PasskeyGroup identifier_first IdentifierFirstGroup captcha CaptchaGroup saml SAMLGroup")
    messages: List[UiText]
    meta: UiNodeMeta
    type: StrictStr = Field(description="The node's type text Text input Input img Image a Anchor script Script")
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["attributes", "group", "messages", "meta", "type"]

    @field_validator('group')
    def group_validate_enum(cls, value):
        """Validates the enum"""
        if value not in set(['default', 'password', 'oidc', 'profile', 'link', 'code', 'totp', 'lookup_secret', 'webauthn', 'passkey', 'identifier_first', 'captcha', 'saml']):
            raise ValueError("must be one of enum values ('default', 'password', 'oidc', 'profile', 'link', 'code', 'totp', 'lookup_secret', 'webauthn', 'passkey', 'identifier_first', 'captcha', 'saml')")
        return value

    @field_validator('type')
    def type_validate_enum(cls, value):
        """Validates the enum"""
        if value not in set(['text', 'input', 'img', 'a', 'script']):
            raise ValueError("must be one of enum values ('text', 'input', 'img', 'a', 'script')")
        return value

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
        """Create an instance of UiNode from a JSON string"""
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
        # override the default output from pydantic by calling `to_dict()` of attributes
        if self.attributes:
            _dict['attributes'] = self.attributes.to_dict()
        # override the default output from pydantic by calling `to_dict()` of each item in messages (list)
        _items = []
        if self.messages:
            for _item_messages in self.messages:
                if _item_messages:
                    _items.append(_item_messages.to_dict())
            _dict['messages'] = _items
        # override the default output from pydantic by calling `to_dict()` of meta
        if self.meta:
            _dict['meta'] = self.meta.to_dict()
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of UiNode from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "attributes": UiNodeAttributes.from_dict(obj["attributes"]) if obj.get("attributes") is not None else None,
            "group": obj.get("group"),
            "messages": [UiText.from_dict(_item) for _item in obj["messages"]] if obj.get("messages") is not None else None,
            "meta": UiNodeMeta.from_dict(obj["meta"]) if obj.get("meta") is not None else None,
            "type": obj.get("type")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


