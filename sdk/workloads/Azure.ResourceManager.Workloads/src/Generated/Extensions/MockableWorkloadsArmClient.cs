// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableWorkloadsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableWorkloadsArmClient"/> class for mocking. </summary>
        protected MockableWorkloadsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableWorkloadsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableWorkloadsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableWorkloadsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="SapVirtualInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapVirtualInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapVirtualInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapVirtualInstanceResource" /> object. </returns>
        public virtual SapVirtualInstanceResource GetSapVirtualInstanceResource(ResourceIdentifier id)
        {
            SapVirtualInstanceResource.ValidateResourceId(id);
            return new SapVirtualInstanceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SapCentralServerInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapCentralServerInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapCentralServerInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapCentralServerInstanceResource" /> object. </returns>
        public virtual SapCentralServerInstanceResource GetSapCentralServerInstanceResource(ResourceIdentifier id)
        {
            SapCentralServerInstanceResource.ValidateResourceId(id);
            return new SapCentralServerInstanceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SapDatabaseInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapDatabaseInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapDatabaseInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapDatabaseInstanceResource" /> object. </returns>
        public virtual SapDatabaseInstanceResource GetSapDatabaseInstanceResource(ResourceIdentifier id)
        {
            SapDatabaseInstanceResource.ValidateResourceId(id);
            return new SapDatabaseInstanceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SapApplicationServerInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapApplicationServerInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapApplicationServerInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapApplicationServerInstanceResource" /> object. </returns>
        public virtual SapApplicationServerInstanceResource GetSapApplicationServerInstanceResource(ResourceIdentifier id)
        {
            SapApplicationServerInstanceResource.ValidateResourceId(id);
            return new SapApplicationServerInstanceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SapMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapMonitorResource.CreateResourceIdentifier" /> to create a <see cref="SapMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapMonitorResource" /> object. </returns>
        public virtual SapMonitorResource GetSapMonitorResource(ResourceIdentifier id)
        {
            SapMonitorResource.ValidateResourceId(id);
            return new SapMonitorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SapProviderInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapProviderInstanceResource.CreateResourceIdentifier" /> to create a <see cref="SapProviderInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapProviderInstanceResource" /> object. </returns>
        public virtual SapProviderInstanceResource GetSapProviderInstanceResource(ResourceIdentifier id)
        {
            SapProviderInstanceResource.ValidateResourceId(id);
            return new SapProviderInstanceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SapLandscapeMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SapLandscapeMonitorResource.CreateResourceIdentifier" /> to create a <see cref="SapLandscapeMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SapLandscapeMonitorResource" /> object. </returns>
        public virtual SapLandscapeMonitorResource GetSapLandscapeMonitorResource(ResourceIdentifier id)
        {
            SapLandscapeMonitorResource.ValidateResourceId(id);
            return new SapLandscapeMonitorResource(Client, id);
        }
    }
}
