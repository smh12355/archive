# Python in meta course(Coursera)
> [!NOTE]
> In progress
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
