using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class Profit
    {
        [JsonProperty("volume")]
        public decimal? Volume { get; set; }

        [JsonProperty("usd")]
        public decimal? Usd { get; set; }

        [JsonProperty("percent")]
        public decimal Percent { get; set; }

        [JsonProperty("roe")]
        public decimal? Roe { get; set; }
    }
}
