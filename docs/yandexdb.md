# Yandex SQL course
> [!NOTE]
> DONE
## postgresql
*   SELECT - выборка
    *   SELECT 'DAS'; = выведет слово
    *   SELECT 3+2; = 5
    *   SELECT COUNT(*) FROM ...; = посчитает количество строк
*   порядок вывода = select
    *   порядок вывода A,B,C
*   AS - псевдонимы
    *   понятность
    *   сложные запросы
    *   следует аккуратно применять так как select выполняется не сразу! => по сути можем ток в order by
        *   FROM
        *   WHERE
        *   GROUP BY
        *   HAVING
        *   SELECT
        *   ORDER BY
*   LIMIT OFFSET - ограничения выгрузки, обычно в конце применяются
    *   LIMIT - ограничение количества строк
        *   LIMIT 10;
    *   OFFSET пропустит строки
        *   LIMIT 10 OFFSET 5;
*   WHERE - филтрация
    *   WHERE a = 5
    *   WHERE b = 'das'
    *   AND 
    *   OR
    *   NOT = WHERE NOT a = 5;
    *   IN = WHERE  a IN (...,...,...)
    *   Приоритет с помощью скобок
    *   нельзя псевдонимы
*   DATE
    *   DATE_TRUNC('...', поле) - усечение времени
        *   DATE_TRUNC('month',date)
        *   return timestamt with time zone
        *   усекает дату
    *   EXTRACT
        *   выводит конретную дату
        *   EXTRACT(field FROM source)
        *   EXTRACT(YEAR FROM '2024-05-21'::DATE)
        *   EXTRACT(hour FROM date)
*   Агригация
    *   sum()
    *   count()
    *   min()
    *   avg()
    *   max()
    *   distinct() - уникальные
*   GROUP BY - группировка
    *   выводит уникальные значения
    *   используется после фильтрации
    *   если в select указаны аттрибуты (с агрегатной функцией) то они должны быть в group by
    *   если я не указал аттрибут в селекте то я могу по нему группироваться
*   HAVING - фильтрация уже после фильтрации и группировки
*   ODRER BY - сортировка
    *   DESC - убывание
    *   ESC - возрастание
    *   работает с псевдонимами
    *   NULLS FIRST
    *   без группировки использовать нельзя ! непонятный момент!!!
    *   выполняется после селекта
    *   может быть по нескольким полям
