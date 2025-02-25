=begin
#Ory Identities API

#This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

The version of the OpenAPI document: v1.3.7
Contact: office@ory.sh
Generated by: https://openapi-generator.tech
Generator version: 7.7.0

=end

require 'date'
require 'time'

module OryKratosClient
  # Update Registration Request Body
  module UpdateRegistrationFlowBody
    class << self
      # List of class defined in oneOf (OpenAPI v3)
      def openapi_one_of
        [
          :'UpdateRegistrationFlowWithCodeMethod',
          :'UpdateRegistrationFlowWithOidcMethod',
          :'UpdateRegistrationFlowWithPasskeyMethod',
          :'UpdateRegistrationFlowWithPasswordMethod',
          :'UpdateRegistrationFlowWithProfileMethod',
          :'UpdateRegistrationFlowWithWebAuthnMethod'
        ]
      end

      # Discriminator's property name (OpenAPI v3)
      def openapi_discriminator_name
        :'method'
      end

      # Discriminator's mapping (OpenAPI v3)
      def openapi_discriminator_mapping
        {
          :'code' => :'UpdateRegistrationFlowWithCodeMethod',
          :'oidc' => :'UpdateRegistrationFlowWithOidcMethod',
          :'passkey' => :'UpdateRegistrationFlowWithPasskeyMethod',
          :'password' => :'UpdateRegistrationFlowWithPasswordMethod',
          :'profile' => :'UpdateRegistrationFlowWithProfileMethod',
          :'webauthn' => :'UpdateRegistrationFlowWithWebAuthnMethod'
        }
      end

      # Builds the object
      # @param [Mixed] Data to be matched against the list of oneOf items
      # @return [Object] Returns the model or the data itself
      def build(data)
        discriminator_value = data[openapi_discriminator_name]
        return nil if discriminator_value.nil?

        klass = openapi_discriminator_mapping[discriminator_value.to_s.to_sym]
        return nil unless klass

        OryKratosClient.const_get(klass).build_from_hash(data)
      end
    end
  end

end
