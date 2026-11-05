namespace adapter;

public class ImportedSensor
{
    private double temperature;
    public ImportedSensor(double temp)
    {
        temperature = temp;
    }
    public double TempFahrenheit()
    {
        return temperature;
    }
}
