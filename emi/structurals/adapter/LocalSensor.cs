namespace adapter;

public class LocalSensor : Sensor
{
    public LocalSensor(double temp) : base(temp){}
    public override double TempCelsius()
    {
        System.Console.WriteLine($"Local sensor: {Temperature} °C");
        return Temperature;
    }
}
