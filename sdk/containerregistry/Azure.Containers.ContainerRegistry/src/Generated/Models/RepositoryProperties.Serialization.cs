// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class RepositoryProperties
    {
        internal static RepositoryProperties DeserializeRepositoryProperties(JsonElement element)
        {
            Optional<string> registry = default;
            Optional<string> imageName = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            Optional<int> manifestCount = default;
            Optional<int> tagCount = default;
            Optional<ContentProperties> changeableAttributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registry"))
                {
                    registry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("manifestCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    manifestCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tagCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tagCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("changeableAttributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    changeableAttributes = ContentProperties.DeserializeContentProperties(property.Value);
                    continue;
                }
            }
            return new RepositoryProperties(registry.Value, imageName.Value, Optional.ToNullable(createdTime), Optional.ToNullable(lastUpdateTime), Optional.ToNullable(manifestCount), Optional.ToNullable(tagCount), changeableAttributes.Value);
        }
    }
}
