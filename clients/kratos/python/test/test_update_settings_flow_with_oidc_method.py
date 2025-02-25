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

from ory_kratos_client.models.update_settings_flow_with_oidc_method import UpdateSettingsFlowWithOidcMethod

class TestUpdateSettingsFlowWithOidcMethod(unittest.TestCase):
    """UpdateSettingsFlowWithOidcMethod unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateSettingsFlowWithOidcMethod:
        """Test UpdateSettingsFlowWithOidcMethod
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateSettingsFlowWithOidcMethod`
        """
        model = UpdateSettingsFlowWithOidcMethod()
        if include_optional:
            return UpdateSettingsFlowWithOidcMethod(
                flow = '',
                link = '',
                method = '',
                traits = ory_kratos_client.models.traits.traits(),
                transient_payload = ory_kratos_client.models.transient_payload.transient_payload(),
                unlink = '',
                upstream_parameters = ory_kratos_client.models.upstream_parameters.upstream_parameters()
            )
        else:
            return UpdateSettingsFlowWithOidcMethod(
                method = '',
        )
        """

    def testUpdateSettingsFlowWithOidcMethod(self):
        """Test UpdateSettingsFlowWithOidcMethod"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
