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
    public enum TradeStatus
    {
        [EnumMember(Value = "idle")]
        Idle,
        [EnumMember(Value = "to_process")]
        ToProcess,
        [EnumMember(Value = "order_placed")]
        OrderPlaced,
        [EnumMember(Value = "pending_cancellation")]
        PendingCancellation,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "panic_sell_pending")]
        PanicSellPending,
        [EnumMember(Value = "panic_sell_order_placed")]
        PanicSellOrderPlaced,
        [EnumMember(Value = "panic_sold")]
        PanicSold,
        [EnumMember(Value = "trailing_activated")]
        TrailingActivated,
        [EnumMember(Value = "finished")]
        Finished,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "smart_sell")]
        SmartSell,
        [EnumMember(Value = "need_reset")]
        NeedReset
    }
}
