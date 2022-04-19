Console.Write("Введите 1 число :");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число :");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("Кратное");
}
else 
{
    Console.WriteLine("Не кратно, остаток от деления = " + a % b);
}
