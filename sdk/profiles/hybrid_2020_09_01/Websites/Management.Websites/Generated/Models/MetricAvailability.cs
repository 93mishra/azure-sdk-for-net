// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Retention policy of a resource metric.
    /// </summary>
    public partial class MetricAvailability
    {
        /// <summary>
        /// Initializes a new instance of the MetricAvailability class.
        /// </summary>
        public MetricAvailability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricAvailability class.
        /// </summary>
        public MetricAvailability(string timeGrain = default(string), string blobDuration = default(string))
        {
            TimeGrain = timeGrain;
            BlobDuration = blobDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "blobDuration")]
        public string BlobDuration { get; set; }

    }
}
