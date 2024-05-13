# Introduction in databases
> [!NOTE]
> In work
## 1-st week
1.  **Intro**
    -   Relation DB
        -   structured data
    -   NoSql - meta nowadays, can own all types of data structuread or not
        -   document
        -   key-value
        -   graph
    -   big-data = не понял зачем про нее говорили, но думаю как-то связано с no-sql и вобщем это мета
        -   predict
        -   improve customer exp
        -   pricing improve
        -   investments improve
        -   quality
        -   Design improve
        -   strategic plans
    -   cloud db = meta nowadays
        -   dropbox
        -   icloud
    -   BI = Business Intelligence
    -   DB history
        -   Flat
            -   single txt file with rows
        -   Hierarchical
            -   иерархическая модель = связь один ко многим
        -   Network
            -   многие ко многим
        -   Relation
            -   первичный и внешний ключ
        -   ORM
            -   классы с атрибутами и поведением
        -   NoSql
            -   распределенность
            -   снижение затрат
            -   гибкость
            -   неструктурированная и структурированная
            -   нет взаимосвязей
        -   DB tasks
            -   store data
            -   form connections
            -   filter data
            -   search data
            -   CRUD operations
        -   create and work with DB = do pipelines
        -   DB составляющие
            -   Entity = Table = relations 
                -   physical
                -   concepts
            -   attributes = columns upper name
            -   fields = columns
            -   row = экземпляры
        -   DB types
            -   Graph Db
                -   work with nodes
            -   ORM
                -   Tables = class
            -   Document
                -   use json as base
                -   коллекции json
        -   Where is DB
            -   Machine
            -   Cloud
        -   Relation DB
            -   fields
            -   attributes
            -   Entity
            -   записи
            -   primary key
            -   foreign key
        -   Diagrams for Relation DB
            -   Bar chart = гистограмма
            -   Bubble chart = пузырьковая
            -   Line chart = просто график => predict
            -   Pie chart = круглешек порезанный => все вместе является целым
            -   диаграмма с 2-мя осями
            -   диаграмма Ганта
            -   Тепловая карта
            -   точечечная диаграмма
            -   стратегия выбора диаграммы
                -   auditory?
                -   idea?
                -   what is the point?
            -   SQL = Structure Query Language
                -   Relation DB mainly
                -   Как он выполняется в бд(интерпритатор, компилятор)
                    -   использует СУБД(DMS)(DOCUMENT MANAGMENT SYSTEM)
                -   SQL
                    -   DDC = DATA DEFENITION LANGUAGE
                        -   CREATE
                        -   ALTER
                        -   DROP
                    -   DMC = DATA MANIPULATION LANGUAGE
                        -   INSERT
                        -   UPDATE
                        -   DELETE
                        -   MOST CRUD
                    -   DQL = DATA QUERY LANGUAGE
                        -   SELECT
                    -   DCL = DATA CONTROL LANGUAGE
                        -   GRANT
                        -   REVOKE
                -   SQL преимущества
                    -   BIG DATA
                    -   SIMLE
                    -   create DB
                    -   multi base portable
                    -   crud
                    -   retrive and share
                    -   security
                -   sql examples
                    -   создание бд
```
создание базы данных DDL
CREATE DATABASE db_new;
```
```
создание таблицы DDL
CREATE TABLE tb_new;
```
```
добавление в таблицу DML
INSERT INTO student
(id,name,secondname,...)
VALUES
(val1,val2,val3,...);
```
```
обновление таблицы DML
UPDATE student
SET date = '...'
WHERE id = '...'
```
```
удаление из таблицы DML
DELETE FROM student
WHERE id = '...'
```                
```
вывод из таблицы DQL
SELECT a,b
FROM student
WHERE id = '01'
```    
```
create table w 3 columns:
CREATE TABLE name(
name1 type(size),
name2 type(size),
name3 type(size)
);
```
```
DROP TABLE - удалить
DROP TABLE name;
```
```
ALTER = изменение структуры
добавление колонны
ALTER TABLE name ADD(
    name datatype(size)
);
```
```
add primary key
ALTER TABLE name ADD PRIMARY KEY(
    name1
);
```
```
Remove all records from table
TRUNCATE - команда
TRUNCATE TABLE name;
```
```
взять данные из таблицы DQL
SELECT * FROM table
```
```
ввести 
INSERT INTO name(
    col1,
    col2,
    col3)
    VALUES(
        val1,
        val2,
        val3
    );
```
```
обновить данные DML
UPDATE name
SET
col1 = val1,
col2 = val2
WHERE
condition
```
```
удаление DML
DELETE FROM name
WHERE condit
```
```
DCL команды
GRANT
REVOKE
```
```
TCL - транзакции
COMMIT
ROLLBACK 
управление изменениями и обьеденине в лог транзакции
```
***
-   defenition RELATION AND ORM
        -   RELATION - entity = Table
        -   ORM - object = Table
        -   columns - fields or attributes = own datatype for each db??
-   default datatypes
    -   string
    -   Numeric
    -   Date and time
    -   Binary
-   Domain
    -   возможные значения аттрибута
-   для каждой строки есть primary key(первичный ключ)
-   datatypes подробно
    -   числовые: INT, TINYINT, BIGINT, FLOAT, REAL
    -   дата и время: DATE, TIME, DATETIME
    -   символьные и строковые: CHAR, VARCHAR
    -   двоичные: BINARY, VARBINARY
    -   разное: CLOB - большой текст в той или иной кодировке, BLOB - коллекция двоичных данных => изображения видео и т.д.
-   relation D.B
    -   таблица - отношения = relation
    -   строка - кортеж = tuple
    -   каждая таблица имеет schema:
        -   аттрибуты
        -   ограничения целостности
        -   тип данных
    -   первичный ключ - однозначно 
    -   составной первичный ключ
    -   первичный ключ в другой таблице = внешний ключ
    -   ограничения целостности
        -   основные ограничения
            -   первичный ключ не равен NULL
        -   ограничения домена
            -   что может храниться в стоблце
        -   ссылочная целостность
            -   внешний и первичный ключ существуют
    -   логическая структура
        -   ERD
            -   один к одному
            -   один ко многим
            -   многие ко многим
        -   физическая структура
            -   первичный и внешний ключ
    -   keys
        -   candidate  - кандидаты
        -   composite - составные
        -   primary - первичный
        -   alternative - один из кандидатов
        -   foreign - внешний ключ