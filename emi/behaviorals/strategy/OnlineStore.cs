namespace strategy;

public class OnlineStore
{
    private Queue<Shipment> shipments;
    public OnlineStore()
    {
        shipments = new();
    }
    public void StartShipment(Shipment shipment)
    {
        System.Console.WriteLine("Shipment started");
        shipments.Enqueue(shipment);
    }
    public Shipment EndShipment()
    {
        System.Console.WriteLine("Shipment ended");
        return shipments.Dequeue();
    }
}
