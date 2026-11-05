using observer;

// The course has an announcements channel. Each student can subscribe to receive updates via email or the app,
// and can unsubscribe at any time.

// Whenever an announcement is posted, it is sent to everyone who is subscribed at that moment.
// The channel should not be aware of the specific notification methods, as other channels—such as WhatsApp—might be added later.

var estudiante1 = new Student(1);
var estudiante2 = new Student(2);
var estudiante3 = new Student(3);

var foroPrincipal = new NewsForum("principal forum");

foroPrincipal.SubscribeStudent(estudiante1);
estudiante1.Forums.Add(foroPrincipal);
foroPrincipal.SubscribeStudent(estudiante2);
estudiante2.Forums.Add(foroPrincipal);
foroPrincipal.SubscribeStudent(estudiante3);
estudiante3.Forums.Add(foroPrincipal);

var segundoForo = new NewsForum("secondary forum");

segundoForo.SubscribeStudent(estudiante1);
estudiante1.Forums.Add(segundoForo);
segundoForo.SubscribeStudent(estudiante2);
estudiante2.Forums.Add(segundoForo);

System.Console.WriteLine();
foroPrincipal.Notify("news on **principal** forum");
System.Console.WriteLine();
segundoForo.Notify("news on **secondary** forum");
