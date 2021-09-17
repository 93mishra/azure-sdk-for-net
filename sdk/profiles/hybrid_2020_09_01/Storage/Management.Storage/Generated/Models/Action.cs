// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Action.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Action
    {
        [EnumMember(Value = "Allow")]
        Allow
    }
    internal static class ActionEnumExtension
    {
        internal static string ToSerializedValue(this Action? value)
        {
            return value == null ? null : ((Action)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Action value)
        {
            switch( value )
            {
                case Action.Allow:
                    return "Allow";
            }
            return null;
        }

        internal static Action? ParseAction(this string value)
        {
            switch( value )
            {
                case "Allow":
                    return Action.Allow;
            }
            return null;
        }
    }
}
