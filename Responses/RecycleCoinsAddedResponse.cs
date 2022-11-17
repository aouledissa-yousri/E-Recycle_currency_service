namespace E_Recycle_currency_service;

public class RecycleRecycleCoinsAddedResponse {

    public string message { get; set; } = "Coins has been added to user";
    public int success  { get; set; } = 1;

    public static RecycleRecycleCoinsAddedResponse createRecycleRecycleCoinsAddedResponse() {
        return new RecycleRecycleCoinsAddedResponse();
    }
}
