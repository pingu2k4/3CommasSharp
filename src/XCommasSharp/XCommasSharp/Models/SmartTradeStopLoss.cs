using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class SmartTradeStopLoss
    {
        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required. Cannot be conditional
        /// </summary>
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }

        /// <summary>
        /// Required only for limit order type
        /// </summary>
        [JsonProperty("price")]
        public DecimalValue Price { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("conditional")]
        public SmartTradeStopLossConditional Conditional { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("timeout")]
        public TimeoutInfo Timeout { get; set; }
    }
}
