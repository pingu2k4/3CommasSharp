using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class GetBotsRequest
    {
        [AliasAs("limit")]
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [AliasAs("offset")]
        [JsonProperty("offset")]
        public int? Offset { get; set; }

        [AliasAs("account_id")]
        [JsonProperty("account_id")]
        public int? AccountId { get; set; }

        [AliasAs("scope")]
        [JsonProperty("scope")]
        public BotScope? Scope { get; set; }

        [AliasAs("strategy")]
        [JsonProperty("strategy")]
        public BotStrategy? Strategy { get; set; }
    }
}
