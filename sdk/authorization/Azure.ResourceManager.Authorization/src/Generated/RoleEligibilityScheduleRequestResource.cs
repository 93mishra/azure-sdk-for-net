// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A Class representing a RoleEligibilityScheduleRequest along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RoleEligibilityScheduleRequestResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRoleEligibilityScheduleRequestResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetRoleEligibilityScheduleRequest method.
    /// </summary>
    public partial class RoleEligibilityScheduleRequestResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RoleEligibilityScheduleRequestResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="roleEligibilityScheduleRequestName"> The roleEligibilityScheduleRequestName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string roleEligibilityScheduleRequestName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _roleEligibilityScheduleRequestClientDiagnostics;
        private readonly RoleEligibilityScheduleRequestsRestOperations _roleEligibilityScheduleRequestRestClient;
        private readonly RoleEligibilityScheduleRequestData _data;

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleRequestResource"/> class for mocking. </summary>
        protected RoleEligibilityScheduleRequestResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RoleEligibilityScheduleRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RoleEligibilityScheduleRequestResource(ArmClient client, RoleEligibilityScheduleRequestData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleRequestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RoleEligibilityScheduleRequestResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleEligibilityScheduleRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string roleEligibilityScheduleRequestApiVersion);
            _roleEligibilityScheduleRequestRestClient = new RoleEligibilityScheduleRequestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleEligibilityScheduleRequestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/roleEligibilityScheduleRequests";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RoleEligibilityScheduleRequestData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the specified role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RoleEligibilityScheduleRequestResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestResource.Get");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRequestRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RoleEligibilityScheduleRequestResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestResource.Get");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRequestRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the role eligibility schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleEligibilityScheduleRequestResource>> UpdateAsync(WaitUntil waitUntil, RoleEligibilityScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestResource.Update");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRequestRestClient.CreateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AuthorizationArmOperation<RoleEligibilityScheduleRequestResource>(Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the role eligibility schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoleEligibilityScheduleRequestResource> Update(WaitUntil waitUntil, RoleEligibilityScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestResource.Update");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRequestRestClient.Create(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new AuthorizationArmOperation<RoleEligibilityScheduleRequestResource>(Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a pending role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Cancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestResource.Cancel");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRequestRestClient.CancelAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a pending role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Cancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestResource.Cancel");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRequestRestClient.Cancel(Id.Parent, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validates a new role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Validate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Parameters for the role eligibility schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<RoleEligibilityScheduleRequestResource>> ValidateAsync(RoleEligibilityScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestResource.Validate");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRequestRestClient.ValidateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validates a new role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Validate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Parameters for the role eligibility schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<RoleEligibilityScheduleRequestResource> Validate(RoleEligibilityScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestResource.Validate");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRequestRestClient.Validate(Id.Parent, Id.Name, data, cancellationToken);
                return Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
