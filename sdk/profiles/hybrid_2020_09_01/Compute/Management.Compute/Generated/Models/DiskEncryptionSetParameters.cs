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
    using System.Linq;

    /// <summary>
    /// Describes the parameter of customer managed disk encryption set
    /// resource id that can be specified for disk. &lt;br&gt;&lt;br&gt; NOTE:
    /// The disk encryption set resource id can only be specified for managed
    /// disk. Please refer https://aka.ms/mdssewithcmkoverview for more
    /// details.
    /// </summary>
    public partial class DiskEncryptionSetParameters : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSetParameters
        /// class.
        /// </summary>
        public DiskEncryptionSetParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSetParameters
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        public DiskEncryptionSetParameters(string id = default(string))
            : base(id)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
