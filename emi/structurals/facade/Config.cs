namespace facade;

public class Config
{
    private static Config instance;
    private string _projectorPort;
    public string ProjectorPort
    {
        get { return _projectorPort; }
        set { _projectorPort = value; }
    }
    private int _mediumLights;
    public int MediumLights
    {
        get { return _mediumLights; }
        set { _mediumLights = value; }
    }
    private int _minLights;
    public int MinLights
    {
        get { return _minLights; }
        set { _minLights = value; }
    }
    private int _mediumVolume;
    public int MediumVolume
    {
        get { return _mediumVolume; }
        set { _mediumVolume = value; }
    }
    private int _minVolume;
    public int MinVolume
    {
        get { return _minVolume; }
        set { _minVolume = value; }
    }
    private Config()
    {
        _projectorPort = "HDMI";
        _mediumLights = 50;
        _minLights = 10;
        _mediumVolume = 15;
        _minVolume = 10;
    }
    public static Config GetInstance()
    {
        if (instance == null)
        {
            return new Config();
        }
        return instance;
    }
}
