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
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsageAggregatesOperations.
    /// </summary>
    public static partial class UsageAggregatesOperationsExtensions
    {
            /// <summary>
            /// Query aggregated Azure subscription consumption data for a date range.
            /// <see href="https://docs.microsoft.com/rest/api/commerce/usageaggregates" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reportedStartTime'>
            /// The start of the time range to retrieve data for.
            /// </param>
            /// <param name='reportedEndTime'>
            /// The end of the time range to retrieve data for.
            /// </param>
            /// <param name='showDetails'>
            /// `True` returns usage data in instance-level detail, `false` causes
            /// server-side aggregation with fewer details. For example, if you have 3
            /// website instances, by default you will get 3 line items for website
            /// consumption. If you specify showDetails = false, the data will be
            /// aggregated as a single line item for website consumption within the time
            /// period (for the given subscriptionId, meterId, usageStartTime and
            /// usageEndTime).
            /// </param>
            /// <param name='aggregationGranularity'>
            /// `Daily` (default) returns the data in daily granularity, `Hourly` returns
            /// the data in hourly granularity. Possible values include: 'Daily', 'Hourly'
            /// </param>
            /// <param name='continuationToken'>
            /// Used when a continuation token string is provided in the response body of
            /// the previous call, enabling paging through a large result set. If not
            /// present, the data is retrieved from the beginning of the day/hour (based on
            /// the granularity) passed in.
            /// </param>
            public static IPage<UsageAggregation> List(this IUsageAggregatesOperations operations, System.DateTime reportedStartTime, System.DateTime reportedEndTime, bool? showDetails = default(bool?), AggregationGranularity? aggregationGranularity = default(AggregationGranularity?), string continuationToken = default(string))
            {
                return operations.ListAsync(reportedStartTime, reportedEndTime, showDetails, aggregationGranularity, continuationToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query aggregated Azure subscription consumption data for a date range.
            /// <see href="https://docs.microsoft.com/rest/api/commerce/usageaggregates" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reportedStartTime'>
            /// The start of the time range to retrieve data for.
            /// </param>
            /// <param name='reportedEndTime'>
            /// The end of the time range to retrieve data for.
            /// </param>
            /// <param name='showDetails'>
            /// `True` returns usage data in instance-level detail, `false` causes
            /// server-side aggregation with fewer details. For example, if you have 3
            /// website instances, by default you will get 3 line items for website
            /// consumption. If you specify showDetails = false, the data will be
            /// aggregated as a single line item for website consumption within the time
            /// period (for the given subscriptionId, meterId, usageStartTime and
            /// usageEndTime).
            /// </param>
            /// <param name='aggregationGranularity'>
            /// `Daily` (default) returns the data in daily granularity, `Hourly` returns
            /// the data in hourly granularity. Possible values include: 'Daily', 'Hourly'
            /// </param>
            /// <param name='continuationToken'>
            /// Used when a continuation token string is provided in the response body of
            /// the previous call, enabling paging through a large result set. If not
            /// present, the data is retrieved from the beginning of the day/hour (based on
            /// the granularity) passed in.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<UsageAggregation>> ListAsync(this IUsageAggregatesOperations operations, System.DateTime reportedStartTime, System.DateTime reportedEndTime, bool? showDetails = default(bool?), AggregationGranularity? aggregationGranularity = default(AggregationGranularity?), string continuationToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(reportedStartTime, reportedEndTime, showDetails, aggregationGranularity, continuationToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Query aggregated Azure subscription consumption data for a date range.
            /// <see href="https://docs.microsoft.com/rest/api/commerce/usageaggregates" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<UsageAggregation> ListNext(this IUsageAggregatesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query aggregated Azure subscription consumption data for a date range.
            /// <see href="https://docs.microsoft.com/rest/api/commerce/usageaggregates" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<UsageAggregation>> ListNextAsync(this IUsageAggregatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
