using System.Text.Json;
using API.Model;


class Program
{
    private static readonly HttpClient client = new HttpClient();
    static async Task Main(string[] args)
    {
        var endpoint = new Uri("https://randomuser.me/api/?inc=gender,name,nat");
        var result = await client.GetAsync(endpoint);

        if (result.IsSuccessStatusCode)
        {
            var json = await result.Content.ReadAsStringAsync();
            var userData = JsonSerializer.Deserialize<User>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            //
        }
    }
}