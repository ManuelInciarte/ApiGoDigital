using ApiGoDigital.DataAccess.Entities;
using ApiGoDigital.DataAccess.IRepository;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiGoDigital.DataAccess
{
    public class RequestHttpDataAccess : IRequestHttpDataAccess
    {
    
        private static Integration _integration
        {
            get
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    //.AddJsonFile($"appsettings.Development.json", optional: true, reloadOnChange: true)
                    .Build();

                return new Integration
                {
                    Services = configuration.GetSection("integration:services").GetChildren().Select(s => new ServicesInt
                    {
                        Name = s.GetSection("name").Value,
                        URL = s.GetSection("url").Value,
                        ApiToken = s.GetSection("token").Value,
                        Methods = s.GetSection("methods").GetChildren().Select(m => new Methods
                        {
                            Method = m.GetSection("method").Value,
                            Value = m.GetSection("value").Value
                        }).ToList()
                    }).ToList()
                };
            }
            
        }

        public async Task<string> CallGetMethod(string service, string method, string parameters)
        {
            try
            {
                var _set = _integration;
                var _service = _set.Services.Where(s => s.Name.Equals(service)).ToList().FirstOrDefault();
                var _method = _service.Methods.Where(m => m.Method.Equals(method)).FirstOrDefault().Value;
                _method = !string.IsNullOrEmpty(_method) ? string.Format($"/{_method}") : null;
                var _token = _service.ApiToken;
                string URL = string.Format($"{_service.URL}{_method}{_token}{parameters}");

                using (var client = new HttpClient())
                using (var request = new HttpRequestMessage(HttpMethod.Get, URL))
                {                
                    request.Headers.Add("Accept", "application/json");
                    using (var response = await client
                        .SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                        .ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();
                        var result = await response.Content.ReadAsStringAsync();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
