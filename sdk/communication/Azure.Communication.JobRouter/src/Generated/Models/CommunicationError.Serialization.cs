// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    internal partial class CommunicationError
    {
        internal static CommunicationError DeserializeCommunicationError(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<CommunicationError>> innerErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        innerErrors = null;
                        continue;
                    }
                    List<CommunicationError> array = new List<CommunicationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeCommunicationError(item));
                    }
                    innerErrors = array;
                    continue;
                }
            }
            return new CommunicationError(code.Value, message.Value, target.Value, Optional.ToList(innerErrors));
        }
    }
}
