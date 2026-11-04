namespace facade;

public class SoundSystem
{
    private int _volume;
    private bool _isOn;
    public int Volume
    {
        get { return _volume; }
    }
    public SoundSystem(int volume)
    {
        _isOn = false;
        _volume = volume;
    }
    public void ChangeVolume(int volume)
    {
        _volume = volume;
    }
    public void PowerOn()
    {
        _isOn = true;
    }
    public void PowerOff()
    {
        _isOn = false;
    }
}
