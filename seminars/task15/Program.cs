// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число для определения дня недели :");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Понедельник");
}
else if (num == 2)
{
    Console.WriteLine("Вторник");
}
else if (num == 3)
{
    Console.WriteLine("Среда");
}
else if (num == 4)
{
    Console.WriteLine("Четверг");
}
else if (num == 5)
{
    Console.WriteLine("Пятница");
}
else if (num == 6)
{
    Console.WriteLine("Суббота - выходной");
}
else if (num == 7)
{
    Console.WriteLine("Воскресенье - выходной");
}

else Console.WriteLine("Введите число от 1 до 7");