using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WebAPIDemo.Web
{
	public static class HttpConfiguration
	{
		public static HttpClient httpClient = new HttpClient();

		static HttpConfiguration()
		{
			httpClient.BaseAddress = new Uri("https://localhost:44308/api/");
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}
	} 
}