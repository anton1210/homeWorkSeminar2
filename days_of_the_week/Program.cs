/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным. (6 -> да    7 -> да 1 -> нет) */

Console.Clear();
Console.WriteLine("Введите цифру дня недели");
int weekDay = Convert.ToInt32(Console.ReadLine());
if (weekDay >= 1 && weekDay <= 5)
    Console.WriteLine("Рабочий день");
else if (weekDay >= 6 && weekDay <= 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Такого дня недели нет");