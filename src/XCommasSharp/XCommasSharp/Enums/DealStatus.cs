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
    public enum DealStatus
    {
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "base_order_placed")]
        BaseOrderPlaced,
        [EnumMember(Value = "bought")]
        Bought,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "panic_sell_pending")]
        PanicSellPending,
        [EnumMember(Value = "panic_sell_order_placed")]
        PanicSellOrderPlaced,
        [EnumMember(Value = "panic_sold")]
        PanicSold,
        [EnumMember(Value = "cancel_pending")]
        CancelPending,
        [EnumMember(Value = "stop_loss_pending")]
        StopLossPending,
        [EnumMember(Value = "stop_loss_finished")]
        StopLossFinished,
        [EnumMember(Value = "stop_loss_order_placed")]
        StopLossOrderPlaced,
        [EnumMember(Value = "switched")]
        Switched,
        [EnumMember(Value = "switched_take_profit")]
        SwitchedTakeProfit,
        [EnumMember(Value = "ttp_activated")]
        TtpActivated,
        [EnumMember(Value = "ttp_order_placed")]
        TtpOrderPlaced,
        [EnumMember(Value = "liquidated")]
        Liquidated,
        [EnumMember(Value = "bought_safety_pending")]
        BoughtSafetyPending,
        [EnumMember(Value = "bought_take_profit_pending")]
        BoughtTakeProfitPending,
        [EnumMember(Value = "settled")]
        Settled
    }
}
