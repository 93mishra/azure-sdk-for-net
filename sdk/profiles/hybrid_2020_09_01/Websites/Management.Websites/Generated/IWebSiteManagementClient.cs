// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.WebSites
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// WebSite Management Client
    /// </summary>
    public partial interface IWebSiteManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Your Azure subscription ID. This is a GUID-formatted string (e.g.
        /// 00000000-0000-0000-0000-000000000000).
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// API Version
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the ICertificatesOperations.
        /// </summary>
        ICertificatesOperations Certificates { get; }

        /// <summary>
        /// Gets the IWebAppsOperations.
        /// </summary>
        IWebAppsOperations WebApps { get; }

        /// <summary>
        /// Gets the IAppServicePlansOperations.
        /// </summary>
        IAppServicePlansOperations AppServicePlans { get; }

        /// <summary>
        /// Gets the IProviderOperations.
        /// </summary>
        IProviderOperations Provider { get; }

        /// <summary>
        /// Gets the IRecommendationsOperations.
        /// </summary>
        IRecommendationsOperations Recommendations { get; }

        /// <summary>
        /// Gets publishing user
        /// </summary>
        /// <remarks>
        /// Gets publishing user
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<User>> GetPublishingUserWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates publishing user
        /// </summary>
        /// <remarks>
        /// Updates publishing user
        /// </remarks>
        /// <param name='userDetails'>
        /// Details of publishing user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<User>> UpdatePublishingUserWithHttpMessagesAsync(User userDetails, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the source controls available for Azure websites.
        /// </summary>
        /// <remarks>
        /// Gets the source controls available for Azure websites.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SourceControl>>> ListSourceControlsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets source control token
        /// </summary>
        /// <remarks>
        /// Gets source control token
        /// </remarks>
        /// <param name='sourceControlType'>
        /// Type of source control
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SourceControl>> GetSourceControlWithHttpMessagesAsync(string sourceControlType, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates source control token
        /// </summary>
        /// <remarks>
        /// Updates source control token
        /// </remarks>
        /// <param name='sourceControlType'>
        /// Type of source control
        /// </param>
        /// <param name='requestMessage'>
        /// Source control token information
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SourceControl>> UpdateSourceControlWithHttpMessagesAsync(string sourceControlType, SourceControl requestMessage, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a list of meters for a given location.
        /// </summary>
        /// <remarks>
        /// Gets a list of meters for a given location.
        /// </remarks>
        /// <param name='billingLocation'>
        /// Azure Location of billable resource
        /// </param>
        /// <param name='osType'>
        /// App Service OS type meters used for
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BillingMeter>>> ListBillingMetersWithHttpMessagesAsync(string billingLocation = default(string), string osType = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check if a resource name is available.
        /// </summary>
        /// <remarks>
        /// Check if a resource name is available.
        /// </remarks>
        /// <param name='name'>
        /// Resource name to verify.
        /// </param>
        /// <param name='type'>
        /// Resource type used for verification. Possible values include:
        /// 'Site', 'Slot', 'HostingEnvironment', 'PublishingUser',
        /// 'Microsoft.Web/sites', 'Microsoft.Web/sites/slots',
        /// 'Microsoft.Web/hostingEnvironments',
        /// 'Microsoft.Web/publishingUsers'
        /// </param>
        /// <param name='isFqdn'>
        /// Is fully qualified domain name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ResourceNameAvailability>> CheckNameAvailabilityWithHttpMessagesAsync(string name, string type, bool? isFqdn = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets list of available geo regions plus ministamps
        /// </summary>
        /// <remarks>
        /// Gets list of available geo regions plus ministamps
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DeploymentLocations>> GetSubscriptionDeploymentLocationsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a list of available geographical regions.
        /// </summary>
        /// <remarks>
        /// Get a list of available geographical regions.
        /// </remarks>
        /// <param name='sku'>
        /// Name of SKU used to filter the regions. Possible values include:
        /// 'Free', 'Shared', 'Basic', 'Standard', 'Premium', 'Dynamic',
        /// 'Isolated', 'PremiumV2', 'ElasticPremium', 'ElasticIsolated'
        /// </param>
        /// <param name='linuxWorkersEnabled'>
        /// Specify &lt;code&gt;true&lt;/code&gt; if you want to filter to only
        /// regions that support Linux workers.
        /// </param>
        /// <param name='xenonWorkersEnabled'>
        /// Specify &lt;code&gt;true&lt;/code&gt; if you want to filter to only
        /// regions that support Xenon workers.
        /// </param>
        /// <param name='linuxDynamicWorkersEnabled'>
        /// Specify &lt;code&gt;true&lt;/code&gt; if you want to filter to only
        /// regions that support Linux Consumption Workers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<GeoRegion>>> ListGeoRegionsWithHttpMessagesAsync(string sku = default(string), bool? linuxWorkersEnabled = default(bool?), bool? xenonWorkersEnabled = default(bool?), bool? linuxDynamicWorkersEnabled = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all apps that are assigned to a hostname.
        /// </summary>
        /// <remarks>
        /// List all apps that are assigned to a hostname.
        /// </remarks>
        /// <param name='nameIdentifier'>
        /// Hostname information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Identifier>>> ListSiteIdentifiersAssignedToHostNameWithHttpMessagesAsync(NameIdentifier nameIdentifier, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all premier add-on offers.
        /// </summary>
        /// <remarks>
        /// List all premier add-on offers.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<PremierAddOnOffer>>> ListPremierAddOnOffersWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all SKUs.
        /// </summary>
        /// <remarks>
        /// List all SKUs.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SkuInfos>> ListSkusWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Verifies if this VNET is compatible with an App Service Environment
        /// by analyzing the Network Security Group rules.
        /// </summary>
        /// <remarks>
        /// Verifies if this VNET is compatible with an App Service Environment
        /// by analyzing the Network Security Group rules.
        /// </remarks>
        /// <param name='parameters'>
        /// VNET information
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VnetValidationFailureDetails>> VerifyHostingEnvironmentVnetWithHttpMessagesAsync(VnetParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Move resources between resource groups.
        /// </summary>
        /// <remarks>
        /// Move resources between resource groups.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='moveResourceEnvelope'>
        /// Object that represents the resource to move.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> MoveWithHttpMessagesAsync(string resourceGroupName, CsmMoveResourceEnvelope moveResourceEnvelope, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Validate if a resource can be created.
        /// </summary>
        /// <remarks>
        /// Validate if a resource can be created.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='validateRequest'>
        /// Request with the resources to validate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ValidateResponse>> ValidateWithHttpMessagesAsync(string resourceGroupName, ValidateRequest validateRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Validate if the container settings are correct.
        /// </summary>
        /// <remarks>
        /// Validate if the container settings are correct.
        /// </remarks>
        /// <param name='validateContainerSettingsRequest'>
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> ValidateContainerSettingsWithHttpMessagesAsync(ValidateContainerSettingsRequest validateContainerSettingsRequest, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Validate whether a resource can be moved.
        /// </summary>
        /// <remarks>
        /// Validate whether a resource can be moved.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='moveResourceEnvelope'>
        /// Object that represents the resource to move.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> ValidateMoveWithHttpMessagesAsync(string resourceGroupName, CsmMoveResourceEnvelope moveResourceEnvelope, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the source controls available for Azure websites.
        /// </summary>
        /// <remarks>
        /// Gets the source controls available for Azure websites.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SourceControl>>> ListSourceControlsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a list of meters for a given location.
        /// </summary>
        /// <remarks>
        /// Gets a list of meters for a given location.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BillingMeter>>> ListBillingMetersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a list of available geographical regions.
        /// </summary>
        /// <remarks>
        /// Get a list of available geographical regions.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<GeoRegion>>> ListGeoRegionsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all apps that are assigned to a hostname.
        /// </summary>
        /// <remarks>
        /// List all apps that are assigned to a hostname.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Identifier>>> ListSiteIdentifiersAssignedToHostNameNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all premier add-on offers.
        /// </summary>
        /// <remarks>
        /// List all premier add-on offers.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<PremierAddOnOffer>>> ListPremierAddOnOffersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
