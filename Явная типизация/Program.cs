﻿/*  До сих пор при определении переменных мы использовали 
ключевое слово var, и обычно это рекомендуемый способ объявления. 
Но еще переменные можно объявлять вот так:   
int x = 3;
string greeting = "Hello Hexlet!";
*/
/* 
Пришло время раскрыть карты! 
C# статически типизированный язык, 
в таких языках тип переменной фиксируется при ее объявлении. 
В большинстве языков для этого перед именем переменной указывается ее тип, 
в примере выше это число (int) и строка (string). 
В первых версиях языка переменные объявляли только так, 
до тех пор пока не появился var.

var – специальное ключевое слово, которое включает механизм вывода типов. 
Вывод типов автоматически определяет тип присваиваемого значения и связывает его с переменной. 
И правда, в примерах выше очевидно, где какой тип, зачем его явно прописывать?

Вывод типов в C# появился начиная с третьей версии языка в 2007 году, 
но существуют языки, в которых вывод типов существует гораздо дольше. 
Первый язык с выводом типов называется ML и появился он аж в 1973 году. 
С тех пор вывод типов был добавлен в уйму языков среди которых Ocaml, 
Haskell, Java, F#, Kotlin, Scala и множество других.

Вывод типов и предпочтителен в большинстве ситуаций, 
однако бывает такое, что выводимый тип нас не устраивает. 
Тогда мы можем указать тип явно. 
Подробнее об этом в следующем уроке.

Задание
Создайте строку One more time с явным указанием типа и выведите ее на экран   */

string gree = "One more time";
Console.WriteLine(gree);

