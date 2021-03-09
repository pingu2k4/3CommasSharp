using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class DecimalValue
    {
        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}
