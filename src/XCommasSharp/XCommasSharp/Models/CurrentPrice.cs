using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class CurrentPrice
    {
        [JsonProperty("bid")]
        public decimal Bid { get; set; }

        [JsonProperty("ask")]
        public decimal Ask { get; set; }

        [JsonProperty("last")]
        public decimal Last { get; set; }

        [JsonProperty("day_change_percent")]
        public decimal DayChangePercent { get; set; }

        [JsonProperty("quote_volume")]
        public decimal QuoteVolume { get; set; }
    }
}
