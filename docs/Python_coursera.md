# Python in meta course(Coursera)
> [!NOTE]
> Done
## 1-st week
1.  **Variables**
    -   Style
        -   camelCase
            -   heyThere
            -   firstOne
        -   Snake
            -   my_variable
            -   first_one
2.  **Data types**
    -   command = type()
    -   Numeric
        -   integer
        -   float
        -   complex number
    -   Sequence
        -   String
        -   List
        -   Tuples
    -   Dictionary
    -   Boolean
    -   Set
3.  **String**
    -   Кодировка:Unicode
    -   Перенос строки(в выводе не переносится) = \
    -   String = array
    -   "daasd" \ "dasdsa" такой перенос тоже работает
    -   конкатинация = a + b
    -   string.format({}) = a = "{}{}".format(a,b)
    -   format f"{a}{b}"
4.  **Type cast**
    -   Imlicit = неявное
        -   в рамках совместимых типов(int <-> float)
    -   Explicit = явное
        -   int()
        -   float()
        -   str()
        -   ord() = unicode cast
        -   oct() = 8-ричное представление
        -   tuple() = картеж
        -   set() = множество
        -   list() = лист
        -   dict() = словарь
5.  **Input and output**
    -   Input("") - ввод данных с клавиатуры
    -   Print - вывод с клавиатуры
        -   sep = сепаратор print("apple", "banana", "orange", sep="))")
        -   end = что будет добавлено в конце строки по умолчанию \n
        -   file = куда будут выводиться данные
        -   flush - форсит немедленно записать в файл
6.  **Operators**
    -   Math
        -   "+"
        -   "-"
        -   "="
        -   "*"
    -   Logical
        -   and
        -   or
        -   not
    -   Condition
        -   if
        -   else
        -   elif
    -   Loops
        -   for
            -   for i in range()
            -   for i,j in enumerate()
        -   exit operators
            -   break
        -   continue operators
            -   continue
        -   skip operators
            -   pass
        -   while
        -   Loops special words
            -   enumerate()
            -   range()
            -   pass
            -   break
            -   continue
    -   mathch-case
        -   case 2:
        -   case _: = default!!
    -   alg complexity
        -   rule with n-alghorithm inpute size data and time program execute => n > => t >
## 2-st week
1.  **Function**
    -   def asd:
    return2
2.  **Scope**
    -   for protect variable with context
        -   specification
            -   local
                -   inside function
            -   global
                -   outside of all functions(main context)
            -   enclosing
                -   def inside def
            -   built-in
                -   can use it without type like print
3.  **data structures**
    -   built-in
        -   List = mutable collection
        -   set = mutable collection
        -   tuple = unmutable collection
        -   dictionary = mutable collection
        -   string!!! = unmutable
        -   frozen set = unmutable
    -   custom
        -   Queue = FIFO => FIRST IN FIRST OUT => {1,2} => {1,2,3} => {2,3}
        -   Stack => LIFO = LAST IN FIRST OUT => СТОПКА КНИГ ИЛИ СТОПКА ТАРЕЛОК => {1} => {2,1} => {3,2,1} => {2,1}
        -   Tree => стоит углубиться = > это надолго
        -   LinkedList => ссылки на следующий и на предидущий элемент в каждом элементе
        -   HashMap => dict в питоне
            -   колизии
                -   __hash__ совпадают для обоих ключей
                -   метод цепочек = двусвязный список в одном ключе
                -   открытая адресация = не понял до конца что-это хеш совпадает ищем новое место
                    -   линейное зондирование
                    -   квадратичное зондирование
                    -   двойное хеширование
                    -   custom
    -   list
        -   a = []
        -   print(*(listexample)) - выводит все элементы листа
        -   print(listexample,sep='')
        -   add
            -   insert
            -   append
            -   extend
        -   remove
            -   pop
            -   del list[1]
        -   for i in list:
    -   tuples
        -   a = ()
        -   a.index()
        -   a.count()
        -   unmutable
    -   set
        -   a = {}
        -   not a sequnce = for dont work
        -   set.add() = add element
        -   set func
            -   union = a | b
            -   intersections = a & b
            -   difference = a - b
            -   symetrical diff = a ^ b
            -   set[0] = error = not a sequence
    -   dicts
        -   for i in a:
        -   for i,j in a.items()
        -   del a[0]
4.  **File read write**
    -   file
        -   open
        -   close
    -   mode
        -   r  = read
        -   r+ = read + write
        -   w = write
        -   a = append
        -   rb = binary read
    -   after open we need to close()
    -   with open("./asd.txt","r+") as file:
5.  **args kwargs**
    -   def (*args)
        for i in args:
    -   def (**kwargs)
        for a,b in kwargs.items()
6.  **Excentions errors**
    -   syntax
    -   runtime exceptions
        -   try:
        -   except:
            -   except Exception as e:
## 3-st week
1.  **Code structure**
    -   procedure
        -   easy to learn
        -   Reusable
        -   easy to do
    -   functional
    -   oop
    -   principe = dont repeat urself = DRY
2.  **Algorithm**
    -   Decomposition
        -   рекусрия
        -   разделяй и властвуй
        -   динамическое программирование
        -   жадный алгоритм
    -   Критерии
        -   время выполнения
        -   память
    -   Сложность
        -   O(1) - доступ по индексу в листе
        -   O(n) - поиск в несартированном списке
        -   0(n^2) - сортировка пузырьком
        -   O(log n) - бинарный поиск в отсортированном списке
        -   O(n log n) - лучший случай быстрой сортировки, сортировки слиянием и пирамиадльной сортировке
        -   O(2^n) - экспоненциальная сложность 
        -   O(n!) - факториальная сложность
    -   Анализ алгоритма
        -   входные данные
        -   обратить внимание на циклы
        -   Количество операций внутри цикла
        -   Вложенные циклы = умножение
        -   Сосредоточиться над доминирующей сложностью
        -   упрощай, удаляй коснтанты
3.  **Функциональное программирование**
    -   традиционное
        -   использует глобальные переменные(контекст)
        -   изменяет глобальные переменные
        -   изменяет аргументы
        -   использует локальные переменные
    -   чистое(pure)
        -   использует локальные переменные
        -   вывод зависит от входных данных
    -   DOUNT TOUCH DATA OUTSIDE
    -   INDEPENDENT
    -   PURE
        -   known outcome
        -   consistant
        -   cache
        -   multi-thread support
    -   recursion
        -   function call urself
4. **Map and filter**
    -   MAP(FUNC,ARG)
        -   возвращает обьект Map => если не удволетворяет услловию возвращает None
    -   Filter(func,arg)
        -   удаляет элементы которые не подходят
```
words = ["apple", "banana", "cherry"]
word_lengths = list(map(len, words))
```
```
words = ["apple", "banana", "cherry"]
word_lengths = list(filter(len, words))
```
5. **Comprehensions**
    -   List
        -   [x + 1 for x in data]
        -   [x + 1 for x in data if x == 0] 
    -   Dict
        -   {x:x*2 for x in data}
        -   {a1:a2 for (a1,a2) in zip(a,b)}
    -   set
        -   {x for x in range (0,20) not in [12,16,13]}
6. **List Generator**
    -   generators - тут на самом деле очень кратко описано там еще yield есть, это сложная тема
```
data = [1, 2, 3, 4, 5]
gener = (x for x in data)
for i in gener:
    print(i)
```
7.  **OOP Python**
    -   вобщем парадигмы программирования
        -   ООП
        -   Императивное выполнение программ
            -   Процедурное
        -   Функциональное = отличие от процедурного - то что функции pure
        -   Декларативное
        -   Логическое
        -   flow-driven - потокове программирование - не обязательно параллельное выполнение и асинхронное = организация внутренней структуры( не распространена)
        -   event-driven - реакция на дейсвие = СОП по русски = dotnet с помощью event реализует подписочную реализацию евентов (publisher/subscriber)
    -   Python
        -   OOP
        -   functional
        -   procedure
    -   модульность ООП
        -   легок для понимания
        -   reusable
        -   Abstraction
        -   Move between projects
    -   key components
        -   class
            -   Attributes = variables
            -   Behavior = functions(methods)
            -   class => object (all in python is a object)
        -   object
            -   instant of class
        -   methods = behavior of class
8.  **OOP Conceptions**
    -   наследование
        -   parent - child модель => в питоне еще допом идет MRO
    -   инкапсуляция
        -   методы и поля в одном блоке данных => область видимости
        -   сокрытие данных с помощью модификаторов доступа
            -   в питоне _ = протектед
            -   __ = приват
    -   полиморфизм
        -   многообразие => например функция ведет себя по-разному взависимости от типа данных которые подаются ей на вход  
    -   абстракция
        -   средство сокрытия, как важной так и ненужной информации
        -   реализуется с помощью абстррактных класов и методов
    -   Attributes = vars
    -   Behavior = methods
    -   Object = main thing in Python
9.  **Class in python**
    -   pass = заглушка
    -   _ = протектед
    -   __ = приват
    -   доступ к приватным полям
    -   заместо self - может быть любое другое слово
    -   очень важно = КЛАСС ДОЛЖЕН БЫТЬ ОБЬЯВЛЕН ДО ИНИЦИЛИЗАЦИИ ЭКЗЕМПЛЯРОВ
```
class MyClass:
    __hidden_variable = 5

    def get_hidden_variable(self):
        return self.__hidden_variable
```
### Пример использования
```
obj = MyClass()
print(obj.get_hidden_variable())  # Работает, потому что мы используем открытый метод для доступа к скрытому атрибуту


# Попытка прямого доступа к скрытой переменной вызовет ошибку
# print(obj.__hidden_variable)  # Ошибка: 'MyClass' object has no attribute '__hidden_variable'

# Однако мы можем получить доступ к этой переменной, используя искаженное имя
print(obj._MyClass__hidden_variable)  # Работает, так как мы испол
```
10. **Наследование(inheritance)**
    -   пример: class A(B)
    -   функции првоерки:
        -   issubclass(child,parent) - является ли сыном
        -   isininstance(b,B) - является ли экземпляром
        -   super() - позволяет обращаться к методам родительского класса из дочернего
            -   чет говорит про использование с _init_ но это не факт.
            -   связано с потоком выполнения
        -   __init__ - иницилизация полей класса инцилизатор = иницилизация аттрибутов
        -   __new__ - метод конструктора = иницилизация обьекта => сложное в использовании что-т
            -   при использовании new он исполняется до init
            -   кеширование
            -   immutable - класс
    -   абстрактные классы
        -   нету иницилизации экземпляра
        -   нету поддержки питона
        -   нету прямого примененеия
        -   есть скрытие деталей реализации
        -   from abc import ABC, abstact method
    -   MRO = method order resolution = строится с помощью определеннного алгоритмма
        -   c помощью линеризации кода
        -   развертываемый порядок методов разрешения
    -   наследование
        -   простое
        -   многоуровневое
        -   иерархическое (от 1 к 2)
        -   гибридное (от 1 к 2 и к 1)
    -   реализация MRO
        -   DFS
        -   C3 LINERIZATION
            -   монотонность
            -   следует графу наследования
            -   наследует супер класс после ....
    -   методы mro
        -   c.mro()
        -   print(help(c))
## 4-st week
1. **modules in python**
    -   modules - что-то наподобие неймспейсов
    -   scope - область видимости другими словами
        -   local
        -   enclosed
        -   global
        -   built-in
        -   LEGB - WORK ON rule
    -   special words
        -   global
        -   non-local
    -   import constructions
        -   from math import smth
        -   import math as smth
        -   from math import smth as smth1
    -   import importlib importlib.reaload(module) = reload module
    -   если в модуле добавляется __path__ => из модуля становится пакетом(packet)
    -   module
        -   scope
        -   reuse
        -   simplicity
    -   module search engine(algo)
        -   current dir path
        -   built in module directory
        -   python env path
        -   installatin depend default directory
        -   sys.path.insert(path) = после этого можно будет использовать нормально модуль
2. **popular packages**
    -   built-in
        -   os
        -   sys
        -   csv
        -   ...
    -   Data science
        -   numpy
        -   scipy
        -   pandas
        -   opencv
        -   matplotlib
    -   AI and ML
        -   Tensor flow
        -   Pytotch
        -   keras
        -   scipy
        -   scykit-learn
        -   Theano
    -   Web
        -   Flask
        -   Django
        -   Cherrypie
        -   pyramid
        -   beutiful soup
        -   selenium
    -   Web Frameworks
        -   Full-stack
            -   Django
            -   Web2py
            -   Pyramid
        -   micro
            -   flask
            -   bottle
            -   Dash
            -   cherrypie
        -   async
            -   Growler
            -   Atohttp
            -   sanic
3. **Testing**
    -   Tests takes
        -   Reuse
        -   Traceability
        -   Efficency
    -   Cicle
        -   Plan
        -   Prepare
        -   Execute
        -   Report
    -   Tests
        -   unit
            -   when write code
        -   integration
            -   data base web data transfer and cast in back
        -   system
            -   business requerments metrics
        -   Acceptence
            -   A-B testing
            -   regression testing
    -   other test types <= просто типы тестов внутри дерева из 4-x верхних
        -   functional
            -   business req
        -   nonfunctional
            -   общая производительность
        -   maintence
            -   расшерение среды или исправление legacy кода
    -   Auto testing
        -   unit
        -   regression
        -   integration
    -   testing steps:
        -   prepare testing environment
        -   run the test scripts
        -   analyze results
    -   popular libs
        -   unittest lib
            -   automatization
            -   independing testing modules
            -   aggregation
        -   pytest
            -   functional
                -   unit
                -   integration
                -   in to end(сквозное)
        -   pyunits
    -   other popular
        -   pytest
        -   robot
            -   RPA - ROBOTIC PROCESS AUTOMATION
            -   TDD - Test Driven Development
        -   selenium
    ```
    import pytest
    import customlib
    def test_lol:
        assert customlib.lol(x,y,z) == 0

    console: python -m test.py::test_add
    ```
    -   TDD - разработка через тестирование
        -   test
        -   code
        -   run tests
        -   eval error
        -   rerun process
    -   red-green refactoring = то что выше(хотя не уверен)