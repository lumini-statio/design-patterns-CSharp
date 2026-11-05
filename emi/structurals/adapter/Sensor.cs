using System.Runtime.CompilerServices;

namespace adapter;

public abstract class Sensor
{
    private double _temperature;
    protected double Temperature
    {
        get { return _temperature; }
        set { _temperature = value; }
    }
    
    public Sensor(double temperature)
    {
        _temperature = temperature;
    }
    public abstract double TempCelsius();
}
