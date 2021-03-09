using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommasSharp.Models;

namespace XCommasSharp
{
    public interface IXCommasApi
    {
        Task<ApiResponse<List<Account>>> GetAccountsAsync();
        Task<ApiResponse<CurrencyInfo>> GetCurrencyRatesAsync(string marketCode, string pair);
        Task<ApiResponse<List<string>>> GetMarketPairsAsync(string marketCode);
        Task<ApiResponse<Account>> GetAccountAsync(int accountId);
        Task<ApiResponse<List<AccountBalance>>> GetAccountBalancesAsync(int accountId);
        Task<ApiResponse<SmartTrade>> CreateSmartTradeAsync(CreateSmartTradeRequest request);
        Task<ApiResponse<SmartTrade>> GetSmartTradeAsync(int smartTradeId);
        Task<ApiResponse<SmartTrade>> CancelSmartTradeAsync(int smartTradeId);
        Task<ApiResponse<List<Trade>>> GetSmartTradeTradesAsync(int smartTradeId);
    }
}
