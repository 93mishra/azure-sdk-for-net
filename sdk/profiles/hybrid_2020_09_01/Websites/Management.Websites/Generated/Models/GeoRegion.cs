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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Geographical region.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GeoRegion : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the GeoRegion class.
        /// </summary>
        public GeoRegion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoRegion class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="description">Region description.</param>
        /// <param name="displayName">Display name for region.</param>
        public GeoRegion(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string description = default(string), string displayName = default(string))
            : base(id, name, kind, type)
        {
            Description = description;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets region description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets display name for region.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

    }
}
