using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class SmartTradeStopLossConditional
    {
        /// <summary>
        /// Required. SL Trigger price
        /// </summary>
        [JsonProperty("price")]
        public StopLossPriceTrigger Price { get; set; }

        /// <summary>
        /// Optional. Only for market orders
        /// </summary>
        [JsonProperty("trailing")]
        public TrailingInfo Trailing { get; set; }
    }
}
