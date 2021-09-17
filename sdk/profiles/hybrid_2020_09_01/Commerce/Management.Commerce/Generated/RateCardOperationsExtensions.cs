// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Commerce
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RateCardOperations.
    /// </summary>
    public static partial class RateCardOperationsExtensions
    {
            /// <summary>
            /// Enables you to query for the resource/meter metadata and related prices
            /// used in a given subscription by Offer ID, Currency, Locale and Region. The
            /// metadata associated with the billing meters, including but not limited to
            /// service names, types, resources, units of measure, and regions, is subject
            /// to change at any time and without notice. If you intend to use this billing
            /// data in an automated fashion, please use the billing meter GUID to uniquely
            /// identify each billable item. If the billing meter GUID is scheduled to
            /// change due to a new billing model, you will be notified in advance of the
            /// change.
            /// <see href="https://docs.microsoft.com/rest/api/commerce/ratecard" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static ResourceRateCardInfo Get(this IRateCardOperations operations, ODataQuery<RateCardQueryParameters> odataQuery)
            {
                return operations.GetAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables you to query for the resource/meter metadata and related prices
            /// used in a given subscription by Offer ID, Currency, Locale and Region. The
            /// metadata associated with the billing meters, including but not limited to
            /// service names, types, resources, units of measure, and regions, is subject
            /// to change at any time and without notice. If you intend to use this billing
            /// data in an automated fashion, please use the billing meter GUID to uniquely
            /// identify each billable item. If the billing meter GUID is scheduled to
            /// change due to a new billing model, you will be notified in advance of the
            /// change.
            /// <see href="https://docs.microsoft.com/rest/api/commerce/ratecard" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceRateCardInfo> GetAsync(this IRateCardOperations operations, ODataQuery<RateCardQueryParameters> odataQuery, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
