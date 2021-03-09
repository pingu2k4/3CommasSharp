using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class AccountBalance
    {
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_name")]
        public string CurrencyName { get; set; }

        [JsonProperty("currency_icon")]
        public Uri CurrencyIcon { get; set; }

        [JsonProperty("currency_slug")]
        public string CurrencySlug { get; set; }

        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }

        [JsonProperty("position")]
        public decimal Position { get; set; }

        [JsonProperty("borrowed")]
        public decimal Borrowed { get; set; }

        [JsonProperty("on_orders")]
        public decimal OnOrders { get; set; }

        [JsonProperty("equity")]
        public decimal Equity { get; set; }

        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }

        [JsonProperty("current_price_usd")]
        public decimal CurrentPriceUsd { get; set; }

        [JsonProperty("day_change_percent")]
        public decimal DayChangePercent { get; set; }

        [JsonProperty("day_change_percent_btc")]
        public decimal DayChangePercentBtc { get; set; }

        [JsonProperty("day_change_percent_usd")]
        public decimal DayChangePercentUsd { get; set; }

        [JsonProperty("btc_value")]
        public decimal BtcValue { get; set; }

        [JsonProperty("usd_value")]
        public decimal UsdValue { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }
    }
}
