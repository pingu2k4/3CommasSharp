﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class Deal
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bot_id")]
        public int BotId { get; set; }

        [JsonProperty("max_safety_orders")]
        public int MaxSafetyOrders { get; set; }

        [JsonProperty("deal_has_error")]
        public bool DealHasError { get; set; }

        [JsonProperty("from_currency_id")]
        public int FromCurrencyId { get; set; }

        [JsonProperty("to_currency_id")]
        public int ToCurrencyId { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("active_safety_orders_count")]
        public int ActiveSafetyOrdersCount { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? ClosedAt { get; set; }

        [JsonProperty("finished?")]
        public bool Finished { get; set; }

        [JsonProperty("current_active_safety_orders_count")]
        public int CurrentActiveSafetyOrdersCount { get; set; }

        [JsonProperty("current_active_safety_orders")]
        public int CurrentActiveSafetyOrders { get; set; }

        [JsonProperty("completed_safety_orders_count")]
        public int CompletedSafetyOrdersCount { get; set; }

        [JsonProperty("completed_manual_safety_orders_count")]
        public int CompletedManualSafetyOrdersCount { get; set; }

        [JsonProperty("cancellable?")]
        public bool Cancellable { get; set; }

        [JsonProperty("panic_sellable?")]
        public bool PanicSellable { get; set; }

        [JsonProperty("trailing_enabled")]
        public bool TrailingEnabled { get; set; }

        [JsonProperty("tsl_enabled")]
        public bool TslEnabled { get; set; }

        [JsonProperty("stop_loss_timeout_enabled")]
        public bool StopLossTimeoutEnabled { get; set; }

        [JsonProperty("stop_loss_timeout_in_seconds")]
        public int StopLossTimeoutInSeconds { get; set; }

        [JsonProperty("active_manual_safety_orders")]
        public int ActiveManualSafetyOrders { get; set; }

        [JsonProperty("pair")]
        public string Pair { get; set; }

        [JsonProperty("status")]
        public DealStatus Status { get; set; }

        [JsonProperty("take_profit")]
        public decimal TakeProfit { get; set; }

        [JsonProperty("base_order_volume")]
        public decimal BaseOrderVolume { get; set; }

        [JsonProperty("safety_order_volume")]
        public decimal SafetyOrderVolume { get; set; }

        [JsonProperty("safety_order_step_percentage")]
        public decimal SafetyOrderStepPercentage { get; set; }

        [JsonProperty("bought_amount")]
        public decimal BoughtAmount { get; set; }

        [JsonProperty("bought_volume")]
        public decimal BoughtVolume { get; set; }

        [JsonProperty("bought_average_price")]
        public decimal BoughtAveragePrice { get; set; }

        [JsonProperty("sold_amount")]
        public decimal SoldAmount { get; set; }

        [JsonProperty("sold_volume")]
        public decimal SoldVolume { get; set; }

        [JsonProperty("sold_average_price")]
        public decimal SoldAveragePrice { get; set; }

        [JsonProperty("take_profit_type")]
        public string TakeProfitType { get; set; }

        [JsonProperty("final_profit")]
        public decimal FinalProfit { get; set; }

        [JsonProperty("martingale_coefficient")]
        public decimal MartingaleCoefficient { get; set; }

        [JsonProperty("martingale_volume_coefficient")]
        public decimal MartingaleVolumeCoefficient { get; set; }

        [JsonProperty("martingale_step_coefficient")]
        public decimal MartingaleStepCoefficient { get; set; }

        [JsonProperty("stop_loss_percentage")]
        public decimal StopLossPercentage { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("profit_currency")]
        public CurrencyType ProfitCurrency { get; set; }

        [JsonProperty("stop_loss_type")]
        public StopLossType StopLossType { get; set; }

        [JsonProperty("safety_order_volume_type")]
        public CurrencyType SafetyOrderVolumeType { get; set; }

        [JsonProperty("base_order_volume_type")]
        public CurrencyType BaseOrderVolumeType { get; set; }

        [JsonProperty("from_currency")]
        public string FromCurrency { get; set; }

        [JsonProperty("to_currency")]
        public string ToCurrency { get; set; }

        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }

        [JsonProperty("take_profit_price")]
        public decimal TakeProfitPrice { get; set; }

        [JsonProperty("stop_loss_price")]
        public decimal StopLossPrice { get; set; }

        [JsonProperty("final_profit_percentage")]
        public decimal FinalProfitPercentage { get; set; }

        [JsonProperty("actual_profit_percentage")]
        public decimal ActualProfitPercentage { get; set; }

        [JsonProperty("bot_name")]
        public string BotName { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("usd_final_profit")]
        public decimal UsdFinalProfit { get; set; }

        [JsonProperty("actual_profit")]
        public decimal ActualProfit { get; set; }

        [JsonProperty("actual_usd_profit")]
        public decimal ActualUsdProfit { get; set; }

        [JsonProperty("failed_message")]
        public string FailedMessage { get; set; }

        [JsonProperty("reserved_base_coin")]
        public decimal ReservedBaseCoin { get; set; }

        [JsonProperty("reserved_second_coin")]
        public decimal ReservedSecondCoin { get; set; }

        [JsonProperty("trailing_deviation")]
        public decimal TrailingDeviation { get; set; }

        [JsonProperty("trailing_max_price")]
        public decimal? TrailingMaxPrice { get; set; }

        [JsonProperty("tsl_max_price")]
        public decimal? TslMaxPrice { get; set; }

        [JsonProperty("strategy")]
        public Enums.BotStrategy Strategy { get; set; }

        [JsonProperty("bot_events")]
        public List<BotEvent> BotEvents { get; set; }
    }
}
