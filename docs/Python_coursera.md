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