// случайное 3значное число и удаляет вторую цифру этого числа
{
    // int n = new Random().Next(100, 1000);
    //int digit1 = n % 10; // сотые
    // int digit2 = n / 10;  // десятые
    //int digit3 = n / 100;

    //Console.WriteLine(n);
    //Console.Write(digit3);
    //Console.Write(digit1);

    int n = new Random().Next(100, 1000);
    int digit1 = n % 10; // сотые
    //int digit2 = (n / 10) % 10; =  N / 10 и остаток от 10 убирается
    int digit3 = n / 100;
    int NewN = digit3 * 10 + digit1;

    Console.WriteLine("Для числа N: ");
    Console.WriteLine(n);

    Console.WriteLine("Новое число: ");
    Console.Write(NewN);
}
