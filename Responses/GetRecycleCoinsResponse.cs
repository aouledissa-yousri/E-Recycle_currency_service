namespace E_Recycle_currency_service;

public class GetRecycleCoinsResponse {

    public float coins { get; set; } 

    public GetRecycleCoinsResponse(float coins) {
        this.coins = coins;
    }

    public static GetRecycleCoinsResponse createGetRecycleCoinsResponse(float coins) {
        return new GetRecycleCoinsResponse(coins);
    }
    


}
