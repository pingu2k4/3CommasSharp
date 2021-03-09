using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class SmartTradeLeverage
    {
        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required only if enabled
        /// </summary>
        [JsonProperty("type")]
        public LeverageType? Type { get; set; }

        /// <summary>
        /// Value of custom leverage
        /// Required only if type is Custom?
        /// </summary>
        public int? Value { get; set; }
    }
}
