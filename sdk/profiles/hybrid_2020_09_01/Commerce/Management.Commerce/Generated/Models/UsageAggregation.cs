// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Commerce.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the usageAggregation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UsageAggregation
    {
        /// <summary>
        /// Initializes a new instance of the UsageAggregation class.
        /// </summary>
        public UsageAggregation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageAggregation class.
        /// </summary>
        /// <param name="id">Unique Id for the usage aggregate.</param>
        /// <param name="name">Name of the usage aggregate.</param>
        /// <param name="type">Type of the resource being returned.</param>
        /// <param name="subscriptionId">The subscription identifier for the
        /// Azure user.</param>
        /// <param name="meterId">Unique ID for the resource that was consumed
        /// (aka ResourceID).</param>
        /// <param name="usageStartTime">UTC start time for the usage bucket to
        /// which this usage aggregate belongs.</param>
        /// <param name="usageEndTime">UTC end time for the usage bucket to
        /// which this usage aggregate belongs.</param>
        /// <param name="quantity">The amount of the resource consumption that
        /// occurred in this time frame.</param>
        /// <param name="unit">The unit in which the usage for this resource is
        /// being counted, e.g. Hours, GB.</param>
        /// <param name="meterName">Friendly name of the resource being
        /// consumed.</param>
        /// <param name="meterCategory">Category of the consumed
        /// resource.</param>
        /// <param name="meterSubCategory">Sub-category of the consumed
        /// resource.</param>
        /// <param name="meterRegion">Region of the meterId used for billing
        /// purposes</param>
        /// <param name="infoFields">Key-value pairs of instance details
        /// (legacy format).</param>
        /// <param name="instanceData">Key-value pairs of instance details
        /// represented as a string.</param>
        public UsageAggregation(string id = default(string), string name = default(string), string type = default(string), System.Guid? subscriptionId = default(System.Guid?), string meterId = default(string), System.DateTime? usageStartTime = default(System.DateTime?), System.DateTime? usageEndTime = default(System.DateTime?), double? quantity = default(double?), string unit = default(string), string meterName = default(string), string meterCategory = default(string), string meterSubCategory = default(string), string meterRegion = default(string), InfoField infoFields = default(InfoField), string instanceData = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            SubscriptionId = subscriptionId;
            MeterId = meterId;
            UsageStartTime = usageStartTime;
            UsageEndTime = usageEndTime;
            Quantity = quantity;
            Unit = unit;
            MeterName = meterName;
            MeterCategory = meterCategory;
            MeterSubCategory = meterSubCategory;
            MeterRegion = meterRegion;
            InfoFields = infoFields;
            InstanceData = instanceData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique Id for the usage aggregate.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets name of the usage aggregate.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type of the resource being returned.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the subscription identifier for the Azure user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public System.Guid? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets unique ID for the resource that was consumed (aka
        /// ResourceID).
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterId")]
        public string MeterId { get; set; }

        /// <summary>
        /// Gets or sets UTC start time for the usage bucket to which this
        /// usage aggregate belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageStartTime")]
        public System.DateTime? UsageStartTime { get; set; }

        /// <summary>
        /// Gets or sets UTC end time for the usage bucket to which this usage
        /// aggregate belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageEndTime")]
        public System.DateTime? UsageEndTime { get; set; }

        /// <summary>
        /// Gets or sets the amount of the resource consumption that occurred
        /// in this time frame.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit in which the usage for this resource is being
        /// counted, e.g. Hours, GB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets friendly name of the resource being consumed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterName")]
        public string MeterName { get; set; }

        /// <summary>
        /// Gets or sets category of the consumed resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterCategory")]
        public string MeterCategory { get; set; }

        /// <summary>
        /// Gets or sets sub-category of the consumed resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterSubCategory")]
        public string MeterSubCategory { get; set; }

        /// <summary>
        /// Gets or sets region of the meterId used for billing purposes
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterRegion")]
        public string MeterRegion { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of instance details (legacy format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.infoFields")]
        public InfoField InfoFields { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of instance details represented as a
        /// string.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceData")]
        public string InstanceData { get; set; }

    }
}
