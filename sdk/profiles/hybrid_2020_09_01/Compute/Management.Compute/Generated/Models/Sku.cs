// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set sku. NOTE: If the new VM SKU is
    /// not supported on the hardware the scale set is currently on, you need
    /// to deallocate the VMs in the scale set before you modify the SKU name.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The sku name.</param>
        /// <param name="tier">Specifies the tier of virtual machines in a
        /// scale set.&lt;br /&gt;&lt;br /&gt; Possible Values:&lt;br
        /// /&gt;&lt;br /&gt; **Standard**&lt;br /&gt;&lt;br /&gt;
        /// **Basic**</param>
        /// <param name="capacity">Specifies the number of virtual machines in
        /// the scale set.</param>
        public Sku(string name = default(string), string tier = default(string), long? capacity = default(long?))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sku name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specifies the tier of virtual machines in a scale
        /// set.&amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt; Possible
        /// Values:&amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt;
        /// **Standard**&amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt; **Basic**
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets specifies the number of virtual machines in the scale
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public long? Capacity { get; set; }

    }
}
