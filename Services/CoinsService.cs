using System.Text.Json;
using System.Net.Http.Headers;

namespace E_Recycle_currency_service;

public class CoinsService {

    public static HttpClient httpClient = new HttpClient();
    public static float calculateRecycleCoins(GainRecycleCoinsPayload gainRecycleCoinsPayload){
        return gainRecycleCoinsPayload.recycleRequest.quantity;
    }

    public static void updateRecycleCoins(int id, float recycleCoins) {
        httpClient.PatchAsync(Hosts.coreUrl+"/gainRecycleCoins/", new StringContent(JsonSerializer.Serialize<UpdateRecycleCoinsPayload>(UpdateRecycleCoinsPayload.createUpdateRecycleCoinsPayload(id, recycleCoins))));
    }

    public static async Task<string> getRecycleCoins(string token){
        httpClient.DefaultRequestHeaders.Add("Token", token);
        var response = await httpClient.GetAsync(Hosts.coreUrl+"/getRecycleCoins/");
        return response.Content.ReadAsStringAsync().Result;
    }

}
