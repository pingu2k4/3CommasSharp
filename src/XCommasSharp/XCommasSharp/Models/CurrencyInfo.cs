using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCommasSharp.Models
{
    public class CurrencyInfo
    {
        [JsonProperty("last")]
        public decimal Last { get; set; }

        [JsonProperty("bid")]
        public decimal Bid { get; set; }

        [JsonProperty("ask")]
        public decimal Ask { get; set; }

        [JsonProperty("orderbook_ask")]
        public decimal OrderbookAsk { get; set; }

        [JsonProperty("orderbook_bid")]
        public decimal OrderbookBid { get; set; }

        [JsonProperty("orderbook_last")]
        public decimal OrderbookLast { get; set; }

        [JsonProperty("orderbook_price_currency")]
        public string OrderbookPriceCurrency { get; set; }

        [JsonProperty("strategy_name")]
        public string StrategyName { get; set; }

        [JsonProperty("contract_strategy_name")]
        public string ContractStrategyName { get; set; }

        [JsonProperty("minPrice")]
        public decimal MinPrice { get; set; }

        [JsonProperty("maxPrice")]
        public decimal MaxPrice { get; set; }

        [JsonProperty("priceStep")]
        public decimal PriceStep { get; set; }

        [JsonProperty("minLotSize")]
        public decimal MinLotSize { get; set; }

        [JsonProperty("maxLotSize")]
        public decimal MaxLotSize { get; set; }

        [JsonProperty("lotStep")]
        public decimal LotStep { get; set; }

        [JsonProperty("minTotal")]
        public decimal MinTotal { get; set; }

        [JsonProperty("maxMarketBuyAmount")]
        public decimal MaxMarketBuyAmount { get; set; }

        [JsonProperty("maxMarketSellAmount")]
        public decimal MaxMarketSellAmount { get; set; }
    }
}
