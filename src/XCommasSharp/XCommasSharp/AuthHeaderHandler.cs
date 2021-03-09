using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XCommasSharp
{
    class AuthHeaderHandler : DelegatingHandler
    {
        private readonly string _apiKey;
        private readonly string _apiSecret;

        public AuthHeaderHandler(string apiKey, string apiSecret) : base(new HttpClientHandler())
        {
            _apiKey = apiKey ?? throw new ArgumentException(null, nameof(apiKey));
            _apiSecret = apiSecret ?? throw new ArgumentException(null, nameof(apiSecret));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("apiKey", _apiKey);
            request.Headers.Add("signature", await Sign(request));

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }

        private async Task<string> Sign(HttpRequestMessage request)
        {
            string stringToSign;

            if(request.Content is not null)
            {
                if(request.Content is StringContent sc)
                {
                    var content = await sc.ReadAsStringAsync();

                    stringToSign = $"{request.RequestUri.AbsolutePath}?{content}";
                }
                else
                {
                    stringToSign = $"{request.RequestUri.AbsolutePath}?{request.Content}";
                }
            }
            else
            {
                stringToSign = request.RequestUri.PathAndQuery;
            }

            using (var hmac = new HMACSHA256(Encoding.ASCII.GetBytes(_apiSecret)))
            {
                var hashValue = hmac.ComputeHash(Encoding.ASCII.GetBytes(stringToSign));
                return HashEncode(hashValue);
            }
        }

        private string HashEncode(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}
