using System.Text.Json;

namespace E_Recycle_currency_service;

public class CoinsService {

    public static HttpClient httpClient = new HttpClient();
    public static float calculateRecycleCoins(GainRecycleCoinsPayload gainRecycleCoinsPayload){
        return gainRecycleCoinsPayload.recycleRequest.quantity;
    }

    public static void updateRecycleCoins(int id, float recycleCoins) {
        var response = httpClient.PatchAsync(Hosts.coreUrl+"/gainRecycleCoins/", new StringContent(JsonSerializer.Serialize<UpdateRecycleCoinsPayload>(UpdateRecycleCoinsPayload.createUpdateRecycleCoinsPayload(id, recycleCoins))));
    }
}
