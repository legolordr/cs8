using System.Net.Http.Json;
using System.Text.Encodings.Web;
using System.Text.Json;
using cs8;

public static class Program
{
    private static async Task Main()
    {
        var http =  new HttpClient();
        while (true)
        {
            try
            {
                string id = Input.InputId();
                CreationUrl url = new CreationUrl(id);
                var json = await http.GetFromJsonAsync<SiteData>(url.FullUrl);
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                Console.WriteLine(JsonSerializer.Serialize(json, options));
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("You entered an invalid id");
            }
            catch (JsonException)
            {
                Console.WriteLine("Invalid json");
                throw;
            }
        }
    }
}