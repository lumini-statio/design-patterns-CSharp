using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace observer
{
    public class NewsForum
    {
        private List<Student> _subscribers = new List<Student>();
        public List<Student> Subscribers
        {
            get { return _subscribers; }
            set { _subscribers = value; }
        }
        private Notification? _notification;
        public Notification? notification
        {
            get { return _notification; }
            set { _notification = value; }
        }
        public NewsForum()
        {
            
        }
        public void Subscribe(Student student){
            System.Console.WriteLine($"subscribing user: {student.Nombre}");
            _subscribers.Add(student);
            System.Console.WriteLine($"the student '{student.Nombre}' with id: '{student.Id}' has been succesfully subscribed");
        }
        public void Unsuscribe(Student student){
            System.Console.WriteLine($"unsubscribing user: {student.Nombre}");
            _subscribers.Remove(student);
            System.Console.WriteLine($"the student {student.Id} has been unsuscribed");
        }
        public void Notify(Notification notif)
        {
            foreach(Student s1 in Subscribers)
            {
                s1.Update(notification.noti);
            }
        }
    }
}