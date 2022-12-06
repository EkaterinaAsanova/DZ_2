//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Введите день недели");
int day=Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
    Console.WriteLine("Вы ввели понедельник");
    break;

    case 2:
    Console.WriteLine("Вы ввели вторник.");
    break;

    case 3:
    Console.WriteLine("Вы ввели среда.");
    break;

    case 4:
    Console.WriteLine("Вы ввели четверг.");
    break;

    case 5:
    Console.WriteLine("Вы ввели пятница.");
    break;

    case 6:
    Console.WriteLine("Вы ввели суббота");
    break;

    case 7:
    Console.WriteLine("Вы ввели восекресенье");
    break;
    default:
    Console.WriteLine("Введите цифру от 1 до 7");
    break;
}
if (day < 6)
Console.WriteLine("Это будний день");
else if (day<=7)
        Console.WriteLine("Это выходной день");


