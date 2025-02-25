# coding: utf-8

"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

    The version of the OpenAPI document: v1.3.6-alpha.1
    Contact: office@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_kratos_client.models.update_settings_flow_with_profile_method import UpdateSettingsFlowWithProfileMethod

class TestUpdateSettingsFlowWithProfileMethod(unittest.TestCase):
    """UpdateSettingsFlowWithProfileMethod unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateSettingsFlowWithProfileMethod:
        """Test UpdateSettingsFlowWithProfileMethod
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateSettingsFlowWithProfileMethod`
        """
        model = UpdateSettingsFlowWithProfileMethod()
        if include_optional:
            return UpdateSettingsFlowWithProfileMethod(
                csrf_token = '',
                method = '',
                traits = ory_kratos_client.models.traits.traits(),
                transient_payload = ory_kratos_client.models.transient_payload.transient_payload()
            )
        else:
            return UpdateSettingsFlowWithProfileMethod(
                method = '',
                traits = ory_kratos_client.models.traits.traits(),
        )
        """

    def testUpdateSettingsFlowWithProfileMethod(self):
        """Test UpdateSettingsFlowWithProfileMethod"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
