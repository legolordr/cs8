using System.Net.Http.Json;
using System.Text.Encodings.Web;
using System.Text.Json;
using cs8;



using var http = new HttpClient();
using var cts = new CancellationTokenSource();
        
Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true;
    cts.Cancel();
};

while (!cts.IsCancellationRequested)
{
    try
    {
        Console.WriteLine("To exit, press Ctrl + C");
        
        string? id = Input.InputId();
       
        CreationUrl url = new CreationUrl(id);
        var json = await http.GetFromJsonAsync<Root>(url.FullUrl, cts.Token);
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        Console.WriteLine(JsonSerializer.Serialize(json, options));
        ParentChildren.PrintId(json!);
    }
    catch (OperationCanceledException)
    {
        Console.WriteLine("Operation cancelled");
        break;
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