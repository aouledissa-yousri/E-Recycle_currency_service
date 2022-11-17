namespace E_Recycle_currency_service;

public class GainRecycleCoinsPayload {

    public int id  { get; }
    public RecycleRequest recycleRequest { get; }

    public GainRecycleCoinsPayload(int id, RecycleRequest recycleRequest){
        this.id = id;
        this.recycleRequest = recycleRequest;
    }

    public static GainRecycleCoinsPayload createGainRecycleCoinsPayload(int id, RecycleRequest recycleRequest){
        return new GainRecycleCoinsPayload(id, recycleRequest);
    }
}
