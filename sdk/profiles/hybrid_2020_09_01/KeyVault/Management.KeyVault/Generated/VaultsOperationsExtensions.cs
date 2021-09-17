// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.KeyVault
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VaultsOperations.
    /// </summary>
    public static partial class VaultsOperationsExtensions
    {
            /// <summary>
            /// Create or update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the vault
            /// </param>
            public static Vault CreateOrUpdate(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, vaultName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the vault
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Vault> CreateOrUpdateAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vaultName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to patch the vault
            /// </param>
            public static Vault Update(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultPatchParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, vaultName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to patch the vault
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Vault> UpdateAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultPatchParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, vaultName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault to delete
            /// </param>
            public static void Delete(this IVaultsOperations operations, string resourceGroupName, string vaultName)
            {
                operations.DeleteAsync(resourceGroupName, vaultName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vaultName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault.
            /// </param>
            public static Vault Get(this IVaultsOperations operations, string resourceGroupName, string vaultName)
            {
                return operations.GetAsync(resourceGroupName, vaultName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Vault> GetAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vaultName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update access policies in a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='operationKind'>
            /// Name of the operation. Possible values include: 'add', 'replace', 'remove'
            /// </param>
            /// <param name='parameters'>
            /// Access policy to merge into the vault
            /// </param>
            public static VaultAccessPolicyParameters UpdateAccessPolicy(this IVaultsOperations operations, string resourceGroupName, string vaultName, AccessPolicyUpdateKind operationKind, VaultAccessPolicyParameters parameters)
            {
                return operations.UpdateAccessPolicyAsync(resourceGroupName, vaultName, operationKind, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update access policies in a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='operationKind'>
            /// Name of the operation. Possible values include: 'add', 'replace', 'remove'
            /// </param>
            /// <param name='parameters'>
            /// Access policy to merge into the vault
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultAccessPolicyParameters> UpdateAccessPolicyAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, AccessPolicyUpdateKind operationKind, VaultAccessPolicyParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateAccessPolicyWithHttpMessagesAsync(resourceGroupName, vaultName, operationKind, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription and within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            public static IPage<Vault> ListByResourceGroup(this IVaultsOperations operations, string resourceGroupName, int? top = default(int?))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription and within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the vault belongs.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Vault>> ListByResourceGroupAsync(this IVaultsOperations operations, string resourceGroupName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            public static IPage<Vault> ListBySubscription(this IVaultsOperations operations, int? top = default(int?))
            {
                return operations.ListBySubscriptionAsync(top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Vault>> ListBySubscriptionAsync(this IVaultsOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the deleted vaults in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DeletedVault> ListDeleted(this IVaultsOperations operations)
            {
                return operations.ListDeletedAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the deleted vaults in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeletedVault>> ListDeletedAsync(this IVaultsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDeletedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the deleted Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted vault.
            /// </param>
            public static DeletedVault GetDeleted(this IVaultsOperations operations, string vaultName, string location)
            {
                return operations.GetDeletedAsync(vaultName, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the deleted Azure key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeletedVault> GetDeletedAsync(this IVaultsOperations operations, string vaultName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDeletedWithHttpMessagesAsync(vaultName, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Permanently deletes the specified vault. aka Purges the deleted Azure key
            /// vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the soft-deleted vault.
            /// </param>
            /// <param name='location'>
            /// The location of the soft-deleted vault.
            /// </param>
            public static void PurgeDeleted(this IVaultsOperations operations, string vaultName, string location)
            {
                operations.PurgeDeletedAsync(vaultName, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Permanently deletes the specified vault. aka Purges the deleted Azure key
            /// vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the soft-deleted vault.
            /// </param>
            /// <param name='location'>
            /// The location of the soft-deleted vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PurgeDeletedAsync(this IVaultsOperations operations, string vaultName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PurgeDeletedWithHttpMessagesAsync(vaultName, location, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            public static IPage<Resource> List(this IVaultsOperations operations, int? top = default(int?))
            {
                return operations.ListAsync(top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Resource>> ListAsync(this IVaultsOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks that the vault name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault.
            /// </param>
            public static CheckNameAvailabilityResult CheckNameAvailability(this IVaultsOperations operations, VaultCheckNameAvailabilityParameters vaultName)
            {
                return operations.CheckNameAvailabilityAsync(vaultName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that the vault name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResult> CheckNameAvailabilityAsync(this IVaultsOperations operations, VaultCheckNameAvailabilityParameters vaultName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(vaultName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the vault
            /// </param>
            public static Vault BeginCreateOrUpdate(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, vaultName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a key vault in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the server belongs.
            /// </param>
            /// <param name='vaultName'>
            /// Name of the vault
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the vault
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Vault> BeginCreateOrUpdateAsync(this IVaultsOperations operations, string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vaultName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Permanently deletes the specified vault. aka Purges the deleted Azure key
            /// vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the soft-deleted vault.
            /// </param>
            /// <param name='location'>
            /// The location of the soft-deleted vault.
            /// </param>
            public static void BeginPurgeDeleted(this IVaultsOperations operations, string vaultName, string location)
            {
                operations.BeginPurgeDeletedAsync(vaultName, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Permanently deletes the specified vault. aka Purges the deleted Azure key
            /// vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the soft-deleted vault.
            /// </param>
            /// <param name='location'>
            /// The location of the soft-deleted vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPurgeDeletedAsync(this IVaultsOperations operations, string vaultName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPurgeDeletedWithHttpMessagesAsync(vaultName, location, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription and within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Vault> ListByResourceGroupNext(this IVaultsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription and within the specified resource group.
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
            public static async Task<IPage<Vault>> ListByResourceGroupNextAsync(this IVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Vault> ListBySubscriptionNext(this IVaultsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
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
            public static async Task<IPage<Vault>> ListBySubscriptionNextAsync(this IVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the deleted vaults in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DeletedVault> ListDeletedNext(this IVaultsOperations operations, string nextPageLink)
            {
                return operations.ListDeletedNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the deleted vaults in a subscription.
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
            public static async Task<IPage<DeletedVault>> ListDeletedNextAsync(this IVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDeletedNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Resource> ListNext(this IVaultsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the vaults associated with the
            /// subscription.
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
            public static async Task<IPage<Resource>> ListNextAsync(this IVaultsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
