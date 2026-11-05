namespace chainOfResponsability;

public interface Handler
{
    public bool handle(double expense);
    public bool callNext(double expense);
    public void setNext(Handler handler);
}
