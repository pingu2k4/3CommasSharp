using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class StopLossPriceTrigger : PriceTrigger
    {
        /// <summary>
        /// Between 0 and 100
        /// Required only if position has trailing and position trailing is not finished
        /// </summary>
        [JsonProperty("percent")]
        public decimal? Percent { get; set; }
    }
}
