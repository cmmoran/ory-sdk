<?php
/**
 * NormalizedProject
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
 * NormalizedProject Class Doc Comment
 *
 * @category Class
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<string, mixed>
 */
class NormalizedProject implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'normalizedProject';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'createdAt' => '\DateTime',
        'currentRevision' => '\Ory\Client\Model\NormalizedProjectRevision',
        'environment' => 'string',
        'homeRegion' => 'string',
        'hosts' => 'string[]',
        'id' => 'string',
        'slug' => 'string',
        'state' => 'string',
        'subscriptionId' => 'string',
        'subscriptionPlan' => 'string',
        'updatedAt' => '\DateTime',
        'workspace' => '\Ory\Client\Model\Workspace',
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
        'createdAt' => 'date-time',
        'currentRevision' => null,
        'environment' => null,
        'homeRegion' => null,
        'hosts' => null,
        'id' => 'uuid',
        'slug' => null,
        'state' => null,
        'subscriptionId' => 'uuid4',
        'subscriptionPlan' => null,
        'updatedAt' => 'date-time',
        'workspace' => null,
        'workspaceId' => 'uuid4'
    ];

    /**
      * Array of nullable properties. Used for (de)serialization
      *
      * @var boolean[]
      */
    protected static array $openAPINullables = [
        'createdAt' => false,
        'currentRevision' => false,
        'environment' => false,
        'homeRegion' => false,
        'hosts' => false,
        'id' => false,
        'slug' => false,
        'state' => false,
        'subscriptionId' => true,
        'subscriptionPlan' => true,
        'updatedAt' => false,
        'workspace' => false,
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
        'createdAt' => 'created_at',
        'currentRevision' => 'current_revision',
        'environment' => 'environment',
        'homeRegion' => 'home_region',
        'hosts' => 'hosts',
        'id' => 'id',
        'slug' => 'slug',
        'state' => 'state',
        'subscriptionId' => 'subscription_id',
        'subscriptionPlan' => 'subscription_plan',
        'updatedAt' => 'updated_at',
        'workspace' => 'workspace',
        'workspaceId' => 'workspace_id'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'createdAt' => 'setCreatedAt',
        'currentRevision' => 'setCurrentRevision',
        'environment' => 'setEnvironment',
        'homeRegion' => 'setHomeRegion',
        'hosts' => 'setHosts',
        'id' => 'setId',
        'slug' => 'setSlug',
        'state' => 'setState',
        'subscriptionId' => 'setSubscriptionId',
        'subscriptionPlan' => 'setSubscriptionPlan',
        'updatedAt' => 'setUpdatedAt',
        'workspace' => 'setWorkspace',
        'workspaceId' => 'setWorkspaceId'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'createdAt' => 'getCreatedAt',
        'currentRevision' => 'getCurrentRevision',
        'environment' => 'getEnvironment',
        'homeRegion' => 'getHomeRegion',
        'hosts' => 'getHosts',
        'id' => 'getId',
        'slug' => 'getSlug',
        'state' => 'getState',
        'subscriptionId' => 'getSubscriptionId',
        'subscriptionPlan' => 'getSubscriptionPlan',
        'updatedAt' => 'getUpdatedAt',
        'workspace' => 'getWorkspace',
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
        $this->setIfExists('createdAt', $data ?? [], null);
        $this->setIfExists('currentRevision', $data ?? [], null);
        $this->setIfExists('environment', $data ?? [], null);
        $this->setIfExists('homeRegion', $data ?? [], null);
        $this->setIfExists('hosts', $data ?? [], null);
        $this->setIfExists('id', $data ?? [], null);
        $this->setIfExists('slug', $data ?? [], null);
        $this->setIfExists('state', $data ?? [], null);
        $this->setIfExists('subscriptionId', $data ?? [], null);
        $this->setIfExists('subscriptionPlan', $data ?? [], null);
        $this->setIfExists('updatedAt', $data ?? [], null);
        $this->setIfExists('workspace', $data ?? [], null);
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

        if ($this->container['createdAt'] === null) {
            $invalidProperties[] = "'createdAt' can't be null";
        }
        if ($this->container['currentRevision'] === null) {
            $invalidProperties[] = "'currentRevision' can't be null";
        }
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

        if ($this->container['hosts'] === null) {
            $invalidProperties[] = "'hosts' can't be null";
        }
        if ($this->container['id'] === null) {
            $invalidProperties[] = "'id' can't be null";
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

        if ($this->container['updatedAt'] === null) {
            $invalidProperties[] = "'updatedAt' can't be null";
        }
        if ($this->container['workspaceId'] === null) {
            $invalidProperties[] = "'workspaceId' can't be null";
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
     * Gets createdAt
     *
     * @return \DateTime
     */
    public function getCreatedAt()
    {
        return $this->container['createdAt'];
    }

    /**
     * Sets createdAt
     *
     * @param \DateTime $createdAt The Project's Creation Date
     *
     * @return self
     */
    public function setCreatedAt($createdAt)
    {
        if (is_null($createdAt)) {
            throw new \InvalidArgumentException('non-nullable createdAt cannot be null');
        }
        $this->container['createdAt'] = $createdAt;

        return $this;
    }

    /**
     * Gets currentRevision
     *
     * @return \Ory\Client\Model\NormalizedProjectRevision
     */
    public function getCurrentRevision()
    {
        return $this->container['currentRevision'];
    }

    /**
     * Sets currentRevision
     *
     * @param \Ory\Client\Model\NormalizedProjectRevision $currentRevision currentRevision
     *
     * @return self
     */
    public function setCurrentRevision($currentRevision)
    {
        if (is_null($currentRevision)) {
            throw new \InvalidArgumentException('non-nullable currentRevision cannot be null');
        }
        $this->container['currentRevision'] = $currentRevision;

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
     * @param string $homeRegion The project's data home region. eu-central EUCentral us-east USEast us-west USWest global Global
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
     * Gets hosts
     *
     * @return string[]
     */
    public function getHosts()
    {
        return $this->container['hosts'];
    }

    /**
     * Sets hosts
     *
     * @param string[] $hosts hosts
     *
     * @return self
     */
    public function setHosts($hosts)
    {
        if (is_null($hosts)) {
            throw new \InvalidArgumentException('non-nullable hosts cannot be null');
        }
        $this->container['hosts'] = $hosts;

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
     * Gets subscriptionId
     *
     * @return string|null
     */
    public function getSubscriptionId()
    {
        return $this->container['subscriptionId'];
    }

    /**
     * Sets subscriptionId
     *
     * @param string|null $subscriptionId subscriptionId
     *
     * @return self
     */
    public function setSubscriptionId($subscriptionId)
    {
        if (is_null($subscriptionId)) {
            array_push($this->openAPINullablesSetToNull, 'subscriptionId');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('subscriptionId', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }
        $this->container['subscriptionId'] = $subscriptionId;

        return $this;
    }

    /**
     * Gets subscriptionPlan
     *
     * @return string|null
     */
    public function getSubscriptionPlan()
    {
        return $this->container['subscriptionPlan'];
    }

    /**
     * Sets subscriptionPlan
     *
     * @param string|null $subscriptionPlan subscriptionPlan
     *
     * @return self
     */
    public function setSubscriptionPlan($subscriptionPlan)
    {
        if (is_null($subscriptionPlan)) {
            array_push($this->openAPINullablesSetToNull, 'subscriptionPlan');
        } else {
            $nullablesSetToNull = $this->getOpenAPINullablesSetToNull();
            $index = array_search('subscriptionPlan', $nullablesSetToNull);
            if ($index !== FALSE) {
                unset($nullablesSetToNull[$index]);
                $this->setOpenAPINullablesSetToNull($nullablesSetToNull);
            }
        }
        $this->container['subscriptionPlan'] = $subscriptionPlan;

        return $this;
    }

    /**
     * Gets updatedAt
     *
     * @return \DateTime
     */
    public function getUpdatedAt()
    {
        return $this->container['updatedAt'];
    }

    /**
     * Sets updatedAt
     *
     * @param \DateTime $updatedAt Last Time Project was Updated
     *
     * @return self
     */
    public function setUpdatedAt($updatedAt)
    {
        if (is_null($updatedAt)) {
            throw new \InvalidArgumentException('non-nullable updatedAt cannot be null');
        }
        $this->container['updatedAt'] = $updatedAt;

        return $this;
    }

    /**
     * Gets workspace
     *
     * @return \Ory\Client\Model\Workspace|null
     */
    public function getWorkspace()
    {
        return $this->container['workspace'];
    }

    /**
     * Sets workspace
     *
     * @param \Ory\Client\Model\Workspace|null $workspace workspace
     *
     * @return self
     */
    public function setWorkspace($workspace)
    {
        if (is_null($workspace)) {
            throw new \InvalidArgumentException('non-nullable workspace cannot be null');
        }
        $this->container['workspace'] = $workspace;

        return $this;
    }

    /**
     * Gets workspaceId
     *
     * @return string
     */
    public function getWorkspaceId()
    {
        return $this->container['workspaceId'];
    }

    /**
     * Sets workspaceId
     *
     * @param string $workspaceId workspaceId
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


