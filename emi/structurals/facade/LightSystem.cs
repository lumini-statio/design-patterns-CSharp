namespace facade;

public class LightSystem
{
    private int _lightLevel;
    public int LightLevel
    {
        get { return _lightLevel; }
    }
    public LightSystem(int lightLevel)
    {
        _lightLevel = lightLevel;
    }
    public void SetLightLevel(int lightLevel)
    {
        _lightLevel = lightLevel;
    }
}
