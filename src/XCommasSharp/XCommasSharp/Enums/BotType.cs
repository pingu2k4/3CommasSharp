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
    public enum BotType
    {
        [EnumMember(Value = "Bot::MultiBot")]
        Multi,
        [EnumMember(Value = "Bot::SingleBot")]
        Single,
        [EnumMember(Value = "Bot::SwitchBot")]
        Switch
    }
}
