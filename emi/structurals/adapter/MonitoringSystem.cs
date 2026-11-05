namespace adapter;

public class MonitoringSystem
{
    private List<Sensor> _sensors;
    public MonitoringSystem(List<Sensor> sensors)
    {
        _sensors = sensors;
    }
    public void ListTemps()
    {
        foreach (Sensor sensor in _sensors)
        {
            System.Console.WriteLine($"{sensor.TempCelsius()}");
        }
    }
}
