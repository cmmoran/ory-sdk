=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v1.3.0
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryClient::CreateSubscriptionBody
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryClient::CreateSubscriptionBody do
  let(:instance) { OryClient::CreateSubscriptionBody.new }

  describe 'test an instance of CreateSubscriptionBody' do
    it 'should create an instance of CreateSubscriptionBody' do
      expect(instance).to be_instance_of(OryClient::CreateSubscriptionBody)
    end
  end
  describe 'test attribute "currency"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["usd", "eur"])
      # validator.allowable_values.each do |value|
      #   expect { instance.currency = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "interval"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["monthly", "yearly"])
      # validator.allowable_values.each do |value|
      #   expect { instance.interval = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "plan"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "provision_first_project"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "return_to"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
