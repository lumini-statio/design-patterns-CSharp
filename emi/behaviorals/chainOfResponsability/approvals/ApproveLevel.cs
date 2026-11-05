namespace chainOfResponsability.approvals;

public abstract class ApproveLevel : Handler
{
    private Handler _next;
    public Handler Next
    {
        get { return _next; }
        set { _next = value; }
    }
    
    public virtual void callNext(double expense)
    {
        _next.handle(expense);
    }
    public abstract bool handle(double expense);
    public void setNext(Handler handler)
    {
        this._next = handler;
    }
}
