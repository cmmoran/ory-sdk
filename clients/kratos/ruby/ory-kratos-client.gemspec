# -*- encoding: utf-8 -*-

=begin
#Ory Identities API

#This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

The version of the OpenAPI document: v1.4.0-alpha.0
Contact: office@ory.sh
Generated by: https://openapi-generator.tech
Generator version: 7.12.0

=end

$:.push File.expand_path("../lib", __FILE__)
require "ory-kratos-client/version"

Gem::Specification.new do |s|
  s.name        = "ory-kratos-client"
  s.version     = OryKratosClient::VERSION
  s.platform    = Gem::Platform::RUBY
  s.authors     = ["ORY GmbH"]
  s.email       = ["opensource@ory.sh"]
  s.homepage    = "https://www.ory.sh"
  s.summary     = "Ory Identities API Ruby Gem"
  s.description = "This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. "
  s.license     = "Apache-2.0"
  s.required_ruby_version = ">= 2.7"
  s.metadata    = {}

  s.add_runtime_dependency 'typhoeus', '~> 1.0', '>= 1.0.1'

  s.add_development_dependency 'rspec', '~> 3.6', '>= 3.6.0'

  s.files         = `find *`.split("\n").uniq.sort.select { |f| !f.empty? }
  s.test_files    = `find spec/*`.split("\n")
  s.executables   = []
  s.require_paths = ["lib"]
end
