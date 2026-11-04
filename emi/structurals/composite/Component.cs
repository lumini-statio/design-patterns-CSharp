namespace composite;

public abstract class Component
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public Component(string name)
    {
        _name = name;
    }
    public virtual void GetDescription()
    {
        GetDescription(0);
    }
    public virtual void GetDescription(int indentationLevel)
    {
        System.Console.WriteLine($"{new string(' ', indentationLevel * 2)}{Name}");
    }
}
