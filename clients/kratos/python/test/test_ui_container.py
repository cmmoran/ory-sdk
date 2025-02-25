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

from ory_kratos_client.models.ui_container import UiContainer

class TestUiContainer(unittest.TestCase):
    """UiContainer unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> UiContainer:
        """Test UiContainer
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `UiContainer`
        """
        model = UiContainer()
        if include_optional:
            return UiContainer(
                action = '',
                messages = [
                    ory_kratos_client.models.ui_text.uiText(
                        context = ory_kratos_client.models.context.context(), 
                        id = 56, 
                        text = '', 
                        type = 'info', )
                    ],
                method = '',
                nodes = [
                    ory_kratos_client.models.node_represents_a_flow's_nodes.Node represents a flow's nodes(
                        attributes = null, 
                        group = 'default', 
                        messages = [
                            ory_kratos_client.models.ui_text.uiText(
                                context = ory_kratos_client.models.context.context(), 
                                id = 56, 
                                text = '', 
                                type = 'info', )
                            ], 
                        meta = ory_kratos_client.models.a_node's_meta_information.A Node's Meta Information(
                            label = ory_kratos_client.models.ui_text.uiText(
                                context = ory_kratos_client.models.context.context(), 
                                id = 56, 
                                text = '', 
                                type = 'info', ), ), 
                        type = 'text', )
                    ]
            )
        else:
            return UiContainer(
                action = '',
                method = '',
                nodes = [
                    ory_kratos_client.models.node_represents_a_flow's_nodes.Node represents a flow's nodes(
                        attributes = null, 
                        group = 'default', 
                        messages = [
                            ory_kratos_client.models.ui_text.uiText(
                                context = ory_kratos_client.models.context.context(), 
                                id = 56, 
                                text = '', 
                                type = 'info', )
                            ], 
                        meta = ory_kratos_client.models.a_node's_meta_information.A Node's Meta Information(
                            label = ory_kratos_client.models.ui_text.uiText(
                                context = ory_kratos_client.models.context.context(), 
                                id = 56, 
                                text = '', 
                                type = 'info', ), ), 
                        type = 'text', )
                    ],
        )
        """

    def testUiContainer(self):
        """Test UiContainer"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
