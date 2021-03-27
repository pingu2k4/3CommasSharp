using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Models;

namespace XCommasSharp
{
    public class XCommasApi : IXCommasApi
    {
        private readonly IXCommasApiInternal _api;

        public XCommasApi(string apiKey, string apiSecret, string baseUri = "https://api.3commas.io/public/api")
        {
            var refitSettings = new RefitSettings()
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer(new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                })
            };

            _api = RestService.For<IXCommasApiInternal>(new HttpClient(new AuthHeaderHandler(apiKey, apiSecret))
            {
                BaseAddress = new Uri(baseUri)
            }, refitSettings);
        }

        public async Task<ApiResponse<List<Account>>> GetAccountsAsync()
        {
            return await _api.GetAccounts();
        }

        public async Task<ApiResponse<List<string>>> GetMarketPairsAsync(string marketCode)
        {
            return await _api.GetMarketPairs(marketCode);
        }

        public async Task<ApiResponse<CurrencyInfo>> GetCurrencyRatesAsync(string marketCode, string pair)
        {
            return await _api.GetCurrencyRates(marketCode, pair);
        }

        public async Task<ApiResponse<Account>> GetAccountAsync(int accountId)
        {
            return await _api.LoadBalances(accountId);
        }

        public async Task<ApiResponse<List<AccountBalance>>> GetAccountBalancesAsync(int accountId)
        {
            return await _api.GetAccountBalances(accountId);
        }

        public async Task<ApiResponse<SmartTrade>> CreateSmartTradeAsync(CreateSmartTradeRequest request)
        {
            return await _api.CreateSmartTrade(request);
        }

        public async Task<ApiResponse<SmartTrade>> GetSmartTradeAsync(int smartTradeId)
        {
            return await _api.GetSmartTrade(smartTradeId);
        }

        public async Task<ApiResponse<SmartTrade>> CancelSmartTradeAsync(int smartTradeId)
        {
            return await _api.CancelSmartTrade(smartTradeId);
        }

        public async Task<ApiResponse<List<Trade>>> GetSmartTradeTradesAsync(int smartTradeId)
        {
            return await _api.GetSmartTradeTrades(smartTradeId);
        }

        public async Task<ApiResponse<List<Bot>>> GetBotsAsync(GetBotsRequest request)
        {
            return await _api.GetBots(request);
        }

        public async Task<ApiResponse<Deal>> StartDealAsync(StartDealRequest request)
        {
            return await _api.StartDeal(request.BotId, request);
        }

        public async Task<ApiResponse<Deal>> GetDealAsync(int id)
        {
            return await _api.GetDeal(id);
        }

        public async Task<ApiResponse<SmartTrade>> PanicSellSmartTradeAsync(int id)
        {
            return await _api.PanicSellSmartTrade(id);
        }
    }
}
