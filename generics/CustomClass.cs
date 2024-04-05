namespace oleg;
class Company<P>
{
    public P CEO { get; set; }  // президент компании
    public Company(P ceo)
    {
        CEO = ceo;
    }
}
class Person<T>
{
    public T Id { get; }
    public string Name { get; }
    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }
}
class Person_new<T, K>
{
    public T first_arg { get; set; }
    public K second_arg { get; set; }

    public Person_new(T a, K b)
    {
        first_arg = a;
        second_arg = b;
    }
}

