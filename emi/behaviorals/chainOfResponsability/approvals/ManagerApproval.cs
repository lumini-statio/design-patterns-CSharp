namespace chainOfResponsability.approvals;

public class ManagerApproval : ApproveLevel
{
    public override bool handle(double expense)
    {
        if (expense > 200000) return Next.handle(expense);
        System.Console.WriteLine("Approved by manager");
        return true;
    }
}
