using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class TakeProfitStepPrice
    {
        /// <summary>
        /// Required only if position has no trailing or position trailing is finished
        /// </summary>
        [JsonProperty("value")]
        public decimal? Value { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public LastPriceType Type { get; set; }

        /// <summary>
        /// Required only if position has trailing or position trailing is not finished
        /// </summary>
        [JsonProperty("percent")]
        public decimal? Percent { get; set; }
    }
}
