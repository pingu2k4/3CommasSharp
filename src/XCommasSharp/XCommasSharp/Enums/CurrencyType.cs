using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyType
    {
        [EnumMember(Value = "quote_currency")]
        Quote,
        [EnumMember(Value = "base_currency")]
        Base,
        [EnumMember(Value = "percent")]
        Percent,
        [EnumMember(Value = "xbt")]
        Xbt
    }
}
