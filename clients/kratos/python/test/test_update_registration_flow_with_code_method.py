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

from ory_kratos_client.models.update_registration_flow_with_code_method import UpdateRegistrationFlowWithCodeMethod

class TestUpdateRegistrationFlowWithCodeMethod(unittest.TestCase):
    """UpdateRegistrationFlowWithCodeMethod unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateRegistrationFlowWithCodeMethod:
        """Test UpdateRegistrationFlowWithCodeMethod
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateRegistrationFlowWithCodeMethod`
        """
        model = UpdateRegistrationFlowWithCodeMethod()
        if include_optional:
            return UpdateRegistrationFlowWithCodeMethod(
                code = '',
                csrf_token = '',
                method = '',
                resend = '',
                traits = ory_kratos_client.models.traits.traits(),
                transient_payload = ory_kratos_client.models.transient_payload.transient_payload()
            )
        else:
            return UpdateRegistrationFlowWithCodeMethod(
                method = '',
                traits = ory_kratos_client.models.traits.traits(),
        )
        """

    def testUpdateRegistrationFlowWithCodeMethod(self):
        """Test UpdateRegistrationFlowWithCodeMethod"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
