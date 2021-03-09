using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class SmartTrade
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("pair")]
        public string Pair { get; set; }

        [JsonProperty("instant")]
        public bool Instant { get; set; }

        [JsonProperty("status")]
        public SmartTradeStatus Status { get; set; }

        [JsonProperty("leverage")]
        public SmartTradeLeverage Leverage { get; set; }

        [JsonProperty("position")]
        public SmartTradePosition Position { get; set; }

        [JsonProperty("take_profit")]
        public SmartTradeTakeProfit TakeProfit { get; set; }

        [JsonProperty("stop_loss")]
        public SmartTradeStopLoss StopLoss { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("skip_enter_step")]
        public bool SkipEnterStep { get; set; }

        [JsonProperty("data")]
        public SmartTradeData Data { get; set; }

        [JsonProperty("profit")]
        public Profit Profit { get; set; }

        [JsonProperty("margin")]
        public Margin Margin { get; set; }

        [JsonProperty("is_position_not_filled")]
        public bool IsPositionNotFilled { get; set; }
    }
}
