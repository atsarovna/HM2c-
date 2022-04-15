// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет

Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

int digit3 = a % 10;

if (a <= 1000)
{
    Console.WriteLine(digit3);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}