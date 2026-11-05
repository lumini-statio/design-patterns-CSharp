namespace adapter;

public class LocalSensorAdapter : Sensor
{
    private ImportedSensor _importedSensor;
    public LocalSensorAdapter(ImportedSensor importedSensor, double temperature) : base(temperature)
    {
        _importedSensor = importedSensor;
    }
    public override double TempCelsius()
    {
        double fTemp = _importedSensor.TempFahrenheit();
        double Temperature = (fTemp - 32) * 5/9;
        System.Console.WriteLine($"Imported sensor: {Temperature} °C");
        return Temperature;
    }
}
