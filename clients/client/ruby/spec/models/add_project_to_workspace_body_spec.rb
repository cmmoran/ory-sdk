=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v1.15.5
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
Generator version: 7.7.0

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryClient::AddProjectToWorkspaceBody
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryClient::AddProjectToWorkspaceBody do
  let(:instance) { OryClient::AddProjectToWorkspaceBody.new }

  describe 'test an instance of AddProjectToWorkspaceBody' do
    it 'should create an instance of AddProjectToWorkspaceBody' do
      # uncomment below to test the instance creation
      #expect(instance).to be_instance_of(OryClient::AddProjectToWorkspaceBody)
    end
  end

  describe 'test attribute "environment"' do
    it 'should work' do
      # assertion here. ref: https://rspec.info/features/3-12/rspec-expectations/built-in-matchers/
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["prod", "stage", "dev"])
      # validator.allowable_values.each do |value|
      #   expect { instance.environment = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "project_subscription"' do
    it 'should work' do
      # assertion here. ref: https://rspec.info/features/3-12/rspec-expectations/built-in-matchers/
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["migrate", "ignore"])
      # validator.allowable_values.each do |value|
      #   expect { instance.project_subscription = value }.not_to raise_error
      # end
    end
  end

end
