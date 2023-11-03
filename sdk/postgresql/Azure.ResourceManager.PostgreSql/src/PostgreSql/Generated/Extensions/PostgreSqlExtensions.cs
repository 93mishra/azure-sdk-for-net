// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.PostgreSql.Mocking;
using Azure.ResourceManager.PostgreSql.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PostgreSql. </summary>
    public static partial class PostgreSqlExtensions
    {
        private static MockablePostgreSqlArmClient GetMockablePostgreSqlArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockablePostgreSqlArmClient(client0));
        }

        private static MockablePostgreSqlResourceGroupResource GetMockablePostgreSqlResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePostgreSqlResourceGroupResource(client, resource.Id));
        }

        private static MockablePostgreSqlSubscriptionResource GetMockablePostgreSqlSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePostgreSqlSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlServerResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlServerResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlServerResource" /> object. </returns>
        public static PostgreSqlServerResource GetPostgreSqlServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlServerResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlFirewallRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlFirewallRuleResource" /> object. </returns>
        public static PostgreSqlFirewallRuleResource GetPostgreSqlFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlFirewallRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlVirtualNetworkRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlVirtualNetworkRuleResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlVirtualNetworkRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlVirtualNetworkRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlVirtualNetworkRuleResource" /> object. </returns>
        public static PostgreSqlVirtualNetworkRuleResource GetPostgreSqlVirtualNetworkRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlVirtualNetworkRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlDatabaseResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlDatabaseResource" /> object. </returns>
        public static PostgreSqlDatabaseResource GetPostgreSqlDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlDatabaseResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlConfigurationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlConfigurationResource" /> object. </returns>
        public static PostgreSqlConfigurationResource GetPostgreSqlConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlConfigurationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlServerAdministratorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlServerAdministratorResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlServerAdministratorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlServerAdministratorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlServerAdministratorResource" /> object. </returns>
        public static PostgreSqlServerAdministratorResource GetPostgreSqlServerAdministratorResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlServerAdministratorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlServerSecurityAlertPolicyResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlServerSecurityAlertPolicyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> object. </returns>
        public static PostgreSqlServerSecurityAlertPolicyResource GetPostgreSqlServerSecurityAlertPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlServerSecurityAlertPolicyResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlPrivateEndpointConnectionResource" /> object. </returns>
        public static PostgreSqlPrivateEndpointConnectionResource GetPostgreSqlPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlPrivateLinkResource" /> object. </returns>
        public static PostgreSqlPrivateLinkResource GetPostgreSqlPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlServerKeyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlServerKeyResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlServerKeyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlArmClient.GetPostgreSqlServerKeyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlServerKeyResource" /> object. </returns>
        public static PostgreSqlServerKeyResource GetPostgreSqlServerKeyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockablePostgreSqlArmClient(client).GetPostgreSqlServerKeyResource(id);
        }

        /// <summary>
        /// Gets a collection of PostgreSqlServerResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlResourceGroupResource.GetPostgreSqlServers()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PostgreSqlServerResources and their operations over a PostgreSqlServerResource. </returns>
        public static PostgreSqlServerCollection GetPostgreSqlServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockablePostgreSqlResourceGroupResource(resourceGroupResource).GetPostgreSqlServers();
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlResourceGroupResource.GetPostgreSqlServerAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PostgreSqlServerResource>> GetPostgreSqlServerAsync(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return await GetMockablePostgreSqlResourceGroupResource(resourceGroupResource).GetPostgreSqlServerAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlResourceGroupResource.GetPostgreSqlServer(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<PostgreSqlServerResource> GetPostgreSqlServer(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return GetMockablePostgreSqlResourceGroupResource(resourceGroupResource).GetPostgreSqlServer(serverName, cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlSubscriptionResource.GetPostgreSqlServers(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PostgreSqlServerResource> GetPostgreSqlServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockablePostgreSqlSubscriptionResource(subscriptionResource).GetPostgreSqlServersAsync(cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlSubscriptionResource.GetPostgreSqlServers(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PostgreSqlServerResource> GetPostgreSqlServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockablePostgreSqlSubscriptionResource(subscriptionResource).GetPostgreSqlServers(cancellationToken);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/performanceTiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedPerformanceTier_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlSubscriptionResource.GetLocationBasedPerformanceTiers(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlPerformanceTierProperties" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PostgreSqlPerformanceTierProperties> GetLocationBasedPerformanceTiersAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetMockablePostgreSqlSubscriptionResource(subscriptionResource).GetLocationBasedPerformanceTiersAsync(locationName, cancellationToken);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/performanceTiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedPerformanceTier_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlSubscriptionResource.GetLocationBasedPerformanceTiers(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlPerformanceTierProperties" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PostgreSqlPerformanceTierProperties> GetLocationBasedPerformanceTiers(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetMockablePostgreSqlSubscriptionResource(subscriptionResource).GetLocationBasedPerformanceTiers(locationName, cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlSubscriptionResource.CheckPostgreSqlNameAvailability(PostgreSqlNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<PostgreSqlNameAvailabilityResult>> CheckPostgreSqlNameAvailabilityAsync(this SubscriptionResource subscriptionResource, PostgreSqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetMockablePostgreSqlSubscriptionResource(subscriptionResource).CheckPostgreSqlNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePostgreSqlSubscriptionResource.CheckPostgreSqlNameAvailability(PostgreSqlNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<PostgreSqlNameAvailabilityResult> CheckPostgreSqlNameAvailability(this SubscriptionResource subscriptionResource, PostgreSqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetMockablePostgreSqlSubscriptionResource(subscriptionResource).CheckPostgreSqlNameAvailability(content, cancellationToken);
        }
    }
}
