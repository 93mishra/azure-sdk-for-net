// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class AcceptJobOfferResponse
    {
        internal static AcceptJobOfferResponse DeserializeAcceptJobOfferResponse(JsonElement element)
        {
            string assignmentId = default;
            string jobId = default;
            string workerId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignmentId"))
                {
                    assignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workerId"))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
            }
            return new AcceptJobOfferResponse(assignmentId, jobId, workerId);
        }
    }
}
