namespace observer;

public class AppNotification : Notification
{
    public void SendNotification(Student student, NewsForum forum)
    {
        string message = $"Notifying via app to student {student.Id} on {forum.Name} news: {forum.News}";
        student.update(message);
    }
}
