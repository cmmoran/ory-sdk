=begin
#Ory Identities API

#This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

The version of the OpenAPI document: v1.4.0-alpha.0
Contact: office@ory.sh
Generated by: https://openapi-generator.tech
Generator version: 7.12.0

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryKratosClient::UiNodeTextAttributes
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryKratosClient::UiNodeTextAttributes do
  let(:instance) { OryKratosClient::UiNodeTextAttributes.new }

  describe 'test an instance of UiNodeTextAttributes' do
    it 'should create an instance of UiNodeTextAttributes' do
      # uncomment below to test the instance creation
      #expect(instance).to be_instance_of(OryKratosClient::UiNodeTextAttributes)
    end
  end

  describe 'test attribute "id"' do
    it 'should work' do
      # assertion here. ref: https://rspec.info/features/3-12/rspec-expectations/built-in-matchers/
    end
  end

  describe 'test attribute "node_type"' do
    it 'should work' do
      # assertion here. ref: https://rspec.info/features/3-12/rspec-expectations/built-in-matchers/
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["text", "input", "img", "a", "script", "div"])
      # validator.allowable_values.each do |value|
      #   expect { instance.node_type = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "text"' do
    it 'should work' do
      # assertion here. ref: https://rspec.info/features/3-12/rspec-expectations/built-in-matchers/
    end
  end

end
