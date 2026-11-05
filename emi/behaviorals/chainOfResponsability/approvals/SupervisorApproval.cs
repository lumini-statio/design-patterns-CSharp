namespace chainOfResponsability.approvals;

public class SupervisorApproval : ApproveLevel
{
    public override bool handle(double expense)
    {
        if (expense <= 0) return false;
        if (expense > 50000) return Next.handle(expense);
        System.Console.WriteLine("Approved by supervisor");
        return true;
    }
}
