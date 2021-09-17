// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Commerce.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AggregationGranularity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AggregationGranularity
    {
        [EnumMember(Value = "Daily")]
        Daily,
        [EnumMember(Value = "Hourly")]
        Hourly
    }
    internal static class AggregationGranularityEnumExtension
    {
        internal static string ToSerializedValue(this AggregationGranularity? value)
        {
            return value == null ? null : ((AggregationGranularity)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AggregationGranularity value)
        {
            switch( value )
            {
                case AggregationGranularity.Daily:
                    return "Daily";
                case AggregationGranularity.Hourly:
                    return "Hourly";
            }
            return null;
        }

        internal static AggregationGranularity? ParseAggregationGranularity(this string value)
        {
            switch( value )
            {
                case "Daily":
                    return AggregationGranularity.Daily;
                case "Hourly":
                    return AggregationGranularity.Hourly;
            }
            return null;
        }
    }
}
