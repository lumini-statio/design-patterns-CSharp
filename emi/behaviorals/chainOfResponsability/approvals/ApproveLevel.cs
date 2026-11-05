namespace chainOfResponsability.approvals;

public abstract class ApproveLevel : Handler
{
    private Handler _next;
    public virtual bool callNext(double expense)
    {
        return _next.handle(expense);
    }
    public abstract bool handle(double expense);
    public void setNext(Handler handler)
    {
        this._next = handler;
    }
}
