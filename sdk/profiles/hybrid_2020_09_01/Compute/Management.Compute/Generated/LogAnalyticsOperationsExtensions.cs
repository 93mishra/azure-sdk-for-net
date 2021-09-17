// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LogAnalyticsOperations.
    /// </summary>
    public static partial class LogAnalyticsOperationsExtensions
    {
            /// <summary>
            /// Export logs that show Api requests made by this subscription in the given
            /// time window to show throttling activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getRequestRateByInterval Api.
            /// </param>
            /// <param name='location'>
            /// The location upon which virtual-machine-sizes is queried.
            /// </param>
            public static LogAnalyticsOperationResult ExportRequestRateByInterval(this ILogAnalyticsOperations operations, RequestRateByIntervalInput parameters, string location)
            {
                return operations.ExportRequestRateByIntervalAsync(parameters, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Export logs that show Api requests made by this subscription in the given
            /// time window to show throttling activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getRequestRateByInterval Api.
            /// </param>
            /// <param name='location'>
            /// The location upon which virtual-machine-sizes is queried.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogAnalyticsOperationResult> ExportRequestRateByIntervalAsync(this ILogAnalyticsOperations operations, RequestRateByIntervalInput parameters, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportRequestRateByIntervalWithHttpMessagesAsync(parameters, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Export logs that show total throttled Api requests for this subscription in
            /// the given time window.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getThrottledRequests Api.
            /// </param>
            /// <param name='location'>
            /// The location upon which virtual-machine-sizes is queried.
            /// </param>
            public static LogAnalyticsOperationResult ExportThrottledRequests(this ILogAnalyticsOperations operations, ThrottledRequestsInput parameters, string location)
            {
                return operations.ExportThrottledRequestsAsync(parameters, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Export logs that show total throttled Api requests for this subscription in
            /// the given time window.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getThrottledRequests Api.
            /// </param>
            /// <param name='location'>
            /// The location upon which virtual-machine-sizes is queried.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogAnalyticsOperationResult> ExportThrottledRequestsAsync(this ILogAnalyticsOperations operations, ThrottledRequestsInput parameters, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportThrottledRequestsWithHttpMessagesAsync(parameters, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Export logs that show Api requests made by this subscription in the given
            /// time window to show throttling activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getRequestRateByInterval Api.
            /// </param>
            /// <param name='location'>
            /// The location upon which virtual-machine-sizes is queried.
            /// </param>
            public static LogAnalyticsOperationResult BeginExportRequestRateByInterval(this ILogAnalyticsOperations operations, RequestRateByIntervalInput parameters, string location)
            {
                return operations.BeginExportRequestRateByIntervalAsync(parameters, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Export logs that show Api requests made by this subscription in the given
            /// time window to show throttling activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getRequestRateByInterval Api.
            /// </param>
            /// <param name='location'>
            /// The location upon which virtual-machine-sizes is queried.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogAnalyticsOperationResult> BeginExportRequestRateByIntervalAsync(this ILogAnalyticsOperations operations, RequestRateByIntervalInput parameters, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginExportRequestRateByIntervalWithHttpMessagesAsync(parameters, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Export logs that show total throttled Api requests for this subscription in
            /// the given time window.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getThrottledRequests Api.
            /// </param>
            /// <param name='location'>
            /// The location upon which virtual-machine-sizes is queried.
            /// </param>
            public static LogAnalyticsOperationResult BeginExportThrottledRequests(this ILogAnalyticsOperations operations, ThrottledRequestsInput parameters, string location)
            {
                return operations.BeginExportThrottledRequestsAsync(parameters, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Export logs that show total throttled Api requests for this subscription in
            /// the given time window.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the LogAnalytics getThrottledRequests Api.
            /// </param>
            /// <param name='location'>
            /// The location upon which virtual-machine-sizes is queried.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LogAnalyticsOperationResult> BeginExportThrottledRequestsAsync(this ILogAnalyticsOperations operations, ThrottledRequestsInput parameters, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginExportThrottledRequestsWithHttpMessagesAsync(parameters, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
