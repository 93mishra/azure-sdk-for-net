// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Dns.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A PTR record.
    /// </summary>
    public partial class PtrRecord
    {
        /// <summary>
        /// Initializes a new instance of the PtrRecord class.
        /// </summary>
        public PtrRecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PtrRecord class.
        /// </summary>
        /// <param name="ptrdname">The PTR target domain name for this PTR
        /// record.</param>
        public PtrRecord(string ptrdname = default(string))
        {
            Ptrdname = ptrdname;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the PTR target domain name for this PTR record.
        /// </summary>
        [JsonProperty(PropertyName = "ptrdname")]
        public string Ptrdname { get; set; }

    }
}
