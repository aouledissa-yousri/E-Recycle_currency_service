namespace E_Recycle_currency_service;

public class RecycleRequest {

    public int id {get; set;}
    public string material {get; set;} = "";
    public float quantity {get; set;}
    public string unit {get; set;} = "";
    public string location {get; set;} = "";
    public string dateSubmitted {get; set;} = ""; 
    public string status {get; set;} = "";
}
