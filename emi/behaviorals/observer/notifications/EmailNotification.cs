namespace observer;

public class EmailNotification : Notification
{
    public void SendNotification(Student student, NewsForum forum)
    {
        string message = $"Notifying via emial to student {student.Id} on {forum.Name} news: {forum.News}";
        student.update(message);
    }
}
