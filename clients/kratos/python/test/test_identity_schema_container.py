# coding: utf-8

"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

    The version of the OpenAPI document: v1.3.7
    Contact: office@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_kratos_client.models.identity_schema_container import IdentitySchemaContainer

class TestIdentitySchemaContainer(unittest.TestCase):
    """IdentitySchemaContainer unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> IdentitySchemaContainer:
        """Test IdentitySchemaContainer
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `IdentitySchemaContainer`
        """
        model = IdentitySchemaContainer()
        if include_optional:
            return IdentitySchemaContainer(
                id = '',
                var_schema = None
            )
        else:
            return IdentitySchemaContainer(
        )
        """

    def testIdentitySchemaContainer(self):
        """Test IdentitySchemaContainer"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
