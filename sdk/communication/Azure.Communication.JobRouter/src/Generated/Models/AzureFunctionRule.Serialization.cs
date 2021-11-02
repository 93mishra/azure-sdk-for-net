// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class AzureFunctionRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("functionAppUrl");
            writer.WriteStringValue(FunctionAppUrl);
            writer.WritePropertyName("functionName");
            writer.WriteStringValue(FunctionName);
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential");
                writer.WriteObjectValue(Credential);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static AzureFunctionRule DeserializeAzureFunctionRule(JsonElement element)
        {
            string functionAppUrl = default;
            string functionName = default;
            Optional<AzureFunctionRuleCredential> credential = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("functionAppUrl"))
                {
                    functionAppUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionName"))
                {
                    functionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credential"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    credential = AzureFunctionRuleCredential.DeserializeAzureFunctionRuleCredential(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new AzureFunctionRule(kind, functionAppUrl, functionName, credential.Value);
        }
    }
}
