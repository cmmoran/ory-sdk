<?php
/**
 * OidcConfiguration
 *
 * PHP version 7.3
 *
 * @category Class
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.
 *
 * The version of the OpenAPI document: v0.2.0-alpha.16
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.4.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace Ory\Client\Model;

use \ArrayAccess;
use \Ory\Client\ObjectSerializer;

/**
 * OidcConfiguration Class Doc Comment
 *
 * @category Class
 * @description It includes links to several endpoints (for example &#x60;/oauth2/token&#x60;) and exposes information on supported signature algorithms among others.
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 */
class OidcConfiguration implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'oidcConfiguration';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'authorizationEndpoint' => 'string',
        'backchannelLogoutSessionSupported' => 'bool',
        'backchannelLogoutSupported' => 'bool',
        'claimsParameterSupported' => 'bool',
        'claimsSupported' => 'string[]',
        'codeChallengeMethodsSupported' => 'string[]',
        'endSessionEndpoint' => 'string',
        'frontchannelLogoutSessionSupported' => 'bool',
        'frontchannelLogoutSupported' => 'bool',
        'grantTypesSupported' => 'string[]',
        'idTokenSignedResponseAlg' => 'string[]',
        'idTokenSigningAlgValuesSupported' => 'string[]',
        'issuer' => 'string',
        'jwksUri' => 'string',
        'registrationEndpoint' => 'string',
        'requestObjectSigningAlgValuesSupported' => 'string[]',
        'requestParameterSupported' => 'bool',
        'requestUriParameterSupported' => 'bool',
        'requireRequestUriRegistration' => 'bool',
        'responseModesSupported' => 'string[]',
        'responseTypesSupported' => 'string[]',
        'revocationEndpoint' => 'string',
        'scopesSupported' => 'string[]',
        'subjectTypesSupported' => 'string[]',
        'tokenEndpoint' => 'string',
        'tokenEndpointAuthMethodsSupported' => 'string[]',
        'userinfoEndpoint' => 'string',
        'userinfoSignedResponseAlg' => 'string[]',
        'userinfoSigningAlgValuesSupported' => 'string[]'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'authorizationEndpoint' => null,
        'backchannelLogoutSessionSupported' => null,
        'backchannelLogoutSupported' => null,
        'claimsParameterSupported' => null,
        'claimsSupported' => null,
        'codeChallengeMethodsSupported' => null,
        'endSessionEndpoint' => null,
        'frontchannelLogoutSessionSupported' => null,
        'frontchannelLogoutSupported' => null,
        'grantTypesSupported' => null,
        'idTokenSignedResponseAlg' => null,
        'idTokenSigningAlgValuesSupported' => null,
        'issuer' => null,
        'jwksUri' => null,
        'registrationEndpoint' => null,
        'requestObjectSigningAlgValuesSupported' => null,
        'requestParameterSupported' => null,
        'requestUriParameterSupported' => null,
        'requireRequestUriRegistration' => null,
        'responseModesSupported' => null,
        'responseTypesSupported' => null,
        'revocationEndpoint' => null,
        'scopesSupported' => null,
        'subjectTypesSupported' => null,
        'tokenEndpoint' => null,
        'tokenEndpointAuthMethodsSupported' => null,
        'userinfoEndpoint' => null,
        'userinfoSignedResponseAlg' => null,
        'userinfoSigningAlgValuesSupported' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'authorizationEndpoint' => 'authorization_endpoint',
        'backchannelLogoutSessionSupported' => 'backchannel_logout_session_supported',
        'backchannelLogoutSupported' => 'backchannel_logout_supported',
        'claimsParameterSupported' => 'claims_parameter_supported',
        'claimsSupported' => 'claims_supported',
        'codeChallengeMethodsSupported' => 'code_challenge_methods_supported',
        'endSessionEndpoint' => 'end_session_endpoint',
        'frontchannelLogoutSessionSupported' => 'frontchannel_logout_session_supported',
        'frontchannelLogoutSupported' => 'frontchannel_logout_supported',
        'grantTypesSupported' => 'grant_types_supported',
        'idTokenSignedResponseAlg' => 'id_token_signed_response_alg',
        'idTokenSigningAlgValuesSupported' => 'id_token_signing_alg_values_supported',
        'issuer' => 'issuer',
        'jwksUri' => 'jwks_uri',
        'registrationEndpoint' => 'registration_endpoint',
        'requestObjectSigningAlgValuesSupported' => 'request_object_signing_alg_values_supported',
        'requestParameterSupported' => 'request_parameter_supported',
        'requestUriParameterSupported' => 'request_uri_parameter_supported',
        'requireRequestUriRegistration' => 'require_request_uri_registration',
        'responseModesSupported' => 'response_modes_supported',
        'responseTypesSupported' => 'response_types_supported',
        'revocationEndpoint' => 'revocation_endpoint',
        'scopesSupported' => 'scopes_supported',
        'subjectTypesSupported' => 'subject_types_supported',
        'tokenEndpoint' => 'token_endpoint',
        'tokenEndpointAuthMethodsSupported' => 'token_endpoint_auth_methods_supported',
        'userinfoEndpoint' => 'userinfo_endpoint',
        'userinfoSignedResponseAlg' => 'userinfo_signed_response_alg',
        'userinfoSigningAlgValuesSupported' => 'userinfo_signing_alg_values_supported'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'authorizationEndpoint' => 'setAuthorizationEndpoint',
        'backchannelLogoutSessionSupported' => 'setBackchannelLogoutSessionSupported',
        'backchannelLogoutSupported' => 'setBackchannelLogoutSupported',
        'claimsParameterSupported' => 'setClaimsParameterSupported',
        'claimsSupported' => 'setClaimsSupported',
        'codeChallengeMethodsSupported' => 'setCodeChallengeMethodsSupported',
        'endSessionEndpoint' => 'setEndSessionEndpoint',
        'frontchannelLogoutSessionSupported' => 'setFrontchannelLogoutSessionSupported',
        'frontchannelLogoutSupported' => 'setFrontchannelLogoutSupported',
        'grantTypesSupported' => 'setGrantTypesSupported',
        'idTokenSignedResponseAlg' => 'setIdTokenSignedResponseAlg',
        'idTokenSigningAlgValuesSupported' => 'setIdTokenSigningAlgValuesSupported',
        'issuer' => 'setIssuer',
        'jwksUri' => 'setJwksUri',
        'registrationEndpoint' => 'setRegistrationEndpoint',
        'requestObjectSigningAlgValuesSupported' => 'setRequestObjectSigningAlgValuesSupported',
        'requestParameterSupported' => 'setRequestParameterSupported',
        'requestUriParameterSupported' => 'setRequestUriParameterSupported',
        'requireRequestUriRegistration' => 'setRequireRequestUriRegistration',
        'responseModesSupported' => 'setResponseModesSupported',
        'responseTypesSupported' => 'setResponseTypesSupported',
        'revocationEndpoint' => 'setRevocationEndpoint',
        'scopesSupported' => 'setScopesSupported',
        'subjectTypesSupported' => 'setSubjectTypesSupported',
        'tokenEndpoint' => 'setTokenEndpoint',
        'tokenEndpointAuthMethodsSupported' => 'setTokenEndpointAuthMethodsSupported',
        'userinfoEndpoint' => 'setUserinfoEndpoint',
        'userinfoSignedResponseAlg' => 'setUserinfoSignedResponseAlg',
        'userinfoSigningAlgValuesSupported' => 'setUserinfoSigningAlgValuesSupported'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'authorizationEndpoint' => 'getAuthorizationEndpoint',
        'backchannelLogoutSessionSupported' => 'getBackchannelLogoutSessionSupported',
        'backchannelLogoutSupported' => 'getBackchannelLogoutSupported',
        'claimsParameterSupported' => 'getClaimsParameterSupported',
        'claimsSupported' => 'getClaimsSupported',
        'codeChallengeMethodsSupported' => 'getCodeChallengeMethodsSupported',
        'endSessionEndpoint' => 'getEndSessionEndpoint',
        'frontchannelLogoutSessionSupported' => 'getFrontchannelLogoutSessionSupported',
        'frontchannelLogoutSupported' => 'getFrontchannelLogoutSupported',
        'grantTypesSupported' => 'getGrantTypesSupported',
        'idTokenSignedResponseAlg' => 'getIdTokenSignedResponseAlg',
        'idTokenSigningAlgValuesSupported' => 'getIdTokenSigningAlgValuesSupported',
        'issuer' => 'getIssuer',
        'jwksUri' => 'getJwksUri',
        'registrationEndpoint' => 'getRegistrationEndpoint',
        'requestObjectSigningAlgValuesSupported' => 'getRequestObjectSigningAlgValuesSupported',
        'requestParameterSupported' => 'getRequestParameterSupported',
        'requestUriParameterSupported' => 'getRequestUriParameterSupported',
        'requireRequestUriRegistration' => 'getRequireRequestUriRegistration',
        'responseModesSupported' => 'getResponseModesSupported',
        'responseTypesSupported' => 'getResponseTypesSupported',
        'revocationEndpoint' => 'getRevocationEndpoint',
        'scopesSupported' => 'getScopesSupported',
        'subjectTypesSupported' => 'getSubjectTypesSupported',
        'tokenEndpoint' => 'getTokenEndpoint',
        'tokenEndpointAuthMethodsSupported' => 'getTokenEndpointAuthMethodsSupported',
        'userinfoEndpoint' => 'getUserinfoEndpoint',
        'userinfoSignedResponseAlg' => 'getUserinfoSignedResponseAlg',
        'userinfoSigningAlgValuesSupported' => 'getUserinfoSigningAlgValuesSupported'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }


    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['authorizationEndpoint'] = $data['authorizationEndpoint'] ?? null;
        $this->container['backchannelLogoutSessionSupported'] = $data['backchannelLogoutSessionSupported'] ?? null;
        $this->container['backchannelLogoutSupported'] = $data['backchannelLogoutSupported'] ?? null;
        $this->container['claimsParameterSupported'] = $data['claimsParameterSupported'] ?? null;
        $this->container['claimsSupported'] = $data['claimsSupported'] ?? null;
        $this->container['codeChallengeMethodsSupported'] = $data['codeChallengeMethodsSupported'] ?? null;
        $this->container['endSessionEndpoint'] = $data['endSessionEndpoint'] ?? null;
        $this->container['frontchannelLogoutSessionSupported'] = $data['frontchannelLogoutSessionSupported'] ?? null;
        $this->container['frontchannelLogoutSupported'] = $data['frontchannelLogoutSupported'] ?? null;
        $this->container['grantTypesSupported'] = $data['grantTypesSupported'] ?? null;
        $this->container['idTokenSignedResponseAlg'] = $data['idTokenSignedResponseAlg'] ?? null;
        $this->container['idTokenSigningAlgValuesSupported'] = $data['idTokenSigningAlgValuesSupported'] ?? null;
        $this->container['issuer'] = $data['issuer'] ?? null;
        $this->container['jwksUri'] = $data['jwksUri'] ?? null;
        $this->container['registrationEndpoint'] = $data['registrationEndpoint'] ?? null;
        $this->container['requestObjectSigningAlgValuesSupported'] = $data['requestObjectSigningAlgValuesSupported'] ?? null;
        $this->container['requestParameterSupported'] = $data['requestParameterSupported'] ?? null;
        $this->container['requestUriParameterSupported'] = $data['requestUriParameterSupported'] ?? null;
        $this->container['requireRequestUriRegistration'] = $data['requireRequestUriRegistration'] ?? null;
        $this->container['responseModesSupported'] = $data['responseModesSupported'] ?? null;
        $this->container['responseTypesSupported'] = $data['responseTypesSupported'] ?? null;
        $this->container['revocationEndpoint'] = $data['revocationEndpoint'] ?? null;
        $this->container['scopesSupported'] = $data['scopesSupported'] ?? null;
        $this->container['subjectTypesSupported'] = $data['subjectTypesSupported'] ?? null;
        $this->container['tokenEndpoint'] = $data['tokenEndpoint'] ?? null;
        $this->container['tokenEndpointAuthMethodsSupported'] = $data['tokenEndpointAuthMethodsSupported'] ?? null;
        $this->container['userinfoEndpoint'] = $data['userinfoEndpoint'] ?? null;
        $this->container['userinfoSignedResponseAlg'] = $data['userinfoSignedResponseAlg'] ?? null;
        $this->container['userinfoSigningAlgValuesSupported'] = $data['userinfoSigningAlgValuesSupported'] ?? null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['authorizationEndpoint'] === null) {
            $invalidProperties[] = "'authorizationEndpoint' can't be null";
        }
        if ($this->container['idTokenSignedResponseAlg'] === null) {
            $invalidProperties[] = "'idTokenSignedResponseAlg' can't be null";
        }
        if ($this->container['idTokenSigningAlgValuesSupported'] === null) {
            $invalidProperties[] = "'idTokenSigningAlgValuesSupported' can't be null";
        }
        if ($this->container['issuer'] === null) {
            $invalidProperties[] = "'issuer' can't be null";
        }
        if ($this->container['jwksUri'] === null) {
            $invalidProperties[] = "'jwksUri' can't be null";
        }
        if ($this->container['responseTypesSupported'] === null) {
            $invalidProperties[] = "'responseTypesSupported' can't be null";
        }
        if ($this->container['subjectTypesSupported'] === null) {
            $invalidProperties[] = "'subjectTypesSupported' can't be null";
        }
        if ($this->container['tokenEndpoint'] === null) {
            $invalidProperties[] = "'tokenEndpoint' can't be null";
        }
        if ($this->container['userinfoSignedResponseAlg'] === null) {
            $invalidProperties[] = "'userinfoSignedResponseAlg' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets authorizationEndpoint
     *
     * @return string
     */
    public function getAuthorizationEndpoint()
    {
        return $this->container['authorizationEndpoint'];
    }

    /**
     * Sets authorizationEndpoint
     *
     * @param string $authorizationEndpoint URL of the OP's OAuth 2.0 Authorization Endpoint.
     *
     * @return self
     */
    public function setAuthorizationEndpoint($authorizationEndpoint)
    {
        $this->container['authorizationEndpoint'] = $authorizationEndpoint;

        return $this;
    }

    /**
     * Gets backchannelLogoutSessionSupported
     *
     * @return bool|null
     */
    public function getBackchannelLogoutSessionSupported()
    {
        return $this->container['backchannelLogoutSessionSupported'];
    }

    /**
     * Sets backchannelLogoutSessionSupported
     *
     * @param bool|null $backchannelLogoutSessionSupported Boolean value specifying whether the OP can pass a sid (session ID) Claim in the Logout Token to identify the RP session with the OP. If supported, the sid Claim is also included in ID Tokens issued by the OP
     *
     * @return self
     */
    public function setBackchannelLogoutSessionSupported($backchannelLogoutSessionSupported)
    {
        $this->container['backchannelLogoutSessionSupported'] = $backchannelLogoutSessionSupported;

        return $this;
    }

    /**
     * Gets backchannelLogoutSupported
     *
     * @return bool|null
     */
    public function getBackchannelLogoutSupported()
    {
        return $this->container['backchannelLogoutSupported'];
    }

    /**
     * Sets backchannelLogoutSupported
     *
     * @param bool|null $backchannelLogoutSupported Boolean value specifying whether the OP supports back-channel logout, with true indicating support.
     *
     * @return self
     */
    public function setBackchannelLogoutSupported($backchannelLogoutSupported)
    {
        $this->container['backchannelLogoutSupported'] = $backchannelLogoutSupported;

        return $this;
    }

    /**
     * Gets claimsParameterSupported
     *
     * @return bool|null
     */
    public function getClaimsParameterSupported()
    {
        return $this->container['claimsParameterSupported'];
    }

    /**
     * Sets claimsParameterSupported
     *
     * @param bool|null $claimsParameterSupported Boolean value specifying whether the OP supports use of the claims parameter, with true indicating support.
     *
     * @return self
     */
    public function setClaimsParameterSupported($claimsParameterSupported)
    {
        $this->container['claimsParameterSupported'] = $claimsParameterSupported;

        return $this;
    }

    /**
     * Gets claimsSupported
     *
     * @return string[]|null
     */
    public function getClaimsSupported()
    {
        return $this->container['claimsSupported'];
    }

    /**
     * Sets claimsSupported
     *
     * @param string[]|null $claimsSupported JSON array containing a list of the Claim Names of the Claims that the OpenID Provider MAY be able to supply values for. Note that for privacy or other reasons, this might not be an exhaustive list.
     *
     * @return self
     */
    public function setClaimsSupported($claimsSupported)
    {
        $this->container['claimsSupported'] = $claimsSupported;

        return $this;
    }

    /**
     * Gets codeChallengeMethodsSupported
     *
     * @return string[]|null
     */
    public function getCodeChallengeMethodsSupported()
    {
        return $this->container['codeChallengeMethodsSupported'];
    }

    /**
     * Sets codeChallengeMethodsSupported
     *
     * @param string[]|null $codeChallengeMethodsSupported JSON array containing a list of Proof Key for Code Exchange (PKCE) [RFC7636] code challenge methods supported by this authorization server.
     *
     * @return self
     */
    public function setCodeChallengeMethodsSupported($codeChallengeMethodsSupported)
    {
        $this->container['codeChallengeMethodsSupported'] = $codeChallengeMethodsSupported;

        return $this;
    }

    /**
     * Gets endSessionEndpoint
     *
     * @return string|null
     */
    public function getEndSessionEndpoint()
    {
        return $this->container['endSessionEndpoint'];
    }

    /**
     * Sets endSessionEndpoint
     *
     * @param string|null $endSessionEndpoint URL at the OP to which an RP can perform a redirect to request that the End-User be logged out at the OP.
     *
     * @return self
     */
    public function setEndSessionEndpoint($endSessionEndpoint)
    {
        $this->container['endSessionEndpoint'] = $endSessionEndpoint;

        return $this;
    }

    /**
     * Gets frontchannelLogoutSessionSupported
     *
     * @return bool|null
     */
    public function getFrontchannelLogoutSessionSupported()
    {
        return $this->container['frontchannelLogoutSessionSupported'];
    }

    /**
     * Sets frontchannelLogoutSessionSupported
     *
     * @param bool|null $frontchannelLogoutSessionSupported Boolean value specifying whether the OP can pass iss (issuer) and sid (session ID) query parameters to identify the RP session with the OP when the frontchannel_logout_uri is used. If supported, the sid Claim is also included in ID Tokens issued by the OP.
     *
     * @return self
     */
    public function setFrontchannelLogoutSessionSupported($frontchannelLogoutSessionSupported)
    {
        $this->container['frontchannelLogoutSessionSupported'] = $frontchannelLogoutSessionSupported;

        return $this;
    }

    /**
     * Gets frontchannelLogoutSupported
     *
     * @return bool|null
     */
    public function getFrontchannelLogoutSupported()
    {
        return $this->container['frontchannelLogoutSupported'];
    }

    /**
     * Sets frontchannelLogoutSupported
     *
     * @param bool|null $frontchannelLogoutSupported Boolean value specifying whether the OP supports HTTP-based logout, with true indicating support.
     *
     * @return self
     */
    public function setFrontchannelLogoutSupported($frontchannelLogoutSupported)
    {
        $this->container['frontchannelLogoutSupported'] = $frontchannelLogoutSupported;

        return $this;
    }

    /**
     * Gets grantTypesSupported
     *
     * @return string[]|null
     */
    public function getGrantTypesSupported()
    {
        return $this->container['grantTypesSupported'];
    }

    /**
     * Sets grantTypesSupported
     *
     * @param string[]|null $grantTypesSupported JSON array containing a list of the OAuth 2.0 Grant Type values that this OP supports.
     *
     * @return self
     */
    public function setGrantTypesSupported($grantTypesSupported)
    {
        $this->container['grantTypesSupported'] = $grantTypesSupported;

        return $this;
    }

    /**
     * Gets idTokenSignedResponseAlg
     *
     * @return string[]
     */
    public function getIdTokenSignedResponseAlg()
    {
        return $this->container['idTokenSignedResponseAlg'];
    }

    /**
     * Sets idTokenSignedResponseAlg
     *
     * @param string[] $idTokenSignedResponseAlg Algorithm used to sign OpenID Connect ID Tokens.
     *
     * @return self
     */
    public function setIdTokenSignedResponseAlg($idTokenSignedResponseAlg)
    {
        $this->container['idTokenSignedResponseAlg'] = $idTokenSignedResponseAlg;

        return $this;
    }

    /**
     * Gets idTokenSigningAlgValuesSupported
     *
     * @return string[]
     */
    public function getIdTokenSigningAlgValuesSupported()
    {
        return $this->container['idTokenSigningAlgValuesSupported'];
    }

    /**
     * Sets idTokenSigningAlgValuesSupported
     *
     * @param string[] $idTokenSigningAlgValuesSupported JSON array containing a list of the JWS signing algorithms (alg values) supported by the OP for the ID Token to encode the Claims in a JWT.
     *
     * @return self
     */
    public function setIdTokenSigningAlgValuesSupported($idTokenSigningAlgValuesSupported)
    {
        $this->container['idTokenSigningAlgValuesSupported'] = $idTokenSigningAlgValuesSupported;

        return $this;
    }

    /**
     * Gets issuer
     *
     * @return string
     */
    public function getIssuer()
    {
        return $this->container['issuer'];
    }

    /**
     * Sets issuer
     *
     * @param string $issuer URL using the https scheme with no query or fragment component that the OP asserts as its IssuerURL Identifier. If IssuerURL discovery is supported , this value MUST be identical to the issuer value returned by WebFinger. This also MUST be identical to the iss Claim value in ID Tokens issued from this IssuerURL.
     *
     * @return self
     */
    public function setIssuer($issuer)
    {
        $this->container['issuer'] = $issuer;

        return $this;
    }

    /**
     * Gets jwksUri
     *
     * @return string
     */
    public function getJwksUri()
    {
        return $this->container['jwksUri'];
    }

    /**
     * Sets jwksUri
     *
     * @param string $jwksUri URL of the OP's JSON Web Key Set [JWK] document. This contains the signing key(s) the RP uses to validate signatures from the OP. The JWK Set MAY also contain the Server's encryption key(s), which are used by RPs to encrypt requests to the Server. When both signing and encryption keys are made available, a use (Key Use) parameter value is REQUIRED for all keys in the referenced JWK Set to indicate each key's intended usage. Although some algorithms allow the same key to be used for both signatures and encryption, doing so is NOT RECOMMENDED, as it is less secure. The JWK x5c parameter MAY be used to provide X.509 representations of keys provided. When used, the bare key values MUST still be present and MUST match those in the certificate.
     *
     * @return self
     */
    public function setJwksUri($jwksUri)
    {
        $this->container['jwksUri'] = $jwksUri;

        return $this;
    }

    /**
     * Gets registrationEndpoint
     *
     * @return string|null
     */
    public function getRegistrationEndpoint()
    {
        return $this->container['registrationEndpoint'];
    }

    /**
     * Sets registrationEndpoint
     *
     * @param string|null $registrationEndpoint URL of the OP's Dynamic Client Registration Endpoint.
     *
     * @return self
     */
    public function setRegistrationEndpoint($registrationEndpoint)
    {
        $this->container['registrationEndpoint'] = $registrationEndpoint;

        return $this;
    }

    /**
     * Gets requestObjectSigningAlgValuesSupported
     *
     * @return string[]|null
     */
    public function getRequestObjectSigningAlgValuesSupported()
    {
        return $this->container['requestObjectSigningAlgValuesSupported'];
    }

    /**
     * Sets requestObjectSigningAlgValuesSupported
     *
     * @param string[]|null $requestObjectSigningAlgValuesSupported JSON array containing a list of the JWS signing algorithms (alg values) supported by the OP for Request Objects, which are described in Section 6.1 of OpenID Connect Core 1.0 [OpenID.Core]. These algorithms are used both when the Request Object is passed by value (using the request parameter) and when it is passed by reference (using the request_uri parameter).
     *
     * @return self
     */
    public function setRequestObjectSigningAlgValuesSupported($requestObjectSigningAlgValuesSupported)
    {
        $this->container['requestObjectSigningAlgValuesSupported'] = $requestObjectSigningAlgValuesSupported;

        return $this;
    }

    /**
     * Gets requestParameterSupported
     *
     * @return bool|null
     */
    public function getRequestParameterSupported()
    {
        return $this->container['requestParameterSupported'];
    }

    /**
     * Sets requestParameterSupported
     *
     * @param bool|null $requestParameterSupported Boolean value specifying whether the OP supports use of the request parameter, with true indicating support.
     *
     * @return self
     */
    public function setRequestParameterSupported($requestParameterSupported)
    {
        $this->container['requestParameterSupported'] = $requestParameterSupported;

        return $this;
    }

    /**
     * Gets requestUriParameterSupported
     *
     * @return bool|null
     */
    public function getRequestUriParameterSupported()
    {
        return $this->container['requestUriParameterSupported'];
    }

    /**
     * Sets requestUriParameterSupported
     *
     * @param bool|null $requestUriParameterSupported Boolean value specifying whether the OP supports use of the request_uri parameter, with true indicating support.
     *
     * @return self
     */
    public function setRequestUriParameterSupported($requestUriParameterSupported)
    {
        $this->container['requestUriParameterSupported'] = $requestUriParameterSupported;

        return $this;
    }

    /**
     * Gets requireRequestUriRegistration
     *
     * @return bool|null
     */
    public function getRequireRequestUriRegistration()
    {
        return $this->container['requireRequestUriRegistration'];
    }

    /**
     * Sets requireRequestUriRegistration
     *
     * @param bool|null $requireRequestUriRegistration Boolean value specifying whether the OP requires any request_uri values used to be pre-registered using the request_uris registration parameter.
     *
     * @return self
     */
    public function setRequireRequestUriRegistration($requireRequestUriRegistration)
    {
        $this->container['requireRequestUriRegistration'] = $requireRequestUriRegistration;

        return $this;
    }

    /**
     * Gets responseModesSupported
     *
     * @return string[]|null
     */
    public function getResponseModesSupported()
    {
        return $this->container['responseModesSupported'];
    }

    /**
     * Sets responseModesSupported
     *
     * @param string[]|null $responseModesSupported JSON array containing a list of the OAuth 2.0 response_mode values that this OP supports.
     *
     * @return self
     */
    public function setResponseModesSupported($responseModesSupported)
    {
        $this->container['responseModesSupported'] = $responseModesSupported;

        return $this;
    }

    /**
     * Gets responseTypesSupported
     *
     * @return string[]
     */
    public function getResponseTypesSupported()
    {
        return $this->container['responseTypesSupported'];
    }

    /**
     * Sets responseTypesSupported
     *
     * @param string[] $responseTypesSupported JSON array containing a list of the OAuth 2.0 response_type values that this OP supports. Dynamic OpenID Providers MUST support the code, id_token, and the token id_token Response Type values.
     *
     * @return self
     */
    public function setResponseTypesSupported($responseTypesSupported)
    {
        $this->container['responseTypesSupported'] = $responseTypesSupported;

        return $this;
    }

    /**
     * Gets revocationEndpoint
     *
     * @return string|null
     */
    public function getRevocationEndpoint()
    {
        return $this->container['revocationEndpoint'];
    }

    /**
     * Sets revocationEndpoint
     *
     * @param string|null $revocationEndpoint URL of the authorization server's OAuth 2.0 revocation endpoint.
     *
     * @return self
     */
    public function setRevocationEndpoint($revocationEndpoint)
    {
        $this->container['revocationEndpoint'] = $revocationEndpoint;

        return $this;
    }

    /**
     * Gets scopesSupported
     *
     * @return string[]|null
     */
    public function getScopesSupported()
    {
        return $this->container['scopesSupported'];
    }

    /**
     * Sets scopesSupported
     *
     * @param string[]|null $scopesSupported SON array containing a list of the OAuth 2.0 [RFC6749] scope values that this server supports. The server MUST support the openid scope value. Servers MAY choose not to advertise some supported scope values even when this parameter is used
     *
     * @return self
     */
    public function setScopesSupported($scopesSupported)
    {
        $this->container['scopesSupported'] = $scopesSupported;

        return $this;
    }

    /**
     * Gets subjectTypesSupported
     *
     * @return string[]
     */
    public function getSubjectTypesSupported()
    {
        return $this->container['subjectTypesSupported'];
    }

    /**
     * Sets subjectTypesSupported
     *
     * @param string[] $subjectTypesSupported JSON array containing a list of the Subject Identifier types that this OP supports. Valid types include pairwise and public.
     *
     * @return self
     */
    public function setSubjectTypesSupported($subjectTypesSupported)
    {
        $this->container['subjectTypesSupported'] = $subjectTypesSupported;

        return $this;
    }

    /**
     * Gets tokenEndpoint
     *
     * @return string
     */
    public function getTokenEndpoint()
    {
        return $this->container['tokenEndpoint'];
    }

    /**
     * Sets tokenEndpoint
     *
     * @param string $tokenEndpoint URL of the OP's OAuth 2.0 Token Endpoint
     *
     * @return self
     */
    public function setTokenEndpoint($tokenEndpoint)
    {
        $this->container['tokenEndpoint'] = $tokenEndpoint;

        return $this;
    }

    /**
     * Gets tokenEndpointAuthMethodsSupported
     *
     * @return string[]|null
     */
    public function getTokenEndpointAuthMethodsSupported()
    {
        return $this->container['tokenEndpointAuthMethodsSupported'];
    }

    /**
     * Sets tokenEndpointAuthMethodsSupported
     *
     * @param string[]|null $tokenEndpointAuthMethodsSupported JSON array containing a list of Client Authentication methods supported by this Token Endpoint. The options are client_secret_post, client_secret_basic, client_secret_jwt, and private_key_jwt, as described in Section 9 of OpenID Connect Core 1.0
     *
     * @return self
     */
    public function setTokenEndpointAuthMethodsSupported($tokenEndpointAuthMethodsSupported)
    {
        $this->container['tokenEndpointAuthMethodsSupported'] = $tokenEndpointAuthMethodsSupported;

        return $this;
    }

    /**
     * Gets userinfoEndpoint
     *
     * @return string|null
     */
    public function getUserinfoEndpoint()
    {
        return $this->container['userinfoEndpoint'];
    }

    /**
     * Sets userinfoEndpoint
     *
     * @param string|null $userinfoEndpoint URL of the OP's UserInfo Endpoint.
     *
     * @return self
     */
    public function setUserinfoEndpoint($userinfoEndpoint)
    {
        $this->container['userinfoEndpoint'] = $userinfoEndpoint;

        return $this;
    }

    /**
     * Gets userinfoSignedResponseAlg
     *
     * @return string[]
     */
    public function getUserinfoSignedResponseAlg()
    {
        return $this->container['userinfoSignedResponseAlg'];
    }

    /**
     * Sets userinfoSignedResponseAlg
     *
     * @param string[] $userinfoSignedResponseAlg Algorithm used to sign OpenID Connect Userinfo Responses.
     *
     * @return self
     */
    public function setUserinfoSignedResponseAlg($userinfoSignedResponseAlg)
    {
        $this->container['userinfoSignedResponseAlg'] = $userinfoSignedResponseAlg;

        return $this;
    }

    /**
     * Gets userinfoSigningAlgValuesSupported
     *
     * @return string[]|null
     */
    public function getUserinfoSigningAlgValuesSupported()
    {
        return $this->container['userinfoSigningAlgValuesSupported'];
    }

    /**
     * Sets userinfoSigningAlgValuesSupported
     *
     * @param string[]|null $userinfoSigningAlgValuesSupported JSON array containing a list of the JWS [JWS] signing algorithms (alg values) [JWA] supported by the UserInfo Endpoint to encode the Claims in a JWT [JWT].
     *
     * @return self
     */
    public function setUserinfoSigningAlgValuesSupported($userinfoSigningAlgValuesSupported)
    {
        $this->container['userinfoSigningAlgValuesSupported'] = $userinfoSigningAlgValuesSupported;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    public function jsonSerialize()
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


