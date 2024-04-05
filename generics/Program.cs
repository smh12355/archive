namespace generics;
// using oleg;

class Program
{
    static void Main(string[] args)
    {
        // Person<int> tom = new Person<int>(546, "Tom");
        // Company<Person<int>> microsoft =  new Company<Person<int>>(tom);
        // Console.WriteLine(microsoft.CEO.Id);  // 546
        // Console.WriteLine(microsoft.CEO.Name);  // Tom

        // Message<string> em = new Message<string>("privet");
        // Message<string>.Testik = "poka";
        // Console.WriteLine(Message<string>.Testik);
        // Message<int>.Testik = 150;
        // Console.WriteLine(Message<string>.Testik);
        // SendMessage(new EmailMessage("Hello World"));
        Person<string> person1 = new Person<string>("34");
        Person<int> person3 = new UniversalPerson<int>(45);
        UniversalPerson<int> person2 = new UniversalPerson<int>(33);
        Console.WriteLine(person1.Id);
        Console.WriteLine(person2.Id);
        Console.WriteLine(person3.Id);
    }
    static void SendMessage(Message message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}
