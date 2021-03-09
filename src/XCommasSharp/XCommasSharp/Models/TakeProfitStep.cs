using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class TakeProfitStep
    {
        /// <summary>
        /// Cannot be conditional
        /// Required
        /// </summary>
        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("price")]
        public TakeProfitStepPrice Price { get; set; }

        /// <summary>
        /// Value between 0 and 100
        /// Should add up to 100% in the sum of all steps
        /// Required
        /// </summary>
        [JsonProperty("volume")]
        public decimal Volume { get; set; }

        /// <summary>
        /// Optional. Only for market orders
        /// </summary>
        [JsonProperty("trailing")]
        public TrailingInfo Trailing { get; set; }
    }
}
