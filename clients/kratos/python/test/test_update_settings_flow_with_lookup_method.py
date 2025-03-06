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

from ory_kratos_client.models.update_settings_flow_with_lookup_method import UpdateSettingsFlowWithLookupMethod

class TestUpdateSettingsFlowWithLookupMethod(unittest.TestCase):
    """UpdateSettingsFlowWithLookupMethod unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateSettingsFlowWithLookupMethod:
        """Test UpdateSettingsFlowWithLookupMethod
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateSettingsFlowWithLookupMethod`
        """
        model = UpdateSettingsFlowWithLookupMethod()
        if include_optional:
            return UpdateSettingsFlowWithLookupMethod(
                csrf_token = '',
                lookup_secret_confirm = True,
                lookup_secret_disable = True,
                lookup_secret_regenerate = True,
                lookup_secret_reveal = True,
                method = '',
                transient_payload = ory_kratos_client.models.transient_payload.transient_payload()
            )
        else:
            return UpdateSettingsFlowWithLookupMethod(
                method = '',
        )
        """

    def testUpdateSettingsFlowWithLookupMethod(self):
        """Test UpdateSettingsFlowWithLookupMethod"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
