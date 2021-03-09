using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class CreateSmartTradeRequest
    {
        /// <summary>
        /// Id from GetAccounts
        /// Required
        /// </summary>
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        /// <summary>
        /// Currency Pair formatted QUOTE_BASE
        /// Required
        /// </summary>
        [JsonProperty("pair")]
        public string Pair { get; set; }

        /// <summary>
        /// True for simple buy and simple sell
        /// Optional
        /// </summary>
        [JsonProperty("instant")]
        public bool? Instant { get; set; }

        /// <summary>
        /// True only for smart sell
        /// Optional
        /// </summary>
        [JsonProperty("skip_enter_step")]
        public bool? SkipEnterStep { get; set; }

        /// <summary>
        /// Note for smart trade
        /// Optional
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Used only for contract exchanges
        /// Optional
        /// </summary>
        [JsonProperty("leverage")]
        public SmartTradeLeverage Leverage { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("position")]
        public SmartTradePosition Position { get; set; }

        /// <summary>
        /// Required only when instant is false
        /// </summary>
        [JsonProperty("take_profit")]
        public SmartTradeTakeProfit TakeProfit { get; set; }

        /// <summary>
        /// Required only when instant is false
        /// </summary>
        [JsonProperty("stop_loss")]
        public SmartTradeStopLoss StopLoss { get; set; }
    }
}
