using strategy;

OnlineStore onlineStore = new OnlineStore();

Shipment shipment1 = new StandarShipment(3);
Shipment shipment2 = new ExpressShipment(2);
Shipment shipment3 = new LocalPickupShipment(1);
Shipment shipment4 = new StandarShipment(5);

onlineStore.StartShipment(shipment1);
onlineStore.StartShipment(shipment2);
onlineStore.StartShipment(shipment3);
onlineStore.StartShipment(shipment4);

System.Console.WriteLine();
Shipment dequeued1 = onlineStore.EndShipment();
Console.WriteLine($"   -> Processing: {dequeued1.GetType().Name} | weight: {dequeued1.Weight} kg | cost: ${dequeued1.CalculateCost():F2}");
Shipment dequeued2 = onlineStore.EndShipment();
Console.WriteLine($"   -> Processing: {dequeued2.GetType().Name} | weight: {dequeued2.Weight} kg | cost: ${dequeued2.CalculateCost():F2}");

System.Console.WriteLine();
Shipment shipment5 = new ExpressShipment(4);
onlineStore.StartShipment(shipment5);

System.Console.WriteLine();
int remainingShipments = 3;
for (int i = 0; i < remainingShipments; i++)
{
    Shipment remaining = onlineStore.EndShipment();
    Console.WriteLine($"   -> Processing: {remaining.GetType().Name} | weight: {remaining.Weight} kg | cost: ${remaining.CalculateCost():F2}");
}