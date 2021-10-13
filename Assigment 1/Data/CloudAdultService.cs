using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assigment_1.Data {
public class CloudAdultService : ICloudAdultInterface {

   private string uri = "https://localhost:5003";
   //  private string uri = "http://jsonplaceholder.typicode.com";
    private readonly HttpClient client;

    public CloudAdultService() {
        
        client = new HttpClient();
    }

    public async Task<IList<Adult>> GetAdultAsync() {
        Task<string> stringAsync = client.GetStringAsync(uri+"/adult");
        string message = await stringAsync;
        List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
        return result;
    }

    public async Task AddAdultAsync(Adult adult) {
        string todoAsJson = JsonSerializer.Serialize(adult);
        HttpContent content = new StringContent(todoAsJson,
            Encoding.UTF8,
            "application/json");
        await client.PostAsync(uri+"/adult", content);
    }

    public async Task RemoveAdultAsync(int todoId) {
        await client.DeleteAsync($"{uri}/adult/{todoId}");
    }

    public async Task UpdateAsync(Adult adult) {
        string todoAsJson = JsonSerializer.Serialize(adult);
        HttpContent content = new StringContent(todoAsJson,
            Encoding.UTF8,
            "application/json");
        await client.PatchAsync($"{uri}/adult/{adult.Id}", content);
    }
}
}