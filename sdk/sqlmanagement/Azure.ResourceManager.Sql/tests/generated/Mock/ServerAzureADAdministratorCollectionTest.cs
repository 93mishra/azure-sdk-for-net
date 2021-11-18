// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ServerAzureADAdministrator. </summary>
    public partial class ServerAzureADAdministratorCollectionMockTests : MockTestBase
    {
        public ServerAzureADAdministratorCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public ServerAzureADAdministratorCollectionMockTests() : this(false)
        {
        }

        private async Task<Sql.ServerAzureADAdministratorCollection> GetServerAzureADAdministratorCollectionAsync(string resourceGroupName, string serverName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            ServerAzureADAdministratorCollection serverAzureADAdministratorCollection = server.GetServerAzureADAdministrators();
            return serverAzureADAdministratorCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Creates or updates an existing Azure Active Directory administrator.
            var collection = await GetServerAzureADAdministratorCollectionAsync("sqlcrudtest-4799", "sqlcrudtest-6440");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection);
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: Gets a list of Azure Active Directory administrator.
            var collection = await GetServerAzureADAdministratorCollectionAsync("sqlcrudtest-4799", "sqlcrudtest-6440");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
