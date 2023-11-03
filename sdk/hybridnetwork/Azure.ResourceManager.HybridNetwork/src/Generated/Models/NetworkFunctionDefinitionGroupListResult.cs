// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> A list of network function definition group resources. </summary>
    internal partial class NetworkFunctionDefinitionGroupListResult
    {
        /// <summary> Initializes a new instance of NetworkFunctionDefinitionGroupListResult. </summary>
        internal NetworkFunctionDefinitionGroupListResult()
        {
            Value = new ChangeTrackingList<NetworkFunctionDefinitionGroupData>();
        }

        /// <summary> Initializes a new instance of NetworkFunctionDefinitionGroupListResult. </summary>
        /// <param name="value"> A list of network function definition group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal NetworkFunctionDefinitionGroupListResult(IReadOnlyList<NetworkFunctionDefinitionGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of network function definition group. </summary>
        public IReadOnlyList<NetworkFunctionDefinitionGroupData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
