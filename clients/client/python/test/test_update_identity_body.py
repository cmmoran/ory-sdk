# coding: utf-8

"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

    The version of the OpenAPI document: v1.12.2
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_client.models.update_identity_body import UpdateIdentityBody

class TestUpdateIdentityBody(unittest.TestCase):
    """UpdateIdentityBody unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UpdateIdentityBody:
        """Test UpdateIdentityBody
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UpdateIdentityBody`
        """
        model = UpdateIdentityBody()
        if include_optional:
            return UpdateIdentityBody(
                credentials = ory_client.models.identity_with_credentials.identityWithCredentials(
                    oidc = ory_client.models.identity_with_credentials_oidc.identityWithCredentialsOidc(
                        config = ory_client.models.identity_with_credentials_oidc_config.identityWithCredentialsOidcConfig(
                            providers = [
                                ory_client.models.identity_with_credentials_oidc_config_provider.identityWithCredentialsOidcConfigProvider(
                                    provider = '', 
                                    subject = '', )
                                ], ), ), 
                    password = ory_client.models.identity_with_credentials_password.identityWithCredentialsPassword(), ),
                metadata_admin = None,
                metadata_public = None,
                schema_id = '',
                state = 'active',
                traits = None
            )
        else:
            return UpdateIdentityBody(
                schema_id = '',
                state = 'active',
                traits = None,
        )
        """

    def testUpdateIdentityBody(self):
        """Test UpdateIdentityBody"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
