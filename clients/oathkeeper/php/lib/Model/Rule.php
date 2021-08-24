<?php
/**
 * Rule
 *
 * PHP version 7.3
 *
 * @category Class
 * @package  Ory\Oathkeeper\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * ORY Oathkeeper
 *
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * The version of the OpenAPI document: v0.0.0-alpha.51
 * Contact: hi@ory.am
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.2.1
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace Ory\Oathkeeper\Client\Model;

use \ArrayAccess;
use \Ory\Oathkeeper\Client\ObjectSerializer;

/**
 * Rule Class Doc Comment
 *
 * @category Class
 * @package  Ory\Oathkeeper\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 */
class Rule implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'rule';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'authenticators' => '\Ory\Oathkeeper\Client\Model\RuleHandler[]',
        'authorizer' => '\Ory\Oathkeeper\Client\Model\RuleHandler',
        'description' => 'string',
        'id' => 'string',
        'match' => '\Ory\Oathkeeper\Client\Model\RuleMatch',
        'mutators' => '\Ory\Oathkeeper\Client\Model\RuleHandler[]',
        'upstream' => '\Ory\Oathkeeper\Client\Model\Upstream'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'authenticators' => null,
        'authorizer' => null,
        'description' => null,
        'id' => null,
        'match' => null,
        'mutators' => null,
        'upstream' => null
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
        'authenticators' => 'authenticators',
        'authorizer' => 'authorizer',
        'description' => 'description',
        'id' => 'id',
        'match' => 'match',
        'mutators' => 'mutators',
        'upstream' => 'upstream'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'authenticators' => 'setAuthenticators',
        'authorizer' => 'setAuthorizer',
        'description' => 'setDescription',
        'id' => 'setId',
        'match' => 'setMatch',
        'mutators' => 'setMutators',
        'upstream' => 'setUpstream'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'authenticators' => 'getAuthenticators',
        'authorizer' => 'getAuthorizer',
        'description' => 'getDescription',
        'id' => 'getId',
        'match' => 'getMatch',
        'mutators' => 'getMutators',
        'upstream' => 'getUpstream'
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
        $this->container['authenticators'] = $data['authenticators'] ?? null;
        $this->container['authorizer'] = $data['authorizer'] ?? null;
        $this->container['description'] = $data['description'] ?? null;
        $this->container['id'] = $data['id'] ?? null;
        $this->container['match'] = $data['match'] ?? null;
        $this->container['mutators'] = $data['mutators'] ?? null;
        $this->container['upstream'] = $data['upstream'] ?? null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

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
     * Gets authenticators
     *
     * @return \Ory\Oathkeeper\Client\Model\RuleHandler[]|null
     */
    public function getAuthenticators()
    {
        return $this->container['authenticators'];
    }

    /**
     * Sets authenticators
     *
     * @param \Ory\Oathkeeper\Client\Model\RuleHandler[]|null $authenticators Authenticators is a list of authentication handlers that will try and authenticate the provided credentials. Authenticators are checked iteratively from index 0 to n and if the first authenticator to return a positive result will be the one used.  If you want the rule to first check a specific authenticator  before \"falling back\" to others, have that authenticator as the first item in the array.
     *
     * @return self
     */
    public function setAuthenticators($authenticators)
    {
        $this->container['authenticators'] = $authenticators;

        return $this;
    }

    /**
     * Gets authorizer
     *
     * @return \Ory\Oathkeeper\Client\Model\RuleHandler|null
     */
    public function getAuthorizer()
    {
        return $this->container['authorizer'];
    }

    /**
     * Sets authorizer
     *
     * @param \Ory\Oathkeeper\Client\Model\RuleHandler|null $authorizer authorizer
     *
     * @return self
     */
    public function setAuthorizer($authorizer)
    {
        $this->container['authorizer'] = $authorizer;

        return $this;
    }

    /**
     * Gets description
     *
     * @return string|null
     */
    public function getDescription()
    {
        return $this->container['description'];
    }

    /**
     * Sets description
     *
     * @param string|null $description Description is a human readable description of this rule.
     *
     * @return self
     */
    public function setDescription($description)
    {
        $this->container['description'] = $description;

        return $this;
    }

    /**
     * Gets id
     *
     * @return string|null
     */
    public function getId()
    {
        return $this->container['id'];
    }

    /**
     * Sets id
     *
     * @param string|null $id ID is the unique id of the rule. It can be at most 190 characters long, but the layout of the ID is up to you. You will need this ID later on to update or delete the rule.
     *
     * @return self
     */
    public function setId($id)
    {
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets match
     *
     * @return \Ory\Oathkeeper\Client\Model\RuleMatch|null
     */
    public function getMatch()
    {
        return $this->container['match'];
    }

    /**
     * Sets match
     *
     * @param \Ory\Oathkeeper\Client\Model\RuleMatch|null $match match
     *
     * @return self
     */
    public function setMatch($match)
    {
        $this->container['match'] = $match;

        return $this;
    }

    /**
     * Gets mutators
     *
     * @return \Ory\Oathkeeper\Client\Model\RuleHandler[]|null
     */
    public function getMutators()
    {
        return $this->container['mutators'];
    }

    /**
     * Sets mutators
     *
     * @param \Ory\Oathkeeper\Client\Model\RuleHandler[]|null $mutators Mutators is a list of mutation handlers that transform the HTTP request. A common use case is generating a new set of credentials (e.g. JWT) which then will be forwarded to the upstream server.  Mutations are performed iteratively from index 0 to n and should all succeed in order for the HTTP request to be forwarded.
     *
     * @return self
     */
    public function setMutators($mutators)
    {
        $this->container['mutators'] = $mutators;

        return $this;
    }

    /**
     * Gets upstream
     *
     * @return \Ory\Oathkeeper\Client\Model\Upstream|null
     */
    public function getUpstream()
    {
        return $this->container['upstream'];
    }

    /**
     * Sets upstream
     *
     * @param \Ory\Oathkeeper\Client\Model\Upstream|null $upstream upstream
     *
     * @return self
     */
    public function setUpstream($upstream)
    {
        $this->container['upstream'] = $upstream;

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


