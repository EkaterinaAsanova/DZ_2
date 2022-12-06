//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("Введите число");
string stringNumber = Console.ReadLine();

if (stringNumber[0] == '-') 
    stringNumber=stringNumber.Remove(0, 1);
 
if (stringNumber.Length > 2)
    Console.WriteLine ("Третья цифра из равна: " + stringNumber[2]);

else
    Console.WriteLine ("В числе нет 3 цифры");