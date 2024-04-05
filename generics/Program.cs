namespace generics;
using oleg;

class Program
{
    static void Main(string[] args)
    {
        Person<int> tom = new Person<int>(546, "Tom");
        Company<Person<int>> microsoft =  new Company<Person<int>>(tom);
        Console.WriteLine(microsoft.CEO.Id);  // 546
        Console.WriteLine(microsoft.CEO.Name);  // Tom
    }
}
