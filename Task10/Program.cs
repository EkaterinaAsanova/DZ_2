//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("Введите 3-х значное число");
string stringNumber = Console.ReadLine();

if (stringNumber[0]== '-') 
    stringNumber=stringNumber.Remove(0, 1);
Console.WriteLine ("Вторая цифра равна: " + stringNumber[1]);