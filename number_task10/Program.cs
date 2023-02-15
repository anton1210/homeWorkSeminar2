/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
(456 -> 5   782 -> 8    918 -> 1) */

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num < 1000)
{
    Console.WriteLine((num / 10) % 10);
}
else
    Console.WriteLine("Введено не трехзначное число");

Console.WriteLine("===============");

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine((number / 10) % 10);