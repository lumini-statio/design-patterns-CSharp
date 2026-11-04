namespace composite;

public class Menu : Component
{
    private Dictionary<string, Component> components;
    public Menu(string name) : base(name)
    {
        components = new();
    }
    public void AddComponent(Component component)
    {
        components.Add(component.Name, component);
    }
    public void RemoveComponent(Component component)
    {
        if (components.ContainsKey(component.Name))
        {
            components.Remove(component.Name);
        } else
        {
            System.Console.WriteLine("No existe tal componente dentro de este menu.");
        }
    }
    public void GetContent()
    {
        System.Console.WriteLine($"{Name}");
        foreach (string fileName in components.Keys)
        {
            System.Console.WriteLine($"  {fileName}");
        }
    }
    public override void GetDescription(int indentationLevel)
    {
        System.Console.WriteLine($"{new string(' ', indentationLevel * 2)}{Name}/");
        foreach (Component component in components.Values)
        {
            component.GetDescription(indentationLevel + 1);
        }
    }
}
