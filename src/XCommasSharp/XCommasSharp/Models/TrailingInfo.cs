using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class TrailingInfo
    {
        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required if enabled
        /// </summary>
        [JsonProperty("percent")]
        public decimal? Percent { get; set; }
    }
}
