// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TransformationNodeKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransformationNodeKind
    {
        [EnumMember(Value = "Aggregate")]
        Aggregate,
        [EnumMember(Value = "GroupBy")]
        GroupBy,
        [EnumMember(Value = "Filter")]
        Filter,
        [EnumMember(Value = "Compute")]
        Compute
    }
    internal static class TransformationNodeKindEnumExtension
    {
        internal static string ToSerializedValue(this TransformationNodeKind? value)
        {
            return value == null ? null : ((TransformationNodeKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TransformationNodeKind value)
        {
            switch( value )
            {
                case TransformationNodeKind.Aggregate:
                    return "Aggregate";
                case TransformationNodeKind.GroupBy:
                    return "GroupBy";
                case TransformationNodeKind.Filter:
                    return "Filter";
                case TransformationNodeKind.Compute:
                    return "Compute";
            }
            return null;
        }

        internal static TransformationNodeKind? ParseTransformationNodeKind(this string value)
        {
            switch( value )
            {
                case "Aggregate":
                    return TransformationNodeKind.Aggregate;
                case "GroupBy":
                    return TransformationNodeKind.GroupBy;
                case "Filter":
                    return TransformationNodeKind.Filter;
                case "Compute":
                    return TransformationNodeKind.Compute;
            }
            return null;
        }
    }
}