using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class BotStrategy
    {
        [JsonProperty("strategy")]
        public string Strategy { get; set; }
    }
}
