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
    /// <summary> Test for WorkloadClassifier. </summary>
    public partial class WorkloadClassifierCollectionMockTests : MockTestBase
    {
        public WorkloadClassifierCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public WorkloadClassifierCollectionMockTests() : this(false)
        {
        }

        private async Task<Sql.WorkloadClassifierCollection> GetWorkloadClassifierCollectionAsync(string resourceGroupName, string serverName, string databaseName, string workloadGroupName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            DatabaseCollection databaseCollection = server.GetDatabases();
            var databaseOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(databaseCollection, databaseName);
            Database database = databaseOperation.Value;
            WorkloadGroupCollection workloadGroupCollection = database.GetWorkloadGroups();
            var workloadGroupOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(workloadGroupCollection, workloadGroupName);
            WorkloadGroup workloadGroup = workloadGroupOperation.Value;
            WorkloadClassifierCollection workloadClassifierCollection = workloadGroup.GetWorkloadClassifiers();
            return workloadClassifierCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create a workload group with all properties specified.
            var collection = await GetWorkloadClassifierCollectionAsync("Default-SQL-SouthEastAsia", "testsvr", "testdb", "wlm_workloadgroup");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "wlm_workloadclassifier");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: Get the list of workload classifiers for a workload group
            var collection = await GetWorkloadClassifierCollectionAsync("Default-SQL-SouthEastAsia", "testsvr", "testdb", "wlm_workloadgroup");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
