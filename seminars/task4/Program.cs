Console.Write("Введите число :");
int a = Convert.ToInt32(Console.ReadLine());

int div = a / b;

if (a % b == 0)
{
    Console.WriteLine("Кратное");
}
else 
{
    Console.WriteLine("Не кратно, остаток от деления = " + a % b);
}
