﻿var company = "hexlet";
company.ToUpper(); // в верхний регистр
Console.WriteLine(company); // => hexlet

var comp = "hexlet";
Console.WriteLine(comp.ToUpper()); // => HEXLET

//Попробуйте ответить на вопрос, что выведет на экран следующий код?

var com = "hexlet";
com.ToUpper(); // в верхний регистр
Console.WriteLine(com); // => ?
/*
Если ваш ответ, "HEXLET", то нам есть о чем поговорить) 
Эта программа выведет "hexlet". Почему?

======     Строки в C# неизменяемы. ===========

Не существует способа и методов, способных изменить саму строку. 
Любой метод строки может только вернуть новую строку. 
Основная причина, почему так сделано – производительность. 

Строки, как и примитивные типы данных нельзя менять 
практически ни в одном современном языке.

Вторая причина связана с простотой кода. 
Когда вместо изменения создаются новые данные на основе старых, 
то код проще анализировать и модифицировать. 
Особенно когда с данными происходит много манипуляций, 
с этим вам еще предстоит столкнуться.

Но как же все таки поступать, если данные нужно поменять? 
Для этого достаточно заменить значение переменной:
====== 1 способ ====== замена переменной ======
*/
var name = "HODOR";
name = name.ToLower();
Console.WriteLine(name); // => "hodor"

//С другой стороны, 
//именно в такой ситуации можно создать новую переменную, с другим именем.
//==== 2 способ = создать новую переменную

var nam = "HODOR";
var processedName = nam.ToLower();
Console.WriteLine(processedName); // => "hodor"
/*
Такой подход нередко предпочтительнее, по соображением читаемости. 
Переменные, которые постоянно меняются сложнее анализировать. 
В конечном итоге все зависит от задачи и понимание того как лучше приходит с опытом.

Задание
Данные, вводимые пользователями в формах, 
часто содержат лишние пробельные символы в конце или начале строки. 
Кроме того, пользователи могут вводить одно и тоже в разном регистре, 
что потом мешает работе с данными. 
Поэтому перед тем как добавлять их, данные обрабатывают (говорят нормализуют). 
В базовую обработку входят два действия:

Удаление концевых пробельных символов с помощью метода Trim(), 
например, было: " hexlet\n ", стало: "hexlet"
Приведение к нижнему регистру с помощью метода ToLower(). 
Было: "SUPPORT@hexlet.io", стало:"support@hexlet.io"`.
Обновите переменную email записав в неё то же самое значение, 
но обработанное по схеме указанной выше. 
Распечатайте то, что получилось, на экран.
*/
var email = " SupporT@hexlet.io\n";

// BEGIN (write your solution here)
email = email.Trim();
email = email.ToLower();
Console.WriteLine(email);
// END
// BEGIN
var emailTrimmed = email.Trim();
var emailFinaly = email.ToLower();
Console.WriteLine(emailFinaly);
// END
// BEGIN
var emailF = email.ToLower().Trim();// цепочка вызовов - следующий раздел 
Console.WriteLine(emailF);
// END



