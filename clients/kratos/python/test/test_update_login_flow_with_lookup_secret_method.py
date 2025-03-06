# coding: utf-8

"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

    The version of the OpenAPI document: v1.4.0-alpha.0
    Contact: office@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_kratos_client.models.update_login_flow_with_lookup_secret_method import UpdateLoginFlowWithLookupSecretMethod

class TestUpdateLoginFlowWithLookupSecretMethod(unittest.TestCase):
    """UpdateLoginFlowWithLookupSecretMethod unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateLoginFlowWithLookupSecretMethod:
        """Test UpdateLoginFlowWithLookupSecretMethod
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateLoginFlowWithLookupSecretMethod`
        """
        model = UpdateLoginFlowWithLookupSecretMethod()
        if include_optional:
            return UpdateLoginFlowWithLookupSecretMethod(
                csrf_token = '',
                lookup_secret = '',
                method = ''
            )
        else:
            return UpdateLoginFlowWithLookupSecretMethod(
                lookup_secret = '',
                method = '',
        )
        """

    def testUpdateLoginFlowWithLookupSecretMethod(self):
        """Test UpdateLoginFlowWithLookupSecretMethod"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
