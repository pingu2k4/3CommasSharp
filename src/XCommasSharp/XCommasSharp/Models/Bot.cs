using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class Bot
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("max_safety_orders")]
        public int MaxSafetyOrders { get; set; }

        [JsonProperty("active_safety_orders_count")]
        public int ActiveSafetyOrdersCount { get; set; }

        [JsonProperty("pairs")]
        public List<string> Pairs { get; set; }

        [JsonProperty("strategy_list")]
        public List<BotStrategy> StrategyList { get; set; }

        [JsonProperty("max_active_deals")]
        public int MaxActiveDeals { get; set; }

        [JsonProperty("active_deals_count")]
        public int ActiveDealsCount { get; set; }

        [JsonProperty("deletable?")]
        public bool Deletable { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("trailing_enabled")]
        public bool TrailingEnabled { get; set; }

        [JsonProperty("tsl_enabled")]
        public bool TslEnabled { get; set; }

        [JsonProperty("deal_start_delay_seconds")]
        public int? DealStartDelaySeconds { get; set; }

        [JsonProperty("stop_loss_timeout_enabled")]
        public bool StopLossTimeoutEnabled { get; set; }

        [JsonProperty("stop_loss_timeout_in_seconds")]
        public int? StopLossTimeoutInSeconds { get; set; }

        [JsonProperty("disable_after_deals_count")]
        public int? DisableAfterDealsCount { get; set; }

        [JsonProperty("deals_counter")]
        public int? DealsCounter { get; set; }

        [JsonProperty("allowed_deals_on_same_pair")]
        public int AllowedDealsOnSamePair { get; set; }

        [JsonProperty("easy_form_supported")]
        public bool EasyFormSupported { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("take_profit")]
        public decimal TakeProfit { get; set; }

        [JsonProperty("base_order_volume")]
        public decimal BaseOrderVolume { get; set; }

        [JsonProperty("safety_order_volume")]
        public decimal SafetyOrderVolume { get; set; }

        [JsonProperty("safety_order_step_percentage")]
        public decimal SafetyOrderStepPercentage { get; set; }

        [JsonProperty("take_profit_type")]
        public TakeProfitType TakeProfitType { get; set; }

        [JsonProperty("type")]
        public BotType Type { get; set; }

        [JsonProperty("martingale_volume_coefficient")]
        public decimal MartingaleVolumeCoefficient { get; set; }

        [JsonProperty("martingale_step_coefficient")]
        public decimal MartingaleStepCoefficient { get; set; }

        [JsonProperty("stop_loss_percentage")]
        public decimal StopLossPercentage { get; set; }

        [JsonProperty("cooldown")]
        public int? Cooldown { get; set; }

        [JsonProperty("strategy")]
        public Enums.BotStrategy Strategy { get; set; }

        [JsonProperty("min_volume_btc_24h")]
        public decimal MinVolumeBtc24H { get; set; }

        [JsonProperty("profit_currency")]
        public CurrencyType ProfitCurrency { get; set; }

        [JsonProperty("min_price")]
        public decimal? MinPrice { get; set; }

        [JsonProperty("max_price")]
        public decimal? MaxPrice { get; set; }

        [JsonProperty("stop_loss_type")]
        public StopLossType StopLossType { get; set; }

        [JsonProperty("safety_order_volume_type")]
        public CurrencyType SafetyOrderVolumeType { get; set; }

        [JsonProperty("base_order_volume_type")]
        public CurrencyType BaseOrderVolumeType { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("trailing_deviation")]
        public decimal TrailingDeviation { get; set; }

        [JsonProperty("finished_deals_profit_usd")]
        public decimal FinishedDealsProfitUsd { get; set; }

        [JsonProperty("finished_deals_count")]
        public int FinishedDealsCount { get; set; }

        [JsonProperty("leverage_type")]
        public LeverageType LeverageType { get; set; }

        [JsonProperty("leverage_custom_value")]
        public decimal? LeverageCustomValue { get; set; }

        [JsonProperty("start_order_type")]
        public OrderType StartOrderType { get; set; }
    }
}
