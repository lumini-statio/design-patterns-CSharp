using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer
{
    public class Student
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        private NewsForum _news;
        public NewsForum News
        {
            get { return _news; }
            set { _news = value; }
        }
        private List<NewsForum> _forums = new();
        public List<NewsForum> Forums
        {
            get { return _forums; }
            set { _forums = value; }
        }
        

        public Student(int id, string name)
        {
            _id = id;
            _nombre = name;
        }
        public void Subscribe(NewsForum forum)
        {
            forum.Subscribe(this);
            Forums.Add(News);
        }
        public void Unsuscribe(NewsForum forum)
        {
            forum.Unsuscribe(this);
            Forums.Remove(News);
        }
        public void Update(TipoNoti noti)
        {
            System.Console.WriteLine($"{noti}");
        }
        
    }
}