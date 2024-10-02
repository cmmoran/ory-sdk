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

from pydantic import BaseModel, ConfigDict, Field, StrictBool, StrictInt, StrictStr
from typing import Any, ClassVar, Dict, List, Optional
from ory_client.models.line_item_v1 import LineItemV1
from ory_client.models.tax_line_item import TaxLineItem
from ory_client.models.time_interval import TimeInterval
from typing import Optional, Set
from typing_extensions import Self

class InvoiceDataV1(BaseModel):
    """
    InvoiceDataV1
    """ # noqa: E501
    billing_period: TimeInterval
    currency: StrictStr = Field(description="The currency of the invoice.")
    deleted: Optional[StrictBool] = Field(default=None, description="Deleted is true if the invoice has been soft-deleted.")
    items: List[LineItemV1] = Field(description="The items that are part of this invoice.")
    plan: Optional[StrictStr] = Field(default=None, description="The plan that this invoice is based on, in the format \"Name@version\".")
    stripe_invoice_item: Optional[StrictStr] = None
    stripe_invoice_status: Optional[StrictStr] = Field(default=None, description="The status of the invoice, one of `draft`, `open`, `paid`, `uncollectible`, or `void`. [Learn more](https://stripe.com/docs/billing/invoices/workflow#workflow-overview)")
    stripe_link: Optional[StrictStr] = Field(default=None, description="An optional link to the invoice on Stripe.")
    subtitle: Optional[StrictStr] = Field(default=None, description="The subtitle of the invoice.")
    tax: Optional[TaxLineItem] = None
    title: StrictStr = Field(description="The title of the invoice.")
    total_in_cent: StrictInt
    additional_properties: Dict[str, Any] = {}
    __properties: ClassVar[List[str]] = ["billing_period", "currency", "deleted", "items", "plan", "stripe_invoice_item", "stripe_invoice_status", "stripe_link", "subtitle", "tax", "title", "total_in_cent"]

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
        """Create an instance of InvoiceDataV1 from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * OpenAPI `readOnly` fields are excluded.
        * Fields in `self.additional_properties` are added to the output dict.
        """
        excluded_fields: Set[str] = set([
            "currency",
            "deleted",
            "items",
            "plan",
            "stripe_link",
            "subtitle",
            "title",
            "additional_properties",
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # override the default output from pydantic by calling `to_dict()` of billing_period
        if self.billing_period:
            _dict['billing_period'] = self.billing_period.to_dict()
        # override the default output from pydantic by calling `to_dict()` of each item in items (list)
        _items = []
        if self.items:
            for _item in self.items:
                if _item:
                    _items.append(_item.to_dict())
            _dict['items'] = _items
        # override the default output from pydantic by calling `to_dict()` of tax
        if self.tax:
            _dict['tax'] = self.tax.to_dict()
        # puts key-value pairs in additional_properties in the top level
        if self.additional_properties is not None:
            for _key, _value in self.additional_properties.items():
                _dict[_key] = _value

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of InvoiceDataV1 from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "billing_period": TimeInterval.from_dict(obj["billing_period"]) if obj.get("billing_period") is not None else None,
            "currency": obj.get("currency"),
            "deleted": obj.get("deleted"),
            "items": [LineItemV1.from_dict(_item) for _item in obj["items"]] if obj.get("items") is not None else None,
            "plan": obj.get("plan"),
            "stripe_invoice_item": obj.get("stripe_invoice_item"),
            "stripe_invoice_status": obj.get("stripe_invoice_status"),
            "stripe_link": obj.get("stripe_link"),
            "subtitle": obj.get("subtitle"),
            "tax": TaxLineItem.from_dict(obj["tax"]) if obj.get("tax") is not None else None,
            "title": obj.get("title"),
            "total_in_cent": obj.get("total_in_cent")
        })
        # store additional fields in additional_properties
        for _key in obj.keys():
            if _key not in cls.__properties:
                _obj.additional_properties[_key] = obj.get(_key)

        return _obj


