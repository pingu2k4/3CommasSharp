using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class Trade
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("average_price")]
        public decimal AveragePrice { get; set; }

        [JsonProperty("follow_price_type")]
        public LastPriceType FollowPriceType { get; set; }

        [JsonProperty("initial_amount")]
        public decimal InitialAmount { get; set; }

        [JsonProperty("initial_total")]
        public decimal InitialTotal { get; set; }

        [JsonProperty("order_price")]
        public decimal OrderPrice { get; set; }

        [JsonProperty("order_side")]
        public PositionType OrderSide { get; set; }

        [JsonProperty("order_type")]
        public OrderType OrderType { get; set; }

        [JsonProperty("pair")]
        public string Pair { get; set; }

        [JsonProperty("position_percentage")]
        public decimal? PositionPercentage { get; set; }

        [JsonProperty("realised_amount")]
        public decimal RealisedAmount { get; set; }

        [JsonProperty("realised_total")]
        public decimal RealisedTotal { get; set; }

        [JsonProperty("status")]
        public TradeStatus Status { get; set; }

        [JsonProperty("take_profit_percentage")]
        public decimal? TakeProfitPercentage { get; set; }

        /// <summary>
        /// Needs to be converted to an enum. Only current known values are position, take_profit and stop_loss.
        /// </summary>
        [JsonProperty("trade_purpose")]
        public string TradePurpose { get; set; }

        [JsonProperty("trail_percentage")]
        public decimal? TrailPercentage { get; set; }

        [JsonProperty("trail_value")]
        public decimal TrailValue { get; set; }

        [JsonProperty("trailing_enabled")]
        public bool TrailingEnabled { get; set; }

        [JsonProperty("trailing_last_price")]
        public decimal TrailingLastPrice { get; set; }

        [JsonProperty("trailing_last_price_updated_at")]
        public DateTime? TrailingLastPriceUpdatedAt { get; set; }

        /// <summary>
        /// Convert to enum - assume that only values are more and less, but unknown.
        /// </summary>
        [JsonProperty("trigger_condition")]
        public string TriggerCondition { get; set; }

        [JsonProperty("trigger_price")]
        public decimal TriggerPrice { get; set; }

        [JsonProperty("trigger_price_percentage")]
        public decimal? TriggerPricePercentage { get; set; }

        /// <summary>
        /// Convert to enum. Known values: none, conditional.
        /// </summary>
        [JsonProperty("trigger_type")]
        public string TriggerType { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("realised_percentage")]
        public decimal RealisedPercentage { get; set; }

        [JsonProperty("initial_price")]
        public decimal InitialPrice { get; set; }

        [JsonProperty("realised_price")]
        public decimal RealisedPrice { get; set; }

        [JsonProperty("cancelable")]
        public bool Cancelable { get; set; }

        [JsonProperty("force_processable")]
        public bool ForceProcessable { get; set; }
    }
}
