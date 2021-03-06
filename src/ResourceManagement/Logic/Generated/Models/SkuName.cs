// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SkuName.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkuName
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "Free")]
        Free,
        [EnumMember(Value = "Shared")]
        Shared,
        [EnumMember(Value = "Basic")]
        Basic,
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Premium")]
        Premium
    }
    internal static class SkuNameEnumExtension
    {
        internal static string ToSerializedValue(this SkuName? value)
        {
            return value == null ? null : ((SkuName)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SkuName value)
        {
            switch( value )
            {
                case SkuName.NotSpecified:
                    return "NotSpecified";
                case SkuName.Free:
                    return "Free";
                case SkuName.Shared:
                    return "Shared";
                case SkuName.Basic:
                    return "Basic";
                case SkuName.Standard:
                    return "Standard";
                case SkuName.Premium:
                    return "Premium";
            }
            return null;
        }

        internal static SkuName? ParseSkuName(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return SkuName.NotSpecified;
                case "Free":
                    return SkuName.Free;
                case "Shared":
                    return SkuName.Shared;
                case "Basic":
                    return SkuName.Basic;
                case "Standard":
                    return SkuName.Standard;
                case "Premium":
                    return SkuName.Premium;
            }
            return null;
        }
    }
}
