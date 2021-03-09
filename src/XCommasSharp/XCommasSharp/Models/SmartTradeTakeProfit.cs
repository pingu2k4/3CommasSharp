using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class SmartTradeTakeProfit
    {
        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required if enabled. Max steps is 4 (docs say 8, but I am sure it should be 4)
        /// </summary>
        [JsonProperty("steps")]
        public List<TakeProfitStep> Steps { get; set; }
    }
}
