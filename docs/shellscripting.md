> [!NOTE]
> Done
## 1-st week
1.  **Intoduction in linux**
    -   unix - семейство операционных систем   
    -   linux - семейство unix- подобных систем=> 1991 год беслатная версия ядра unix с открытым исходным кодом
    -   дистрибутивы linux
        -   дебиан
        -   ubuntu основана на debian
        -   red hat enterprise linux
        -   suse linux enterprice
        -   arch linux
    -   уровни linux
        -   ui = user interface
        -   apps = applications
        -   os = operating system
        -   kernel
        -   hardware = железо
    -   терминал
        -   оболочки
            -   bash
            -   zsh
    -   редакторы
        -   vim
        -   nano
        -   gedit
        -   emacs
    -   полезные команды
        -   man = manual
        -   cd ~ = home dir
        -   cd / = root dir
        -   nano file = create file
        -   touch file = create file
        -   apt install ... = download smthing
    -   overall:
        -   В 1980-х годах в Массачусетском технологическом институте была разработана GNU. GNU расшифровывается как "GNU's not Unix" и была создана как бесплатный набор системных инструментов Unix с открытым исходным кодом. А в 1991 году Линус Торвальдс разработал бесплатную версию ядра Unix с открытым исходным кодом под названием Linux.

        -   Сегодня Linux широко используется в мобильных устройствах, настольных компьютерах, суперкомпьютерах, центрах обработки данных и облачных серверах. 

        -   Дистрибутивы Linux (также известные как дистрибутивы) отличаются друг от друга пользовательским интерфейсом, приложениями оболочки, а также тем, как поддерживается и создается ОС. 

        -   Дизайн дистрибутива ориентирован на его конкретную аудиторию и/или сферу использования. К популярным дистрибутивам Linux относятся Red Hat Enterprise Linux (RHEL), Debian, Ubuntu, Suse (SLES, SLED, OpenSuse), Fedora, Mint и Arch. 

        -   Система Linux состоит из пяти ключевых уровней: пользовательский интерфейс, приложения, ОС, ядро и аппаратное обеспечение. Пользовательский интерфейс позволяет пользователям взаимодействовать с приложениями. Приложения позволяют пользователям выполнять задачи в системе. Операционная система работает поверх ядра и жизненно важна для здоровья и стабильности системы, а ядро - это программное обеспечение самого низкого уровня, которое позволяет приложениям взаимодействовать с аппаратным обеспечением. К аппаратному обеспечению относятся все физические или электронные компоненты вашего PC. 

        -   Файловая система Linux - это древовидная структура, состоящая из всех каталогов и файлов в системе. 

        -   Оболочка Linux - это приложение на уровне ОС, которое можно использовать для ввода команд. Вы используете терминал для отправки команд в оболочку, а также команду `cd` для навигации по файловой системе Linux. 

        -   Вы можете использовать различные текстовые редакторы, основанные на командной строке или GUI, такие как GNU nano, vim, vi и gedit. 

        -   .deb и .rpm - это разные типы файлов, используемые менеджерами пакетов в операционных системах Linux. 

        -   Вы можете использовать менеджеры пакетов на основе GUI и командной строки для обновления и установки программного обеспечения в системах Linux.
2.  **Intoduction in linux commands** 
    -   общие команды
        -   whoami = имя пользователя
        -   id = текущий пользователь
        -   uname = имя операционки
        -   ps = отображает запущенные процессы
        -   top = улучшенная ps
        -   df = смонтированные файловые системы
        -   man = справочное руковдство
        -   cp = скопировать файл
        -   mv = изменить имя или путь к файлу
        -   rm = удалить
        -   touch = создание пустого файла(обновить временную метку)
        -   chmod = изменине права доступа
        -   wc = количество строк,слов,символов в файле
        -   grep = возвращение строк в шаблоне
        -   cat = print содержимого
        -   head n = первые n строк
        -   tail n = последние n строк
        -   echo = печать
        -   zip,unzip
        -   ifconfig,hostname,ping = сетевые
        -   curl = содержимое файла по URL
        -   wget = загрузка файла с URL
        -   \* = защита символа
        -   просто cd = cd ~
        -   ls -la = права доступа
        -   chmod +x filename = права для выполнения
        -   chmod г+x filename = права для выполнения для текущего юзера
        -   more = показывать содержимое по страницам
        -   uniq = уникальные строки
3.  **Shell scripting basics**
    -   pipes
        -   comm1 | comm2 : cat Bitcoinprice.txt | grep -oE "\"price\"\s*:\s*[0-9]*?\.[0-9]*"
    -   examples of bash scripting
        -   #= for comments
        -   ;=separate comands on a single line : echo "Hello, "; echo "world!"
        -   *= wild character = любой символ : ls *.txt
        -   ?=single character = любой одиночный символ
        -   \escape symbol
        -   " " = Interpret metacharacters within string = $ echo "Hello $USER" => Hello <username>
        -   ' ' = Escape all metacharacters within string = $ echo 'Hello $USER' => Hello $USER
    -   Redirect symbols
        -   ">" = Redirect output to file, overwrite: ls > files.txt
        -   ">>" = Redirect output to file, append: ls >> files.txt
        -   "2>" = Redirect standard error to file, overwrite: ls non-existent-directory 2> error.txt
        -   "2>>" = Redirect standard error to file, append: ls non-existent-directory 2>> error.txt
        -   "<" = Redirect file contents to standard input: sort < data.txt
    -   variables
        -   here=$(pwd) => cd $here
    -   arguments
        -   ./MyBashScript.sh arg1 arg2
    -   conditions

    ```
    if [ condition ]
then
    statement_block_1  
else
    statement_block_2  
fi
    ```
comman line args = 2
    ```
if [[ $# == 2 ]]
then
    echo "number of arguments is equal to 2"
else
    echo "number of arguments is not equal to 2"
fi
    ```

    ```
if [ condition1 ] && [ condition2 ]
then
    echo "conditions 1 and 2 are both true"
else
    echo "one or both conditions are false"
fi
    ```
    -   math
        -   echo $((3+2))
        -   $(($a+$b))
        -   arrays: my_array=(1 2 "three" "four" 5) => y_array+=("six") => my_array+=(7) => echo ${my_array[0]}
    -   loops

    ```
for item in ${my_array[@]}; do
    echo $item
done
    ```

    ```
N=6
for (( i=0; i<=$N; i++ )) ; do
    echo $i
done
    ```
4.  **finall project**
    
```
#!/bin/bash

# This checks if the number of arguments is correct
# If the number of arguments is incorrect ( $# != 2) print error message and exit
if [[ $# != 2 ]]
then
  echo "backup.sh target_directory_name destination_directory_name"
  exit
fi

# This checks if argument 1 and argument 2 are valid directory paths
if [[ ! -d $1 ]] || [[ ! -d $2 ]]
then
  echo "Invalid directory path provided"
  exit
fi

# [TASK 1]
targetDirectory=$1
destinationDirectory=$2

# [TASK 2]
echo "$targetDirectory"
echo "$destinationDirectory"

# [TASK 3]
currentTS=$(date +%s)

# [TASK 4]
backupFileName="backup-$currentTS.tar.gz"

# We're going to:
  # 1: Go into the target directory
  # 2: Create the backup file
  # 3: Move the backup file to the destination directory

# To make things easier, we will define some useful variables...

# [TASK 5]
origAbsPath=$(pwd)

# [TASK 6]
cd $destinationDirectory
destDirAbsPath=$(pwd)

# [TASK 7]
# what is the point of cd $origAbsPath
cd $origAbsPath
cd $targetDirectory

# [TASK 8]
yesterdayTS=$(($currentTS - 3600 * 24))

declare -a toBackup

for file in $(ls) # [TASK 9]
do
  # [TASK 10]
  if [ $(($(date -r $file +%s) > $yesterdayTS)) ] 
  then
    # [TASK 11]
    toBackup+=($file)
  fi
done
# [TASK 12]
# tar -czvf $backupFileName ${toBackup[@]}
if [ ${#toBackup[@]} != 0 ]
    then
    tar -czvf "$backupFileName" "${toBackup[@]}"
    # [TASK 13]
    mv $backupFileName $destDirAbsPath
else
    echo "no files to archive"
fi

# Congratulations! You completed the final project for this course!
```