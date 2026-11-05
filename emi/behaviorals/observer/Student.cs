namespace observer;

public class Student
{
    private List<NewsForum> _forums;
    public List<NewsForum> Forums
    {
        get { return _forums; }
        set { _forums = value; }
    }
    
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public Student(int id)
    {
        _forums = new();
        _id = id;
    }
    public void update(string message)
    {
        System.Console.WriteLine(message);
    }
}
