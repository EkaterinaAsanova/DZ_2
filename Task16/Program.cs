// Задача 16 - Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine ("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number1 <= number2) & (number2 == number1 * number1))
    Console.WriteLine ("Да, число {0} является квадратом {1}", number2, number1); 
else 
  if ((number1 > number2) & (number2 / number1 == 0))
      Console.WriteLine ("Да, {0} это квадрат {1}", number1, number2);
   else
     Console.WriteLine ("Числа не являются квадратом друг друга");
