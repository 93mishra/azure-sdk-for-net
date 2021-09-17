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
    /// Virtual IP mapping.
    /// </summary>
    public partial class VirtualIPMapping
    {
        /// <summary>
        /// Initializes a new instance of the VirtualIPMapping class.
        /// </summary>
        public VirtualIPMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualIPMapping class.
        /// </summary>
        /// <param name="virtualIP">Virtual IP address.</param>
        /// <param name="internalHttpPort">Internal HTTP port.</param>
        /// <param name="internalHttpsPort">Internal HTTPS port.</param>
        /// <param name="inUse">Is virtual IP mapping in use.</param>
        public VirtualIPMapping(string virtualIP = default(string), int? internalHttpPort = default(int?), int? internalHttpsPort = default(int?), bool? inUse = default(bool?))
        {
            VirtualIP = virtualIP;
            InternalHttpPort = internalHttpPort;
            InternalHttpsPort = internalHttpsPort;
            InUse = inUse;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets virtual IP address.
        /// </summary>
        [JsonProperty(PropertyName = "virtualIP")]
        public string VirtualIP { get; set; }

        /// <summary>
        /// Gets or sets internal HTTP port.
        /// </summary>
        [JsonProperty(PropertyName = "internalHttpPort")]
        public int? InternalHttpPort { get; set; }

        /// <summary>
        /// Gets or sets internal HTTPS port.
        /// </summary>
        [JsonProperty(PropertyName = "internalHttpsPort")]
        public int? InternalHttpsPort { get; set; }

        /// <summary>
        /// Gets or sets is virtual IP mapping in use.
        /// </summary>
        [JsonProperty(PropertyName = "inUse")]
        public bool? InUse { get; set; }

    }
}
