// первое число крато второму(делится без остатка). Если 1 не кратно 2, то вывод остаток от деления

Console.Write("Введите первое число :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число :");
int b = Convert.ToInt32(Console.ReadLine());
int div = a / b;

if (a % b == 0)
{
    Console.WriteLine("Кратное");
}
else 
{
    Console.WriteLine("Не кратно, остаток от деления = " + a % b);
}
