// See https://aka.ms/new-console-template for more information
using observer;

Console.WriteLine("Hello, World!");
Student Luis = new(1,"Luis");
Student Ana = new(2,"Ana");
NewsForum forum = new();
NotiApp notiApp = new();
notiApp.noti = TipoNoti.clases;
forum.notification = notiApp;


Ana.Subscribe(forum);
Luis.Subscribe(forum);
forum.Notify(notiApp);
Luis.Unsuscribe(forum);