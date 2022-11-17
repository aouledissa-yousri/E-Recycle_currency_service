namespace E_Recycle_currency_service;

public class UpdateRecycleCoinsPayload {

    public int id  { get; }
    public float coins { get; }

    public UpdateRecycleCoinsPayload(int id, float coins) {
        this.id = id;
        this.coins = coins;
    }

    public static UpdateRecycleCoinsPayload createUpdateRecycleCoinsPayload(int id, float coins){
        return new UpdateRecycleCoinsPayload(id, coins);
    }
}
