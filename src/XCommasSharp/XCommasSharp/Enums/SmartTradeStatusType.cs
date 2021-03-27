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
    public enum SmartTradeStatusType
    {
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "waiting_position")]
        WaitingPosition,
        [EnumMember(Value = "waiting_targets")]
        WaitingTargets,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "cancellation_in_progress")]
        CancellationInProgress,
        [EnumMember(Value = "cancellation_pending")]
        CancellationPending,
        [EnumMember(Value = "panic_sell_pending")]
        PanicSellPending,
        [EnumMember(Value = "panic_sell_in_progress")]
        PanicSellInProgress,
        [EnumMember(Value = "panic_sold")]
        PanicSold,
        [EnumMember(Value = "finished")]
        Finished,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "stop_loss_in_progress")]
        StopLossInProgress,
        [EnumMember(Value = "stop_loss_finished")]
        StopLossFinished
    }
}
