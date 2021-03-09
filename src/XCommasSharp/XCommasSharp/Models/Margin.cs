using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class Margin
    {
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        [JsonProperty("total")]
        public decimal? Total { get; set; }
    }
}
