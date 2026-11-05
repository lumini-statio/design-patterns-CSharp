namespace templateMethod;

public abstract class PreparedInfusion
{
    protected List<ComplementType> extras;
    public PreparedInfusion()
    {
        extras = new();
    }
    public virtual void TemplateInfusion()
    {
        BoilWater();
        Prepare();
        Serve();
    }
    public void BoilWater()
    {
        System.Console.WriteLine("Boiling water...");
    }
    public abstract void Prepare();
    public void Serve()
    {
        System.Console.WriteLine("Serving...");
    }
    public abstract void AddExtra(ComplementType complement);
}
