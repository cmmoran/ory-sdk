# coding: utf-8

"""
    Ory APIs

    # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

    The version of the OpenAPI document: v1.16.1
    Contact: support@ory.sh
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


import unittest

from ory_client.models.list_invoices_response import ListInvoicesResponse

class TestListInvoicesResponse(unittest.TestCase):
    """ListInvoicesResponse unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional) -> ListInvoicesResponse:
        """Test ListInvoicesResponse
            include_optional is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # uncomment below to create an instance of `ListInvoicesResponse`
        """
        model = ListInvoicesResponse()
        if include_optional:
            return ListInvoicesResponse(
                buckets = [
                    ory_client.models.billing_period_bucket.BillingPeriodBucket(
                        base_invoices = [
                            ory_client.models.invoice.invoice(
                                id = '', 
                                invoiced_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                type = 'usage', 
                                updated_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                v1 = ory_client.models.invoice_data_v1.InvoiceDataV1(
                                    billing_period = ory_client.models.time_interval.TimeInterval(
                                        end = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                        start = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), ), 
                                    currency = '', 
                                    deleted = True, 
                                    items = [
                                        ory_client.models.line_item_v1.LineItemV1(
                                            amount_in_cent = 56, 
                                            description = '', 
                                            quantity = 56, 
                                            title = '', 
                                            unit_price = '', )
                                        ], 
                                    plan = '', 
                                    stripe_invoice_item = '', 
                                    stripe_invoice_status = '', 
                                    stripe_link = '', 
                                    subtitle = '', 
                                    tax = ory_client.models.tax_line_item.TaxLineItem(
                                        amount_in_cent = 56, 
                                        title = '', ), 
                                    title = '', 
                                    total_in_cent = 56, ), )
                            ], 
                        billing_period = ory_client.models.time_interval.TimeInterval(
                            end = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                            start = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), ), 
                        usage_invoice = ory_client.models.invoice.invoice(
                            id = '', 
                            invoiced_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                            type = 'usage', 
                            updated_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), ), )
                    ],
                has_next_page = True,
                next_page_token = ''
            )
        else:
            return ListInvoicesResponse(
                buckets = [
                    ory_client.models.billing_period_bucket.BillingPeriodBucket(
                        base_invoices = [
                            ory_client.models.invoice.invoice(
                                id = '', 
                                invoiced_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                type = 'usage', 
                                updated_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                v1 = ory_client.models.invoice_data_v1.InvoiceDataV1(
                                    billing_period = ory_client.models.time_interval.TimeInterval(
                                        end = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                                        start = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), ), 
                                    currency = '', 
                                    deleted = True, 
                                    items = [
                                        ory_client.models.line_item_v1.LineItemV1(
                                            amount_in_cent = 56, 
                                            description = '', 
                                            quantity = 56, 
                                            title = '', 
                                            unit_price = '', )
                                        ], 
                                    plan = '', 
                                    stripe_invoice_item = '', 
                                    stripe_invoice_status = '', 
                                    stripe_link = '', 
                                    subtitle = '', 
                                    tax = ory_client.models.tax_line_item.TaxLineItem(
                                        amount_in_cent = 56, 
                                        title = '', ), 
                                    title = '', 
                                    total_in_cent = 56, ), )
                            ], 
                        billing_period = ory_client.models.time_interval.TimeInterval(
                            end = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                            start = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), ), 
                        usage_invoice = ory_client.models.invoice.invoice(
                            id = '', 
                            invoiced_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), 
                            type = 'usage', 
                            updated_at = datetime.datetime.strptime('2013-10-20 19:20:30.00', '%Y-%m-%d %H:%M:%S.%f'), ), )
                    ],
                has_next_page = True,
                next_page_token = '',
        )
        """

    def testListInvoicesResponse(self):
        """Test ListInvoicesResponse"""
        # inst_req_only = self.make_instance(include_optional=False)
        # inst_req_and_optional = self.make_instance(include_optional=True)

if __name__ == '__main__':
    unittest.main()
