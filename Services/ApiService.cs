// ApiService.cs
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> FetchDataFromApiAsync()
    {
        // Replace with your actual API endpoint
        string apiUrl = "https://pokeapi.co/api/v2/";

        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"API request failed with status code {response.StatusCode}");
            }
        }
        catch (HttpRequestException ex)
        {
            throw new Exception("API request failed", ex);
        }
    }
}
