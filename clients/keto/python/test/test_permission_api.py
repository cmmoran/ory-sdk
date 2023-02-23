"""
    Ory Keto API

    Documentation for all of Ory Keto's REST APIs. gRPC is documented separately.   # noqa: E501

    The version of the OpenAPI document: v0.11.0-alpha.0
    Contact: hi@ory.sh
    Generated by: https://openapi-generator.tech
"""


import unittest

import ory_keto_client
from ory_keto_client.api.permission_api import PermissionApi  # noqa: E501


class TestPermissionApi(unittest.TestCase):
    """PermissionApi unit test stubs"""

    def setUp(self):
        self.api = PermissionApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_check_permission(self):
        """Test case for check_permission

        Check a permission  # noqa: E501
        """
        pass

    def test_check_permission_or_error(self):
        """Test case for check_permission_or_error

        Check a permission  # noqa: E501
        """
        pass

    def test_expand_permissions(self):
        """Test case for expand_permissions

        Expand a Relationship into permissions.  # noqa: E501
        """
        pass

    def test_post_check_permission(self):
        """Test case for post_check_permission

        Check a permission  # noqa: E501
        """
        pass

    def test_post_check_permission_or_error(self):
        """Test case for post_check_permission_or_error

        Check a permission  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
