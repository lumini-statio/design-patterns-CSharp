namespace templateMethod;

public class PrepareTea : PreparedInfusion
{
    public override void AddExtra(ComplementType complement)
    {
        if (complement != ComplementType.LEMON)
        {
            System.Console.WriteLine("Not allowed to asign this complement");
        }
        else
        {
            System.Console.WriteLine($"Adding {complement.ToString().ToLower()}");
            extras.Add(complement);
        }
    }

    public override void Prepare()
    {
        System.Console.WriteLine("soaking the tea bag...");
    }
}
