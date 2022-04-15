// Для случайного числа в диапозоне 10-99 вывести его наибольшую цифру
{
    int n = new Random().Next(10, 100);

    int digit1 = n % 10;
    int digit2 = n / 10;    //25/10=2(делим и отбрасываем остаток)

    if (digit1 > digit2)
        Console.WriteLine("Для числа " + n + "наибольшая цифра" + digit1);
    else
        Console.WriteLine("Для числа " + n + " наибольшая цифра " + digit2);
}