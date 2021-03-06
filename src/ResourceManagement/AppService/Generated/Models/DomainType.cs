// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DomainType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DomainType
    {
        [EnumMember(Value = "Regular")]
        Regular,
        [EnumMember(Value = "SoftDeleted")]
        SoftDeleted
    }
    internal static class DomainTypeEnumExtension
    {
        internal static string ToSerializedValue(this DomainType? value)  =>
            value == null ? null : ((DomainType)value).ToSerializedValue();

        internal static string ToSerializedValue(this DomainType value)
        {
            switch( value )
            {
                case DomainType.Regular:
                    return "Regular";
                case DomainType.SoftDeleted:
                    return "SoftDeleted";
            }
            return null;
        }

        internal static DomainType? ParseDomainType(this string value)
        {
            switch( value )
            {
                case "Regular":
                    return DomainType.Regular;
                case "SoftDeleted":
                    return DomainType.SoftDeleted;
            }
            return null;
        }
    }
}
