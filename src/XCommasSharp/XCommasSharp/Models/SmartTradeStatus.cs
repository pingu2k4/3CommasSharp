using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class SmartTradeStatus
    {
        [JsonProperty("type")]
        public SmartTradeStatusType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
