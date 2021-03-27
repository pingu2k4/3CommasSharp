using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Models;

namespace XCommasSharp
{
    internal interface IXCommasApiInternal
    {
        [Get("/ver1/accounts")]
        Task<ApiResponse<List<Account>>> GetAccounts();

        [Get("/ver1/accounts/market_pairs")]
        Task<ApiResponse<List<string>>> GetMarketPairs([AliasAs("market_code")] string marketCode);

        [Get("/ver1/accounts/currency_rates")]
        Task<ApiResponse<CurrencyInfo>> GetCurrencyRates([AliasAs("market_code")] string marketCode, [AliasAs("pair")] string pair);

        [Post("/ver1/accounts/{account_id}/load_balances")]
        Task<ApiResponse<Account>> LoadBalances([AliasAs("account_id")] int accountId);

        [Post("/ver1/accounts/{account_id}/account_table_data")]
        Task<ApiResponse<List<AccountBalance>>> GetAccountBalances([AliasAs("account_id")] int accountId);

        [Post("/v2/smart_trades")]
        Task<ApiResponse<SmartTrade>> CreateSmartTrade([Body] CreateSmartTradeRequest request);

        [Get("/v2/smart_trades/{id}")]
        Task<ApiResponse<SmartTrade>> GetSmartTrade([AliasAs("id")] int smartTradeId);

        [Delete("/v2/smart_trades/{id}")]
        Task<ApiResponse<SmartTrade>> CancelSmartTrade([AliasAs("id")] int smartTradeId);

        [Get("/v2/smart_trades/{id}/trades")]
        Task<ApiResponse<List<Trade>>> GetSmartTradeTrades([AliasAs("id")] int smartTradeId);

        [Get("/ver1/bots")]
        Task<ApiResponse<List<Bot>>> GetBots(GetBotsRequest request);

        [Post("/ver1/bots/{id}/start_new_deal")]
        Task<ApiResponse<Deal>> StartDeal([AliasAs("id")] int id, [Body] StartDealRequest request);

        [Get("/ver1/deals/{id}/show")]
        Task<ApiResponse<Deal>> GetDeal([AliasAs("id")] int id);

        [Post("/v2/smart_trades/{id}/close_by_market")]
        Task<ApiResponse<SmartTrade>> PanicSellSmartTrade([AliasAs("id")] int smartTradeId);
    }
}
