"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v1.2.2
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.identity_schema_container import IdentitySchemaContainer
globals()['IdentitySchemaContainer'] = IdentitySchemaContainer
from ory_client.model.identity_schemas import IdentitySchemas


class TestIdentitySchemas(unittest.TestCase):
    """IdentitySchemas unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testIdentitySchemas(self):
        """Test IdentitySchemas"""
        # FIXME: construct object with mandatory attributes with example values
        # model = IdentitySchemas()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
