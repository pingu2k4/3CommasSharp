using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace XCommasSharp
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StopLossType
    {
        [EnumMember(Value = "stop_loss")]
        StopLoss,
        [EnumMember(Value = "stop_loss_and_disable_bot")]
        StopLossAndDisableBot
    }
}