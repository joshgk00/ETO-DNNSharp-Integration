using System;

namespace Eto.Parser
{
    public static class Common
    {
        public static string GetApiBaseUrl(string domainRoot)
        {
            return $"{domainRoot}/DesktopModules/DnnSharp/DnnApiEndpoint/Api.ashx";
        }

        public static string ExecuteApiCall(Uri apiUrl)
        {
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            var response = httpClient.GetAsync(apiUrl);
            response.Result.EnsureSuccessStatusCode();

            var strRespone = response.Result.Content.ReadAsStringAsync();
            return strRespone.Result.ToString();
        }
    }
}