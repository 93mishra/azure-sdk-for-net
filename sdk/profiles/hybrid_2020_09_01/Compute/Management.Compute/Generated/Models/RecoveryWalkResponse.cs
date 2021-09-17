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
    /// Response after calling a manual recovery walk
    /// </summary>
    public partial class RecoveryWalkResponse
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryWalkResponse class.
        /// </summary>
        public RecoveryWalkResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryWalkResponse class.
        /// </summary>
        /// <param name="walkPerformed">Whether the recovery walk was
        /// performed</param>
        /// <param name="nextPlatformUpdateDomain">The next update domain that
        /// needs to be walked. Null means walk spanning all update domains has
        /// been completed</param>
        public RecoveryWalkResponse(bool? walkPerformed = default(bool?), int? nextPlatformUpdateDomain = default(int?))
        {
            WalkPerformed = walkPerformed;
            NextPlatformUpdateDomain = nextPlatformUpdateDomain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets whether the recovery walk was performed
        /// </summary>
        [JsonProperty(PropertyName = "walkPerformed")]
        public bool? WalkPerformed { get; private set; }

        /// <summary>
        /// Gets the next update domain that needs to be walked. Null means
        /// walk spanning all update domains has been completed
        /// </summary>
        [JsonProperty(PropertyName = "nextPlatformUpdateDomain")]
        public int? NextPlatformUpdateDomain { get; private set; }

    }
}
