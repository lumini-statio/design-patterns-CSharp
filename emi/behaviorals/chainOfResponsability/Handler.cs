namespace chainOfResponsability;

public interface Handler
{
    public bool handle(double expense);
    public void callNext(double expense);
    public void setNext(Handler handler);
}
