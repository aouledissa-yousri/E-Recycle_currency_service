namespace E_Recycle_currency_service;

public class RecycleRecycleCoinsNotAddedResponse {

    public string message { get; set; } = "Coins has not been added to user";
    public int success  { get; set; } = -1;

    public static RecycleRecycleCoinsNotAddedResponse createRecycleRecycleCoinsNotAddedResponse() {
        return new RecycleRecycleCoinsNotAddedResponse();
    }
}
