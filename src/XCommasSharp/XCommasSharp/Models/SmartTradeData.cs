using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class SmartTradeData
    {
        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("current_price")]
        public CurrentPrice CurrentPrice { get; set; }

        [JsonProperty("target_price_type")]
        public string TargetPriceType { get; set; }

        [JsonProperty("base_order_finished")]
        public bool BaseOrderFinished { get; set; }

        [JsonProperty("missing_funds_to_close")]
        public decimal? MissingFundsToClose { get; set; }

        [JsonProperty("liquidation_price")]
        public decimal? LiquidationPrice { get; set; }

        [JsonProperty("average_enter_price")]
        public decimal? AverageEnterPrice { get; set; }

        [JsonProperty("average_close_price")]
        public decimal? AverageClosePrice { get; set; }

        [JsonProperty("average_enter_price_without_commission")]
        public decimal? AverageEnterPriceWithoutCommission { get; set; }

        [JsonProperty("average_close_price_without_commission")]
        public decimal? AverageClosePriceWithoutCommission { get; set; }

        [JsonProperty("panic_sell_available")]
        public bool PanicSellAvailable { get; set; }

        [JsonProperty("add_funds_available")]
        public bool AddFundsAvailable { get; set; }

        [JsonProperty("force_start_available")]
        public bool ForceStartAvailable { get; set; }

        [JsonProperty("force_process_available")]
        public bool ForceProcessAvailable { get; set; }

        [JsonProperty("cancel_available")]
        public bool CancelAvailable { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
