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
    public T Id { get;}
    public string Name { get;}
    public Person(T id, string name)
    {
        Id = id; 
        Name = name;
    }
}