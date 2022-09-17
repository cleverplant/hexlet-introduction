﻿/* 
Особняком в C# стоит значение null. 
Здесь оно, в отличии от других языков программирования, 
не является типом, это просто конкретное значение 
со специальным смыслом и логикой работы. 
Начнем с примера:

// Определение переменной с инициализацией null
// С var такое не сработает, так как невозможно вывести тип
string a = null;
Что находится внутри переменной a? 
Если мы ее распечатаем, то увидим null. 
null используется для ссылочных типов, тогда, когда значение не определено. 
Как такое возможно? 
Представьте, что мы хотим извлечь из базы данных пользователя, а его там нет. 
Что, в таком случае, вернет нам запрос в базу? 
Вот именно для таких ситуаций и нужен null. 
Их гораздо больше чем может показаться на первый взгляд и чем дальше мы будем двигаться, 
тем чаще он начнет встречаться.

var user = // тут делаем запрос в базу
// Если данных нет, то user станет null
// Запись выше равносильна
var user = null;

Из вышесказанного следует важный вывод. 
Любой ссылочный тип данных может принимать значение null. 
То есть, null, в каком-то смысле, является значением любого ссылочного типа. 
А вот значимые типы и null не совместимы. 
Значимая переменная всегда должна быть определена:

// error CS0037: Cannot convert null to 'int' because it is a non-nullable value type
int x = null;

Задание
Определите переменную с именем greeting, но не инициализируйте ее 
*/
// BEGIN (write your solution here)
string greeting;
// END
greeting = "Hello Hexlet!";
Console.WriteLine(greeting); //Hello Hexlet! 


