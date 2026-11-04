namespace facade;

public class Projector
{
    private bool _isOn;
    public bool IsOn
    {
        get { return _isOn; }
    }
    private string _inputCable;
    public string InputCable
    {
        get { return _inputCable; }
    }
    
    public Projector()
    {
        _isOn = false;
    }
    public void ChooseInput(string inputCable)
    {
        _inputCable = inputCable;
        System.Console.WriteLine($"Input on {_inputCable}");
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
