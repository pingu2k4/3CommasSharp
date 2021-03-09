using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class SmartTradePositionConditional
    {
        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("price")]
        public PriceTrigger Price { get; set; }

        /// <summary>
        /// Cannot be Conditional
        /// Required
        /// </summary>
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }

        /// <summary>
        /// Optional. Only used for limit orders
        /// </summary>
        [JsonProperty("trailing")]
        public TrailingInfo Trailing { get; set; }
    }
}
