class Person<T>
{
    public T Id { get;}
    public Person(T id)
    {
        Id = id;
    }
}
class UniversalPerson<T> : Person<T>
{
    public UniversalPerson(T id) : base(id) { }
}