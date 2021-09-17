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
    /// Describes the result of resource validation.
    /// </summary>
    public partial class ValidateResponse
    {
        /// <summary>
        /// Initializes a new instance of the ValidateResponse class.
        /// </summary>
        public ValidateResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateResponse class.
        /// </summary>
        /// <param name="status">Result of validation.</param>
        /// <param name="error">Error details for the case when validation
        /// fails.</param>
        public ValidateResponse(string status = default(string), ValidateResponseError error = default(ValidateResponseError))
        {
            Status = status;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets result of validation.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets error details for the case when validation fails.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ValidateResponseError Error { get; set; }

    }
}
