using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.Marshalling;

namespace observer;

public class NewsForum
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _news;
    public string News
    {
        get { return _news; }
        set { _news = value; }
    }
    
    private Dictionary<int, Student> _students;
    public NewsForum(string name)
    {
        _name = name;
        _students = new(); 
    }
    public void SubscribeStudent(Student student)
    {
        _students.Add(student.Id, student);
        System.Console.WriteLine($"Student {student.Id} subscribed.");
    }
    public void UnsibscribeStudent(Student student)
    {
        _students.Remove(student.Id);
    }
    public void Notify(string news)
    {
        _news = news;
        Notification emailNotification = new EmailNotification();
        Notification appNotification = new AppNotification();
        foreach (Student student in _students.Values)
        {
            emailNotification.SendNotification(student, this);
            appNotification.SendNotification(student, this);
        }
    }
}
