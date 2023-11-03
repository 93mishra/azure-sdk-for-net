// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.FlexibleServers;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_TenantResourceExtensions
    {
        // GetPrivateDnsZoneSuffix
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ExecuteGetPrivateDnsZoneSuffix_GetPrivateDnsZoneSuffix()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/ServiceOperations/preview/2023-06-01-preview/examples/GetPrivateDnsZoneSuffix.json
            // this example is just showing the usage of "GetPrivateDnsZoneSuffix_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            MySqlFlexibleServerPrivateDnsZoneSuffixResponse result = await tenantResource.ExecuteGetPrivateDnsZoneSuffixAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
