/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. (645 -> 5  78 -> третьей цифры нет
32679 -> 6) */

Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
while (num >= 1000)
{
    num = num / 10;
}
if (num >= 100 && num < 1000)
    Console.WriteLine(num % 10);
else if (num < 100) 
Console.WriteLine("третьей цифры нет");