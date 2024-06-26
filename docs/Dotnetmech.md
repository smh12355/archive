## Using namespaces
Пример [(ping)][token1]

Достаточно взглянуть на пространство имен "oleg", если пространство имен явно не указано, то файл добавляется в глобальное пространство имен.


## Передача с помощью generica ссылочного типа в конструктор другого класса
Пример [(ping)][token2]

В нашем случае, все ок, потому что у нас поля в Person readonly, но в других случаях следует использовать:
* Использование конструктора копирования:
Вы можете добавить конструктор копирования в класс Person, который будет создавать копию объекта Person. Затем вы можете использовать этот конструктор при создании экземпляров Company. Этот подход аналогичен использованию интерфейса ICloneable, но с явным определением метода копирования.
```
class Company<P> where P : ICloneable
{
    public P CEO { get; set; }  // президент компании
    public Company(P ceo)
    {
        CEO = (P)ceo.Clone();
    }
}
class Person<T> : ICloneable
{
    public T Id { get; }
    public string Name { get; }
    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public object Clone()
    {
        return new Person<T>(Id, Name);
    }
}

namespace testgenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person<int> tom = new Person<int>(546, "Tom");
            Company<Person<int>> microsoft = new Company<Person<int>>(tom);
            Console.WriteLine(microsoft.CEO.Id);  // 546
            Console.WriteLine(microsoft.CEO.Name);  // Tom

            // Изменение одного экземпляра не отразится на другом
            tom.Name = "Tommy";
            Console.WriteLine(microsoft.CEO.Name);  // Tom
        }
    }
}
```

* Использование сериализации:
Вы можете сериализовать и десериализовать объект ceo, чтобы создать его глубокую копию. Это может быть сделано, например, с использованием бинарной сериализации в .NET.
csharp
```
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Company<P>
{
    public P CEO { get; set; }

    public Company(P ceo)
    {
        CEO = DeepCopy(ceo);
    }

    private P DeepCopy(P source)
    {
        if (!typeof(P).IsSerializable)
        {
            throw new ArgumentException("Type must be serializable.", nameof(source));
        }

        if (ReferenceEquals(source, null))
        {
            return default(P);
        }

        // Serialize the object to a memory stream
        BinaryFormatter formatter = new BinaryFormatter();
        using (MemoryStream stream = new MemoryStream())
        {
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);

            // Deserialize the memory stream to create a new copy
            return (P)formatter.Deserialize(stream);
        }
    }
}
```
* Использование методов клонирования:
Вместо реализации интерфейса ICloneable вы можете добавить метод клонирования в класс Person, который будет создавать глубокую копию объекта Person. Это позволяет явно контролировать процесс клонирования.
```
class Person<T>
{
    public T Id { get; }
    public string Name { get; }

    public Person<T> Clone()
    {
        return new Person<T>(Id, Name);
    }
}

class Company<P>
{
    public P CEO { get; set; }

    public Company(P ceo)
    {
        CEO = ceo.Clone();
    }
}
```
## механика плавающей точки     

При создании разностной сетки изначально я использовал следующую конструкцию:

```
X_grid = new double[Npoints];
            T_grid = new double[Tpoints];
            double ForCycle = 0;
            for (int i = 0; i < Npoints; i++)
            {
                X_grid[i] = ForCycle;
                ForCycle += (L / (Npoints - 1)) / L;
            }
            ForCycle = 0;
            for (int i = 0; i < Tpoints; i++)
            {
                T_grid[i] = ForCycle;
                ForCycle += UpperT / (Tpoints - 1) / T_star;
            }
```
тут происходит обезразмеривание на каждом шаге сетки, то есть сумма обезразмеренных элементов, в итоге получаем:
<p float="center">
  <img src="https://github.com/smh12355/archive/blob/master/imges/f1.PNG" width="400" >
</p>
посмотрим на следующий код:

```
double[] X_Grid = Enumerable.Range(0, Xpoints).Select(x => x * TrunkLength / (Xpoints - 1.0)).Select(x => x / TrunkLength).ToArray();
double[] T_Grid = Enumerable.Range(0, Tpoints).Select(x => x * UpperTimeLimit / (Tpoints - 1.0)).Select(x => x / T_Star).ToArray();
```
тут обезразмеривание происходит в последний момент и получаем уже другой результат:
<p float="center">
  <img src="https://github.com/smh12355/archive/blob/master/imges/f2.PNG" width="400" >
</p>
большая разница и меньше кода

## отличие debug от release версии в visual studio
    -   debug
        -   не выполняются некоторые оптимизации
        -   меделенее чем release
        -   доп сведения о сборке и отладочные файлы
    -   release
        -   окончательные оптимизации
        -   отладочные и метафайлы не вносятся
## !    

Videos:

Articles:

[//]: # (LINKS)
[token1]:../metanit/generics/CustomClass.cs
[token2]:../metanit/generics/Program.cs
