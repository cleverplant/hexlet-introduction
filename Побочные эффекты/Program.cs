﻿/*
Console.WriteLine() - обычный метод. 
Внимание, вопрос: что возвращает метод WriteLine()? 
Ответ: 
что бы она не возвращала, этот возврат не имеет смысла. 
WriteLine() выводит что-то на экран, 
но это не возврат значения — это просто какое-то действие, 
которое выполняет метод.

Вывод на экран и возврат значения из метода 
— разные и независимые операции. 

Tехнически вывод на экран равносилен записи в файл 
(немного особый, но всё-таки файл). 
С точки зрения программы вывод на экран 
— это так называемый побочный эффект.

Побочным эффектом называют действия, 
которые соприкасаются с внешним окружением. 

К таким действиям относятся любые сетевые взаимодействия, 
взаимодействие с файловой системой (чтение и запись файлов), 
вывод информации на экран, печать на принтере и так далее.

Побочные эффекты — один из основных источников проблем и ошибок в программных системах.
Код с побочными эффектами сложен в тестировании и ненадежен. 
При этом без побочных эффектов программирование не имеет смысла. 

Без них было бы невозможно получить результат работы программы 
(записать в базу, вывести на экран, отправить по сети и так далее).

Понимание принципов работы с побочными эффектами очень сильно влияет 
на стиль программирования и способность строить качественные программы. 
Эта тема полностью раскроется в курсах на Хекслете.

Вопрос для самопроверки. 
Можно ли определить наличие побочных эффектов внутри метода, 
опираясь только на её возврат?

Задание
Напишем код в стиле "повтори за учителем". 
Попробуйте прочитать послание из файла message-from-stark.txt и вывести его содержимое на экран:
*/
// --- ЭТОТ РАЗДЕЛ МОЖНО ПРОСТО ПОЧИТАТЬ --------
// -> File.ReadAllText("message-from-stark.txt"); сейчас в VScode ВВОДИТЬ НЕ НАДО !!!
// 
// Чтение текста из указанного файла
File.ReadAllText("шпаргалка.txt");

// Читаем содержимое файла в переменную
// var message = File.ReadAllText("message-from-stark.txt");
// Выводим содержимое на экран
// Console.WriteLine(message);
