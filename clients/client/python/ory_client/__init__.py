# flake8: noqa

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v1.2.2
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


__version__ = "v1.2.2"

# import ApiClient
from ory_client.api_client import ApiClient

# import Configuration
from ory_client.configuration import Configuration

# import exceptions
from ory_client.exceptions import OpenApiException
from ory_client.exceptions import ApiAttributeError
from ory_client.exceptions import ApiTypeError
from ory_client.exceptions import ApiValueError
from ory_client.exceptions import ApiKeyError
from ory_client.exceptions import ApiException
