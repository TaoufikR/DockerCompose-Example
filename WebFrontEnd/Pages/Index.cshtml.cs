using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyWebAPI.Service;
using System.Threading.Tasks;

namespace WebFrontEnd.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private readonly IApiCallService _apiCallService;

		public IndexModel(ILogger<IndexModel> logger, IApiCallService apiCallService)
		{
			_logger = logger;
			_apiCallService = apiCallService;
		}

		public async Task OnGet()
		{
			ViewData["Message"] += " and " + await _apiCallService.GetApiResult();
			//using (var client = new System.Net.Http.HttpClient())
			//{
			//	// Call *mywebapi*, and display its response in the page
			//	var request = new System.Net.Http.HttpRequestMessage();
			//	 request.RequestUri = new Uri("http://mywebapi/WeatherForecast"); // ASP.NET 3 (VS 2019 only)
			//	//request.RequestUri = new Uri("http://mywebapi/api/values/1"); // ASP.NET 2.x
			//	var response = await client.SendAsync(request);
			//	ViewData["Message"] += " and " + await response.Content.ReadAsStringAsync();
			//}

		}
	}
}
