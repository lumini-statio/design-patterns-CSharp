namespace chainOfResponsability.approvals;

public class DirectorApproval : ApproveLevel
{
    public override bool handle(double expense)
    {
        System.Console.WriteLine($"Approved by director");
        return true;
    }
}
