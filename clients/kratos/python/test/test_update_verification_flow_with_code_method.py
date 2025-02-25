# coding: utf-8

"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

    The version of the OpenAPI document: v1.3.6-alpha.2
    Contact: office@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_kratos_client.models.update_verification_flow_with_code_method import UpdateVerificationFlowWithCodeMethod

class TestUpdateVerificationFlowWithCodeMethod(unittest.TestCase):
    """UpdateVerificationFlowWithCodeMethod unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateVerificationFlowWithCodeMethod:
        """Test UpdateVerificationFlowWithCodeMethod
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateVerificationFlowWithCodeMethod`
        """
        model = UpdateVerificationFlowWithCodeMethod()
        if include_optional:
            return UpdateVerificationFlowWithCodeMethod(
                code = '',
                csrf_token = '',
                email = '',
                method = 'link',
                transient_payload = ory_kratos_client.models.transient_payload.transient_payload()
            )
        else:
            return UpdateVerificationFlowWithCodeMethod(
                method = 'link',
        )
        """

    def testUpdateVerificationFlowWithCodeMethod(self):
        """Test UpdateVerificationFlowWithCodeMethod"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
