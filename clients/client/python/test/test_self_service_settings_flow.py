"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v0.1.0-alpha.8
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.identity import Identity
from ory_client.model.self_service_settings_flow_state import SelfServiceSettingsFlowState
from ory_client.model.ui_container import UiContainer
globals()['Identity'] = Identity
globals()['SelfServiceSettingsFlowState'] = SelfServiceSettingsFlowState
globals()['UiContainer'] = UiContainer
from ory_client.model.self_service_settings_flow import SelfServiceSettingsFlow


class TestSelfServiceSettingsFlow(unittest.TestCase):
    """SelfServiceSettingsFlow unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testSelfServiceSettingsFlow(self):
        """Test SelfServiceSettingsFlow"""
        # FIXME: construct object with mandatory attributes with example values
        # model = SelfServiceSettingsFlow()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
