=begin
#Ory Kratos

#Welcome to the ORY Kratos HTTP API documentation!

The version of the OpenAPI document: latest

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.2.2

=end

require 'spec_helper'
require 'json'

# Unit tests for OryHydraClient::AdminApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'AdminApi' do
  before do
    # run before each test
    @api_instance = OryHydraClient::AdminApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of AdminApi' do
    it 'should create an instance of AdminApi' do
      expect(@api_instance).to be_instance_of(OryHydraClient::AdminApi)
    end
  end

  # unit tests for create_identity
  # Create an identity
  # This endpoint creates an identity. It is NOT possible to set an identity&#39;s credentials (password, ...) using this method! A way to achieve that will be introduced in the future.  Learn how identities work in [ORY Kratos&#39; User And Identity Model Documentation](https://www.ory.sh/docs/next/kratos/concepts/identity-user-model).
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [Identity]
  describe 'create_identity test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for delete_identity
  # Delete an identity
  # This endpoint deletes an identity. This can not be undone.  Learn how identities work in [ORY Kratos&#39; User And Identity Model Documentation](https://www.ory.sh/docs/next/kratos/concepts/identity-user-model).
  # @param id ID is the identity&#39;s ID.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'delete_identity test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_identity
  # Get an identity
  # Learn how identities work in [ORY Kratos&#39; User And Identity Model Documentation](https://www.ory.sh/docs/next/kratos/concepts/identity-user-model).
  # @param id ID must be set to the ID of identity you want to get
  # @param [Hash] opts the optional parameters
  # @return [Identity]
  describe 'get_identity test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_self_service_browser_login_request
  # Get the request context of browser-based login user flows
  # This endpoint returns a login request&#39;s context with, for example, error details and other information.  When accessing this endpoint through ORY Kratos&#39; Public API, ensure that cookies are set as they are required for CSRF to work. To prevent token scanning attacks, the public endpoint does not return 404 status codes to prevent scanning attacks.  More information can be found at [ORY Kratos User Login and User Registration Documentation](https://www.ory.sh/docs/next/kratos/self-service/flows/user-login-user-registration).
  # @param request Request is the Login Request ID  The value for this parameter comes from &#x60;request&#x60; URL Query parameter sent to your application (e.g. &#x60;/login?request&#x3D;abcde&#x60;).
  # @param [Hash] opts the optional parameters
  # @return [LoginRequest]
  describe 'get_self_service_browser_login_request test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_self_service_browser_profile_management_request
  # Get the request context of browser-based profile management flows
  # When accessing this endpoint through ORY Kratos&#39; Public API, ensure that cookies are set as they are required for checking the auth session. To prevent scanning attacks, the public endpoint does not return 404 status codes but instead 403 or 500.  More information can be found at [ORY Kratos Profile Management Documentation](https://www.ory.sh/docs/next/kratos/self-service/flows/user-profile-management).
  # @param request Request is the Login Request ID  The value for this parameter comes from &#x60;request&#x60; URL Query parameter sent to your application (e.g. &#x60;/login?request&#x3D;abcde&#x60;).
  # @param [Hash] opts the optional parameters
  # @return [ProfileManagementRequest]
  describe 'get_self_service_browser_profile_management_request test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_self_service_browser_registration_request
  # Get the request context of browser-based registration user flows
  # This endpoint returns a registration request&#39;s context with, for example, error details and other information.  When accessing this endpoint through ORY Kratos&#39; Public API, ensure that cookies are set as they are required for CSRF to work. To prevent token scanning attacks, the public endpoint does not return 404 status codes to prevent scanning attacks.  More information can be found at [ORY Kratos User Login and User Registration Documentation](https://www.ory.sh/docs/next/kratos/self-service/flows/user-login-user-registration).
  # @param request Request is the Registration Request ID  The value for this parameter comes from &#x60;request&#x60; URL Query parameter sent to your application (e.g. &#x60;/registration?request&#x3D;abcde&#x60;).
  # @param [Hash] opts the optional parameters
  # @return [RegistrationRequest]
  describe 'get_self_service_browser_registration_request test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_self_service_error
  # Get user-facing self-service errors
  # This endpoint returns the error associated with a user-facing self service errors.  When accessing this endpoint through ORY Kratos&#39; Public API, ensure that cookies are set as they are required for CSRF to work. To prevent token scanning attacks, the public endpoint does not return 404 status codes to prevent scanning attacks.  More information can be found at [ORY Kratos User User Facing Error Documentation](https://www.ory.sh/docs/kratos/self-service/flows/user-facing-errors).
  # @param [Hash] opts the optional parameters
  # @option opts [String] :id 
  # @return [ErrorContainer]
  describe 'get_self_service_error test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for list_identities
  # List all identities in the system
  # This endpoint returns a login request&#39;s context with, for example, error details and other information.  Learn how identities work in [ORY Kratos&#39; User And Identity Model Documentation](https://www.ory.sh/docs/next/kratos/concepts/identity-user-model).
  # @param [Hash] opts the optional parameters
  # @return [Array<Identity>]
  describe 'list_identities test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for update_identity
  # Update an identity
  # This endpoint updates an identity. It is NOT possible to set an identity&#39;s credentials (password, ...) using this method! A way to achieve that will be introduced in the future.  The full identity payload (except credentials) is expected. This endpoint does not support patching.  Learn how identities work in [ORY Kratos&#39; User And Identity Model Documentation](https://www.ory.sh/docs/next/kratos/concepts/identity-user-model).
  # @param id ID must be set to the ID of identity you want to update
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [Identity]
  describe 'update_identity test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
