using Microsoft.Extensions.Options;
using MyWebAPI.Infrastructure;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyWebAPI.Service
{
	public interface IApiCallService
	{
		public Task<string> GetApiResult();
	}

	public class ApiCallService : IApiCallService
	{
		private readonly HttpClient _httpClient;
		private readonly IOptions<Api> _appSettings;

		public ApiCallService(HttpClient httpClient, IOptions<Api> appSettings)
		{
			_httpClient = httpClient;
			_appSettings = appSettings;
		}

		public async Task<string> GetApiResult()
		{
			var uri = _appSettings.Value.Uri;

			var responseString = await _httpClient.GetStringAsync(uri);

			
			return responseString;
		}
	}
}
