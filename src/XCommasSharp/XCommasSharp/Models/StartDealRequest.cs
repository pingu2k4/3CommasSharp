using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class StartDealRequest
    {
        [JsonIgnore]
        public int BotId { get; set; }

        /// <summary>
        /// Can be omitted for simple bot, but not for composite
        /// </summary>
        [JsonProperty("pair")]
        public string Pair { get; set; }

        /// <summary>
        /// If false or null then all parameters like signals or volume filters will be checked. If true, those checks will be skipped
        /// </summary>
        [JsonProperty("skip_signal_checks")]
        public bool? SkipSignalChecks { get; set; }

        /// <summary>
        /// if true then you will be allowed to open more than one deal per pair in composite bot
        /// </summary>
        [JsonProperty("skip_open_deals_checks")]
        public bool? SkipOpenDealChecks { get; set; }
    }
}
