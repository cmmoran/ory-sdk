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

from ory_kratos_client.models.recovery_code_for_identity import RecoveryCodeForIdentity

class TestRecoveryCodeForIdentity(unittest.TestCase):
    """RecoveryCodeForIdentity unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> RecoveryCodeForIdentity:
        """Test RecoveryCodeForIdentity
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `RecoveryCodeForIdentity`
        """
        model = RecoveryCodeForIdentity()
        if include_optional:
            return RecoveryCodeForIdentity(
                expires_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'),
                recovery_code = '',
                recovery_link = ''
            )
        else:
            return RecoveryCodeForIdentity(
                recovery_code = '',
                recovery_link = '',
        )
        """

    def testRecoveryCodeForIdentity(self):
        """Test RecoveryCodeForIdentity"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
