//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int n = new Random().Next(100, 1000);

int digit2 = (n / 10) % 10; 

Console.WriteLine("Для числа N: ");
Console.WriteLine(n);

Console.WriteLine("Вторая цифра числа N: ");
Console.Write(digit2);