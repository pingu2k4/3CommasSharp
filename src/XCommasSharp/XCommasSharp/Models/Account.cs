using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Enums;

namespace XCommasSharp.Models
{
    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("auto_balance_period")]
        public int? AutoBalancePeriod { get; set; }

        [JsonProperty("auto_balance_portfolio_id")]
        public int? AutoBalancePortfolioId { get; set; }

        [JsonProperty("auto_balance_currency_change_limit")]
        public int? AutoBalanceCurrencyChangeLimit { get; set; }

        [JsonProperty("autobalance_enabled")]
        public bool AutobalanceEnabled { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("smart_trading_supported")]
        public bool SmartTradingSupported { get; set; }

        [JsonProperty("available_for_trading")]
        public Dictionary<string, string> AvailableForTrading { get; set; }

        [JsonProperty("stats_supported")]
        public bool StatsSupported { get; set; }

        [JsonProperty("trading_supported")]
        public bool TradingSupported { get; set; }

        [JsonProperty("market_buy_supported")]
        public bool MarketBuySupported { get; set; }

        [JsonProperty("market_sell_supported")]
        public bool MarketSellSupported { get; set; }

        [JsonProperty("conditional_buy_supported")]
        public bool ConditionalBuySupported { get; set; }

        [JsonProperty("bots_allowed")]
        public bool BotsAllowed { get; set; }

        [JsonProperty("bots_ttp_allowed")]
        public bool BotsTtpAllowed { get; set; }

        [JsonProperty("bots_tsl_allowed")]
        public bool BotsTslAllowed { get; set; }

        [JsonProperty("gordon_bots_available")]
        public bool GordonBotsAvailable { get; set; }

        [JsonProperty("multi_bots_allowed")]
        public bool MultiBotsAllowed { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("last_auto_balance")]
        public DateTime? LastAutoBalance { get; set; }

        [JsonProperty("fast_convert_available")]
        public bool FastConvertAvailable { get; set; }

        [JsonProperty("grid_bots_allowed")]
        public bool GridBotsAllowed { get; set; }

        [JsonProperty("api_key_invalid")]
        public bool ApiKeyInvalid { get; set; }

        [JsonProperty("nomics_id")]
        public string NomicsId { get; set; }

        [JsonProperty("market_icon")]
        public Uri MarketIcon { get; set; }

        [JsonProperty("supported_market_types")]
        public List<string> SupportedMarketTypes { get; set; }

        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("auto_balance_method")]
        public AccountBalanceMethod AutoBalanceMethod { get; set; }

        [JsonProperty("auto_balance_error")]
        public string AutoBalanceError { get; set; }

        [JsonProperty("lock_reason")]
        public string LockReason { get; set; }

        [JsonProperty("btc_amount")]
        public decimal BtcAmount { get; set; }

        [JsonProperty("usd_amount")]
        public decimal UsdAmount { get; set; }

        [JsonProperty("day_profit_btc")]
        public decimal DayProfitBtc { get; set; }

        [JsonProperty("day_profit_usd")]
        public decimal DayProfitUsd { get; set; }

        [JsonProperty("day_profit_btc_percentage")]
        public decimal DayProfitBtcPercentage { get; set; }

        [JsonProperty("day_profit_usd_percentage")]
        public decimal DayProfitUsdPercentage { get; set; }

        [JsonProperty("btc_profit")]
        public decimal BtcProfit { get; set; }

        [JsonProperty("usd_profit")]
        public decimal UsdProfit { get; set; }

        [JsonProperty("usd_profit_percentage")]
        public decimal UsdProfitPercentage { get; set; }

        [JsonProperty("btc_profit_percentage")]
        public decimal BtcProfitPercentage { get; set; }

        [JsonProperty("total_btc_profit")]
        public decimal TotalBtcProfit { get; set; }

        [JsonProperty("total_usd_profit")]
        public decimal TotalUsdProfit { get; set; }

        [JsonProperty("pretty_display_type")]
        public string PrettyDisplayType { get; set; }

        [JsonProperty("exchange_name")]
        public string ExchangeName { get; set; }

        [JsonProperty("market_code")]
        public string MarketCode { get; set; }
    }
}