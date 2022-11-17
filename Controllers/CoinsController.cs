using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace E_Recycle_currency_service;

[ApiController]
[Route("api/[controller]")]
public class CoinsController : ControllerBase {


    [HttpPatch(Name = "gainCoins")]
    [Route("gainCoins")]
    public string gainCoins([FromBody] GainRecycleCoinsPayload  gainCoinsPayload){

        if(gainCoinsPayload.id == 0)
            return JsonSerializer.Serialize<RecycleRecycleCoinsAddedResponse>(RecycleRecycleCoinsAddedResponse.createRecycleRecycleCoinsAddedResponse());
        
        CoinsService.updateRecycleCoins(gainCoinsPayload.id, CoinsService.calculateRecycleCoins(gainCoinsPayload));
        return JsonSerializer.Serialize<RecycleRecycleCoinsAddedResponse>(RecycleRecycleCoinsAddedResponse.createRecycleRecycleCoinsAddedResponse());
    }
}
