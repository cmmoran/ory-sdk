<?php
/**
 * Project
 *
 * PHP version 7.4
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
 * The version of the OpenAPI document: v1.12.2
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 * Generator version: 7.4.0
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
 * Project Class Doc Comment
 *
 * @category Class
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<string, mixed>
 */
class Project implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'project';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'corsAdmin' => '\Ory\Client\Model\ProjectCors',
        'corsPublic' => '\Ory\Client\Model\ProjectCors',
        'environment' => 'string',
        'homeRegion' => 'string',
        'id' => 'string',
        'name' => 'string',
        'revisionId' => 'string',
        'services' => '\Ory\Client\Model\ProjectServices',
        'slug' => 'string',
        'state' => 'string',
        'workspaceId' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'corsAdmin' => null,
        'corsPublic' => null,
        'environment' => null,
        'homeRegion' => null,
        'id' => 'uuid',
        'name' => null,
        'revisionId' => 'uuid',
        'services' => null,
        'slug' => null,
        'state' => null,
        'workspaceId' => 'uuid4'
    ];

    /**
      * Array of nullable properties. Used for (de)serialization
      *
      * @var boolean[]
      */
    protected static array $openAPINullables = [
        'corsAdmin' => false,
        'corsPublic' => false,
        'environment' => false,
        'homeRegion' => false,
        'id' => false,
        'name' => false,
        'revisionId' => false,
        'services' => false,
        'slug' => false,
        'state' => false,
        'workspaceId' => true
    ];

    /**
      * If a nullable field gets set to null, insert it here
      *
      * @var boolean[]
      */
    protected array $openAPINullablesSetToNull = [];

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
     * Array of nullable properties
     *
     * @return array
     */
    protected static function openAPINullables(): array
    {
        return self::$openAPINullables;
    }

    /**
     * Array of nullable field names deliberately set to null
     *
     * @return boolean[]
     */
    private function getOpenAPINullablesSetToNull(): array
    {
        return $this->openAPINullablesSetToNull;
    }

    /**
     * Setter - Array of nullable field names deliberately set to null
     *
     * @param boolean[] $openAPINullablesSetToNull
     */
    private function setOpenAPINullablesSetToNull(array $openAPINullablesSetToNull): void
    {
        $this->openAPINullablesSetToNull = $openAPINullablesSetToNull;
    }

    /**
     * Checks if a property is nullable
     *
     * @param string $property
     * @return bool
     */
    public static function isNullable(string $property): bool
    {
        return self::openAPINullables()[$property] ?? false;
    }

    /**
     * Checks if a nullable property is set to null.
     *
     * @param string $property
     * @return bool
     */
    public function isNullableSetToNull(string $property): bool
    {
        return in_array($property, $this->getOpenAPINullablesSetToNull(), true);
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'corsAdmin' => 'cors_admin',
        'corsPublic' => 'cors_public',
        'environment' => 'environment',
        'homeRegion' => 'home_region',
        'id' => 'id',
        'name' => 'name',
        'revisionId' => 'revision_id',
        'services' => 'services',
        'slug' => 'slug',
        'state' => 'state',
        'workspaceId' => 'workspace_id'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'corsAdmin' => 'setCorsAdmin',
        'corsPublic' => 'setCorsPublic',
        'environment' => 'setEnvironment',
        'homeRegion' => 'setHomeRegion',
        'id' => 'setId',
        'name' => 'setName',
        'revisionId' => 'setRevisionId',
        'services' => 'setServices',
        'slug' => 'setSlug',
        'state' => 'setState',
        'workspaceId' => 'setWorkspaceId'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'corsAdmin' => 'getCorsAdmin',
        'corsPublic' => 'getCorsPublic',
        'environment' => 'getEnvironment',
        'homeRegion' => 'getHomeRegion',
        'id' => 'getId',
        'name' => 'getName',
        'revisionId' => 'getRevisionId',
        'services' => 'getServices',
        'slug' => 'getSlug',
        'state' => 'getState',
        'workspaceId' => 'getWorkspaceId'
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

    public const ENVIRONMENT_PROD = 'prod';
    public const ENVIRONMENT_STAGE = 'stage';
    public const ENVIRONMENT_DEV = 'dev';
    public const HOME_REGION_EU_CENTRAL = 'eu-central';
    public const HOME_REGION_US_EAST = 'us-east';
    public const HOME_REGION_US_WEST = 'us-west';
    public const HOME_REGION__GLOBAL = 'global';
    public const STATE_RUNNING = 'running';
    public const STATE_HALTED = 'halted';
    public const STATE_DELETED = 'deleted';

    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getEnvironmentAllowableValues()
    {
        return [
            self::ENVIRONMENT_PROD,
            self::ENVIRONMENT_STAGE,
            self::ENVIRONMENT_DEV,
        ];
    }

    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getHomeRegionAllowableValues()
    {
        return [
            self::HOME_REGION_EU_CENTRAL,
            self::HOME_REGION_US_EAST,
            self::HOME_REGION_US_WEST,
            self::HOME_REGION__GLOBAL,
        ];
    }

    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getStateAllowableValues()
    {
        return [
            self::STATE_RUNNING,
            self::STATE_HALTED,
            self::STATE_DELETED,
        ];
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
        $this->setIfExists('corsAdmin', $data ?? [], null);
        $this->setIfExists('corsPublic', $data ?? [], null);
        $this->setIfExists('environment', $data ?? [], null);
        $this->setIfExists('homeRegion', $data ?? [], null);
        $this->setIfExists('id', $data ?? [], null);
        $this->setIfExists('name', $data ?? [], null);
        $this->setIfExists('revisionId', $data ?? [], null);
        $this->setIfExists('services', $data ?? [], null);
        $this->setIfExists('slug', $data ?? [], null);
        $this->setIfExists('state', $data ?? [], null);
        $this->setIfExists('workspaceId', $data ?? [], null);
    }

    /**
    * Sets $this->container[$variableName] to the given data or to the given default Value; if $variableName
    * is nullable and its value is set to null in the $fields array, then mark it as "set to null" in the
    * $this->openAPINullablesSetToNull array
    *
    * @param string $variableName
    * @param array  $fields
    * @param mixed  $defaultValue
    */
    private function setIfExists(string $variableName, array $fields, $defaultValue): void
    {
        if (self::isNullable($variableName) && array_key_exists($variableName, $fields) && is_null($fields[$variableName])) {
            $this->openAPINullablesSetToNull[] = $variableName;
        }

        $this->container[$variableName] = $fields[$variableName] ?? $defaultValue;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['environment'] === null) {
            $invalidProperties[] = "'environment' can't be null";
        }
        $allowedValues = $this->getEnvironmentAllowableValues();
        if (!is_null($this->container['environment']) && !in_array($this->container['environment'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value '%s' for 'environment', must be one of '%s'",
                $this->container['environment'],
                implode("', '", $allowedValues)
            );
        }

        if ($this->container['homeRegion'] === null) {
            $invalidProperties[] = "'homeRegion' can't be null";
        }
        $allowedValues = $this->getHomeRegionAllowableValues();
        if (!is_null($this->container['homeRegion']) && !in_array($this->container['homeRegion'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value '%s' for 'homeRegion', must be one of '%s'",
                $this->container['homeRegion'],
                implode("', '", $allowedValues)
            );
        }

        if ($this->container['id'] === null) {
            $invalidProperties[] = "'id' can't be null";
        }
        if ($this->container['name'] === null) {
            $invalidProperties[] = "'name' can't be null";
        }
        if ($this->container['revisionId'] === null) {
            $invalidProperties[] = "'revisionId' can't be null";
        }
        if ($this->container['services'] === null) {
            $invalidProperties[] = "'services' can't be null";
        }
        if ($this->container['slug'] === null) {
            $invalidProperties[] = "'slug' can't be null";
        }
        if ($this->container['state'] === null) {
            $invalidProperties[] = "'state' can't be null";
        }
        $allowedValues = $this->getStateAllowableValues();
        if (!is_null($this->container['state']) && !in_array($this->container['state'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value '%s' for 'state', must be one of '%s'",
                $this->container['state'],
                implode("', '", $allowedValues)
            );
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
     * Gets corsAdmin
     *
     * @return \Ory\Client\Model\ProjectCors|null
     */
    public function getCorsAdmin()
    {
        return $this->container['corsAdmin'];
    }

    /**
     * Sets corsAdmin
     *
     * @param \Ory\Client\Model\ProjectCors|null $corsAdmin corsAdmin
     *
     * @return self
     */
    public function setCorsAdmin($corsAdmin)
    {
        if (is_null($corsAdmin)) {
            throw new \InvalidArgumentException('non-nullable corsAdmin cannot be null');
        }
        $this->container['corsAdmin'] = $corsAdmin;

        return $this;
    }

    /**
     * Gets corsPublic
     *
     * @return \Ory\Client\Model\ProjectCors|null
     */
    public function getCorsPublic()
    {
        return $this->container['corsPublic'];
    }

    /**
     * Sets corsPublic
     *
     * @param \Ory\Client\Model\ProjectCors|null $corsPublic corsPublic
     *
     * @return self
     */
    public function setCorsPublic($corsPublic)
    {
        if (is_null($corsPublic)) {
            throw new \InvalidArgumentException('non-nullable corsPublic cannot be null');
        }
        $this->container['corsPublic'] = $corsPublic;

        return $this;
    }

    /**
     * Gets environment
     *
     * @return string
     */
    public function getEnvironment()
    {
        return $this->container['environment'];
    }

    /**
     * Sets environment
     *
     * @param string $environment The environment of the project. prod Production stage Staging dev Development
     *
     * @return self
     */
    public function setEnvironment($environment)
    {
        if (is_null($environment)) {
            throw new \InvalidArgumentException('non-nullable environment cannot be null');
        }
        $allowedValues = $this->getEnvironmentAllowableValues();
        if (!in_array($environment, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value '%s' for 'environment', must be one of '%s'",
                    $environment,
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['environment'] = $environment;

        return $this;
    }

    /**
     * Gets homeRegion
     *
     * @return string
     */
    public function getHomeRegion()
    {
        return $this->container['homeRegion'];
    }

    /**
     * Sets homeRegion
     *
     * @param string $homeRegion The project home region.  This is used to set where the project data is stored and where the project's endpoints are located. eu-central EUCentral us-east USEast us-west USWest global Global
     *
     * @return self
     */
    public function setHomeRegion($homeRegion)
    {
        if (is_null($homeRegion)) {
            throw new \InvalidArgumentException('non-nullable homeRegion cannot be null');
        }
        $allowedValues = $this->getHomeRegionAllowableValues();
        if (!in_array($homeRegion, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value '%s' for 'homeRegion', must be one of '%s'",
                    $homeRegion,
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['homeRegion'] = $homeRegion;

        return $this;
    }

    /**
     * Gets id
     *
     * @return string
     */
    public function getId()
    {
        return $this->container['id'];
    }

    /**
     * Sets id
     *
     * @param string $id The project's ID.
     *
     * @return self
     */
    public function setId($id)
    {
        if (is_null($id)) {
            throw new \InvalidArgumentException('non-nullable id cannot be null');
        }
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets name
     *
     * @return string
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     *
     * @param string $name The name of the project.
     *
     * @return self
     */
    public function setName($name)
    {
        if (is_null($name)) {
            throw new \InvalidArgumentException('non-nullable name cannot be null');
        }
        $this->container['name'] = $name;

        return $this;
    }

    /**
     * Gets revisionId
     *
     * @return string
     */
    public function getRevisionId()
    {
        return $this->container['revisionId'];
    }

    /**
     * Sets revisionId
     *
     * @param string $revisionId The configuration revision ID.
     *
     * @return self
     */
    public function setRevisionId($revisionId)
    {
        if (is_null($revisionId)) {
            throw new \InvalidArgumentException('non-nullable revisionId cannot be null');
        }
        $this->container['revisionId'] = $revisionId;

        return $this;
    }

    /**
     * Gets services
     *
     * @return \Ory\Client\Model\ProjectServices
     */
    public function getServices()
    {
        return $this->container['services'];
    }

    /**
     * Sets services
     *
     * @param \Ory\Client\Model\ProjectServices $services services
     *
     * @return self
     */
    public function setServices($services)
    {
        if (is_null($services)) {
            throw new \InvalidArgumentException('non-nullable services cannot be null');
        }
        $this->container['services'] = $services;

        return $this;
    }

    /**
     * Gets slug
     *
     * @return string
     */
    public function getSlug()
    {
        return $this->container['slug'];
    }

    /**
     * Sets slug
     *
     * @param string $slug The project's slug
     *
     * @return self
     */
    public function setSlug($slug)
    {
        if (is_null($slug)) {
            throw new \InvalidArgumentException('non-nullable slug cannot be null');
        }
        $this->container['slug'] = $slug;

        return $this;
    }

    /**
     * Gets state
     *
     * @return string
     */
    public function getState()
    {
        return $this->container['state'];
    }

    /**
     * Sets state
     *
     * @param string $state The state of the project. running Running halted Halted deleted Deleted
     *
     * @return self
     */
    public function setState($state)
    {
        if (is_null($state)) {
            throw new \InvalidArgumentException('non-nullable state cannot be null');
        }
        $allowedValues = $this->getStateAllowableValues();
        if (!in_array($state, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value '%s' for 'state', must be one of '%s'",
                    $state,
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['state'] = $state;

        return $this;
    }

    /**
     * Gets workspaceId
     *
     * @return string|null
     */
    public function getWorkspaceId()
    {
        return $this->container['workspaceId'];
    }

    /**
     * Sets workspaceId
     *
     * @param string|null $workspaceId workspaceId
     *
     * @return self
     */
    public function setWorkspaceId($workspaceId)
    {
        if (is_null($workspaceId)) {
            array_push($this->openAPINullablesSetToNull, 'workspaceId');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('workspaceId', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }
        $this->container['workspaceId'] = $workspaceId;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset): bool
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
    #[\ReturnTypeWillChange]
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
    public function offsetSet($offset, $value): void
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
    public function offsetUnset($offset): void
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
    #[\ReturnTypeWillChange]
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


