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

from ory_kratos_client.models.ui_node_attributes import UiNodeAttributes

class TestUiNodeAttributes(unittest.TestCase):
    """UiNodeAttributes unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UiNodeAttributes:
        """Test UiNodeAttributes
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UiNodeAttributes`
        """
        model = UiNodeAttributes()
        if include_optional:
            return UiNodeAttributes(
                autocomplete = 'email',
                disabled = True,
                label = ory_kratos_client.models.ui_text.uiText(
                    context = ory_kratos_client.models.context.context(), 
                    id = 56, 
                    text = '', 
                    type = 'info', ),
                maxlength = 56,
                name = '',
                node_type = 'text',
                onclick = '',
                onclick_trigger = 'oryWebAuthnRegistration',
                onload = '',
                onload_trigger = 'oryWebAuthnRegistration',
                pattern = '',
                required = True,
                type = '',
                value = ory_kratos_client.models.value.value(),
                id = '',
                text = ory_kratos_client.models.ui_text.uiText(
                    context = ory_kratos_client.models.context.context(), 
                    id = 56, 
                    text = '', 
                    type = 'info', ),
                height = 56,
                src = '',
                width = 56,
                href = '',
                title = ory_kratos_client.models.ui_text.uiText(
                    context = ory_kratos_client.models.context.context(), 
                    id = 56, 
                    text = '', 
                    type = 'info', ),
                var_async = True,
                crossorigin = '',
                integrity = '',
                nonce = '',
                referrerpolicy = ''
            )
        else:
            return UiNodeAttributes(
                disabled = True,
                name = '',
                node_type = 'text',
                type = '',
                id = '',
                text = ory_kratos_client.models.ui_text.uiText(
                    context = ory_kratos_client.models.context.context(), 
                    id = 56, 
                    text = '', 
                    type = 'info', ),
                height = 56,
                src = '',
                width = 56,
                href = '',
                title = ory_kratos_client.models.ui_text.uiText(
                    context = ory_kratos_client.models.context.context(), 
                    id = 56, 
                    text = '', 
                    type = 'info', ),
                var_async = True,
                crossorigin = '',
                integrity = '',
                nonce = '',
                referrerpolicy = '',
        )
        """

    def testUiNodeAttributes(self):
        """Test UiNodeAttributes"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
